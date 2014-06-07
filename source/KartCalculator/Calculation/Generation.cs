using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace KartCalculator
{
    public class Generation
    {
        public delegate void IntHandler(int val);
        public event IntHandler ChangePerc;

        public delegate void StrHandler(string val);
        public event StrHandler ChangeText;

        private BaseParams baseParams;
        private string dirPath;
        private int cntFiles;  
        public int CntFiles
        {
            get { return cntFiles; }
            set { cntFiles = value; }
        }        
        public string DirPath
        {
            get { return dirPath; }
            set { dirPath = value; }
        }

        public Generation(BaseParams baseParams)
        {
            this.baseParams = baseParams;
        }

        public void Generate()
        {
            if (!isReady()) return;
            Thread thread = new Thread(new ThreadStart(generate));
            thread.Start();
        }

        private bool isReady()
        {
            if (cntFiles == null)
            {
                if (ChangeText != null) ChangeText(string.Empty);
                return false;
            }

            if (dirPath == null)
            {
                if (ChangeText != null) ChangeText(string.Empty);
                return false;
            }
            return true;
        }

        private void generate()
        {
            Directory.CreateDirectory(dirPath);

            for (int indFile = 0; indFile < cntFiles; indFile++)
            {
                String filePath = dirPath + indFile.ToString() + ".dtk";
                double[,] arrWrite = createGenArray();

                StreamWriter sWr = File.CreateText(filePath);
                sWr.WriteLine(baseParams.CntParams);
                sWr.WriteLine(baseParams.WeightViborka);
                sWr.WriteLine(baseParams.CntViborka);
                for (int j = 0; j < arrWrite.GetLength(1); j++)
                {
                    string curLine = string.Empty;
                    curLine += arrWrite[0, j].ToString("0.000");
                    for (int k = 1; k < arrWrite.GetLength(0); k++)
                        curLine += '\t' + arrWrite[k, j].ToString("0.000");                    
                    if (j != arrWrite.GetLength(1) - 1)
                        sWr.WriteLine(curLine);
                    else
                        sWr.Write(curLine);                        
                }
                sWr.Close();

                if (ChangePerc != null) ChangePerc(Convert.ToInt32(indFile * 100.0 / cntFiles));
            }
            if (ChangePerc != null) ChangePerc(0);
            if (ChangeText != null) ChangeText(Global.msgGenerationDone + cntFiles);
        }

        private double[,] createGenArray()
        {
            double[,] normBeginArr = createNorm(baseParams.CntParams, baseParams.FullViborka);
            double[,] normFinishArr = new double[baseParams.CntParams, baseParams.FullViborka];
            for (int i = 0; i < baseParams.FullViborka; i++)
            {
                double[] temp = new double[baseParams.CntParams];
                for (int j = 0; j < temp.Length; j++)
                    temp[j] = normBeginArr[j, i];
                double[] norm = mult1V2V(temp, baseParams.Cholesky);
                for (int j = 0; j < baseParams.CntParams; j++)
                    normFinishArr[j, i] = norm[j] + baseParams.Mo[j];
            }
            return normFinishArr;
        }

        private double[,] createNorm(int weight, int height)
        {
            Random rnd = new Random();
            double[,] arrTmp = new double[weight, height];
            for (int i = 0; i < weight; i++)
                for (int j = 0; j < height; j++)
                    arrTmp[i, j] = randGauss(0, 1, rnd);
            return arrTmp;
        }

        private double randGauss(double moVal, double skoVal, Random rnd)
        {
            double u1 = 0.0;
            double s2 = 0.0;
            do
            {
                double tmp1 = rnd.NextDouble();
                u1 = 2 * tmp1 - 1;
                double tmp2 = rnd.NextDouble();
                s2 = Math.Pow(u1, 2) + Math.Pow(2.0 * tmp2 - 1, 2);
            } while (s2 >= 1);
            return Math.Sqrt(-2.0 * Math.Log(s2) / s2) * u1 * skoVal + moVal;
        }

        private double[] mult1V2V(double[] data, double[,] src)
        {
            double[] arrTmp = new double[data.Length];
            for (int i = 0; i < data.Length; i++)
                for (int j = 0; j < data.Length; j++)
                    arrTmp[i] += src[j, i] * data[j];
            return arrTmp;
        }
    }
}
