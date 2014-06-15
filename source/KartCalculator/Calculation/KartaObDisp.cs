using System;
using System.Globalization;
using System.IO;

namespace KartCalculator.Calculation
{
    public class KartaObDisp
    {
        private readonly BaseParams _basePar;

        public double[,] ArrS { get; private set; }

        public double[,,] ArrSt { get; private set; }

        public double[] DetArrSt { get; private set; }

        public double DetArrS { get; private set; }

        public double Ucl { get; private set; }

        public double Lcl { get; private set; }

        public double B1 { get; private set; }

        public double B2 { get; private set; }

        public KartaObDisp(BaseParams baseParams)
        {
            _basePar = baseParams;
            CalcParams();
        }

        public void SaveData(string filePath)
        {
            using (var sWr = File.CreateText(filePath))
            {
                sWr.WriteLine("Базовый файл для расчетов: " + _basePar.FilePath);
                sWr.WriteLine("Параметры базового файла:");
                sWr.WriteLine("Количество параметров: " + _basePar.CntParams);
                sWr.WriteLine("Глубина выборки: " + _basePar.WeightViborka);
                sWr.WriteLine("Количество выборок: " + _basePar.CntViborka);
                sWr.WriteLine();

                sWr.WriteLine("Выборочная ковариационная матрица:");
                for (int t = 0; t < ArrSt.GetLength(2); t++)
                {
                    sWr.WriteLine("Выборка № " + (t + 1).ToString() + " Определитель: " + Global.GetString(DetArrSt[t]));
                    for (int i = 0; i < ArrSt.GetLength(0); i++)
                    {
                        var line = string.Empty;
                        for (int j = 0; j < ArrSt.GetLength(1); j++)
                            line += Global.GetString(ArrSt[i, j, t]) + '\t';
                        sWr.WriteLine(line);
                    }
                    sWr.WriteLine();
                }

                sWr.WriteLine("Ковариационная матрица. Определитель: "+Global.GetString(DetArrS));
                for (int i = 0; i < ArrS.GetLength(0); i++)
                {
                    var line = string.Empty;
                    for (int j = 0; j < ArrS.GetLength(1); j++)
                        line += Global.GetString(ArrS[i, j]) + '\t';
                    sWr.WriteLine(line);
                }
                sWr.WriteLine();

                sWr.WriteLine("B1=" + Global.GetString(B1));
                sWr.WriteLine("B2=" + Global.GetString(B2));
                sWr.WriteLine("Верхняя граница: UCL=" + Global.GetString(Ucl));
                sWr.WriteLine("Нижняя граница: LCL=" + Global.GetString(Lcl));
            }
        }

        private void CalcParams()
        {
            CalcArrSt();
            CalcDetArrSt();
            CalcArrS();
            CalcDetArrS();
            CalcB1B2();
            CalcUclLcl();
        }
        //расчет виборочной ковариационной матрицы St
        private void CalcArrSt()
        {
            var arrTmpSjkt = new double[_basePar.CntParams, _basePar.CntParams, _basePar.CntViborka];
            for (var j = 0; j < _basePar.CntParams; j++)
                for (var k = 0; k < _basePar.CntParams; k++)
                    for (var t = 0; t < _basePar.CntViborka; t++)
                    {
                        //среднее значение по выборке
                        var avVibJ = 0.0;
                        var avVibK = 0.0;
                        for (var i = 0; i < _basePar.WeightViborka; i++)
                        {
                            avVibJ += _basePar.InputData[j, t * _basePar.WeightViborka + i];
                            avVibK += _basePar.InputData[k, t * _basePar.WeightViborka + i];
                        }
                        avVibJ /= _basePar.WeightViborka;
                        avVibK /= _basePar.WeightViborka;

                        //умножение разниц значений и средних сзначений
                        var multVib = 0.0;
                        for (var i = 0; i < _basePar.WeightViborka; i++)
                            multVib +=
                                (_basePar.InputData[j, t * _basePar.WeightViborka + i] - avVibJ) *
                                (_basePar.InputData[k, t * _basePar.WeightViborka + i] - avVibK);
                        multVib /= _basePar.WeightViborka - 1;
                        arrTmpSjkt[j, k, t] = multVib;
                    }

            ArrSt = arrTmpSjkt;
        }
        //расчет массива детерминатов
        private void CalcDetArrSt()
        {
            var arrTmp = new double[ArrSt.GetLength(2)];
            for (var i = 0; i < ArrSt.GetLength(2); i++)
            {
                var arrSjk = new double[ArrSt.GetLength(0), ArrSt.GetLength(1)];
                for (var j = 0; j < arrSjk.GetLength(0); j++)
                    for (var k = 0; k < arrSjk.GetLength(1); k++)
                        arrSjk[j, k] = ArrSt[j, k, i];
                arrTmp[i] = Determinant(arrSjk);
            }
            DetArrSt = arrTmp;
        }        
        //расчет ковариационной матрицы S
        private void CalcArrS()
        {
            var arrTmp = new double[_basePar.CntParams, _basePar.CntParams];
            for (var j = 0; j < _basePar.CntParams; j++)
                for (var k = 0; k < _basePar.CntParams; k++)
                {
                    var sumTmp = 0.0;
                    for (var t = 0; t < _basePar.CntViborka; t++)
                        sumTmp += ArrSt[j, k, t];
                    sumTmp /= _basePar.CntViborka;
                    arrTmp[j, k] = sumTmp;
                }
            ArrS = arrTmp;
        }

        //расчет определителя S
        private void CalcDetArrS()
        {
            DetArrS = Determinant(ArrS);
        }
        private void CalcB1B2()
        {
            var b1Tmp = 1.0;
            for (var i = 1; i <= _basePar.CntParams; i++)
                b1Tmp *= _basePar.WeightViborka - i;
            b1Tmp /= Math.Pow(_basePar.WeightViborka - 1, _basePar.CntParams);
            B1 = b1Tmp;

            var b2Tmp = 1.0;
            var tmp1 = 1.0;
            var tmp2 = 1.0;
            for (var i = 1; i <= _basePar.CntParams; i++)
                tmp1 *= _basePar.WeightViborka - i + 2;
            for (var i = 1; i <= _basePar.CntParams; i++)
                tmp2 *= _basePar.WeightViborka - i;
            for (var i = 1; i <= _basePar.CntParams; i++)
                b2Tmp *= _basePar.WeightViborka - i;
            b2Tmp *= tmp1 - tmp2;
            b2Tmp /= Math.Pow(_basePar.WeightViborka - 1, 2 * _basePar.CntParams);
            B2 = b2Tmp;
        }
        private void CalcUclLcl()
        {
            Ucl = DetArrS * (B1 + 3 * Math.Sqrt(B2));
            if (Ucl < 0.0) Ucl = 0.0;
            Lcl = DetArrS * (B1 - 3 * Math.Sqrt(B2));
            if (Lcl < 0.0) Lcl = 0.0;
        }

        #region Детерминант
        //this method determines the sign of the elements
        private int signOfElement(int i, int j)
        {
            if ((i + j) % 2 == 0)
            {
                return 1;
            }
            return -1;
        }

        //this method determines the sub matrix corresponding to a given element
        private double[,] createSmallerMatrix (double[,]input, int i, int j)
        {
            var order = int.Parse(Math.Sqrt(input.Length).ToString(CultureInfo.InvariantCulture));
            var output = new double[order-1, order-1];
            int x = 0;
            for (var m = 0; m < order; m++, x++)
            {
                if (m != i)
                {
                    int y = 0;
                    for (var n = 0; n < order; n++)
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
        private double Determinant(double[,] input)
        {
            var order = int.Parse(Math.Sqrt(input.Length).ToString(CultureInfo.InvariantCulture));
            if (order > 2)
            {
                double value = 0;
                for (var j = 0; j < order; j++)
                {
                    var temp = createSmallerMatrix(input, 0, j);
                    value = value + input[0, j] * (signOfElement(0, j) * Determinant(temp));
                }
                return value;
            }
            if (order == 2)
            {
                return ((input[0, 0] * input[1, 1]) - (input[1, 0] * input[0, 1]));
            }
            return (input[0, 0]);
        }
        #endregion
    }
}