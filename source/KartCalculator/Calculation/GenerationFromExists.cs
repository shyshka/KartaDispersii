using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace KartCalculator.Calculation
{
    public class GenerationFromExists
    {
        public delegate void IntHandler(int val);

        public event IntHandler ChangePerc;

        public delegate void StrHandler(string val);

        public event StrHandler ChangeText;

        private readonly string _oldDir;
        private readonly string _newDir;
        private  List<string> _lstOldFiles;
        private  int _oldCntViborka;
        private const int CntViborkaPerFile = 370;

        public GenerationFromExists(string oldDirPath)
        {
            _oldDir = oldDirPath;
            _newDir = Path.Combine(
                Directory.GetParent(_oldDir).FullName,
                "Generation-M370");
        }

        public void LoadFiles()
        {
            var files = Directory.GetFiles(_oldDir);
            _lstOldFiles = new List<string>();
            _oldCntViborka = 0;
            for (int i = 0; i < files.Length; i++)
                if (BaseParams.IsGoodFile(files[i]))
                {
                    _lstOldFiles.Add(files[i]);
                    var bp = new BaseParams(files[i]);
                    _oldCntViborka += bp.CntViborka;
                    ChangePerc(Convert.ToInt32(i * 100.0 / files.Length));
                }
            ChangePerc(0);
        }

        public int CntOldViborka
        {
            get { return _oldCntViborka; }
        }

        public int CntOldFiles
        {
            get { return _lstOldFiles == null ? 0 : _lstOldFiles.Count; }
        }

        public int CntCalcNewFiles
        {
            get
            {
                var bp = new BaseParams(_lstOldFiles[0]);
                var cntSmallInBig = Convert.ToInt32(Math.Floor(double.Parse((CntViborkaPerFile/bp.CntViborka).ToString())) + 1);
                return cntSmallInBig;
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

        private void GenerateThread()
        {
            Directory.CreateDirectory(_newDir);
            var indOldFile = 0;
            var indOldVib = 0;
            //обработка новых файлов
            for (var indNewFile = 0; indNewFile < CntCalcNewFiles; indNewFile++)
            {
                if (indOldFile >= _lstOldFiles.Count) indOldFile = 0;
                var filePath = Path.Combine(_newDir, indNewFile + ".dtk");
                var sWrNew = File.CreateText(filePath);
                sWrNew.WriteLine(new BaseParams(_lstOldFiles[indOldFile]).CntParams);
                sWrNew.WriteLine(new BaseParams(_lstOldFiles[indOldFile]).WeightViborka);
                sWrNew.WriteLine(CntViborkaPerFile);

                var indNewVib = 0;
                //запись выборок максимум 370 в файл
                while (indNewVib < CntViborkaPerFile)
                {
                    if (indOldFile >= _lstOldFiles.Count) indOldFile = 0;
                    var bpCur = new BaseParams(_lstOldFiles[indOldFile]);
                    //считывание выборок из файла
                    while (indOldVib < bpCur.CntViborka)
                    {
                        //запись одной выборки указанной глубины
                        for (var j = 0; j < bpCur.WeightViborka; j++)
                        {
                            var curLine = string.Empty;
                            curLine +=
                                bpCur.InputData[0, indOldVib*bpCur.WeightViborka + j].ToString("0.000")
                                    .Replace(',', '.');
                            for (var i = 1; i < bpCur.CntParams; i++)
                                curLine += '\t' +
                                           bpCur.InputData[i, indOldVib*bpCur.WeightViborka + j].ToString("0.000")
                                               .Replace(',', '.');
                            sWrNew.WriteLine(curLine);
                        }
                        indOldVib++;
                        indNewVib++;
                        if (ChangePerc != null) ChangePerc(Convert.ToInt32(100.0*indNewFile/CntCalcNewFiles));
                        if (indNewVib == CntViborkaPerFile)
                            break;
                    }
                    indOldFile++;
                    indOldVib = 0;
                }
                sWrNew.Close();
            }

            if (ChangePerc != null) ChangePerc(0);
            if (ChangeText != null) ChangeText(Global.MsgGenerationDone + CntCalcNewFiles);
        }

        public void GenerateNewFiles()
        {
            if (!IsReadyGenerate()) return;
            var thread = new Thread(GenerateThread);
            thread.Start();
        }
    }
}
