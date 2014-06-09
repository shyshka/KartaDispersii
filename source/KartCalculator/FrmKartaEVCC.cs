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

            tBoxOldDir.Text =
               Path.GetDirectoryName(Application.ExecutablePath) + Path.DirectorySeparatorChar +
               baseParams.CntParams + "_" +
               baseParams.WeightViborka + "_" +
               baseParams.CntViborka +
               Path.DirectorySeparatorChar +
               "samples" + Path.DirectorySeparatorChar;
            tBoxNewDir.Text = 
                tBoxOldDir.Text + "new" + Path.DirectorySeparatorChar;
        }

        public new void Show()
        {
            base.Show();
        }

        private void btnReadOldFiles_Click(object sender, EventArgs e)
        {
            kartaEvcc.OldDir = this.tBoxOldDir.Text;
            this.lblTotalOldFiles.Text = kartaEvcc.CntOldFiles.ToString();
            this.lblTotalCntViborkaOldFiles.Text = kartaEvcc.OldCntViborka.ToString();
            this.lblCntNewFilesCalc.Text = kartaEvcc.CntCalcNewFiles.ToString();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            kartaEvcc.GenerateNewFiles();
        }

        private void btnReadNewFiles_Click(object sender, EventArgs e)
        {
            kartaEvcc.NewDir = this.tBoxNewDir.Text;
            this.lblCntNewFiles.Text = kartaEvcc.CntNewFiles.ToString();
            this.lblNewViborok.Text = kartaEvcc.NewCntViborka.ToString();
        }

        private void btnMakeKarta_Click(object sender, EventArgs e)
        {
            kartaEvcc.CalcH();
            this.lblH.Text = "Усредненное значение H=" + Global.GetString(kartaEvcc.HAv);
            chartKarta.Series[0].Points.Clear();
            chartKarta.Series[1].Points.Clear();
            chartKarta.Series[2].Points.Clear();

            for (int t = 0; t < kartaEvcc.ArrEt.GetLength(0); t++)
            {
                //chartKarta.Series[0].Points.AddXY(t + 1, kartaEvcc.Ucl);
                //chartKarta.Series[1].Points.AddXY(t + 1, kartaEvcc.Lcl);
                chartKarta.Series[2].Points.AddXY(t + 1, kartaEvcc.ArrEt[t]);
            }
        }
    }
}
