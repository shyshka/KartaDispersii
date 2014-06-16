using System;
using System.IO;
using System.Windows.Forms;
using KartCalculator.Calculation;

namespace KartCalculator
{
    public partial class FrmBaseParams : Form
    {
        public delegate void SendMessage(String msg);
        public SendMessage SetActiveTitle;

        private BaseParams _baseParams;

        public FrmBaseParams(BaseParams baseParams)
        {
            InitializeComponent();
            _baseParams = baseParams;
        }

        public new void Show()
        {
            lblFileName.Text = "Файл: " + Path.GetFileName(_baseParams.FilePath);
            lblCntParams.Text = "К-во параметров: " + _baseParams.CntParams;
            lblWeightViborka.Text = "Обьем выборки: " + _baseParams.WeightViborka;
            lblCntViborka.Text = "К-во выборок: " + _baseParams.CntViborka;

            Global.ShowArrayInDataGrid(_baseParams.InputData, dataGVInput);
            Global.ShowArrayInDataGrid(_baseParams.Correlation, dataGVCorelation);
            Global.ShowArrayInDataGrid(_baseParams.Mosko, dataGVMOSKO);
            dataGVMOSKO.Rows[0].HeaderCell.Value = "MO";
            dataGVMOSKO.Rows[1].HeaderCell.Value = "SKO";
            Global.ShowArrayInDataGrid(_baseParams.Covariation, dataGVCovariation);

            Text = "Базовые характеристики. Файл: " + Path.GetFileName(_baseParams.FilePath);
            SetActiveTitle(Path.GetFileName(_baseParams.FilePath));
            base.Show();
        }        

        private void FrmBaseParams_Activated(object sender, EventArgs e)
        {
            SetActiveTitle(Path.GetFileName(_baseParams.FilePath));
        }
    }
}
