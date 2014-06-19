using System;
using System.IO;
using System.Windows.Forms;

namespace KartCalculator
{
    public partial class FrmHelp : Form
    {
        private const string FileHelpPath = "Help.html";

        public FrmHelp()
        {
            InitializeComponent();
            webBrowser.Url = new Uri(Path.Combine(
                Path.GetDirectoryName(Application.ExecutablePath), 
                "Help",
                FileHelpPath));
        }
    }
}
