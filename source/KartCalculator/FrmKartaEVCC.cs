using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KartCalculator
{
    public partial class FrmKartaEVCC : Form
    {
        private BaseParams baseParams;
        private KartaEVCC kartaEvcc;

        public FrmKartaEVCC(BaseParams baseParams)
        {
            this.baseParams = baseParams;
            this.kartaEvcc = new KartaEVCC(this.baseParams);
            InitializeComponent();

            tBoxDir.Text =
               Path.GetDirectoryName(Application.ExecutablePath) + Path.DirectorySeparatorChar +
               baseParams.CntParams + "_" +
               baseParams.WeightViborka + "_" +
               baseParams.CntViborka +
               Path.DirectorySeparatorChar +
               "samples" + Path.DirectorySeparatorChar +
               "new" + Path.DirectorySeparatorChar;
        }

        public new void Show()
        {
            base.Show();
        }

        private void btnReadFiles_Click(object sender, EventArgs e)
        {
            kartaEvcc.DirPath = this.tBoxDir.Text;
            this.lblCntFiles.Text = kartaEvcc.CntFiles.ToString();
            this.lblCntViborok.Text = kartaEvcc.CntViborka.ToString();
        }

        private void btnMakeKarta_Click(object sender, EventArgs e)
        {
            kartaEvcc.K = Double.Parse(this.numericUpDown1.Value.ToString());
            kartaEvcc.CalcUclLcl();
            this.lblH.Text = "Усредненное значение H=" + Global.GetString(kartaEvcc.HAv);
            chartKarta.Series[0].Points.Clear();
            chartKarta.Series[1].Points.Clear();
            chartKarta.Series[2].Points.Clear();

            chartKarta.Series[2].IsValueShownAsLabel = true;

            for (int t = 0; t < kartaEvcc.ArrEt.GetLength(0); t++)
            {
                chartKarta.Series[0].Points.AddXY(t + 1, kartaEvcc.Ucl[t]);
                chartKarta.Series[1].Points.AddXY(t + 1, kartaEvcc.Lcl[t]);
                chartKarta.Series[2].Points.AddXY(t + 1, kartaEvcc.ArrEt[t]);
            }
        }
    }
}
