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
    public partial class FrmModelRass : Form
    {
        private BaseParams baseParams;

        public FrmModelRass(BaseParams baseParams )
        {
            this.baseParams = baseParams;
            InitializeComponent();

            this.tBoxOldDirPath.Text =
               Path.GetDirectoryName(Application.ExecutablePath) + Path.DirectorySeparatorChar +
               baseParams.CntParams + "_" +
               baseParams.WeightViborka + "_" +
               baseParams.CntViborka +
               Path.DirectorySeparatorChar +
               "samples" + Path.DirectorySeparatorChar;
        }

        private void btnReadOldDir_Click(object sender, EventArgs e)
        {
            GenerationRass gen = new GenerationRass(tBoxOldDirPath.Text);
            lblCntOldFiles.Text = gen.CntOldFiles.ToString();
            lblCntViborka.Text = gen.CntOldViborka.ToString();            
        }

        private void changePrBarVal(int val)
        {
            try { this.prBarMain.Value = val; }
            catch { }
        }

        private void btnGener_Click(object sender, EventArgs e)
        {
            GenerationRass gen = new GenerationRass(tBoxOldDirPath.Text);
            gen.ChangePerc += val =>
            {
                if (this.InvokeRequired) this.BeginInvoke(new GenerationRass.IntHandler(changePrBarVal), val);
                else changePrBarVal(val);
            };
            gen.ChangeText += val => MessageBox.Show(val);

            gen.GenerateNewFiles();
        }
    }
}
