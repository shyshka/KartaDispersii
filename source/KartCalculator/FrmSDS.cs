using System;
using System.Windows.Forms;
using KartCalculator.Calculation;

namespace KartCalculator
{
    public partial class FrmSDS : Form
    {
        private CalcSds _sds;

        public FrmSDS(BaseParams baseParams )
        {
            InitializeComponent();
            _sds = new CalcSds(baseParams);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _sds.CalcParams();
        }
    }
}
