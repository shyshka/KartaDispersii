using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using KartCalculator.Calculation;

namespace KartCalculator
{
    public partial class FrmKartaObDisp : Form
    {
        private readonly BaseParams _baseParams;
        private readonly KartaObDisp _kartaObDisp;

        public FrmKartaObDisp(BaseParams baseParams)
        {
            InitializeComponent();
            this._baseParams = baseParams;
            _kartaObDisp = new KartaObDisp(this._baseParams);
        }

        public new void Show()
        {
            //вкладка выборочная ковариационная матрица
            listBoxArrSt.Items.Clear();
            for (var i = 0; i < _kartaObDisp.ArrSt.GetLength(2); i++)
                listBoxArrSt.Items.Add(i + 1);
            listBoxArrSt.SelectedIndex = 0;

            //вкладка обобщенная дисперсия
            Global.ShowArrayInDataGrid(_kartaObDisp.DetArrSt, dataGVDetArrSt);

            //вкладка ковариационная матрица
            Global.ShowArrayInDataGrid(_kartaObDisp.ArrS, dataGVCovarArr);            
            lblDetArrS.Text += "|S|=" +Global.GetString(_kartaObDisp.DetArrS);
            lblDetArrS.Text += "; b1=" + Global.GetString(_kartaObDisp.B1);
            lblDetArrS.Text += "; b2=" + Global.GetString(_kartaObDisp.B2);
            lblDetArrS.Text += "; UCL=" + Global.GetString(_kartaObDisp.Ucl);
            lblDetArrS.Text += "; LCL=" + Global.GetString(_kartaObDisp.Lcl);

            tBoxTextFilePath.Text = Path.Combine(Global.GetPathBaseDir(_baseParams), "Обобщенная дисперсия.txt");
            tBoxImageFilePath.Text = Path.Combine(Global.GetPathBaseDir(_baseParams), "Обобщенная дисперсия.jpg");

            showKarta();
            base.Show();
        }

        private void showKarta()
        {
            chartObDisp.Series[0].Points.Clear();
            chartObDisp.Series[1].Points.Clear();
            chartObDisp.Series[2].Points.Clear();

            for (var i = 0; i < _kartaObDisp.DetArrSt.GetLength(0); i++)
            {
                chartObDisp.Series[0].Points.AddXY(i + 1, _kartaObDisp.Ucl);
                chartObDisp.Series[1].Points.AddXY(i + 1, _kartaObDisp.Lcl);
                chartObDisp.Series[2].Points.AddXY(i + 1, _kartaObDisp.DetArrSt[i]);
            }
        }

        private void listBoxArrSt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.ShowArrayInDataGrid(_kartaObDisp.ArrSt, listBoxArrSt.SelectedIndex, dataGVArrSt);
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            chartObDisp.SaveImage(tBoxImageFilePath.Text,ChartImageFormat.Jpeg);
        }

        private void btnSaveText_Click(object sender, EventArgs e)
        {
            _kartaObDisp.SaveData(tBoxTextFilePath.Text);
        }
    }
}
