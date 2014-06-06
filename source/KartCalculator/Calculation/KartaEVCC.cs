using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KartCalculator
{
    public class KartaEVCC
    {
        private BaseParams baseParams;
        private KartaObDisp kartaObDisp;
        private double[] arrEt;
        private double k = 0.25;
        private double sigmaS;
        private double arrSigmaEt;
        private double ulc;
        private double lcl;

        public double K
        {
            set { k = value; }
        }
        public double[] ArrEt
        {
            get { return arrEt; }
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
            double arrTmp = 0.0;
            arrTmp = sigmaS * k * (1 - Math.Pow(1 - k, 2 * kartaObDisp.DetArrSt.GetLength(0)));
            arrTmp /= baseParams.WeightViborka * (2 - k);
            this.arrSigmaEt = arrTmp;
        }
    }
}
