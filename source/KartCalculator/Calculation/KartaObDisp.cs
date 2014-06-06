using System;
using System.Collections.Generic;
using System.Text;

namespace KartCalculator
{
    public class KartaObDisp
    {
        private BaseParams basePar;
        private double[, ,] arrSt;
        private double[] detArrSt;
        private double[,] arrS;
        private double detArrS;
        private double ucl;        
        private double lcl;
        private double b1;        
        private double b2;        
        
        public double[,] ArrS
        {
            get { return arrS; }
        }
        public double[, ,] ArrSt
        {
            get { return arrSt; }
        }
        public double[] DetArrSt
        {
            get { return detArrSt; }
        }
        public double DetArrS
        {
            get { return detArrS; }
        }
        public double Ucl
        {
            get { return ucl; }
        }
        public double Lcl
        {
            get { return lcl; }
        }
        public double B1
        {
            get { return b1; }
        }
        public double B2
        {
            get { return b2; }
        }

        public KartaObDisp(BaseParams baseParams)
        {
            this.basePar = baseParams;
            this.calcParams();
        }

        private void calcParams()
        {
            this.calcArrSt();
            this.calcDetArrSt();
            this.calcArrS();
            this.calcDetArrS();
            this.calcB1B2();
            this.calcUclLcl();
        }

        //расчет виборочной ковариационной матрицы St
        private void calcArrSt()
        {
            double[, ,] arrTmpSjkt = new double[basePar.CntParams, basePar.CntParams, basePar.CntViborka];
            for (int j = 0; j < basePar.CntParams; j++)
                for (int k = 0; k < basePar.CntParams; k++)
                    for (int t = 0; t < basePar.CntViborka; t++)
                    {
                        //среднее значение по выборке
                        double avVibJ = 0.0;
                        double avVibK = 0.0;
                        for (int i = 0; i < basePar.WeightViborka; i++)
                        {
                            avVibJ += basePar.InputData[j, t * basePar.WeightViborka + i];
                            avVibK += basePar.InputData[k, t * basePar.WeightViborka + i];
                        }
                        avVibJ /= basePar.WeightViborka;
                        avVibK /= basePar.WeightViborka;

                        //умножение разниц значений и средних сзначений
                        double multVib = 0.0;
                        for (int i = 0; i < basePar.WeightViborka; i++)
                            multVib +=
                                (basePar.InputData[j, t * basePar.WeightViborka + i] - avVibJ) *
                                (basePar.InputData[k, t * basePar.WeightViborka + i] - avVibK);
                        multVib /= basePar.WeightViborka - 1;
                        arrTmpSjkt[j, k, t] = multVib;
                    }

            this.arrSt = arrTmpSjkt;
        }
        //расчет массива детерминатов
        private void calcDetArrSt()
        {
            double[] arrTmp = new double[arrSt.GetLength(2)];
            for (int i = 0; i < arrSt.GetLength(2); i++)
            {
                double[,] arrSjk = new double[arrSt.GetLength(0), arrSt.GetLength(1)];
                for (int j = 0; j < arrSjk.GetLength(0); j++)
                    for (int k = 0; k < arrSjk.GetLength(1); k++)
                        arrSjk[j, k] = arrSt[j, k, i];
                arrTmp[i] = determinant(arrSjk);
            }
            this.detArrSt = arrTmp;
        }        
        //расчет ковариационной матрицы S
        private void calcArrS()
        {
            double[,] arrTmp = new double[basePar.CntParams, basePar.CntParams];
            for (int j=0;j<basePar.CntParams;j++)
                for (int k = 0; k < basePar.CntParams; k++)
                {
                    double sumTmp = 0.0;
                    for (int t = 0; t < basePar.CntViborka; t++)
                        sumTmp += arrSt[j, k, t];
                    sumTmp /= basePar.CntViborka;
                    arrTmp[j, k] = sumTmp;
                }
            this.arrS = arrTmp;
        }
        //расчет определителя S
        private void calcDetArrS()
        {
            this.detArrS = determinant(arrS);
        }
        private void calcB1B2()
        {
            double b1Tmp = 1.0;
            for (int i = 1; i <= basePar.CntParams; i++)
                b1Tmp *= basePar.WeightViborka - i;
            b1Tmp /= Math.Pow(basePar.WeightViborka - 1, basePar.CntParams);
            this.b1 = b1Tmp;

            double b2Tmp = 1.0;
            double tmp1 = 1.0;
            double tmp2 = 1.0;
            for (int i = 1; i <= basePar.CntParams; i++)
                tmp1 *= basePar.WeightViborka - i + 2;
            for (int i = 1; i <= basePar.CntParams; i++)
                tmp2 *= basePar.WeightViborka - i;
            for (int i = 1; i <= basePar.CntParams; i++)
                b2Tmp *= basePar.WeightViborka - i;
            b2Tmp *= tmp1 - tmp2;
            b2Tmp /= Math.Pow(basePar.WeightViborka - 1, 2 * basePar.CntParams);
            this.b2 = b2Tmp;
        }
        private void calcUclLcl()
        {
            this.ucl = detArrS * (b1 + 3 * Math.Sqrt(b2));
            if (this.ucl < 0.0) ucl = 0.0;
            this.lcl = detArrS * (b1 - 3 * Math.Sqrt(b2));
            if (this.lcl < 0.0) lcl = 0.0;
        }

        #region Детерминант
        //this method determines the sign of the elements
        private int signOfElement(int i, int j)
        {
            if ((i + j) % 2 == 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        //this method determines the sub matrix corresponding to a given element
        private double[,] createSmallerMatrix (double[,]input, int i, int j)
        {
            int order = int.Parse(System.Math.Sqrt(input.Length).ToString());
            double[,] output = new double[order-1, order-1];
            int x = 0, y = 0;
            for (int m = 0; m < order; m++, x++)
            {
                if (m != i)
                {
                    y = 0;
                    for (int n = 0; n < order; n++)
                    {
                        if (n != j)
                        {
                            output[x, y] = input[m, n];
                            y++;
                        }
                    }
                }
                else
                {
                    x--;
                }
            }
            return output;
        }
        //this method determines the value of determinant using recursion
        private double determinant(double[,] input)
        {
            int order = int.Parse(System.Math.Sqrt(input.Length).ToString());
            if (order > 2)
            {
                double value = 0;
                for (int j = 0; j < order; j++)
                {
                    double[,] Temp = createSmallerMatrix(input, 0, j);
                    value = value + input[0, j] * (signOfElement(0, j) * determinant(Temp));
                }
                return value;
            }
            else if (order == 2)
            {
                return ((input[0, 0] * input[1, 1]) - (input[1, 0] * input[0, 1]));
            }
            else
            {
                return (input[0, 0]);
            }
        }
        #endregion
    }
}