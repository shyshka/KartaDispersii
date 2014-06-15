using System;
using System.Drawing;
using System.Windows.Forms;
using WinWord = Microsoft.Office.Interop.Word;

namespace KartCalculator
{
    public partial class FrmMain : Form
    {
        private BaseParams _baseParams;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new Form
            {
                Size = new Size(350, 150),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false
            };
            
            var lbl = new Label
            {
                Dock = DockStyle.Fill,
                Text = Global.msgTitleApp,
                TextAlign = ContentAlignment.MiddleCenter,
                Parent = frm
            };
            frm.ShowDialog();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmHelp = new FrmHelp();
            frmHelp.Show();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDlg.ShowDialog() != DialogResult.OK) return;
            _baseParams = new BaseParams(openFileDlg.FileName);
            var frmBaseParams = new FrmBaseParams(_baseParams) { MdiParent = this };
            frmBaseParams.SetActiveTitle += msg => Text = string.Format(Global.msgFrmMainTitle, msg);
            frmBaseParams.FormClosed += (obj, arg) =>
            {
                _baseParams = null;
                Text = string.Format(Global.msgFrmMainTitle,string.Empty);
            };

            frmBaseParams.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void генерацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_baseParams == null)
            {
                MessageBox.Show(Global.msgBaseFileError);
                return;
            }
            var frmGeneration = new FrmGeneration(_baseParams) {MdiParent = this};
            frmGeneration.Show();
        }

        private void картаОбобщеннойДисперсииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_baseParams == null)
            {
                MessageBox.Show(Global.msgBaseFileError);
                return;
            }
            var frmKartaObDisp = new FrmKartaObDisp(_baseParams) { MdiParent = this };
            frmKartaObDisp.Show();
        }

        private void картаЭВССДляОбобщеннойДисперсииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_baseParams == null)
            {
                MessageBox.Show(Global.msgBaseFileError);
                return;
            }
            
            var frmKartaEvcc = new FrmKartaEVCC(_baseParams) { MdiParent = this };
            frmKartaEvcc.Show();
        }

        private void моделированиеУвеличенияРассеянияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmTmp = new FrmModelRass(_baseParams);
            frmTmp.Show();
        }
    }
}
