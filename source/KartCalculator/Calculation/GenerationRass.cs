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
            oldDir = oldDirPath;
            newDir = Directory.GetParent(oldDir).FullName;

            var files = Directory.GetFiles(oldDir);
            lstOldFiles = new List<string>();
            oldCntViborka = 0;
            foreach (var filePath in files)
                if (BaseParams.IsGoodFile(filePath))
                {
                    lstOldFiles.Add(filePath);
                    var bp = new BaseParams(filePath);
                    oldCntViborka += bp.CntViborka;
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
            for (var d = 1.25; d <= 2; d += 0.25)
            {
                var newDirTmp = Path.Combine(newDir, "Generation-D" + d);
                Directory.CreateDirectory(newDirTmp);
                foreach (var filePath in lstOldFiles)
                {                    
                    var bp = new BaseParams(filePath);
                    var arrTmp = new double[bp.InputData.GetLength(0), bp.InputData.GetLength(1)];
                    for (var i=0;i<bp.InputData.GetLength(0);i++)
                        for (var j = 0; j < bp.InputData.GetLength(1); j++)
                            arrTmp[i, j] = bp.InputData[i, j] * Math.Pow(d, 1.0 / bp.CntParams);

                    var filePathNew = Path.Combine(newDirTmp, Path.GetFileName(filePath));

                    var sWr = File.CreateText(filePathNew);
                    sWr.WriteLine(bp.CntParams);
                    sWr.WriteLine(bp.WeightViborka);
                    sWr.WriteLine(bp.CntViborka);
                    for (var j = 0; j < arrTmp.GetLength(1); j++)
                    {
                        var curLine = string.Empty;
                        curLine += arrTmp[0, j].ToString("0.000").Replace(',', '.');
                        for (var k = 1; k < arrTmp.GetLength(0); k++)
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
            var thread = new Thread(generate);
            thread.Start();
        }
    }
}
