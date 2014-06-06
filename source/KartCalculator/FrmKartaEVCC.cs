using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KartCalculator
{
    public partial class FrmKartaEVCC : Form
    {
        private BaseParams baseParams;
        private KartaEVCC kartaEvcc;

        public FrmKartaEVCC(BaseParams baseParams)
        {
            this.baseParams = baseParams;
            this.kartaEvcc = new KartaEVCC(this.baseParams);            
            InitializeComponent();
        }

        public new void Show()
        {
            base.Show();
        }
    }
}
