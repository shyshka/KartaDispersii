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
        private double k;

        public KartaEVCC(BaseParams baseParams)
        {
            this.baseParams = baseParams;
            this.kartaObDisp = new KartaObDisp(this.baseParams);
            calcParams();   
        }

        private void calcParams()
        {
            calcArrEt();
        }

        private void calcArrEt()
        {
            double[] arrTmp = new double[kartaObDisp.DetArrSt.GetLength(0)];
            arrTmp[0] = kartaObDisp.DetArrS;
            for (int t = 1; t < arrTmp.GetLength(0); t++)
                arrTmp[t] = (1 - k) * arrTmp[t - 1] + k * kartaObDisp.DetArrSt[t];
            this.arrEt = arrTmp;
        }
    }
}
