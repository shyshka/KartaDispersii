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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.prBarMain = new System.Windows.Forms.ToolStripProgressBar();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCntNewFilesCalc = new System.Windows.Forms.Label();
            this.lblCntViborka = new System.Windows.Forms.Label();
            this.lblCntOldFiles = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGenerM370 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReadOldDir = new System.Windows.Forms.Button();
            this.btnSelectOldDirPath = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tBoxOldDirPath = new System.Windows.Forms.TextBox();
            this.tabPageButstrep = new System.Windows.Forms.TabPage();
            this.btnGenerateNorm = new System.Windows.Forms.Button();
            this.nUpDownCntFilesGenerateNorm = new System.Windows.Forms.NumericUpDown();
            this.btnBrowseDirGenerateNorm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxDirGenerNorm = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.statusStrip.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPageButstrep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownCntFilesGenerateNorm)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prBarMain});
            this.statusStrip.Location = new System.Drawing.Point(0, 239);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(434, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // prBarMain
            // 
            this.prBarMain.AutoSize = false;
            this.prBarMain.Name = "prBarMain";
            this.prBarMain.Size = new System.Drawing.Size(400, 16);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblCntNewFilesCalc);
            this.tabPage1.Controls.Add(this.lblCntViborka);
            this.tabPage1.Controls.Add(this.lblCntOldFiles);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnGenerM370);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnReadOldDir);
            this.tabPage1.Controls.Add(this.btnSelectOldDirPath);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.tBoxOldDirPath);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(426, 235);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Формирование m=370";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblCntNewFilesCalc
            // 
            this.lblCntNewFilesCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCntNewFilesCalc.Location = new System.Drawing.Point(244, 147);
            this.lblCntNewFilesCalc.Name = "lblCntNewFilesCalc";
            this.lblCntNewFilesCalc.Size = new System.Drawing.Size(52, 13);
            this.lblCntNewFilesCalc.TabIndex = 21;
            // 
            // lblCntViborka
            // 
            this.lblCntViborka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCntViborka.Location = new System.Drawing.Point(244, 114);
            this.lblCntViborka.Name = "lblCntViborka";
            this.lblCntViborka.Size = new System.Drawing.Size(52, 13);
            this.lblCntViborka.TabIndex = 22;
            // 
            // lblCntOldFiles
            // 
            this.lblCntOldFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCntOldFiles.Location = new System.Drawing.Point(244, 81);
            this.lblCntOldFiles.Name = "lblCntOldFiles";
            this.lblCntOldFiles.Size = new System.Drawing.Size(52, 13);
            this.lblCntOldFiles.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Новых файлов:";
            // 
            // btnGenerM370
            // 
            this.btnGenerM370.Location = new System.Drawing.Point(102, 176);
            this.btnGenerM370.Name = "btnGenerM370";
            this.btnGenerM370.Size = new System.Drawing.Size(225, 29);
            this.btnGenerM370.TabIndex = 13;
            this.btnGenerM370.Text = "Создать новые";
            this.btnGenerM370.UseVisualStyleBackColor = true;
            this.btnGenerM370.Click += new System.EventHandler(this.btnGenerM370_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Сумма выборок:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Файлов обработано:";
            // 
            // btnReadOldDir
            // 
            this.btnReadOldDir.Location = new System.Drawing.Point(99, 39);
            this.btnReadOldDir.Name = "btnReadOldDir";
            this.btnReadOldDir.Size = new System.Drawing.Size(225, 28);
            this.btnReadOldDir.TabIndex = 17;
            this.btnReadOldDir.Text = "Cчитать данные";
            this.btnReadOldDir.UseVisualStyleBackColor = true;
            this.btnReadOldDir.Click += new System.EventHandler(this.btnReadOldDir_Click);
            // 
            // btnSelectOldDirPath
            // 
            this.btnSelectOldDirPath.Location = new System.Drawing.Point(299, 13);
            this.btnSelectOldDirPath.Name = "btnSelectOldDirPath";
            this.btnSelectOldDirPath.Size = new System.Drawing.Size(25, 20);
            this.btnSelectOldDirPath.TabIndex = 16;
            this.btnSelectOldDirPath.Text = "...";
            this.btnSelectOldDirPath.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(99, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Каталог";
            // 
            // tBoxOldDirPath
            // 
            this.tBoxOldDirPath.Location = new System.Drawing.Point(153, 13);
            this.tBoxOldDirPath.Name = "tBoxOldDirPath";
            this.tBoxOldDirPath.Size = new System.Drawing.Size(143, 20);
            this.tBoxOldDirPath.TabIndex = 14;
            // 
            // tabPageButstrep
            // 
            this.tabPageButstrep.Controls.Add(this.btnGenerateNorm);
            this.tabPageButstrep.Controls.Add(this.nUpDownCntFilesGenerateNorm);
            this.tabPageButstrep.Controls.Add(this.btnBrowseDirGenerateNorm);
            this.tabPageButstrep.Controls.Add(this.label2);
            this.tabPageButstrep.Controls.Add(this.label1);
            this.tabPageButstrep.Controls.Add(this.tBoxDirGenerNorm);
            this.tabPageButstrep.Location = new System.Drawing.Point(4, 22);
            this.tabPageButstrep.Name = "tabPageButstrep";
            this.tabPageButstrep.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageButstrep.Size = new System.Drawing.Size(426, 235);
            this.tabPageButstrep.TabIndex = 0;
            this.tabPageButstrep.Text = "Многомерное нормальное распределение";
            this.tabPageButstrep.UseVisualStyleBackColor = true;
            // 
            // btnGenerateNorm
            // 
            this.btnGenerateNorm.Location = new System.Drawing.Point(218, 90);
            this.btnGenerateNorm.Name = "btnGenerateNorm";
            this.btnGenerateNorm.Size = new System.Drawing.Size(160, 30);
            this.btnGenerateNorm.TabIndex = 4;
            this.btnGenerateNorm.Text = "Сгенерировать файлы";
            this.btnGenerateNorm.UseVisualStyleBackColor = true;
            this.btnGenerateNorm.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // nUpDownCntFilesGenerateNorm
            // 
            this.nUpDownCntFilesGenerateNorm.Location = new System.Drawing.Point(90, 97);
            this.nUpDownCntFilesGenerateNorm.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUpDownCntFilesGenerateNorm.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUpDownCntFilesGenerateNorm.Name = "nUpDownCntFilesGenerateNorm";
            this.nUpDownCntFilesGenerateNorm.Size = new System.Drawing.Size(109, 20);
            this.nUpDownCntFilesGenerateNorm.TabIndex = 3;
            this.nUpDownCntFilesGenerateNorm.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // btnBrowseDirGenerateNorm
            // 
            this.btnBrowseDirGenerateNorm.Location = new System.Drawing.Point(353, 32);
            this.btnBrowseDirGenerateNorm.Name = "btnBrowseDirGenerateNorm";
            this.btnBrowseDirGenerateNorm.Size = new System.Drawing.Size(25, 20);
            this.btnBrowseDirGenerateNorm.TabIndex = 2;
            this.btnBrowseDirGenerateNorm.Text = "...";
            this.btnBrowseDirGenerateNorm.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 99);
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
            // tBoxDirGenerNorm
            // 
            this.tBoxDirGenerNorm.Location = new System.Drawing.Point(90, 33);
            this.tBoxDirGenerNorm.Name = "tBoxDirGenerNorm";
            this.tBoxDirGenerNorm.Size = new System.Drawing.Size(257, 20);
            this.tBoxDirGenerNorm.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageButstrep);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(434, 261);
            this.tabControl.TabIndex = 0;
            // 
            // FrmGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmGeneration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генерация";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPageButstrep.ResumeLayout(false);
            this.tabPageButstrep.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownCntFilesGenerateNorm)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrDlg;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar prBarMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPageButstrep;
        private System.Windows.Forms.Button btnGenerateNorm;
        private System.Windows.Forms.NumericUpDown nUpDownCntFilesGenerateNorm;
        private System.Windows.Forms.Button btnBrowseDirGenerateNorm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxDirGenerNorm;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label lblCntNewFilesCalc;
        private System.Windows.Forms.Label lblCntViborka;
        private System.Windows.Forms.Label lblCntOldFiles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGenerM370;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReadOldDir;
        private System.Windows.Forms.Button btnSelectOldDirPath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBoxOldDirPath;
    }
}