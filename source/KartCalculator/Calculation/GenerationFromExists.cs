using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace KartCalculator
{
    public class GenerationFromExists
    {
        public delegate void IntHandler(int val);
        public event IntHandler ChangePerc;

        public delegate void StrHandler(string val);
        public event StrHandler ChangeText;

        private string oldDir;
        private string newDir;
        private List<string> lstOldFiles;
        private int oldCntViborka;
        private const int cntViborkaPerFile = 370;

        public GenerationFromExists(string oldDirPath)
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

        public int CntCalcNewFiles
        {
            get
            {
                return oldCntViborka / cntViborkaPerFile;
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
            int indexOldFile = 0;
            //обработка новых файлов
            for (int indNew = 0; indNew < CntCalcNewFiles; indNew++)
            {
                int indexVibWr = 0;
                String filePath = newDir + indNew.ToString() + ".dtk";
                StreamWriter sWr = File.CreateText(filePath);
                sWr.WriteLine(new BaseParams(lstOldFiles[indexOldFile]).CntParams);
                sWr.WriteLine(new BaseParams(lstOldFiles[indexOldFile]).WeightViborka);
                sWr.WriteLine(cntViborkaPerFile);
                //запись выборок максимум 370 в файл
                while (indexVibWr < cntViborkaPerFile)
                {
                    BaseParams bpCur = new BaseParams(lstOldFiles[indexOldFile]);
                    int curVibRd = 0;
                    while (curVibRd < bpCur.CntViborka)
                    {
                        for (int j = 0; j < bpCur.WeightViborka; j++)
                        {
                            string curLine = string.Empty;
                            curLine += bpCur.InputData[0, curVibRd * bpCur.WeightViborka + j].ToString("0.000").Replace(',', '.');
                            for (int i = 1; i < bpCur.CntParams; i++)
                                curLine += '\t' + bpCur.InputData[i, curVibRd * bpCur.WeightViborka + j].ToString("0.000").Replace(',', '.');
                            sWr.WriteLine(curLine);
                        }
                        curVibRd++;
                        indexVibWr++;
                        if (ChangePerc != null) ChangePerc(Convert.ToInt32(100.0 * indNew / CntCalcNewFiles));
                    }
                }
                indexOldFile++;
                sWr.Close();
            }

            if (ChangePerc != null) ChangePerc(0);
            if (ChangeText != null) ChangeText(Global.msgGenerationDone + CntCalcNewFiles);
        }
        public void GenerateNewFiles()
        {
            if (!isReadyGenerate()) return;
            Thread thread = new Thread(new ThreadStart(generate));
            thread.Start();
        }
    }
}
