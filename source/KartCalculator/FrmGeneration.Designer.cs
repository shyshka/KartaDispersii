namespace KartCalculator
{
    partial class FrmGeneration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageButstrep = new System.Windows.Forms.TabPage();
            this.btnCreate = new System.Windows.Forms.Button();
            this.nUpDownCntFiles = new System.Windows.Forms.NumericUpDown();
            this.btnBrowseDir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxDir = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.prBarMain = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControl.SuspendLayout();
            this.tabPageButstrep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownCntFiles)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageButstrep);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(384, 161);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageButstrep
            // 
            this.tabPageButstrep.Controls.Add(this.btnCreate);
            this.tabPageButstrep.Controls.Add(this.nUpDownCntFiles);
            this.tabPageButstrep.Controls.Add(this.btnBrowseDir);
            this.tabPageButstrep.Controls.Add(this.label2);
            this.tabPageButstrep.Controls.Add(this.label1);
            this.tabPageButstrep.Controls.Add(this.tBoxDir);
            this.tabPageButstrep.Location = new System.Drawing.Point(4, 22);
            this.tabPageButstrep.Name = "tabPageButstrep";
            this.tabPageButstrep.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageButstrep.Size = new System.Drawing.Size(376, 135);
            this.tabPageButstrep.TabIndex = 0;
            this.tabPageButstrep.Text = "Многомерное нормальное распределение";
            this.tabPageButstrep.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(259, 69);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Создать";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // nUpDownCntFiles
            // 
            this.nUpDownCntFiles.Location = new System.Drawing.Point(90, 69);
            this.nUpDownCntFiles.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUpDownCntFiles.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUpDownCntFiles.Name = "nUpDownCntFiles";
            this.nUpDownCntFiles.Size = new System.Drawing.Size(55, 20);
            this.nUpDownCntFiles.TabIndex = 3;
            this.nUpDownCntFiles.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // btnBrowseDir
            // 
            this.btnBrowseDir.Location = new System.Drawing.Point(309, 33);
            this.btnBrowseDir.Name = "btnBrowseDir";
            this.btnBrowseDir.Size = new System.Drawing.Size(25, 20);
            this.btnBrowseDir.TabIndex = 2;
            this.btnBrowseDir.Text = "...";
            this.btnBrowseDir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Файлов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Каталог";
            // 
            // tBoxDir
            // 
            this.tBoxDir.Location = new System.Drawing.Point(90, 33);
            this.tBoxDir.Name = "tBoxDir";
            this.tBoxDir.Size = new System.Drawing.Size(213, 20);
            this.tBoxDir.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prBarMain});
            this.statusStrip.Location = new System.Drawing.Point(0, 139);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(384, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // prBarMain
            // 
            this.prBarMain.AutoSize = false;
            this.prBarMain.Name = "prBarMain";
            this.prBarMain.Size = new System.Drawing.Size(350, 16);
            // 
            // FrmGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmGeneration";
            this.Text = "Генерация";
            this.tabControl.ResumeLayout(false);
            this.tabPageButstrep.ResumeLayout(false);
            this.tabPageButstrep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownCntFiles)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrDlg;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageButstrep;
        private System.Windows.Forms.Button btnBrowseDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUpDownCntFiles;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar prBarMain;
    }
}