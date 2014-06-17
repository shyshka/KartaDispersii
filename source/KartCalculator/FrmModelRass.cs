using System;
using System.IO;
using System.Windows.Forms;
using KartCalculator.Calculation;

namespace KartCalculator
{
    public partial class FrmModelRass : Form
    {
        private readonly BaseParams _baseParams;

        public FrmModelRass(BaseParams baseParams )
        {
            _baseParams = baseParams;
            InitializeComponent();
        }

        public new void Show()
        {
            tBoxOldDirPath.Text = Path.Combine(Global.GetPathBaseDir(_baseParams), "Generation-M370");
            base.Show();
        }

        private void btnReadOldDir_Click(object sender, EventArgs e)
        {
            var gen = new GenerationRass(tBoxOldDirPath.Text);
            // ReSharper disable once SpecifyACultureInStringConversionExplicitly
            lblCntOldFiles.Text = gen.CntOldFiles.ToString();
            // ReSharper disable once SpecifyACultureInStringConversionExplicitly
            lblCntViborka.Text = gen.CntOldViborka.ToString();            
        }

        private void ChangePrBarVal(int val)
        {
            try { prBarMain.Value = val; }
// ReSharper disable once EmptyGeneralCatchClause
            catch (Exception)
            { }
        }

        private void btnGener_Click(object sender, EventArgs e)
        {
            var gen = new GenerationRass(tBoxOldDirPath.Text);
            gen.ChangePerc += val =>
            {
                if (InvokeRequired) BeginInvoke(new GenerationRass.IntHandler(ChangePrBarVal), val);
                else ChangePrBarVal(val);
            };
            gen.ChangeText += val => MessageBox.Show(val);

            gen.GenerateNewFiles();
        }
    }
}
