using System;
using System.IO;
using System.Windows.Forms;
using KartCalculator.Calculation;

namespace KartCalculator
{
    public partial class FrmSDS : Form
    {
        private BaseParams _baseParams;
        private CalcSds _sds;

        public FrmSDS(BaseParams baseParams )
        {
            InitializeComponent();
            _baseParams = baseParams;
            _sds = new CalcSds(_baseParams);
            _sds.ChangePerc += val =>
            {
                if (InvokeRequired) BeginInvoke(new Global.IntHandler(ChangePrBarVal), val);
                else ChangePrBarVal(val);
            };
            _sds.ChangeText += val =>
            {
                if (InvokeRequired) BeginInvoke(new Global.StrHandler(ChangeText), val);
                else ChangeText(val);
            };
        }

        private void btnReadOldDir_Click(object sender, EventArgs e)
        {
            _sds.CalcParams();
            ShowLBoxFiles();
        }

        public new void Show()
        {
            base.Show();
        }

        private void ChangeText(string val)
        {
            MessageBox.Show(val);
            ShowResSds();
        }

        private void ChangePrBarVal(int val)
        {
            try { prBarMain.Value = val; }
            // ReSharper disable once EmptyGeneralCatchClause
            catch (Exception)
            { }
        }

        private void ShowLBoxFiles()
        {
            var d = Convert.ToDouble(nUpDownD.Value);
            var dirName = _sds.GetPathByD(d);
            lBoxFile.Items.Clear();
            foreach (string file in Directory.GetFiles(dirName))
                lBoxFile.Items.Add(Path.GetFileName(file));
            lBoxFile.SelectedIndex = 0;

            listBoxEvcc_SelectedIndexChanged(null, null);
        }

        private void nUpDownD_ValueChanged(object sender, EventArgs e)
        {
            ShowLBoxFiles();
        }

        private void lBoxFile_SelectedIndexChanged(object sender, EventArgs e)
        {
           RefreshChartKS();
        }

        private void RefreshChartKS()
        {
            var d = Convert.ToDouble(nUpDownD.Value);
            var selFile = Path.Combine(_sds.GetPathByD(d), lBoxFile.Text);

            chartKartaKS.Series[0].Points.Clear();
            chartKartaKS.Series[1].Points.Clear();

            var Ct = _sds.CalcCt(selFile);
            var Ckr = _sds.CalcCkr(selFile);

            for (var t = 0; t < Ct.GetLength(0); t++)
            {
                chartKartaKS.Series[0].Points.AddXY(t + 1, Ct[t]);
                chartKartaKS.Series[1].Points.AddXY(t + 1, Ckr[t]);
            }

            Global.ShowArrayInDataGrid(Ct, dataGridViewСt);
            Global.ShowArrayInDataGrid(Ckr, dataGridViewCkr);
        }

        private void ShowResSds()
        {
            Global.ShowArrayInDataGrid(_sds.sdsKartaKS, dataGVSdsKC);
            if (dataGVSdsKC.Rows.Count == 4)
                for (int i = 0; i < 4; i++)
                    dataGVSdsKC.Rows[i].HeaderCell.Value = (1.25 + i * .25).ToString("F");
            Global.ShowArrayInDataGrid(_sds.sdsKartaEvcc, dataGVSdsEvcc);
            if (dataGVSdsEvcc.Rows.Count == 4)
                for (int i = 0; i < 4; i++)
                    dataGVSdsEvcc.Rows[i].HeaderCell.Value = (1.25 + i * .25).ToString("F");

        }

        private void numericUpDownDEvcc_ValueChanged(object sender, EventArgs e)
        {
            var d = Convert.ToDouble(nUpDownD.Value);
            var dirName = _sds.GetPathByD(d);
            listBoxEvcc.Items.Clear();
            foreach (string file in Directory.GetFiles(dirName))
                listBoxEvcc.Items.Add(Path.GetFileName(file));
            listBoxEvcc.SelectedIndex = 0;            
        }

        private void listBoxEvcc_SelectedIndexChanged(object sender, EventArgs e)
        {
            double d = Convert.ToDouble(numericUpDownDEvcc.Value);
            KartaEvcc kartaEvcc = new KartaEvcc(new BaseParams( Path.Combine(_sds.GetPathByD(d), lBoxFile.Text)));
            kartaEvcc.DirPath = _sds.GetPathByD(d);
            kartaEvcc.CalcUclLcl();

            chartKartaEvcc.Series[0].Points.Clear();
            chartKartaEvcc.Series[1].Points.Clear();
            chartKartaEvcc.Series[2].Points.Clear();

            for (var t = 0; t < kartaEvcc.ArrEt.GetLength(0); t++)
            {
                chartKartaEvcc.Series[0].Points.AddXY(t + 1, kartaEvcc.Ucl[t]);
                chartKartaEvcc.Series[1].Points.AddXY(t + 1, kartaEvcc.Lcl[t]);
                chartKartaEvcc.Series[2].Points.AddXY(t + 1, kartaEvcc.ArrEt[t]);
            }

            Global.ShowArrayInDataGrid(kartaEvcc.ArrEt, dataGridViewKartaEvcc);


        }

    }
}
