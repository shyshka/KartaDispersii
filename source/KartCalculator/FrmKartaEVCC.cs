using System;
using System.IO;
using System.Windows.Forms;
using KartCalculator.Calculation;

namespace KartCalculator
{
    public partial class FrmKartaEVCC : Form
    {
        private readonly BaseParams _baseParams;
        private KartaEvcc _kartaEvcc;

        public FrmKartaEVCC(BaseParams baseParams)
        {
            _baseParams = baseParams;
            _kartaEvcc = new KartaEvcc(_baseParams);

            _kartaEvcc = new KartaEvcc(_baseParams);
            _kartaEvcc.ChangePerc += val =>
                {
                    if (InvokeRequired)
                        BeginInvoke(new Global.IntHandler(ChangePrBarVal), val);
                    else
                        ChangePrBarVal(val);
                };
            _kartaEvcc.ChangeText += val => MessageBox.Show(val); 

            InitializeComponent();
        }

        public new void Show()
        {
            tBoxDir.Text = Path.Combine(Global.GetPathBaseDir(_baseParams), "Generation-M370");
            base.Show();
        }

        private void btnReadFiles_Click(object sender, EventArgs e)
        {
            Global.KartaEvcc.DirPath = tBoxDir.Text;
            lblCntFiles.Text = Global.KartaEvcc.CntFiles.ToString();
            lblCntViborok.Text = Global.KartaEvcc.CntViborka.ToString();
        }

        private void btnMakeKarta_Click(object sender, EventArgs e)
        {
            Global.KartaEvcc.K = Double.Parse(numericUpDownK.Value.ToString());
            Global.KartaEvcc.HavUser = cBoxUseH.Checked ? double.Parse(numericUpDownH.Value.ToString()) : 0.0;
            Global.KartaEvcc.CalcUclLcl();

            Global.ShowArrayInDataGrid(Global.KartaEvcc.ArrEt, dataGVDetArrEt);
            Global.ShowArrayInDataGrid(Global.KartaEvcc.SigmaEt, dataGVDetSigmaEt);
            Global.ShowArrayInDataGrid(Global.KartaEvcc.Ucl, dataGVDetUCL);
            Global.ShowArrayInDataGrid(Global.KartaEvcc.Lcl, dataGVDetLCL);

            lblResults.Text = Global.KartaEvcc.GetResultsString();

            chartKarta.Series[0].Points.Clear();
            chartKarta.Series[1].Points.Clear();
            chartKarta.Series[2].Points.Clear();

            for (var t = 0; t < Global.KartaEvcc.ArrEt.GetLength(0); t++)
            {
                chartKarta.Series[0].Points.AddXY(t + 1, Global.KartaEvcc.Ucl[t]);
                chartKarta.Series[1].Points.AddXY(t + 1, Global.KartaEvcc.Lcl[t]);
                chartKarta.Series[2].Points.AddXY(t + 1, Global.KartaEvcc.ArrEt[t]);
            }
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
    }
}
