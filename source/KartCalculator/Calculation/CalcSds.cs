using System;
using System.IO;
using System.Threading;

namespace KartCalculator.Calculation
{
    public class CalcSds
    {
        public event Global.IntHandler ChangePerc;
        public event Global.StrHandler ChangeText;

        private readonly BaseParams _baseParams;

        public CalcSds(BaseParams baseParams)
        {
            _baseParams = baseParams;
        }

        public double[] ArrSds { get; private set; }

        public void CalcParams(string dirBasePath)
        {
            ArrSds = new double[4];
            var thread = new Thread(() =>
            {
                for (int i = 0; i <4; i++)
                {
                    double d = i*0.25 + 1.25;
                    string dirPath = Path.Combine(
                        Directory.GetParent(dirBasePath).FullName,
                        "Generation-D" + d);
                    string[] files = Directory.GetFiles(dirPath);
                    int dlinaSer = 0;

                    for (int j = 0; j < files.Length; j++)
                    {
                        for (int t0 = 10; t0 <= _baseParams.CntViborka; t0++)
                        {
                            for (int t = t0 - 10; t < t0; t++)
                            {
                                var Ct = CalcCt(files[j], t);
                                var Ckr = CalcCkr(files[j], t0, t);
                                if (Ct < Ckr)
                                {
                                    dlinaSer += t0 - 10 + t;
                                    break;
                                };
                                if (t == t0 - 1)
                                    dlinaSer += 10;
                            }
                            if (ChangePerc != null)
                                ChangePerc(Convert.ToInt32(100.0*(d - 1.25) + 25.0*(j*1.0/files.Length)));
                        }
                    }
                    dlinaSer /= _baseParams.CntViborka*files.Length;
                    ArrSds[i] = dlinaSer;
                }
                if (ChangePerc != null) ChangePerc(0);
                if (ChangeText != null) ChangeText("Расчет завершен");
            });
            thread.Start();
        }

        private double CalcCt(string filePath, int t)
        {
            var avS = 0.0;
            var kartaObDisp = new KartaObDisp(new BaseParams(filePath));
            for (int i = 0; i < kartaObDisp.DetArrSt.GetLength(0); i++)
                avS += kartaObDisp.DetArrSt[i];
            avS /= 1.0*kartaObDisp.DetArrSt.GetLength(0);

            var sRes = 0.0;
            for (int i = 0; i < kartaObDisp.DetArrSt.GetLength(0); i++)
                sRes += Math.Pow(kartaObDisp.DetArrSt[i] - avS, 2);
            sRes /= kartaObDisp.DetArrSt.GetLength(0);
            sRes = Math.Sqrt(sRes);

            var res = (1.0/sRes)*(kartaObDisp.DetArrSt[t] - kartaObDisp.DetArrS);
            return res;
        }

        private double CalcCkr(string filePath, int t0, int t)
        {
            var c0 = CalcCt(filePath,0);
            return c0 - 5 + 0.5*(t - t0);
        }

        public string GetPathByD(double d)
        {
            return Path.Combine(Global.GetPathBaseDir(_baseParams), "Generation-D" + d);
        }

        public double[] CalcCt(string filePath)
        {
            var arrTmp = new double[_baseParams.CntViborka];
            for (int i = 0; i < arrTmp.GetLength(0); i++)
                arrTmp[i] = CalcCt(filePath, i);
            return arrTmp;
        }

        public double[] CalcCkr(string filePath)
        {
            var arrTmp = new double[_baseParams.CntViborka];
            for (int i = 0; i < arrTmp.GetLength(0); i++)
                arrTmp[i] = CalcCkr(filePath, 10, i);
            return arrTmp;
        }
    }
}
