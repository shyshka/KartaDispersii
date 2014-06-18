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
            _sds.ChangeText += val => MessageBox.Show(val);
        }

        private void btnReadOldDir_Click(object sender, EventArgs e)
        {
            _sds.CalcParams(tBoxOldDirPath.Text);
            ShowLBoxFiles();
        }

        public new void Show()
        {
            tBoxOldDirPath.Text = Path.Combine(Global.GetPathBaseDir(_baseParams), "Generation-Norm");
            base.Show();
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
        }

        private void nUpDownD_ValueChanged(object sender, EventArgs e)
        {
            ShowLBoxFiles();
        }

        private void lBoxFile_SelectedIndexChanged(object sender, EventArgs e)
        {
           RefreshChart();
        }

        private void RefreshChart()
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

            Global.ShowArrayInDataGrid(_sds.ArrSds, dataGVDetArrSDS);
            if (dataGVDetArrSDS.Rows.Count == 4)
                for (int i = 0; i <4; i++)
                    dataGVDetArrSDS.Rows[i].HeaderCell.Value = (1.25 + i * .25).ToString("F");
        }
    }
}
