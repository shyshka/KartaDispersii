using System;
using System.Collections.Generic;
using System.IO;

namespace KartCalculator.Calculation
{
    public class KartaEvcc
    {
        public event Global.IntHandler ChangePerc;
        public event Global.StrHandler ChangeText;

        private readonly BaseParams _baseParams;
        private readonly KartaObDisp _kartaObDisp;
        private string _dirPath;
        private List<string> _lstFiles;
        private double _k = 0.25;
        private double _sigmaS;
        private double _hAvUser;

        public string DirPath
        {
            set
            {
                _dirPath = value;
                LoadFiles();
            }
        }

        public int CntViborka { get; private set; }

        public double K
        {
            set { _k = value; }
        }

        public double[] ArrEt { get; private set; }

        public int CntFiles
        {
            get
            {
                if (_lstFiles == null) return 0;
                return _lstFiles.Count;
            }
        }

        public double[] Ucl { get; private set; }

        public double[] Lcl { get; private set; }

        public double HAv { get; private set; }

        public double HavUser
        {
            set { _hAvUser = value; }
        }

        public double[] SigmaEt { get; private set; }

        public KartaEvcc(BaseParams baseParams)
        {
            _baseParams = baseParams;
            _kartaObDisp = new KartaObDisp(_baseParams);
            CalcParams();   
        }

        public void CalcUclLcl()
        {
            CalcParams();
            var hAvTmp = 0.0;
            for (int i = 0; i < _lstFiles.Count; i++)
            {
                var kartaEvccCur = new KartaEvcc(new BaseParams(_lstFiles[i]));
                var maxEt = 0.0;
                var minEt = 0.0;
                var hCurMax = 0.0;
                var hCurMin = 0.0;

                for (var t = 0; t < _baseParams.CntViborka; t++)
                {
                    if (maxEt < kartaEvccCur.ArrEt[t]) maxEt = kartaEvccCur.ArrEt[t];
                    if (minEt > kartaEvccCur.ArrEt[t] && kartaEvccCur.ArrEt[t] >= 0.0)
                        minEt = kartaEvccCur.ArrEt[t];
// ReSharper disable once CompareOfFloatsByEqualityOperator
                    if (minEt == 0.0) minEt = kartaEvccCur.ArrEt[t];

                    hCurMax = (maxEt - new KartaObDisp(new BaseParams(_lstFiles[i])).DetArrS)/SigmaEt[t];
                    hCurMin = (-minEt + new KartaObDisp(new BaseParams(_lstFiles[i])).DetArrS)/SigmaEt[t];
                }

                ChangePerc(Convert.ToInt32(i*100.0/_lstFiles.Count));
                hAvTmp += hCurMax + hCurMin;
            }
            
            hAvTmp /= _lstFiles.Count * _baseParams.CntViborka;
            HAv = hAvTmp;

            Ucl = new double[_baseParams.CntViborka];
            Lcl = new double[_baseParams.CntViborka];

// ReSharper disable once CompareOfFloatsByEqualityOperator
            if (_hAvUser!=0.0)
            {
                for (var t = 0; t < _baseParams.CntViborka; t++)
                {
                    Ucl[t] = _kartaObDisp.DetArrS + _hAvUser * SigmaEt[t];
                    Lcl[t] = _kartaObDisp.DetArrS - _hAvUser * SigmaEt[t];
                }
            }
            else
            {
                for (var t = 0; t < _baseParams.CntViborka; t++)
                {
                    Ucl[t] = _kartaObDisp.DetArrS + HAv * SigmaEt[t];
                    Lcl[t] = _kartaObDisp.DetArrS - HAv * SigmaEt[t];
                }
            }
            ChangePerc(0);
            ChangeText("Обсчет карты прошел успешно");
        }

        public string GetResultsString()
        {
            var s = string.Empty;
            s += "SigmaS=" + Global.GetString(_sigmaS)+'\n';
            s += "Calculated H=" + Global.GetString(HAv);
            return s;
        }

        private void CalcParams()
        {
            CalcArrEt();
            CalcSigmaS();
            CalcSigmaEt();
        }
        private void CalcArrEt()
        {
            var arrTmp = new double[_kartaObDisp.DetArrSt.GetLength(0)];
            arrTmp[0] = _kartaObDisp.DetArrS;
            for (var t = 1; t < arrTmp.GetLength(0); t++)
                arrTmp[t] = (1 - _k) * arrTmp[t - 1] + _k * _kartaObDisp.DetArrSt[t];
            ArrEt = arrTmp;
        }
        private void CalcSigmaS()
        {
            _sigmaS = Math.Sqrt(_kartaObDisp.B2) * _kartaObDisp.DetArrS;
        }
        private void CalcSigmaEt()
        {
            var arrTmp = new double[_baseParams.CntViborka];
            for (var i = 0; i < arrTmp.Length; i++)
            {
                arrTmp[i] = Math.Pow(_sigmaS, 2) * _k * (1 - Math.Pow(1 - _k, 2 * (i + 1)));
                arrTmp[i] /= _baseParams.WeightViborka * (2 - _k);
                arrTmp[i] = Math.Sqrt(arrTmp[i]);
            }

            SigmaEt = arrTmp;
        }
        private void LoadFiles()
        {
            var files = Directory.GetFiles(_dirPath);
            _lstFiles = new List<string>();
            CntViborka = 0;
            foreach (var filePath in files)
                if (BaseParams.IsGoodFile(filePath))
                {
                    _lstFiles.Add(filePath);
                    var bp = new BaseParams(filePath);
                    CntViborka += bp.CntViborka;
                }
        }        
    }
}
