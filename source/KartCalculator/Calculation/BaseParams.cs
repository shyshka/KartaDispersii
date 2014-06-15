﻿using System;
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
                var tmp = new double[cntParams, 2];
                for (var i = 0; i < cntParams; i++)
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
            calcBaseParams();
        }

        public static bool IsGoodFile(String filePath)
        {
            try
            { new BaseParams(filePath); }
            catch (Exception ex)
            { return false; }

            return true;
        }
        #endregion

        #region Private methods
        private void calcBaseParams()
        {
            //Входные данные
            using (var sr = new StreamReader(filePath))
            {
                cntParams = Convert.ToInt32(sr.ReadLine());
                weightViborka = Convert.ToInt32(sr.ReadLine());
                cntViborka = Convert.ToInt32(sr.ReadLine());
                fullViborka = weightViborka * cntViborka;

                inputData = new double[cntParams, fullViborka];
                for (var i = 0; i < fullViborka; i++)
                {
                    var curLineItems = sr.ReadLine().Split('\t');
                    for (var j = 0; j < curLineItems.Length; j++)
                        inputData[j, i] = float.Parse(curLineItems[j], CultureInfo.InvariantCulture.NumberFormat);
                }
            }
            mo = calcMO();
            sko = calcSKO();
            correlation = calcCorrelation();
            covariation = calcCovariation();
            cholesky = calcCholesky();
        }

        private double[] calcMO()
        {
            var moTmp = new double[cntParams];
            for (var i = 0; i < cntParams; i++)
            {
                for (var j = 0; j < fullViborka; j++)
                    moTmp[i] += inputData[i, j];
                moTmp[i] /= fullViborka;
            }
            return moTmp;
        }        
        private double[] calcSKO()
        {
            var skoTmp = new double[cntParams];
            for (var i = 0; i < cntParams; i++)
            {
                for (var j = 0; j < fullViborka; j++)
                    skoTmp[i] += Math.Pow(inputData[i, j] - mo[i], 2);
                skoTmp[i] = Math.Sqrt(skoTmp[i] / fullViborka);
            }
            return skoTmp;
        }        
        private double[,] calcCorrelation()
        {
            var corTmp = new double[cntParams, cntParams];

            for (var i = 0; i < cntParams; i++)
                for (var j = 0; j < cntParams; j++)
                {
                    var sum = 0.0;
                    for (var k = 0; k < fullViborka; k++)
                        sum += (inputData[i, k] - mo[i]) * (inputData[j, k] - mo[j]);
                    corTmp[i, j] = sum / (fullViborka * sko[i] * sko[j]);
                }
            return corTmp;
        }
        private double[,] calcCovariation()
        {
            var tmp = new double[cntParams, cntParams];
            for (var i = 0; i < cntParams; i++)
                for (var j = 0; j < cntParams; j++)
                {
                    var sum = 0.0;
                    for (var k = 0; k < fullViborka; k++)
                        sum += (inputData[i, k] - mo[i]) * (inputData[j, k] - mo[j]);
                    tmp[i, j] = sum / (fullViborka - 1);
                }

            return tmp;
        }
        private double[,] calcCholesky()
        {
            var resArr = new double[cntParams,cntParams];
            for (var j = 0; j < cntParams; j++)
            {
                var s = 0.0;
                var ss = 0.0;
                for (var k = 0; k < cntParams - 1; k++)
                    s += resArr[j, k] * resArr[j, k];
                ss = covariation[j, j] - s;
                if (ss <= 0) break;
                ss = Math.Sqrt(ss);
                for (var i = j; i < cntParams; i++)
                {
                    s = 0.0;
                    for (var k = 0; k < cntParams - 1; k++) 
                        s += resArr[i, k] * resArr[j, k];
                    resArr[i, j] = (covariation[i, j] - s) / ss;
                }                
            }
            return resArr;
        }
        #endregion
    }
}
