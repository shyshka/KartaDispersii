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
        private FrmBaseParams frmBaseParams;

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
                BaseParams baseParams = new BaseParams(openFileDlg.FileName);
                frmBaseParams = new FrmBaseParams(baseParams);
                frmBaseParams.SetActiveTitle += msg => this.Text = Global.msgFrmMainTitle + msg;
                frmBaseParams.FormClosed += (obj, arg) =>
                {
                    frmBaseParams = null;
                    this.Text = Global.msgFrmMainTitle;
                };

                frmBaseParams.MdiParent = this;
                frmBaseParams.ShowBaseParams();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void генерацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generation generation = new Generation(frmBaseParams.BaseParams);            
            FrmGeneration frmGeneration = new FrmGeneration(generation);
            frmGeneration.MdiParent = this;
            frmGeneration.Show();
        }

        private void картаОбобщеннойДисперсииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KartaObDisp kartaObDisp = new KartaObDisp(frmBaseParams.BaseParams);
            FrmKartaObDisp frmKartaObDisp = new FrmKartaObDisp(kartaObDisp);
            frmKartaObDisp.MdiParent = this;
            frmKartaObDisp.ShowParams();
        }
    }
}
