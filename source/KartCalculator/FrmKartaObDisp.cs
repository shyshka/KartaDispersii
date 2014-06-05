using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KartCalculator
{
    public partial class FrmKartaObDisp : Form
    {
        private KartaObDisp kartaObDisp;

        public FrmKartaObDisp(KartaObDisp kartaObDisp)
        {
            InitializeComponent();
            this.kartaObDisp = kartaObDisp;
        }

        public void ShowParams()
        {
            //вкладка выборочная ковариационная матрица
            listBoxArrSt.Items.Clear();
            for (int i = 0; i < kartaObDisp.ArrSt.GetLength(2); i++)
                listBoxArrSt.Items.Add(i + 1);
            listBoxArrSt.SelectedIndex = 0;

            //вкладка обобщенная дисперсия
            Global.ShowArrayInDataGrid(kartaObDisp.DetArrSt, this.dataGVDetArrSt);

            //вкладка ковариационная матрица
            Global.ShowArrayInDataGrid(kartaObDisp.ArrS, this.dataGVCovarArr);
            lblDetArrS.Text = Global.msgDeterminant;
            this.lblDetArrS.Text += Global.GetString(kartaObDisp.DetArrS);
            this.lblDetArrS.Text += "; b1=" + Global.GetString(kartaObDisp.B1);
            this.lblDetArrS.Text += "; b2=" + Global.GetString(kartaObDisp.B2);
            this.lblDetArrS.Text += "; UCL=" + Global.GetString(kartaObDisp.Ucl);
            this.lblDetArrS.Text += "; LCL=" + Global.GetString(kartaObDisp.Lcl);

            this.showKarta();
            this.Show();
        }

        private void showKarta()
        {
            this.chartObDisp.Series[0].Points.Clear();
            this.chartObDisp.Series[1].Points.Clear();
            this.chartObDisp.Series[2].Points.Clear();

            for (int i = 0; i < kartaObDisp.DetArrSt.GetLength(0); i++)
            {
                this.chartObDisp.Series[0].Points.AddXY(i + 1, kartaObDisp.Ucl);
                this.chartObDisp.Series[1].Points.AddXY(i + 1, kartaObDisp.Lcl);
                this.chartObDisp.Series[2].Points.AddXY(i + 1, kartaObDisp.DetArrSt[i]);
            }
        }

        private void listBoxArrSt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.ShowArrayInDataGrid(kartaObDisp.ArrSt, listBoxArrSt.SelectedIndex, this.dataGVArrSt);
        }
    }
}
