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
        private Generation generation;

        public FrmGeneration(BaseParams baseParams)
        {
            InitializeComponent();

            this.baseParams = baseParams;
            this.generation = new Generation(this.baseParams);
            this.generation.ChangePerc += val=>
                {
                    if (InvokeRequired) 
                        BeginInvoke(new Generation.IntHandler(changePrBarVal),val);
                    else
                        changePrBarVal(val);
                };
            this.generation.ChangeText += val => MessageBox.Show(val);
            tBoxDir.Text =
                Path.GetDirectoryName(Application.ExecutablePath) + Path.DirectorySeparatorChar +
                generation.BaseParams.CntParams + "_" +
                generation.BaseParams.WeightViborka + "_" +
                generation.BaseParams.CntViborka +
                Path.DirectorySeparatorChar +
                "samples" + Path.DirectorySeparatorChar;
        }

        private void changePrBarVal(int val)
        {
            this.prBarMain.Value = val;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            generation.CntFiles = Convert.ToInt32(nUpDownCntFiles.Value);
            generation.DirPath = tBoxDir.Text;
            generation.Generate();
        }
    }
}
