using System;
using System.IO;
using System.Windows.Forms;
using KartCalculator.Calculation;

namespace KartCalculator
{
    public partial class FrmKartaEVCC : Form
    {
        private readonly BaseParams _baseParams;
        private readonly KartaEvcc _kartaEvcc;

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
            _kartaEvcc.DirPath = tBoxDir.Text;
            lblCntFiles.Text = _kartaEvcc.CntFiles.ToString();
            lblCntViborok.Text = _kartaEvcc.CntViborka.ToString();
        }

        private void btnMakeKarta_Click(object sender, EventArgs e)
        {
            _kartaEvcc.K = Double.Parse(numericUpDownK.Value.ToString());
            _kartaEvcc.HavUser = cBoxUseH.Checked ? Convert.ToDouble(numericUpDownH.Value) : 0.0;
            _kartaEvcc.CalcUclLcl();

            Global.ShowArrayInDataGrid(_kartaEvcc.ArrEt, dataGVDetArrEt);
            Global.ShowArrayInDataGrid(_kartaEvcc.SigmaEt, dataGVDetSigmaEt);
            Global.ShowArrayInDataGrid(_kartaEvcc.Ucl, dataGVDetUCL);
            Global.ShowArrayInDataGrid(_kartaEvcc.Lcl, dataGVDetLCL);

            lblResults.Text = _kartaEvcc.GetResultsString();

            chartKarta.Series[0].Points.Clear();
            chartKarta.Series[1].Points.Clear();
            chartKarta.Series[2].Points.Clear();

            for (var t = 0; t < _kartaEvcc.ArrEt.GetLength(0); t++)
            {
                chartKarta.Series[0].Points.AddXY(t + 1, _kartaEvcc.Ucl[t]);
                chartKarta.Series[1].Points.AddXY(t + 1, _kartaEvcc.Lcl[t]);
                chartKarta.Series[2].Points.AddXY(t + 1, _kartaEvcc.ArrEt[t]);
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
