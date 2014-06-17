using System;
using System.Globalization;
using System.IO;

namespace KartCalculator.Calculation
{
    public class BaseParams
    {
        #region Public fields

        public string FilePath { get; private set; }

        public int CntParams { get; private set; }

        public int WeightViborka { get; private set; }

        public int CntViborka { get; private set; }

        public int FullViborka { get; private set; }

        public double[,] InputData { get; private set; }

        public double[] Mo { get; private set; }

        public double[] Sko { get; private set; }

        public double[,] Mosko
        {
            get
            {
                var tmp = new double[CntParams, 2];
                for (var i = 0; i < CntParams; i++)
                {
                    tmp[i, 0] = Mo[i];
                    tmp[i, 1] = Sko[i];
                }
                return tmp;
            }
        }

        public double[,] Correlation { get; private set; }

        public double[,] Covariation { get; private set; }

        public double[,] Cholesky { get; private set; }

        #endregion

        #region Public methods
        public BaseParams(string filePath)
        {
            FilePath = filePath;
            CalcBaseParams();
        }

        public static bool IsGoodFile(String filePath)
        {
            try
            {
            // ReSharper disable once ObjectCreationAsStatement
                if (filePath != null) new BaseParams(filePath);
            }
            catch (Exception)
            { return false; }

            return true;
        }
        #endregion

        #region Private methods
        private void CalcBaseParams()
        {
            //Входные данные
            using (var sr = new StreamReader(FilePath))
            {
                CntParams = Convert.ToInt32(sr.ReadLine());
                WeightViborka = Convert.ToInt32(sr.ReadLine());
                CntViborka = Convert.ToInt32(sr.ReadLine());
                FullViborka = WeightViborka * CntViborka;

                InputData = new double[CntParams, FullViborka];
                for (var i = 0; i < FullViborka; i++)
                {
                    var readLine = sr.ReadLine();
                    if (readLine == null) continue;
                    var curLineItems = readLine.Split('\t');
                    for (var j = 0; j < curLineItems.Length; j++)
                        InputData[j, i] = float.Parse(curLineItems[j], CultureInfo.InvariantCulture.NumberFormat);
                }
            }
            Mo = CalcMo();
            Sko = CalcSko();
            Correlation = CalcCorrelation();
            Covariation = CalcCovariation();
            Cholesky = CalcCholesky();
        }

        private double[] CalcMo()
        {
            var moTmp = new double[CntParams];
            for (var i = 0; i < CntParams; i++)
            {
                for (var j = 0; j < FullViborka; j++)
                    moTmp[i] += InputData[i, j];
                moTmp[i] /= FullViborka;
            }
            return moTmp;
        }        
        private double[] CalcSko()
        {
            var skoTmp = new double[CntParams];
            for (var i = 0; i < CntParams; i++)
            {
                for (var j = 0; j < FullViborka; j++)
                    skoTmp[i] += Math.Pow(InputData[i, j] - Mo[i], 2);
                skoTmp[i] = Math.Sqrt(skoTmp[i] / FullViborka);
            }
            return skoTmp;
        }        
        private double[,] CalcCorrelation()
        {
            var corTmp = new double[CntParams, CntParams];

            for (var i = 0; i < CntParams; i++)
                for (var j = 0; j < CntParams; j++)
                {
                    var sum = 0.0;
                    for (var k = 0; k < FullViborka; k++)
                        sum += (InputData[i, k] - Mo[i]) * (InputData[j, k] - Mo[j]);
                    corTmp[i, j] = sum / (FullViborka * Sko[i] * Sko[j]);
                }
            return corTmp;
        }
        private double[,] CalcCovariation()
        {
            var tmp = new double[CntParams, CntParams];
            for (var i = 0; i < CntParams; i++)
                for (var j = 0; j < CntParams; j++)
                {
                    var sum = 0.0;
                    for (var k = 0; k < FullViborka; k++)
                        sum += (InputData[i, k] - Mo[i]) * (InputData[j, k] - Mo[j]);
                    tmp[i, j] = sum / (FullViborka - 1);
                }

            return tmp;
        }
        private double[,] CalcCholesky()
        {
            var resArr = new double[CntParams,CntParams];
            for (var j = 0; j < CntParams; j++)
            {
                var s = 0.0;
                for (var k = 0; k < CntParams - 1; k++)
                    s += resArr[j, k] * resArr[j, k];
                var ss = Covariation[j, j] - s;
                if (ss <= 0) break;
                ss = Math.Sqrt(ss);
                for (var i = j; i < CntParams; i++)
                {
                    s = 0.0;
                    for (var k = 0; k < CntParams - 1; k++) 
                        s += resArr[i, k] * resArr[j, k];
                    resArr[i, j] = (Covariation[i, j] - s) / ss;
                }                
            }
            return resArr;
        }
        #endregion
    }
}
