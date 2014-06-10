using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KartCalculator
{
    public partial class FrmMain : Form
    {
        private BaseParams baseParams;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Global.msgNotWorking);
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            MessageBox.Show(Global.msgNotWorking);
            //считывать с файла help.txt
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                baseParams = new BaseParams(openFileDlg.FileName);
                FrmBaseParams frmBaseParams = new FrmBaseParams(baseParams) { MdiParent = this };
                frmBaseParams.SetActiveTitle += msg => this.Text = Global.msgFrmMainTitle + msg;
                frmBaseParams.FormClosed += (obj, arg) =>
                {
                    frmBaseParams = null;
                    this.Text = Global.msgFrmMainTitle;
                };

                frmBaseParams.Show();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void генерацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.baseParams == null)
            {
                MessageBox.Show(Global.msgBaseFileError);
                return;
            }
            FrmGeneration frmGeneration = new FrmGeneration(this.baseParams) { MdiParent = this };
            frmGeneration.Show();
        }

        private void картаОбобщеннойДисперсииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.baseParams == null)
            {
                MessageBox.Show(Global.msgBaseFileError);
                return;
            }
            FrmKartaObDisp frmKartaObDisp = new FrmKartaObDisp(this.baseParams) { MdiParent = this };
            frmKartaObDisp.Show();
        }

        private void картаЭВССДляОбобщеннойДисперсииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.baseParams == null)
            {
                MessageBox.Show(Global.msgBaseFileError);
                return;
            }
            
            FrmKartaEVCC frmKartaEvcc = new FrmKartaEVCC(this.baseParams) { MdiParent = this };
            frmKartaEvcc.Show();
        }

        private void моделированиеУвеличенияРассеянияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModelRass frmTmp = new FrmModelRass(baseParams);
            frmTmp.Show();
        }
    }
}
