namespace KartCalculator
{
    partial class FrmModelRass
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
            this.lblCntViborka = new System.Windows.Forms.Label();
            this.lblCntOldFiles = new System.Windows.Forms.Label();
            this.btnGener = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReadOldDir = new System.Windows.Forms.Button();
            this.btnSelectOldDirPath = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tBoxOldDirPath = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.prBarMain = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCntViborka
            // 
            this.lblCntViborka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCntViborka.Location = new System.Drawing.Point(252, 148);
            this.lblCntViborka.Name = "lblCntViborka";
            this.lblCntViborka.Size = new System.Drawing.Size(52, 13);
            this.lblCntViborka.TabIndex = 33;
            // 
            // lblCntOldFiles
            // 
            this.lblCntOldFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCntOldFiles.Location = new System.Drawing.Point(252, 115);
            this.lblCntOldFiles.Name = "lblCntOldFiles";
            this.lblCntOldFiles.Size = new System.Drawing.Size(52, 13);
            this.lblCntOldFiles.TabIndex = 34;
            // 
            // btnGener
            // 
            this.btnGener.Location = new System.Drawing.Point(110, 193);
            this.btnGener.Name = "btnGener";
            this.btnGener.Size = new System.Drawing.Size(225, 29);
            this.btnGener.TabIndex = 24;
            this.btnGener.Text = "Создать новые";
            this.btnGener.UseVisualStyleBackColor = true;
            this.btnGener.Click += new System.EventHandler(this.btnGener_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Всего выборок:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(133, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Файлов обработано:";
            // 
            // btnReadOldDir
            // 
            this.btnReadOldDir.Location = new System.Drawing.Point(107, 56);
            this.btnReadOldDir.Name = "btnReadOldDir";
            this.btnReadOldDir.Size = new System.Drawing.Size(225, 28);
            this.btnReadOldDir.TabIndex = 28;
            this.btnReadOldDir.Text = "Cчитать данные";
            this.btnReadOldDir.UseVisualStyleBackColor = true;
            this.btnReadOldDir.Click += new System.EventHandler(this.btnReadOldDir_Click);
            // 
            // btnSelectOldDirPath
            // 
            this.btnSelectOldDirPath.Location = new System.Drawing.Point(307, 30);
            this.btnSelectOldDirPath.Name = "btnSelectOldDirPath";
            this.btnSelectOldDirPath.Size = new System.Drawing.Size(25, 20);
            this.btnSelectOldDirPath.TabIndex = 27;
            this.btnSelectOldDirPath.Text = "...";
            this.btnSelectOldDirPath.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(107, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Каталог";
            // 
            // tBoxOldDirPath
            // 
            this.tBoxOldDirPath.Location = new System.Drawing.Point(161, 30);
            this.tBoxOldDirPath.Name = "tBoxOldDirPath";
            this.tBoxOldDirPath.Size = new System.Drawing.Size(143, 20);
            this.tBoxOldDirPath.TabIndex = 25;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prBarMain});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(434, 22);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // prBarMain
            // 
            this.prBarMain.Name = "prBarMain";
            this.prBarMain.Size = new System.Drawing.Size(400, 16);
            // 
            // FrmModelRass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblCntViborka);
            this.Controls.Add(this.lblCntOldFiles);
            this.Controls.Add(this.btnGener);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnReadOldDir);
            this.Controls.Add(this.btnSelectOldDirPath);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tBoxOldDirPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmModelRass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Моделирование увеличения рассеяния";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCntViborka;
        private System.Windows.Forms.Label lblCntOldFiles;
        private System.Windows.Forms.Button btnGener;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReadOldDir;
        private System.Windows.Forms.Button btnSelectOldDirPath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBoxOldDirPath;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar prBarMain;
    }
}