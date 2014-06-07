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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReadNewFiles = new System.Windows.Forms.Button();
            this.lblNewViborok = new System.Windows.Forms.Label();
            this.btnMakeKarta = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCntNewFiles = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBrowseNewDir = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tBoxNewDir = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCntNewFilesCalc = new System.Windows.Forms.Label();
            this.lblTotalCntViborkaOldFiles = new System.Windows.Forms.Label();
            this.lblTotalOldFiles = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReadOldFiles = new System.Windows.Forms.Button();
            this.btnBrowseOldDir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxOldDir = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.folderBrDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.chartKarta = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartKarta)).BeginInit();
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
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(726, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расчетные значения";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReadNewFiles);
            this.groupBox2.Controls.Add(this.lblNewViborok);
            this.groupBox2.Controls.Add(this.btnMakeKarta);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblCntNewFiles);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnBrowseNewDir);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tBoxNewDir);
            this.groupBox2.Location = new System.Drawing.Point(367, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 218);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Обработка подходящих файлов";
            // 
            // btnReadNewFiles
            // 
            this.btnReadNewFiles.Location = new System.Drawing.Point(9, 49);
            this.btnReadNewFiles.Name = "btnReadNewFiles";
            this.btnReadNewFiles.Size = new System.Drawing.Size(222, 28);
            this.btnReadNewFiles.TabIndex = 13;
            this.btnReadNewFiles.Text = "Cчитать данные";
            this.btnReadNewFiles.UseVisualStyleBackColor = true;
            this.btnReadNewFiles.Click += new System.EventHandler(this.btnReadNewFiles_Click);
            // 
            // lblNewViborok
            // 
            this.lblNewViborok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewViborok.Location = new System.Drawing.Point(151, 124);
            this.lblNewViborok.Name = "lblNewViborok";
            this.lblNewViborok.Size = new System.Drawing.Size(52, 13);
            this.lblNewViborok.TabIndex = 12;
            // 
            // btnMakeKarta
            // 
            this.btnMakeKarta.Location = new System.Drawing.Point(6, 183);
            this.btnMakeKarta.Name = "btnMakeKarta";
            this.btnMakeKarta.Size = new System.Drawing.Size(225, 29);
            this.btnMakeKarta.TabIndex = 2;
            this.btnMakeKarta.Text = "Расчитать карту";
            this.btnMakeKarta.UseVisualStyleBackColor = true;
            this.btnMakeKarta.Click += new System.EventHandler(this.btnMakeKarta_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown1.Location = new System.Drawing.Point(182, 157);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Параметр сглажывания k";
            // 
            // lblCntNewFiles
            // 
            this.lblCntNewFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCntNewFiles.Location = new System.Drawing.Point(151, 91);
            this.lblCntNewFiles.Name = "lblCntNewFiles";
            this.lblCntNewFiles.Size = new System.Drawing.Size(52, 13);
            this.lblCntNewFiles.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Сумма выборок:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Файлов обработано:";
            // 
            // btnBrowseNewDir
            // 
            this.btnBrowseNewDir.Location = new System.Drawing.Point(206, 23);
            this.btnBrowseNewDir.Name = "btnBrowseNewDir";
            this.btnBrowseNewDir.Size = new System.Drawing.Size(25, 20);
            this.btnBrowseNewDir.TabIndex = 9;
            this.btnBrowseNewDir.Text = "...";
            this.btnBrowseNewDir.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Каталог";
            // 
            // tBoxNewDir
            // 
            this.tBoxNewDir.Location = new System.Drawing.Point(60, 23);
            this.tBoxNewDir.Name = "tBoxNewDir";
            this.tBoxNewDir.Size = new System.Drawing.Size(143, 20);
            this.tBoxNewDir.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCntNewFilesCalc);
            this.groupBox1.Controls.Add(this.lblTotalCntViborkaOldFiles);
            this.groupBox1.Controls.Add(this.lblTotalOldFiles);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnReadOldFiles);
            this.groupBox1.Controls.Add(this.btnBrowseOldDir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tBoxOldDir);
            this.groupBox1.Location = new System.Drawing.Point(106, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 218);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Обработка потока выборок";
            // 
            // lblCntNewFilesCalc
            // 
            this.lblCntNewFilesCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCntNewFilesCalc.Location = new System.Drawing.Point(151, 157);
            this.lblCntNewFilesCalc.Name = "lblCntNewFilesCalc";
            this.lblCntNewFilesCalc.Size = new System.Drawing.Size(52, 13);
            this.lblCntNewFilesCalc.TabIndex = 12;
            // 
            // lblTotalCntViborkaOldFiles
            // 
            this.lblTotalCntViborkaOldFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalCntViborkaOldFiles.Location = new System.Drawing.Point(151, 124);
            this.lblTotalCntViborkaOldFiles.Name = "lblTotalCntViborkaOldFiles";
            this.lblTotalCntViborkaOldFiles.Size = new System.Drawing.Size(52, 13);
            this.lblTotalCntViborkaOldFiles.TabIndex = 12;
            // 
            // lblTotalOldFiles
            // 
            this.lblTotalOldFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalOldFiles.Location = new System.Drawing.Point(151, 91);
            this.lblTotalOldFiles.Name = "lblTotalOldFiles";
            this.lblTotalOldFiles.Size = new System.Drawing.Size(52, 13);
            this.lblTotalOldFiles.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Новых файлов:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(6, 184);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(225, 29);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Создать новые";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Сумма выборок:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Файлов обработано:";
            // 
            // btnReadOldFiles
            // 
            this.btnReadOldFiles.Location = new System.Drawing.Point(6, 49);
            this.btnReadOldFiles.Name = "btnReadOldFiles";
            this.btnReadOldFiles.Size = new System.Drawing.Size(225, 28);
            this.btnReadOldFiles.TabIndex = 10;
            this.btnReadOldFiles.Text = "Cчитать данные";
            this.btnReadOldFiles.UseVisualStyleBackColor = true;
            this.btnReadOldFiles.Click += new System.EventHandler(this.btnReadOldFiles_Click);
            // 
            // btnBrowseOldDir
            // 
            this.btnBrowseOldDir.Location = new System.Drawing.Point(206, 23);
            this.btnBrowseOldDir.Name = "btnBrowseOldDir";
            this.btnBrowseOldDir.Size = new System.Drawing.Size(25, 20);
            this.btnBrowseOldDir.TabIndex = 9;
            this.btnBrowseOldDir.Text = "...";
            this.btnBrowseOldDir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Каталог";
            // 
            // tBoxOldDir
            // 
            this.tBoxOldDir.Location = new System.Drawing.Point(60, 23);
            this.tBoxOldDir.Name = "tBoxOldDir";
            this.tBoxOldDir.Size = new System.Drawing.Size(143, 20);
            this.tBoxOldDir.TabIndex = 7;
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
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.Black;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 5;
            series1.Name = "Верхняя граница";
            series1.YValuesPerPoint = 2;
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.Black;
            series2.Legend = "Legend1";
            series2.Name = "Нижняя граница";
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Color = System.Drawing.Color.Black;
            series3.Legend = "Legend1";
            series3.Name = "ЭВСС";
            this.chartKarta.Series.Add(series1);
            this.chartKarta.Series.Add(series2);
            this.chartKarta.Series.Add(series3);
            this.chartKarta.Size = new System.Drawing.Size(720, 379);
            this.chartKarta.TabIndex = 1;
            // 
            // FrmKartaEVCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.tabControl);
            this.Name = "FrmKartaEVCC";
            this.Text = "Карта эксоненциально взвешенных скользящих средних";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartKarta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReadOldFiles;
        private System.Windows.Forms.Button btnBrowseOldDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxOldDir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCntNewFilesCalc;
        private System.Windows.Forms.Label lblTotalCntViborkaOldFiles;
        private System.Windows.Forms.Label lblTotalOldFiles;
        private System.Windows.Forms.FolderBrowserDialog folderBrDlg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNewViborok;
        private System.Windows.Forms.Label lblCntNewFiles;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBrowseNewDir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tBoxNewDir;
        private System.Windows.Forms.Button btnReadNewFiles;
        private System.Windows.Forms.Button btnMakeKarta;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKarta;
    }
}