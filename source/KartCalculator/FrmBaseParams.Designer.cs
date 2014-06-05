namespace KartCalculator
{
    partial class FrmBaseParams
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCntParams = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblWeightViborka = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCntViborka = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageInput = new System.Windows.Forms.TabPage();
            this.dataGVInput = new System.Windows.Forms.DataGridView();
            this.dataGVMOSKO = new System.Windows.Forms.DataGridView();
            this.tabPageCorrelation = new System.Windows.Forms.TabPage();
            this.dataGVCorelation = new System.Windows.Forms.DataGridView();
            this.tabPageCovarioation = new System.Windows.Forms.TabPage();
            this.dataGVCovariation = new System.Windows.Forms.DataGridView();
            this.statusStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVMOSKO)).BeginInit();
            this.tabPageCorrelation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCorelation)).BeginInit();
            this.tabPageCovarioation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCovariation)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFileName,
            this.lblCntParams,
            this.lblWeightViborka,
            this.lblCntViborka});
            this.statusStrip.Location = new System.Drawing.Point(0, 389);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(734, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = false;
            this.lblFileName.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(200, 17);
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCntParams
            // 
            this.lblCntParams.AutoSize = false;
            this.lblCntParams.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblCntParams.Name = "lblCntParams";
            this.lblCntParams.Size = new System.Drawing.Size(130, 17);
            this.lblCntParams.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWeightViborka
            // 
            this.lblWeightViborka.AutoSize = false;
            this.lblWeightViborka.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblWeightViborka.Name = "lblWeightViborka";
            this.lblWeightViborka.Size = new System.Drawing.Size(118, 17);
            this.lblWeightViborka.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCntViborka
            // 
            this.lblCntViborka.AutoSize = false;
            this.lblCntViborka.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblCntViborka.Name = "lblCntViborka";
            this.lblCntViborka.Size = new System.Drawing.Size(118, 17);
            this.lblCntViborka.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabPageInput);
            this.tabControl.Controls.Add(this.tabPageCorrelation);
            this.tabControl.Controls.Add(this.tabPageCovarioation);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(734, 389);
            this.tabControl.TabIndex = 1;
            // 
            // tabPageInput
            // 
            this.tabPageInput.Controls.Add(this.dataGVInput);
            this.tabPageInput.Controls.Add(this.dataGVMOSKO);
            this.tabPageInput.Location = new System.Drawing.Point(4, 25);
            this.tabPageInput.Name = "tabPageInput";
            this.tabPageInput.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInput.Size = new System.Drawing.Size(726, 360);
            this.tabPageInput.TabIndex = 0;
            this.tabPageInput.Text = "Входные данные";
            this.tabPageInput.UseVisualStyleBackColor = true;
            // 
            // dataGVInput
            // 
            this.dataGVInput.AllowUserToAddRows = false;
            this.dataGVInput.AllowUserToDeleteRows = false;
            this.dataGVInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVInput.Location = new System.Drawing.Point(0, 0);
            this.dataGVInput.Name = "dataGVInput";
            this.dataGVInput.ReadOnly = true;
            this.dataGVInput.RowHeadersWidth = 60;
            this.dataGVInput.Size = new System.Drawing.Size(726, 287);
            this.dataGVInput.TabIndex = 2;
            // 
            // dataGVMOSKO
            // 
            this.dataGVMOSKO.AllowUserToAddRows = false;
            this.dataGVMOSKO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVMOSKO.Location = new System.Drawing.Point(0, 293);
            this.dataGVMOSKO.Name = "dataGVMOSKO";
            this.dataGVMOSKO.RowHeadersWidth = 60;
            this.dataGVMOSKO.Size = new System.Drawing.Size(726, 67);
            this.dataGVMOSKO.TabIndex = 1;
            // 
            // tabPageCorrelation
            // 
            this.tabPageCorrelation.Controls.Add(this.dataGVCorelation);
            this.tabPageCorrelation.Location = new System.Drawing.Point(4, 25);
            this.tabPageCorrelation.Name = "tabPageCorrelation";
            this.tabPageCorrelation.Size = new System.Drawing.Size(726, 360);
            this.tabPageCorrelation.TabIndex = 1;
            this.tabPageCorrelation.Text = "Корреляции";
            this.tabPageCorrelation.UseVisualStyleBackColor = true;
            // 
            // dataGVCorelation
            // 
            this.dataGVCorelation.AllowUserToAddRows = false;
            this.dataGVCorelation.AllowUserToDeleteRows = false;
            this.dataGVCorelation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVCorelation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVCorelation.Location = new System.Drawing.Point(0, 0);
            this.dataGVCorelation.Name = "dataGVCorelation";
            this.dataGVCorelation.ReadOnly = true;
            this.dataGVCorelation.RowHeadersWidth = 60;
            this.dataGVCorelation.Size = new System.Drawing.Size(726, 360);
            this.dataGVCorelation.TabIndex = 0;
            // 
            // tabPageCovarioation
            // 
            this.tabPageCovarioation.Controls.Add(this.dataGVCovariation);
            this.tabPageCovarioation.Location = new System.Drawing.Point(4, 25);
            this.tabPageCovarioation.Name = "tabPageCovarioation";
            this.tabPageCovarioation.Size = new System.Drawing.Size(726, 360);
            this.tabPageCovarioation.TabIndex = 2;
            this.tabPageCovarioation.Text = "Ковариации";
            this.tabPageCovarioation.UseVisualStyleBackColor = true;
            // 
            // dataGVCovariation
            // 
            this.dataGVCovariation.AllowUserToAddRows = false;
            this.dataGVCovariation.AllowUserToDeleteRows = false;
            this.dataGVCovariation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVCovariation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVCovariation.Location = new System.Drawing.Point(0, 0);
            this.dataGVCovariation.Name = "dataGVCovariation";
            this.dataGVCovariation.ReadOnly = true;
            this.dataGVCovariation.RowHeadersWidth = 60;
            this.dataGVCovariation.Size = new System.Drawing.Size(726, 360);
            this.dataGVCovariation.TabIndex = 1;
            // 
            // FrmBaseParams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmBaseParams";
            this.Text = "Базовые характеристики";
            this.Activated += new System.EventHandler(this.FrmBaseParams_Activated);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVMOSKO)).EndInit();
            this.tabPageCorrelation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCorelation)).EndInit();
            this.tabPageCovarioation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCovariation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblFileName;
        private System.Windows.Forms.ToolStripStatusLabel lblCntParams;
        private System.Windows.Forms.ToolStripStatusLabel lblWeightViborka;
        private System.Windows.Forms.ToolStripStatusLabel lblCntViborka;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageInput;
        private System.Windows.Forms.TabPage tabPageCorrelation;
        private System.Windows.Forms.DataGridView dataGVCorelation;
        private System.Windows.Forms.DataGridView dataGVMOSKO;
        private System.Windows.Forms.TabPage tabPageCovarioation;
        private System.Windows.Forms.DataGridView dataGVCovariation;
        private System.Windows.Forms.DataGridView dataGVInput;
    }
}