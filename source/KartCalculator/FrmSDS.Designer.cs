namespace KartCalculator
{
    partial class FrmSDS
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSelectOldDirPath = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tBoxOldDirPath = new System.Windows.Forms.TextBox();
            this.btnReadOldDir = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGVDetArrSDS = new System.Windows.Forms.DataGridView();
            this.chartKartaKS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nUpDownD = new System.Windows.Forms.NumericUpDown();
            this.lBoxFile = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.prBarMain = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDetArrSDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKartaKS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownD)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(734, 411);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSelectOldDirPath);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.tBoxOldDirPath);
            this.tabPage1.Controls.Add(this.btnReadOldDir);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(726, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Инициализация";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSelectOldDirPath
            // 
            this.btnSelectOldDirPath.Location = new System.Drawing.Point(433, 117);
            this.btnSelectOldDirPath.Name = "btnSelectOldDirPath";
            this.btnSelectOldDirPath.Size = new System.Drawing.Size(25, 20);
            this.btnSelectOldDirPath.TabIndex = 45;
            this.btnSelectOldDirPath.Text = "...";
            this.btnSelectOldDirPath.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Каталог";
            // 
            // tBoxOldDirPath
            // 
            this.tBoxOldDirPath.Location = new System.Drawing.Point(287, 117);
            this.tBoxOldDirPath.Name = "tBoxOldDirPath";
            this.tBoxOldDirPath.Size = new System.Drawing.Size(143, 20);
            this.tBoxOldDirPath.TabIndex = 43;
            // 
            // btnReadOldDir
            // 
            this.btnReadOldDir.Location = new System.Drawing.Point(236, 178);
            this.btnReadOldDir.Name = "btnReadOldDir";
            this.btnReadOldDir.Size = new System.Drawing.Size(225, 28);
            this.btnReadOldDir.TabIndex = 46;
            this.btnReadOldDir.Text = "Cчитать данные";
            this.btnReadOldDir.UseVisualStyleBackColor = true;
            this.btnReadOldDir.Click += new System.EventHandler(this.btnReadOldDir_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGVDetArrSDS);
            this.tabPage2.Controls.Add(this.chartKartaKS);
            this.tabPage2.Controls.Add(this.nUpDownD);
            this.tabPage2.Controls.Add(this.lBoxFile);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(726, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Результаты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGVDetArrSDS
            // 
            this.dataGVDetArrSDS.AllowUserToAddRows = false;
            this.dataGVDetArrSDS.AllowUserToDeleteRows = false;
            this.dataGVDetArrSDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDetArrSDS.Location = new System.Drawing.Point(584, 18);
            this.dataGVDetArrSDS.Name = "dataGVDetArrSDS";
            this.dataGVDetArrSDS.ReadOnly = true;
            this.dataGVDetArrSDS.RowHeadersWidth = 60;
            this.dataGVDetArrSDS.Size = new System.Drawing.Size(134, 342);
            this.dataGVDetArrSDS.TabIndex = 28;
            // 
            // chartKartaKS
            // 
            chartArea1.Name = "ChartArea1";
            this.chartKartaKS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartKartaKS.Legends.Add(legend1);
            this.chartKartaKS.Location = new System.Drawing.Point(140, 18);
            this.chartKartaKS.Name = "chartKartaKS";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Ct";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Cкр";
            this.chartKartaKS.Series.Add(series1);
            this.chartKartaKS.Series.Add(series2);
            this.chartKartaKS.Size = new System.Drawing.Size(438, 342);
            this.chartKartaKS.TabIndex = 2;
            this.chartKartaKS.Text = "chart1";
            // 
            // nUpDownD
            // 
            this.nUpDownD.DecimalPlaces = 2;
            this.nUpDownD.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nUpDownD.Location = new System.Drawing.Point(8, 18);
            this.nUpDownD.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUpDownD.Minimum = new decimal(new int[] {
            125,
            0,
            0,
            131072});
            this.nUpDownD.Name = "nUpDownD";
            this.nUpDownD.Size = new System.Drawing.Size(126, 20);
            this.nUpDownD.TabIndex = 1;
            this.nUpDownD.Value = new decimal(new int[] {
            125,
            0,
            0,
            131072});
            this.nUpDownD.ValueChanged += new System.EventHandler(this.nUpDownD_ValueChanged);
            // 
            // lBoxFile
            // 
            this.lBoxFile.FormattingEnabled = true;
            this.lBoxFile.Location = new System.Drawing.Point(8, 44);
            this.lBoxFile.Name = "lBoxFile";
            this.lBoxFile.Size = new System.Drawing.Size(126, 316);
            this.lBoxFile.TabIndex = 0;
            this.lBoxFile.SelectedIndexChanged += new System.EventHandler(this.lBoxFile_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prBarMain});
            this.statusStrip1.Location = new System.Drawing.Point(0, 389);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(734, 22);
            this.statusStrip1.TabIndex = 43;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // prBarMain
            // 
            this.prBarMain.Name = "prBarMain";
            this.prBarMain.Size = new System.Drawing.Size(700, 16);
            // 
            // FrmSDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSDS";
            this.Text = "Расчет СДС";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDetArrSDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartKartaKS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownD)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar prBarMain;
        private System.Windows.Forms.Button btnSelectOldDirPath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBoxOldDirPath;
        private System.Windows.Forms.Button btnReadOldDir;
        private System.Windows.Forms.ListBox lBoxFile;
        private System.Windows.Forms.NumericUpDown nUpDownD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKartaKS;
        private System.Windows.Forms.DataGridView dataGVDetArrSDS;

    }
}