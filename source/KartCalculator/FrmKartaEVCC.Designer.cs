namespace KartCalculator
{
    partial class FrmKartaEVCC
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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGVDetLCL = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGVDetUCL = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGVDetSigmaEt = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGVDetArrEt = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxUseH = new System.Windows.Forms.CheckBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnReadFiles = new System.Windows.Forms.Button();
            this.lblCntViborok = new System.Windows.Forms.Label();
            this.btnMakeKarta = new System.Windows.Forms.Button();
            this.numericUpDownH = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownK = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCntFiles = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBrowseDir = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tBoxDir = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartKarta = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.folderBrDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.prBarMain = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDetLCL)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDetUCL)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDetSigmaEt)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDetArrEt)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartKarta)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(734, 411);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(726, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расчет карты";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGVDetLCL);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(582, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(125, 347);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "LCL";
            // 
            // dataGVDetLCL
            // 
            this.dataGVDetLCL.AllowUserToAddRows = false;
            this.dataGVDetLCL.AllowUserToDeleteRows = false;
            this.dataGVDetLCL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDetLCL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVDetLCL.Location = new System.Drawing.Point(3, 16);
            this.dataGVDetLCL.Name = "dataGVDetLCL";
            this.dataGVDetLCL.ReadOnly = true;
            this.dataGVDetLCL.RowHeadersWidth = 60;
            this.dataGVDetLCL.Size = new System.Drawing.Size(119, 328);
            this.dataGVDetLCL.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(32, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 45);
            this.label5.TabIndex = 26;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGVDetUCL);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(454, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(125, 347);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "UCL";
            // 
            // dataGVDetUCL
            // 
            this.dataGVDetUCL.AllowUserToAddRows = false;
            this.dataGVDetUCL.AllowUserToDeleteRows = false;
            this.dataGVDetUCL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDetUCL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVDetUCL.Location = new System.Drawing.Point(3, 16);
            this.dataGVDetUCL.Name = "dataGVDetUCL";
            this.dataGVDetUCL.ReadOnly = true;
            this.dataGVDetUCL.RowHeadersWidth = 60;
            this.dataGVDetUCL.Size = new System.Drawing.Size(119, 328);
            this.dataGVDetUCL.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(32, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 45);
            this.label4.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGVDetSigmaEt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(326, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 347);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Матрица SigmaS(Et)";
            // 
            // dataGVDetSigmaEt
            // 
            this.dataGVDetSigmaEt.AllowUserToAddRows = false;
            this.dataGVDetSigmaEt.AllowUserToDeleteRows = false;
            this.dataGVDetSigmaEt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDetSigmaEt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVDetSigmaEt.Location = new System.Drawing.Point(3, 16);
            this.dataGVDetSigmaEt.Name = "dataGVDetSigmaEt";
            this.dataGVDetSigmaEt.ReadOnly = true;
            this.dataGVDetSigmaEt.RowHeadersWidth = 60;
            this.dataGVDetSigmaEt.Size = new System.Drawing.Size(119, 328);
            this.dataGVDetSigmaEt.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(32, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 45);
            this.label3.TabIndex = 26;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGVDetArrEt);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(198, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(125, 347);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Матрица ЭВСС";
            // 
            // dataGVDetArrEt
            // 
            this.dataGVDetArrEt.AllowUserToAddRows = false;
            this.dataGVDetArrEt.AllowUserToDeleteRows = false;
            this.dataGVDetArrEt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDetArrEt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVDetArrEt.Location = new System.Drawing.Point(3, 16);
            this.dataGVDetArrEt.Name = "dataGVDetArrEt";
            this.dataGVDetArrEt.ReadOnly = true;
            this.dataGVDetArrEt.RowHeadersWidth = 60;
            this.dataGVDetArrEt.Size = new System.Drawing.Size(119, 328);
            this.dataGVDetArrEt.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 45);
            this.label2.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxUseH);
            this.groupBox1.Controls.Add(this.lblResults);
            this.groupBox1.Controls.Add(this.btnReadFiles);
            this.groupBox1.Controls.Add(this.lblCntViborok);
            this.groupBox1.Controls.Add(this.btnMakeKarta);
            this.groupBox1.Controls.Add(this.numericUpDownH);
            this.groupBox1.Controls.Add(this.numericUpDownK);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblCntFiles);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnBrowseDir);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tBoxDir);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Обработка файлов";
            // 
            // cBoxUseH
            // 
            this.cBoxUseH.AutoSize = true;
            this.cBoxUseH.Location = new System.Drawing.Point(18, 214);
            this.cBoxUseH.Name = "cBoxUseH";
            this.cBoxUseH.Size = new System.Drawing.Size(103, 17);
            this.cBoxUseH.TabIndex = 37;
            this.cBoxUseH.Text = "Параметр Нср.";
            this.cBoxUseH.UseVisualStyleBackColor = true;
            // 
            // lblResults
            // 
            this.lblResults.Location = new System.Drawing.Point(5, 282);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(171, 66);
            this.lblResults.TabIndex = 26;
            // 
            // btnReadFiles
            // 
            this.btnReadFiles.Location = new System.Drawing.Point(8, 61);
            this.btnReadFiles.Name = "btnReadFiles";
            this.btnReadFiles.Size = new System.Drawing.Size(168, 28);
            this.btnReadFiles.TabIndex = 36;
            this.btnReadFiles.Text = "Cчитать данные";
            this.btnReadFiles.UseVisualStyleBackColor = true;
            this.btnReadFiles.Click += new System.EventHandler(this.btnReadFiles_Click);
            // 
            // lblCntViborok
            // 
            this.lblCntViborok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCntViborok.Location = new System.Drawing.Point(124, 143);
            this.lblCntViborok.Name = "lblCntViborok";
            this.lblCntViborok.Size = new System.Drawing.Size(52, 13);
            this.lblCntViborok.TabIndex = 34;
            // 
            // btnMakeKarta
            // 
            this.btnMakeKarta.Location = new System.Drawing.Point(8, 250);
            this.btnMakeKarta.Name = "btnMakeKarta";
            this.btnMakeKarta.Size = new System.Drawing.Size(168, 29);
            this.btnMakeKarta.TabIndex = 28;
            this.btnMakeKarta.Text = "Рассчитать карту";
            this.btnMakeKarta.UseVisualStyleBackColor = true;
            this.btnMakeKarta.Click += new System.EventHandler(this.btnMakeKarta_Click);
            // 
            // numericUpDownH
            // 
            this.numericUpDownH.DecimalPlaces = 2;
            this.numericUpDownH.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownH.Location = new System.Drawing.Point(127, 213);
            this.numericUpDownH.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownH.Name = "numericUpDownH";
            this.numericUpDownH.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownH.TabIndex = 27;
            this.numericUpDownH.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDownK
            // 
            this.numericUpDownK.DecimalPlaces = 2;
            this.numericUpDownK.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownK.Location = new System.Drawing.Point(127, 172);
            this.numericUpDownK.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownK.Name = "numericUpDownK";
            this.numericUpDownK.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownK.TabIndex = 27;
            this.numericUpDownK.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "П-тр сглаживания k";
            // 
            // lblCntFiles
            // 
            this.lblCntFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCntFiles.Location = new System.Drawing.Point(124, 110);
            this.lblCntFiles.Name = "lblCntFiles";
            this.lblCntFiles.Size = new System.Drawing.Size(52, 13);
            this.lblCntFiles.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Всего выборок:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Файлов обработано:";
            // 
            // btnBrowseDir
            // 
            this.btnBrowseDir.Location = new System.Drawing.Point(151, 34);
            this.btnBrowseDir.Name = "btnBrowseDir";
            this.btnBrowseDir.Size = new System.Drawing.Size(25, 20);
            this.btnBrowseDir.TabIndex = 31;
            this.btnBrowseDir.Text = "...";
            this.btnBrowseDir.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Каталог";
            // 
            // tBoxDir
            // 
            this.tBoxDir.Location = new System.Drawing.Point(60, 35);
            this.tBoxDir.Name = "tBoxDir";
            this.tBoxDir.Size = new System.Drawing.Size(85, 20);
            this.tBoxDir.TabIndex = 29;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartKarta);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(726, 385);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Карта";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartKarta
            // 
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.chartKarta.ChartAreas.Add(chartArea1);
            this.chartKarta.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartKarta.Legends.Add(legend1);
            this.chartKarta.Location = new System.Drawing.Point(3, 3);
            this.chartKarta.Name = "chartKarta";
            this.chartKarta.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderColor = System.Drawing.Color.White;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Black;
            series1.MarkerBorderWidth = 5;
            series1.MarkerColor = System.Drawing.Color.Black;
            series1.MarkerImageTransparentColor = System.Drawing.Color.Black;
            series1.MarkerStep = 5;
            series1.Name = "Верхняя граница";
            series1.YValuesPerPoint = 2;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Нижняя граница";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Color = System.Drawing.Color.Black;
            series3.Legend = "Legend1";
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series3.Name = "ЭВСС";
            this.chartKarta.Series.Add(series1);
            this.chartKarta.Series.Add(series2);
            this.chartKarta.Series.Add(series3);
            this.chartKarta.Size = new System.Drawing.Size(720, 379);
            this.chartKarta.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prBarMain});
            this.statusStrip1.Location = new System.Drawing.Point(3, 360);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(720, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // prBarMain
            // 
            this.prBarMain.Name = "prBarMain";
            this.prBarMain.Size = new System.Drawing.Size(700, 16);
            // 
            // FrmKartaEVCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmKartaEVCC";
            this.Text = "Карта экспоненциально взвешенных скользящих средних";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDetLCL)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDetUCL)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDetSigmaEt)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDetArrEt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartKarta)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FolderBrowserDialog folderBrDlg;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKarta;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReadFiles;
        private System.Windows.Forms.Label lblCntViborok;
        private System.Windows.Forms.Button btnMakeKarta;
        private System.Windows.Forms.NumericUpDown numericUpDownK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCntFiles;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBrowseDir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tBoxDir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGVDetArrEt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGVDetLCL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGVDetUCL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGVDetSigmaEt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cBoxUseH;
        private System.Windows.Forms.NumericUpDown numericUpDownH;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar prBarMain;
    }
}