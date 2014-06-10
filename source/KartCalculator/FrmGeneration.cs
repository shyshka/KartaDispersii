using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace KartCalculator
{
    public partial class FrmGeneration : Form
    {
        private BaseParams baseParams;

        public FrmGeneration(BaseParams baseParams)
        {
            InitializeComponent();

            this.baseParams = baseParams;
            
            this.tBoxDirGenerNorm.Text =
                Path.GetDirectoryName(Application.ExecutablePath) + Path.DirectorySeparatorChar +
                baseParams.CntParams + "_" +
                baseParams.WeightViborka + "_" +
                baseParams.CntViborka +
                Path.DirectorySeparatorChar +
                "samples" + Path.DirectorySeparatorChar;
            this.tBoxOldDirPath.Text = this.tBoxDirGenerNorm.Text;
        }

        private void changePrBarVal(int val)
        {
            try { this.prBarMain.Value = val; }
            catch { }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            GenerationNorm generNorm = new GenerationNorm(this.baseParams);
            generNorm.ChangePerc += val =>
            {
                if (InvokeRequired)
                    BeginInvoke(new GenerationNorm.IntHandler(changePrBarVal), val);
                else
                    changePrBarVal(val);
            };
            generNorm.ChangeText += val => MessageBox.Show(val);            
            generNorm.CntFiles = Convert.ToInt32(nUpDownCntFilesGenerateNorm.Value);
            generNorm.DirPath = tBoxDirGenerNorm.Text;
            generNorm.Generate();
        }

        private void btnBrowseDir_Click(object sender, EventArgs e)
        {

        }

        private void btnReadOldDir_Click(object sender, EventArgs e)
        {
            GenerationFromExists genEx = new GenerationFromExists(this.tBoxOldDirPath.Text);
            this.lblCntOldFiles.Text = genEx.CntOldFiles.ToString();
            this.lblCntViborka.Text = genEx.CntOldViborka.ToString();
            this.lblCntNewFilesCalc.Text = genEx.CntCalcNewFiles.ToString();
        }

        private void btnGenerM370_Click(object sender, EventArgs e)
        {
            GenerationFromExists genEx = new GenerationFromExists(this.tBoxOldDirPath.Text);
            genEx.ChangePerc += val =>
                {
                    if (InvokeRequired)
                        BeginInvoke(new GenerationNorm.IntHandler(changePrBarVal), val);
                    else
                        changePrBarVal(val);
                };
            genEx.ChangeText += val => MessageBox.Show(val);
            genEx.GenerateNewFiles();
        }
    }
}
