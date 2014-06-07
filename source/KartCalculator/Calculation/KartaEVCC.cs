using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace KartCalculator
{
    public class KartaEVCC
    {
        public delegate void IntHandler(int val);
        public event IntHandler ChangePerc;

        public delegate void StrHandler(string val);
        public event StrHandler ChangeText;

        private BaseParams baseParams;
        private KartaObDisp kartaObDisp;
        private string oldDir;
        private string newDir;
        private List<string> lstOldFiles;
        private List<string> lstNewFiles;
        private int oldCntViborka;
        private int newCntViborka;
        private double[] arrEt;
        private double k = 0.25;
        private double sigmaS;
        private double sigmaEt;
        private double ucl; 
        private double lcl;
        private const int cntViborkaPerFile = 370;

        public string OldDir
        {
            set
            {
                oldDir = value;
                newDir = oldDir + Path.DirectorySeparatorChar + "new" + Path.DirectorySeparatorChar;
                loadOldFiles();
            }
        }
        public string NewDir
        {
            set
            {
                newDir = value;
                loadNewFiles();
            }
        }
        public int OldCntViborka
        {
            get { return oldCntViborka; }
        }
        public int NewCntViborka
        {
            get { return newCntViborka; }
        }        
        public double K
        {
            set { k = value; }
        }
        public double[] ArrEt
        {
            get { return arrEt; }
        }
        public int CntOldFiles
        {
            get
            {
                if (lstOldFiles == null) return 0;
                else return lstOldFiles.Count;
            }
        }
        public int CndNewFiles
        {
            get
            {
                if (lstNewFiles == null) return 0;
                else return lstNewFiles.Count;
            }
        }
        public double Ucl
        {
            get { return ucl; }
        }
        public double Lcl
        {
            get { return lcl; }
        }

        public KartaEVCC(BaseParams baseParams)
        {
            this.baseParams = baseParams;
            this.kartaObDisp = new KartaObDisp(this.baseParams);
            calcParams();   
        }

        private void calcParams()
        {
            calcArrEt();
            calcSigmaS();
            calcSigmaEt();
        }
        private void calcArrEt()
        {
            double[] arrTmp = new double[kartaObDisp.DetArrSt.GetLength(0)];
            arrTmp[0] = kartaObDisp.DetArrS;
            for (int t = 1; t < arrTmp.GetLength(0); t++)
                arrTmp[t] = (1 - k) * arrTmp[t - 1] + k * kartaObDisp.DetArrSt[t];
            this.arrEt = arrTmp;
        }
        private void calcSigmaS()
        {
            this.sigmaS = Math.Sqrt(kartaObDisp.B2) * kartaObDisp.DetArrS;
        }
        private void calcSigmaEt()
        {
            double arrTmp = 0.0;
            arrTmp = sigmaS * k * (1 - Math.Pow(1 - k, 2 * cntViborkaPerFile));
            arrTmp /= baseParams.WeightViborka * (2 - k);
            this.sigmaEt = Math.Sqrt(arrTmp);
        }
        private void loadOldFiles()
        {
            string[] oldFiles = Directory.GetFiles(this.oldDir);
            this.lstOldFiles = new List<string>();
            this.oldCntViborka = 0;
            foreach (string filePath in oldFiles)
                if (BaseParams.IsGoodFile(filePath))
                {
                    lstOldFiles.Add(filePath);
                    BaseParams bp = new BaseParams(filePath);
                    this.oldCntViborka += bp.CntViborka;
                }
        }
        private void loadNewFiles()
        {
            string[] newFiles = Directory.GetFiles(this.newDir);
            this.lstNewFiles = new List<string>();
            this.newCntViborka = 0;
            foreach (string filePath in newFiles)
                if (BaseParams.IsGoodFile(filePath))
                {
                    lstNewFiles.Add(filePath);
                    BaseParams bp = new BaseParams(filePath);
                    this.newCntViborka+= bp.CntViborka;
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
            for (int indNew = 0; indNew < CndNewFiles; indNew++)
            {
                int indexVibWr = 0;
                String filePath = newDir + indNew.ToString() + ".dtk";
                StreamWriter sWr = File.CreateText(filePath);
                sWr.WriteLine(baseParams.CntParams);
                sWr.WriteLine(baseParams.WeightViborka);
                sWr.WriteLine(cntViborkaPerFile);
                while (indexVibWr < cntViborkaPerFile)
                {
                    BaseParams bpCur = new BaseParams(lstOldFiles[indexOldFile]);
                    int curVibRd = 0;
                    while (curVibRd < bpCur.CntViborka)
                    {
                        for (int j = 0; j < bpCur.WeightViborka; j++)
                        {
                            string curLine = string.Empty;
                            curLine += bpCur.InputData[0, curVibRd * bpCur.WeightViborka + j].ToString("0.000");
                            for (int i = 1; i < bpCur.CntParams; i++)
                                curLine += '\t' + bpCur.InputData[i, curVibRd * bpCur.WeightViborka + j].ToString("0.000");
                            sWr.WriteLine(curLine);
                        }
                        curVibRd++;
                        indexVibWr++;
                    }
                    indexOldFile++;
                }
                sWr.Close();
            }

            if (ChangePerc != null) ChangePerc(0);
            if (ChangeText != null) ChangeText(Global.msgGenerationDone);
        }

        public void GenerateNewFiles()
        {
            if (!isReadyGenerate()) return;
            Thread thread = new Thread(new ThreadStart(generate));
            thread.Start();
        }
        public void CalcUclLcl()
        {
            double maxEt = 0.0;
            double minEt = 0.0;
            foreach (string filePath in lstNewFiles)
            {                
                KartaEVCC kartaEvccCur = new KartaEVCC(new BaseParams(filePath));
                for (int t = 0; t < baseParams.CntViborka; t++)
                {
                    if (maxEt < kartaEvccCur.ArrEt[t]) maxEt = kartaEvccCur.ArrEt[t];
                    if (minEt > kartaEvccCur.ArrEt[t] && kartaEvccCur.ArrEt[t] >= 0.0)
                        minEt = kartaEvccCur.ArrEt[t];
                    if (minEt == 0.0) minEt = kartaEvccCur.ArrEt[t];
                }
            }
            this.ucl = kartaObDisp.DetArrSt[0] + maxEt * sigmaEt;
            this.lcl = kartaObDisp.DetArrSt[0] - minEt * sigmaEt;
        }
    }
}
