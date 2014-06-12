using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace KartCalculator
{
    public class KartaEVCC
    {
        private BaseParams baseParams;
        private KartaObDisp kartaObDisp;
        private string dirPath;
        private List<string> lstFiles;
        private int cntViborka;
        private double[] arrEt;
        private double k = 0.25;
        private double sigmaS;
        private double[] sigmaEt;
        private double[] ucl; 
        private double[] lcl;
        private double hAv;        
        private const int cntViborkaPerFile = 370;

        public string DirPath
        {
            set
            {
                dirPath = value;
                loadFiles();
            }
        }
        public int CntViborka
        {
            get { return cntViborka; }
        }        
        public double K
        {
            set { k = value; }
        }
        public double[] ArrEt
        {
            get { return arrEt; }
        }
        public int CntFiles
        {
            get
            {
                if (lstFiles == null) return 0;
                else return lstFiles.Count;
            }
        }
        public double[] Ucl
        {
            get { return ucl; }
        }
        public double[] Lcl
        {
            get { return lcl; }
        }
        public double HAv
        {
            get { return hAv; }
        }

        public KartaEVCC(BaseParams baseParams)
        {
            this.baseParams = baseParams;
            this.kartaObDisp = new KartaObDisp(this.baseParams);
            calcParams();   
        }

        private void calcParams()
        {
            calcArrEt();
            calcSigmaS();
            calcSigmaEt();
        }
        private void calcArrEt()
        {
            double[] arrTmp = new double[kartaObDisp.DetArrSt.GetLength(0)];
            arrTmp[0] = kartaObDisp.DetArrS;
            for (int t = 1; t < arrTmp.GetLength(0); t++)
                arrTmp[t] = (1 - k) * arrTmp[t - 1] + k * kartaObDisp.DetArrSt[t];
            this.arrEt = arrTmp;
        }
        private void calcSigmaS()
        {
            this.sigmaS = Math.Sqrt(kartaObDisp.B2) * kartaObDisp.DetArrS;
        }
        private void calcSigmaEt()
        {
            double[] arrTmp = new double[this.baseParams.CntViborka];
            for (int i = 0; i < arrTmp.Length; i++)
            {
                arrTmp[i] = Math.Pow(sigmaS, 2) * k * (1 - Math.Pow(1 - k, 2 * (i + 1)));
                arrTmp[i] /= baseParams.WeightViborka * (2 - k);
                arrTmp[i] = Math.Sqrt(arrTmp[i]);
            }

            this.sigmaEt = arrTmp;
        }
        private void loadFiles()
        {
            string[] files = Directory.GetFiles(this.dirPath);
            this.lstFiles = new List<string>();
            this.cntViborka = 0;
            foreach (string filePath in files)
                if (BaseParams.IsGoodFile(filePath))
                {
                    lstFiles.Add(filePath);
                    BaseParams bp = new BaseParams(filePath);
                    this.cntViborka += bp.CntViborka;
                }
        }        
        
        public void CalcUclLcl()
        {
            calcParams();
            double hAvTmp = 0.0;
            foreach (string filePath in lstFiles)
            {                
                KartaEVCC kartaEvccCur = new KartaEVCC(new BaseParams(filePath));
                double maxEt = 0.0;
                double minEt = 0.0;
                double hCurMax = 0.0;
                double hCurMin = 0.0;

                for (int t = 0; t < baseParams.CntViborka; t++)
                {
                    if (maxEt < kartaEvccCur.ArrEt[t]) maxEt = kartaEvccCur.ArrEt[t];
                    if (minEt > kartaEvccCur.ArrEt[t] && kartaEvccCur.ArrEt[t] >= 0.0)
                        minEt = kartaEvccCur.ArrEt[t];
                    if (minEt == 0.0) minEt = kartaEvccCur.ArrEt[t];

                    hCurMax = (maxEt - new KartaObDisp(new BaseParams(filePath)).DetArrS) / sigmaEt[t];
                    hCurMin = (-minEt + new KartaObDisp(new BaseParams(filePath)).DetArrS) / sigmaEt[t];
                }
                
                hAvTmp += hCurMax + hCurMin;                
            }
            hAvTmp /= lstFiles.Count * baseParams.CntViborka;
            this.hAv = hAvTmp;

            this.hAv = 3;
            this.ucl = new double[baseParams.CntViborka];
            this.lcl= new double[baseParams.CntViborka];

            for (int t = 0; t < baseParams.CntViborka; t++)
            {
                this.ucl[t] = kartaObDisp.DetArrS + this.hAv * sigmaEt[t];
                this.lcl[t] = kartaObDisp.DetArrS - this.hAv * sigmaEt[t];
            }
        }
    }
}
