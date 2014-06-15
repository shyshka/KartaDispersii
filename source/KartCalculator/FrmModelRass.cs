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

           
        }

        public new void Show()
        {
            tBoxOldDirPath.Text = Path.Combine(Global.GetPathBaseDir(baseParams), "Generation-M370");
            base.Show();
        }

        private void btnReadOldDir_Click(object sender, EventArgs e)
        {
            var gen = new GenerationRass(tBoxOldDirPath.Text);
            lblCntOldFiles.Text = gen.CntOldFiles.ToString();
            lblCntViborka.Text = gen.CntOldViborka.ToString();            
        }

        private void changePrBarVal(int val)
        {
            try { prBarMain.Value = val; }
            catch { }
        }

        private void btnGener_Click(object sender, EventArgs e)
        {
            var gen = new GenerationRass(tBoxOldDirPath.Text);
            gen.ChangePerc += val =>
            {
                if (InvokeRequired) BeginInvoke(new GenerationRass.IntHandler(changePrBarVal), val);
                else changePrBarVal(val);
            };
            gen.ChangeText += val => MessageBox.Show(val);

            gen.GenerateNewFiles();
        }
    }
}
