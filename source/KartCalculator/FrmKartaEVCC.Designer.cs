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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnReadFiles = new System.Windows.Forms.Button();
            this.lblCntViborok = new System.Windows.Forms.Label();
            this.btnMakeKarta = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCntFiles = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBrowseDir = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tBoxDir = new System.Windows.Forms.TextBox();
            this.lblH = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartKarta = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.folderBrDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.tabPage1.Controls.Add(this.btnReadFiles);
            this.tabPage1.Controls.Add(this.lblCntViborok);
            this.tabPage1.Controls.Add(this.btnMakeKarta);
            this.tabPage1.Controls.Add(this.numericUpDown1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblCntFiles);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.btnBrowseDir);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.tBoxDir);
            this.tabPage1.Controls.Add(this.lblH);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(726, 385);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расчетные значения";
            // 
            // btnReadFiles
            // 
            this.btnReadFiles.Location = new System.Drawing.Point(254, 124);
            this.btnReadFiles.Name = "btnReadFiles";
            this.btnReadFiles.Size = new System.Drawing.Size(222, 28);
            this.btnReadFiles.TabIndex = 24;
            this.btnReadFiles.Text = "Cчитать данные";
            this.btnReadFiles.UseVisualStyleBackColor = true;
            this.btnReadFiles.Click += new System.EventHandler(this.btnReadFiles_Click);
            // 
            // lblCntViborok
            // 
            this.lblCntViborok.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCntViborok.Location = new System.Drawing.Point(396, 199);
            this.lblCntViborok.Name = "lblCntViborok";
            this.lblCntViborok.Size = new System.Drawing.Size(52, 13);
            this.lblCntViborok.TabIndex = 22;
            // 
            // btnMakeKarta
            // 
            this.btnMakeKarta.Location = new System.Drawing.Point(251, 258);
            this.btnMakeKarta.Name = "btnMakeKarta";
            this.btnMakeKarta.Size = new System.Drawing.Size(225, 29);
            this.btnMakeKarta.TabIndex = 16;
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
            this.numericUpDown1.Location = new System.Drawing.Point(399, 232);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Параметр сглажывания k";
            // 
            // lblCntFiles
            // 
            this.lblCntFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCntFiles.Location = new System.Drawing.Point(396, 166);
            this.lblCntFiles.Name = "lblCntFiles";
            this.lblCntFiles.Size = new System.Drawing.Size(52, 13);
            this.lblCntFiles.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Сумма выборок:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(277, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Файлов обработано:";
            // 
            // btnBrowseDir
            // 
            this.btnBrowseDir.Location = new System.Drawing.Point(451, 98);
            this.btnBrowseDir.Name = "btnBrowseDir";
            this.btnBrowseDir.Size = new System.Drawing.Size(25, 20);
            this.btnBrowseDir.TabIndex = 19;
            this.btnBrowseDir.Text = "...";
            this.btnBrowseDir.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(251, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Каталог";
            // 
            // tBoxDir
            // 
            this.tBoxDir.Location = new System.Drawing.Point(305, 98);
            this.tBoxDir.Name = "tBoxDir";
            this.tBoxDir.Size = new System.Drawing.Size(143, 20);
            this.tBoxDir.TabIndex = 17;
            // 
            // lblH
            // 
            this.lblH.Location = new System.Drawing.Point(251, 290);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(225, 45);
            this.lblH.TabIndex = 8;
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
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.Name = "ChartArea1";
            this.chartKarta.ChartAreas.Add(chartArea2);
            this.chartKarta.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartKarta.Legends.Add(legend2);
            this.chartKarta.Location = new System.Drawing.Point(3, 3);
            this.chartKarta.Name = "chartKarta";
            this.chartKarta.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.BorderColor = System.Drawing.Color.White;
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.MarkerBorderColor = System.Drawing.Color.Black;
            series4.MarkerBorderWidth = 5;
            series4.MarkerColor = System.Drawing.Color.Black;
            series4.MarkerImageTransparentColor = System.Drawing.Color.Black;
            series4.MarkerStep = 5;
            series4.Name = "Верхняя граница";
            series4.YValuesPerPoint = 2;
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Legend1";
            series5.Name = "Нижняя граница";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.Color = System.Drawing.Color.Black;
            series6.Legend = "Legend1";
            series6.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series6.Name = "ЭВСС";
            this.chartKarta.Series.Add(series4);
            this.chartKarta.Series.Add(series5);
            this.chartKarta.Series.Add(series6);
            this.chartKarta.Size = new System.Drawing.Size(720, 379);
            this.chartKarta.TabIndex = 1;
            // 
            // FrmKartaEVCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmKartaEVCC";
            this.Text = "Карта эксоненциально взвешенных скользящих средних";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartKarta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FolderBrowserDialog folderBrDlg;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartKarta;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Button btnReadFiles;
        private System.Windows.Forms.Label lblCntViborok;
        private System.Windows.Forms.Button btnMakeKarta;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCntFiles;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBrowseDir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tBoxDir;
    }
}