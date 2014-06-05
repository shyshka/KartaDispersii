using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace KartCalculator
{
    public class BaseParams
    {
        #region Private fields
        private string filePath;        
        private int cntParams;        
        private int weightViborka;        
        private int cntViborka;
        private int fullViborka;

        private double[,] inputData;
        private double[] mo;
        private double[] sko;
        private double[,] correlation;
        private double[,] covariation;
        private double[,] cholesky;        
        #endregion

        #region Public fields
        public string FilePath
        {
            get { return filePath; }
        }
        public int CntParams
        {
            get { return cntParams; }
        }
        public int WeightViborka
        {
            get { return weightViborka; }
        }
        public int CntViborka
        {
            get { return cntViborka; }
        }
        public int FullViborka
        {
            get { return fullViborka; }
        }
        public double[,] InputData
        {
            get { return inputData; }
        }
        public double[] Mo
        {
            get { return mo; }
        }
        public double[] Sko
        {
            get { return sko; }
        }
        public double[,] MOSKO
        {
            get
            {
                double[,] tmp = new double[cntParams, 2];
                for (int i = 0; i < cntParams; i++)
                {
                    tmp[i, 0] = mo[i];
                    tmp[i, 1] = sko[i];
                }
                return tmp;
            }
        }
        public double[,] Correlation
        {
            get { return correlation; }
        }
        public double[,] Covariation
        {
            get { return covariation; }
        }
        public double[,] Cholesky
        {
            get { return cholesky; }
        }
        #endregion

        #region Public methods
        public BaseParams(string filePath)
        {
            this.filePath = filePath;
            this.calcBaseParams();
        } 
        #endregion

        #region Private methods
        private void calcBaseParams()
        {
            //Входные данные
            using (StreamReader sr = new StreamReader(this.filePath))
            {
                this.cntParams = Convert.ToInt32(sr.ReadLine());
                this.weightViborka = Convert.ToInt32(sr.ReadLine());
                this.cntViborka = Convert.ToInt32(sr.ReadLine());
                this.fullViborka = weightViborka * cntViborka;

                this.inputData = new double[cntParams, fullViborka];
                for (int i = 0; i < fullViborka; i++)
                {
                    String[] curLineItems = sr.ReadLine().Split('\t');
                    for (int j = 0; j < curLineItems.Length; j++)
                        this.inputData[j, i] = float.Parse(curLineItems[j], CultureInfo.InvariantCulture.NumberFormat);
                }
            }
            this.mo = calcMO();
            this.sko = calcSKO();
            this.correlation = calcCorrelation();
            this.covariation = calcCovariation();
            this.cholesky = calcCholesky();
        }

        private double[] calcMO()
        {
            double[] moTmp = new double[cntParams];
            for (int i = 0; i < cntParams; i++)
            {
                for (int j = 0; j < fullViborka; j++)
                    moTmp[i] += inputData[i, j];
                moTmp[i] /= fullViborka;
            }
            return moTmp;
        }        
        private double[] calcSKO()
        {
            double[] skoTmp = new double[cntParams];
            for (int i = 0; i < cntParams; i++)
            {
                for (int j = 0; j < fullViborka; j++)
                    skoTmp[i] += Math.Pow(inputData[i, j] - mo[i], 2);
                skoTmp[i] = Math.Sqrt(skoTmp[i] / fullViborka);
            }
            return skoTmp;
        }        
        private double[,] calcCorrelation()
        {
            double[,] corTmp = new double[cntParams, cntParams];

            for (int i = 0; i < cntParams; i++)
                for (int j = 0; j < cntParams; j++)
                {
                    double sum = 0.0;
                    for (int k = 0; k < fullViborka; k++)
                        sum += (inputData[i, k] - mo[i]) * (inputData[j, k] - mo[j]);
                    corTmp[i, j] = sum / (fullViborka * sko[i] * sko[j]);
                }
            return corTmp;
        }
        private double[,] calcCovariation()
        {
            double[,] tmp = new double[cntParams, cntParams];
            for (int i = 0; i < cntParams; i++)
                for (int j = 0; j < cntParams; j++)
                {
                    double sum = 0.0;
                    for (int k = 0; k < fullViborka; k++)
                        sum += (inputData[i, k] - mo[i]) * (inputData[j, k] - mo[j]);
                    tmp[i, j] = sum / (fullViborka - 1);
                }

            return tmp;
        }
        private double[,] calcCholesky()
        {
            double[,] resArr = new double[cntParams,cntParams];
            for (int j = 0; j < cntParams; j++)
            {
                double s = 0.0;
                double ss = 0.0;
                for (int k = 0; k < cntParams - 1; k++)
                    s += resArr[j, k] * resArr[j, k];
                ss = covariation[j, j] - s;
                if (ss <= 0) break;
                ss = Math.Sqrt(ss);
                for (int i = j; i < cntParams; i++)
                {
                    s = 0.0;
                    for (int k = 0; k < cntParams - 1; k++) 
                        s += resArr[i, k] * resArr[j, k];
                    resArr[i, j] = (covariation[i, j] - s) / ss;
                }                
            }
            return resArr;
        }
        #endregion
    }
}
