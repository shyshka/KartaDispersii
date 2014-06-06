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
    public partial class FrmBaseParams : Form
    {
        public delegate void SendMessage(String msg);
        public SendMessage SetActiveTitle;

        private BaseParams baseParams;

        public FrmBaseParams(BaseParams baseParams)
        {
            InitializeComponent();
            this.baseParams = baseParams;
        }

        public new void Show()
        {
            this.lblFileName.Text = "Файл: " + Path.GetFileName(baseParams.FilePath);
            this.lblCntParams.Text = "К-во параметров: " + baseParams.CntParams;
            this.lblWeightViborka.Text = "Обьем выборки: " + baseParams.WeightViborka;
            this.lblCntViborka.Text = "К-во выборок: " + baseParams.CntViborka;

            Global.ShowArrayInDataGrid(baseParams.InputData, this.dataGVInput);
            Global.ShowArrayInDataGrid(baseParams.Correlation, this.dataGVCorelation);
            Global.ShowArrayInDataGrid(baseParams.MOSKO, this.dataGVMOSKO);
            this.dataGVMOSKO.Rows[0].HeaderCell.Value = "MO";
            this.dataGVMOSKO.Rows[1].HeaderCell.Value = "SKO";
            Global.ShowArrayInDataGrid(baseParams.Covariation, this.dataGVCovariation);

            this.Text = "Базовые характеристики. Файл: " + Path.GetFileName(baseParams.FilePath);
            this.SetActiveTitle(Path.GetFileName(baseParams.FilePath));
            base.Show();
        }        

        private void FrmBaseParams_Activated(object sender, EventArgs e)
        {
            this.SetActiveTitle(Path.GetFileName(baseParams.FilePath));
        }
    }
}
