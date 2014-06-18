using System;
using System.IO;
using System.Threading;

namespace KartCalculator.Calculation
{
    public class GenerationNorm
    {
        public event Global.IntHandler ChangePerc;
        public event Global.StrHandler ChangeText;

        private readonly BaseParams _baseParams;
        private string _dirPath;
        public int CntFiles { get; set; }

        private Random rnd;

        public string DirPath
        {
            get { return _dirPath; }
            set { _dirPath = value; }
        }

        public GenerationNorm(BaseParams baseParams)
        {
            _baseParams = baseParams;
            rnd = new Random();
        }

        public void Generate()
        {
            if (!IsReady()) return;
            var thread = new Thread(GenerateThread);
            thread.Start();
        }

        private bool IsReady()
        {
            return _dirPath != null;
        }

        private void GenerateThread()
        {
            Directory.CreateDirectory(_dirPath);

            for (var indFile = 0; indFile < CntFiles; indFile++)
            {
                var rnd = new Random();
                var filePath = Path.Combine(_dirPath, indFile + ".dtk");
                var arrWrite = CreateGenArray();

                var sWr = File.CreateText(filePath);
                sWr.WriteLine(_baseParams.CntParams);
                sWr.WriteLine(_baseParams.WeightViborka);
                sWr.WriteLine(_baseParams.CntViborka);
                for (var j = 0; j < arrWrite.GetLength(1); j++)
                {
                    var curLine = string.Empty;
                    curLine += arrWrite[0, j].ToString("0.000").Replace(',', '.');
                    for (var k = 1; k < arrWrite.GetLength(0); k++)
                        curLine += '\t' + arrWrite[k, j].ToString("0.000").Replace(',', '.');                    
                    if (j != arrWrite.GetLength(1) - 1)
                        sWr.WriteLine(curLine);
                    else
                        sWr.Write(curLine);                        
                }
                sWr.Close();

                if (ChangePerc != null) ChangePerc(Convert.ToInt32(indFile * 100.0 / CntFiles));
            }
            if (ChangePerc != null) ChangePerc(0);
            if (ChangeText != null) ChangeText(Global.MsgGenerationDone + CntFiles);
        }

        private double[,] CreateGenArray()
        {
            var normBeginArr = CreateNorm(_baseParams.CntParams, _baseParams.FullViborka);
            var normFinishArr = new double[_baseParams.CntParams, _baseParams.FullViborka];
            for (var i = 0; i < _baseParams.FullViborka; i++)
            {
                var temp = new double[_baseParams.CntParams];
                for (var j = 0; j < temp.Length; j++)
                    temp[j] = normBeginArr[j, i];
                var norm = mult1V2V(temp, _baseParams.Cholesky);
                for (var j = 0; j < _baseParams.CntParams; j++)
                    normFinishArr[j, i] = norm[j] + _baseParams.Mo[j];
            }
            return normFinishArr;
        }

        private double[,] CreateNorm(int weight, int height)
        {
            var arrTmp = new double[weight, height];
            for (var i = 0; i < weight; i++)
                for (var j = 0; j < height; j++)
                    arrTmp[i, j] = randGauss(0, 1);
            return arrTmp;
        }

        private double randGauss(double moVal, double skoVal)
        {
            double u1;
            double s2;
            do
            {
                var tmp1 = rnd.NextDouble();
                u1 = 2 * tmp1 - 1;
                var tmp2 = rnd.NextDouble();
                s2 = Math.Pow(u1, 2) + Math.Pow(2.0 * tmp2 - 1, 2);
            } while (s2 >= 1);
            return Math.Sqrt(-2.0 * Math.Log(s2) / s2) * u1 * skoVal + moVal;
            //return rnd.NextDouble();
        }

        private double[] mult1V2V(double[] data, double[,] src)
        {
            var arrTmp = new double[data.Length];
            for (var i = 0; i < data.Length; i++)
                for (var j = 0; j < data.Length; j++)
                    arrTmp[i] += src[j, i]*data[j];
            return arrTmp;
        }
    }
}
