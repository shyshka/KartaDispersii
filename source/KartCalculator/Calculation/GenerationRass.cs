using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace KartCalculator.Calculation
{
    public class GenerationRass
    {
        public event Global.IntHandler ChangePerc;
        public event Global.StrHandler ChangeText;

        private readonly string _newDir;
        private readonly List<string> _lstOldFiles;
        private readonly int _oldCntViborka;
        private Random _rnd;

        public GenerationRass(string oldDirPath)
        {
            var oldDir = oldDirPath;
            _newDir = Directory.GetParent(oldDir).FullName;

            var files = Directory.GetFiles(oldDir);
            _lstOldFiles = new List<string>();
            _oldCntViborka = 0;
            foreach (var filePath in files)
                if (BaseParams.IsGoodFile(filePath))
                {
                    _lstOldFiles.Add(filePath);
                    var bp = new BaseParams(filePath);
                    _oldCntViborka += bp.CntViborka;
                }
            _rnd = new Random();
        }
       
        public int CntOldViborka
        {
            get { return _oldCntViborka; }
        }
        
        public int CntOldFiles
        {
            get
            {
                return _lstOldFiles == null ? 0 : _lstOldFiles.Count;
            }
        }

        private bool IsReadyGenerate()
        {
            if (_lstOldFiles == null)
            {
                if (ChangeText != null) ChangeText(string.Empty);
                return false;
            }

            if (_newDir == null)
            {
                if (ChangeText != null) ChangeText(string.Empty);
                return false;
            }
            return true;
        }

        private void Generate()
        {
            Directory.CreateDirectory(_newDir);            
            //обработка новых файлов
            for (var d = 1.25; d <= 2; d += 0.25)
            {
                var newDirTmp = Path.Combine(_newDir, "Generation-D" + d);
                Directory.CreateDirectory(newDirTmp);
                foreach (var filePath in _lstOldFiles)
                {                    
                    if (filePath==null) return;
                    var bp = new BaseParams(filePath);
                    var arrTmp = new double[bp.InputData.GetLength(0), bp.InputData.GetLength(1)];
                    for (var i=0;i<bp.InputData.GetLength(0);i++)
                        for (var j = 0; j < bp.InputData.GetLength(1); j++)
                            arrTmp[i, j] = bp.InputData[i, j]*Math.Pow(d, 1.0/bp.CntParams);

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
                        ChangePerc(Convert.ToInt32((d - 1.25) * 100.0 + _lstOldFiles.IndexOf(filePath) * 100.0 / (_lstOldFiles.Count * 4.0)));
                }
            }
            if (ChangePerc != null) ChangePerc(0);
            if (ChangeText != null) ChangeText(Global.MsgGenerationDone + _lstOldFiles.Count * 4);
        }

        public void GenerateNewFiles()
        {
            if (!IsReadyGenerate()) return;
            var thread = new Thread(Generate);
            thread.Start();
        }
    }
}
