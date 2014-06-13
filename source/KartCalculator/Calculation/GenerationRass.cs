using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace KartCalculator
{
    public class GenerationRass
    {
        public delegate void IntHandler(int val);
        public event IntHandler ChangePerc;

        public delegate void StrHandler(string val);
        public event StrHandler ChangeText;

        private string oldDir;
        private string newDir;
        private List<string> lstOldFiles;
        private int oldCntViborka;

        public GenerationRass(string oldDirPath)
        {
            this.oldDir = oldDirPath;
            this.newDir = oldDir + Path.DirectorySeparatorChar + "new" + Path.DirectorySeparatorChar;

            string[] files = Directory.GetFiles(this.oldDir);
            this.lstOldFiles = new List<string>();
            this.oldCntViborka = 0;
            foreach (string filePath in files)
                if (BaseParams.IsGoodFile(filePath))
                {
                    this.lstOldFiles.Add(filePath);
                    BaseParams bp = new BaseParams(filePath);
                    this.oldCntViborka += bp.CntViborka;
                }
        }
       
        public int CntOldViborka
        {
            get { return oldCntViborka; }
        }
        
        public int CntOldFiles
        {
            get
            {
                if (lstOldFiles == null) return 0;
                else return lstOldFiles.Count;
            }
        }

        private bool isReadyGenerate()
        {
            if (lstOldFiles == null)
            {
                if (ChangeText != null) ChangeText(string.Empty);
                return false;
            }

            if (newDir == null)
            {
                if (ChangeText != null) ChangeText(string.Empty);
                return false;
            }
            return true;
        }

        private void generate()
        {
            Directory.CreateDirectory(newDir);            
            //обработка новых файлов
            for (double d = 1.25; d <= 2; d += 0.25)
            {
                string newDirTmp = newDir + d.ToString() + Path.DirectorySeparatorChar;
                Directory.CreateDirectory(newDirTmp);
                foreach (string filePath in lstOldFiles)
                {                    
                    BaseParams bp = new BaseParams(filePath);
                    double[,] arrTmp = new double[bp.InputData.GetLength(0), bp.InputData.GetLength(1)];
                    for (int i=0;i<bp.InputData.GetLength(0);i++)
                        for (int j = 0; j < bp.InputData.GetLength(1); j++)
                            arrTmp[i, j] = bp.InputData[i, j] * Math.Pow(d, 1.0 / bp.CntParams);

                    String filePathNew = newDirTmp + Path.GetFileName(filePath);

                    StreamWriter sWr = File.CreateText(filePathNew);
                    sWr.WriteLine(bp.CntParams);
                    sWr.WriteLine(bp.WeightViborka);
                    sWr.WriteLine(bp.CntViborka);
                    for (int j = 0; j < arrTmp.GetLength(1); j++)
                    {
                        string curLine = string.Empty;
                        curLine += arrTmp[0, j].ToString("0.000").Replace(',', '.');
                        for (int k = 1; k < arrTmp.GetLength(0); k++)
                            curLine += '\t' + arrTmp[k, j].ToString("0.000").Replace(',', '.');
                        if (j != arrTmp.GetLength(1) - 1)
                            sWr.WriteLine(curLine);
                        else
                            sWr.Write(curLine);
                    }
                    sWr.Close();

                    if (ChangePerc != null)
                        ChangePerc(Convert.ToInt32((d - 1.25) * 100.0 + lstOldFiles.IndexOf(filePath) * 100.0 / (lstOldFiles.Count * 4.0)));
                }
            }
            if (ChangePerc != null) ChangePerc(0);
            if (ChangeText != null) ChangeText(Global.msgGenerationDone + lstOldFiles.Count * 4);
        }

        public void GenerateNewFiles()
        {
            if (!isReadyGenerate()) return;
            Thread thread = new Thread(new ThreadStart(generate));
            thread.Start();
        }
    }
}
