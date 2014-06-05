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

            this.Show();
        }

        private void listBoxArrSt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.ShowArrayInDataGrid(kartaObDisp.ArrSt, listBoxArrSt.SelectedIndex, this.dataGVArrSt);
        }
    }
}
