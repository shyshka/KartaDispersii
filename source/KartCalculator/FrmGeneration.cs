using System;
using System.IO;
using System.Windows.Forms;
using KartCalculator.Calculation;

namespace KartCalculator
{
    public partial class FrmGeneration : Form
    {
        private readonly BaseParams _baseParams;
        private GenerationFromExists _genarationFromExist;

        public FrmGeneration(BaseParams baseParams)
        {
            InitializeComponent();
            _baseParams = baseParams;
        }

        public new void Show()
        {
            Text = "Генерация файлов на основе: " + Path.GetFileName(_baseParams.FilePath);
            tBoxDirGenerNorm.Text =
                Path.Combine(
                    Global.GetPathBaseDir(_baseParams),
                    "Generation-Norm");
            tBoxOldDirPath.Text = tBoxDirGenerNorm.Text;
            base.Show();
        }

        private void ChangePrBarVal(int val)
        {
            try
            {
                prBarMain.Value = val;
            }
            catch (Exception exception)
            {
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var generNorm = new GenerationNorm(_baseParams);
            generNorm.ChangePerc += val =>
            {
                if (InvokeRequired)
                    BeginInvoke(new GenerationNorm.IntHandler(ChangePrBarVal), val);
                else
                    ChangePrBarVal(val);
            };
            generNorm.ChangeText += val => MessageBox.Show(val);            
            generNorm.CntFiles = Convert.ToInt32(nUpDownCntFilesGenerateNorm.Value);
            generNorm.DirPath = tBoxDirGenerNorm.Text;
            generNorm.Generate();
        }

        private void btnReadOldDir_Click(object sender, EventArgs e)
        {
            _genarationFromExist = new GenerationFromExists(tBoxOldDirPath.Text);
            _genarationFromExist.ChangePerc += val =>
            {
                if (InvokeRequired)
                    BeginInvoke(new GenerationNorm.IntHandler(ChangePrBarVal), val);
                else
                    ChangePrBarVal(val);
            };
            _genarationFromExist.ChangeText += val => MessageBox.Show(val);
            _genarationFromExist.LoadFiles();
            lblCntOldFiles.Text = _genarationFromExist.CntOldFiles.ToString();
            lblCntViborka.Text = _genarationFromExist.CntOldViborka.ToString();
            lblCntNewFilesCalc.Text = _genarationFromExist.CntCalcNewFiles.ToString();
        }

        private void btnGenerM370_Click(object sender, EventArgs e)
        {
            _genarationFromExist.GenerateNewFiles();
        }
    }
}
