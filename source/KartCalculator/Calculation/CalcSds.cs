using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace KartCalculator.Calculation
{
    public class CalcSds
    {
        private BaseParams _baseParams;

        public CalcSds(BaseParams baseParams)
        {
            _baseParams = baseParams;
        }

        public void CalcParams()
        {
            for (double d = 1.25; d <= 2.0; d += 0.5)
            {
                string dirPath = Path.Combine(
                    Global.GetPathBaseDir(_baseParams),
                    "Generation-D" + d);
                foreach (string filePath in Directory.GetFiles(dirPath))
                {
                    for (int t0 = 10; t0 <= _baseParams.CntViborka; t0++)
                    {
                        for (int t = t0 - 10; t < t0; t++)
                        {
                            var Ct = CalcCt(filePath, t);
                            var Ckr = CalcCkr(filePath, t0, t);
                            if (Ct < Ckr) MessageBox.Show("Fuck");
                        }
                    }
                }
            }
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
            var c0 = CalcCt(filePath,t);
            return c0 - 5 + 0.5*(t-t0);
        }
    }
}
