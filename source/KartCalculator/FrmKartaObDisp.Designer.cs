namespace KartCalculator
{
    partial class FrmKartaObDisp
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
            this.tabPageArrSt = new System.Windows.Forms.TabPage();
            this.dataGVArrSt = new System.Windows.Forms.DataGridView();
            this.groupBoxArrSt = new System.Windows.Forms.GroupBox();
            this.listBoxArrSt = new System.Windows.Forms.ListBox();
            this.tabPageArrDetSt = new System.Windows.Forms.TabPage();
            this.dataGVDetArrSt = new System.Windows.Forms.DataGridView();
            this.tabPageCovarArr = new System.Windows.Forms.TabPage();
            this.lblDetArrS = new System.Windows.Forms.Label();
            this.dataGVCovarArr = new System.Windows.Forms.DataGridView();
            this.tabPageKarta = new System.Windows.Forms.TabPage();
            this.chartObDisp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageSave = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveText = new System.Windows.Forms.Button();
            this.tBoxImageFilePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxTextFilePath = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPageArrSt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVArrSt)).BeginInit();
            this.groupBoxArrSt.SuspendLayout();
            this.tabPageArrDetSt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDetArrSt)).BeginInit();
            this.tabPageCovarArr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCovarArr)).BeginInit();
            this.tabPageKarta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartObDisp)).BeginInit();
            this.tabPageSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageArrSt);
            this.tabControl.Controls.Add(this.tabPageArrDetSt);
            this.tabControl.Controls.Add(this.tabPageCovarArr);
            this.tabControl.Controls.Add(this.tabPageKarta);
            this.tabControl.Controls.Add(this.tabPageSave);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(734, 411);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageArrSt
            // 
            this.tabPageArrSt.Controls.Add(this.dataGVArrSt);
            this.tabPageArrSt.Controls.Add(this.groupBoxArrSt);
            this.tabPageArrSt.Location = new System.Drawing.Point(4, 22);
            this.tabPageArrSt.Name = "tabPageArrSt";
            this.tabPageArrSt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArrSt.Size = new System.Drawing.Size(726, 385);
            this.tabPageArrSt.TabIndex = 0;
            this.tabPageArrSt.Text = "Выбор. ковар. матрица";
            this.tabPageArrSt.UseVisualStyleBackColor = true;
            // 
            // dataGVArrSt
            // 
            this.dataGVArrSt.AllowUserToAddRows = false;
            this.dataGVArrSt.AllowUserToDeleteRows = false;
            this.dataGVArrSt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVArrSt.Location = new System.Drawing.Point(95, 0);
            this.dataGVArrSt.Name = "dataGVArrSt";
            this.dataGVArrSt.ReadOnly = true;
            this.dataGVArrSt.RowHeadersWidth = 60;
            this.dataGVArrSt.Size = new System.Drawing.Size(631, 385);
            this.dataGVArrSt.TabIndex = 2;
            // 
            // groupBoxArrSt
            // 
            this.groupBoxArrSt.Controls.Add(this.listBoxArrSt);
            this.groupBoxArrSt.Location = new System.Drawing.Point(8, 6);
            this.groupBoxArrSt.Name = "groupBoxArrSt";
            this.groupBoxArrSt.Size = new System.Drawing.Size(84, 379);
            this.groupBoxArrSt.TabIndex = 0;
            this.groupBoxArrSt.TabStop = false;
            this.groupBoxArrSt.Text = "Выборка №";
            // 
            // listBoxArrSt
            // 
            this.listBoxArrSt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxArrSt.FormattingEnabled = true;
            this.listBoxArrSt.Location = new System.Drawing.Point(3, 16);
            this.listBoxArrSt.Name = "listBoxArrSt";
            this.listBoxArrSt.Size = new System.Drawing.Size(78, 360);
            this.listBoxArrSt.TabIndex = 1;
            this.listBoxArrSt.SelectedIndexChanged += new System.EventHandler(this.listBoxArrSt_SelectedIndexChanged);
            // 
            // tabPageArrDetSt
            // 
            this.tabPageArrDetSt.Controls.Add(this.dataGVDetArrSt);
            this.tabPageArrDetSt.Location = new System.Drawing.Point(4, 22);
            this.tabPageArrDetSt.Name = "tabPageArrDetSt";
            this.tabPageArrDetSt.Size = new System.Drawing.Size(726, 385);
            this.tabPageArrDetSt.TabIndex = 1;
            this.tabPageArrDetSt.Text = "Обобщенная дисперсия";
            this.tabPageArrDetSt.UseVisualStyleBackColor = true;
            // 
            // dataGVDetArrSt
            // 
            this.dataGVDetArrSt.AllowUserToAddRows = false;
            this.dataGVDetArrSt.AllowUserToDeleteRows = false;
            this.dataGVDetArrSt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVDetArrSt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVDetArrSt.Location = new System.Drawing.Point(0, 0);
            this.dataGVDetArrSt.Name = "dataGVDetArrSt";
            this.dataGVDetArrSt.ReadOnly = true;
            this.dataGVDetArrSt.RowHeadersWidth = 60;
            this.dataGVDetArrSt.Size = new System.Drawing.Size(726, 385);
            this.dataGVDetArrSt.TabIndex = 3;
            // 
            // tabPageCovarArr
            // 
            this.tabPageCovarArr.Controls.Add(this.lblDetArrS);
            this.tabPageCovarArr.Controls.Add(this.dataGVCovarArr);
            this.tabPageCovarArr.Location = new System.Drawing.Point(4, 22);
            this.tabPageCovarArr.Name = "tabPageCovarArr";
            this.tabPageCovarArr.Size = new System.Drawing.Size(726, 385);
            this.tabPageCovarArr.TabIndex = 2;
            this.tabPageCovarArr.Text = "Ковариционная м-ца";
            this.tabPageCovarArr.UseVisualStyleBackColor = true;
            // 
            // lblDetArrS
            // 
            this.lblDetArrS.Location = new System.Drawing.Point(3, 367);
            this.lblDetArrS.Name = "lblDetArrS";
            this.lblDetArrS.Size = new System.Drawing.Size(720, 18);
            this.lblDetArrS.TabIndex = 5;
            // 
            // dataGVCovarArr
            // 
            this.dataGVCovarArr.AllowUserToAddRows = false;
            this.dataGVCovarArr.AllowUserToDeleteRows = false;
            this.dataGVCovarArr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVCovarArr.Location = new System.Drawing.Point(0, 0);
            this.dataGVCovarArr.Name = "dataGVCovarArr";
            this.dataGVCovarArr.ReadOnly = true;
            this.dataGVCovarArr.RowHeadersWidth = 60;
            this.dataGVCovarArr.Size = new System.Drawing.Size(726, 364);
            this.dataGVCovarArr.TabIndex = 4;
            // 
            // tabPageKarta
            // 
            this.tabPageKarta.Controls.Add(this.chartObDisp);
            this.tabPageKarta.Location = new System.Drawing.Point(4, 22);
            this.tabPageKarta.Name = "tabPageKarta";
            this.tabPageKarta.Size = new System.Drawing.Size(726, 385);
            this.tabPageKarta.TabIndex = 3;
            this.tabPageKarta.Text = "Карта";
            this.tabPageKarta.UseVisualStyleBackColor = true;
            // 
            // chartObDisp
            // 
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.chartObDisp.ChartAreas.Add(chartArea1);
            this.chartObDisp.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartObDisp.Legends.Add(legend1);
            this.chartObDisp.Location = new System.Drawing.Point(0, 0);
            this.chartObDisp.Name = "chartObDisp";
            this.chartObDisp.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BorderColor = System.Drawing.Color.White;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 5;
            series1.Name = "Верхняя граница";
            series1.YValuesPerPoint = 2;
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Нижняя граница";
            series3.BorderWidth = 5;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Color = System.Drawing.Color.Black;
            series3.Legend = "Legend1";
            series3.Name = "Обобщенная дисперсия";
            this.chartObDisp.Series.Add(series1);
            this.chartObDisp.Series.Add(series2);
            this.chartObDisp.Series.Add(series3);
            this.chartObDisp.Size = new System.Drawing.Size(726, 385);
            this.chartObDisp.TabIndex = 0;
            // 
            // tabPageSave
            // 
            this.tabPageSave.Controls.Add(this.button2);
            this.tabPageSave.Controls.Add(this.button1);
            this.tabPageSave.Controls.Add(this.btnSaveImage);
            this.tabPageSave.Controls.Add(this.label2);
            this.tabPageSave.Controls.Add(this.btnSaveText);
            this.tabPageSave.Controls.Add(this.tBoxImageFilePath);
            this.tabPageSave.Controls.Add(this.label1);
            this.tabPageSave.Controls.Add(this.tBoxTextFilePath);
            this.tabPageSave.Location = new System.Drawing.Point(4, 22);
            this.tabPageSave.Name = "tabPageSave";
            this.tabPageSave.Size = new System.Drawing.Size(726, 385);
            this.tabPageSave.TabIndex = 4;
            this.tabPageSave.Text = "Сохранение";
            this.tabPageSave.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(563, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 20);
            this.button2.TabIndex = 3;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(482, 238);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(75, 23);
            this.btnSaveImage.TabIndex = 2;
            this.btnSaveImage.Text = "Сохранить";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Путь к графическому файлу:";
            // 
            // btnSaveText
            // 
            this.btnSaveText.Location = new System.Drawing.Point(482, 131);
            this.btnSaveText.Name = "btnSaveText";
            this.btnSaveText.Size = new System.Drawing.Size(75, 23);
            this.btnSaveText.TabIndex = 2;
            this.btnSaveText.Text = "Сохранить";
            this.btnSaveText.UseVisualStyleBackColor = true;
            this.btnSaveText.Click += new System.EventHandler(this.btnSaveText_Click);
            // 
            // tBoxImageFilePath
            // 
            this.tBoxImageFilePath.Location = new System.Drawing.Point(216, 212);
            this.tBoxImageFilePath.Name = "tBoxImageFilePath";
            this.tBoxImageFilePath.Size = new System.Drawing.Size(341, 20);
            this.tBoxImageFilePath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Путь к текстовому файлу:";
            // 
            // tBoxTextFilePath
            // 
            this.tBoxTextFilePath.Location = new System.Drawing.Point(216, 105);
            this.tBoxTextFilePath.Name = "tBoxTextFilePath";
            this.tBoxTextFilePath.Size = new System.Drawing.Size(341, 20);
            this.tBoxTextFilePath.TabIndex = 0;
            // 
            // FrmKartaObDisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.tabControl);
            this.Name = "FrmKartaObDisp";
            this.Text = "Карта обобщенной дисперсии";
            this.tabControl.ResumeLayout(false);
            this.tabPageArrSt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVArrSt)).EndInit();
            this.groupBoxArrSt.ResumeLayout(false);
            this.tabPageArrDetSt.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVDetArrSt)).EndInit();
            this.tabPageCovarArr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCovarArr)).EndInit();
            this.tabPageKarta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartObDisp)).EndInit();
            this.tabPageSave.ResumeLayout(false);
            this.tabPageSave.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageArrSt;
        private System.Windows.Forms.GroupBox groupBoxArrSt;
        private System.Windows.Forms.ListBox listBoxArrSt;
        private System.Windows.Forms.DataGridView dataGVArrSt;
        private System.Windows.Forms.TabPage tabPageArrDetSt;
        private System.Windows.Forms.DataGridView dataGVDetArrSt;
        private System.Windows.Forms.TabPage tabPageCovarArr;
        private System.Windows.Forms.DataGridView dataGVCovarArr;
        private System.Windows.Forms.Label lblDetArrS;
        private System.Windows.Forms.TabPage tabPageKarta;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartObDisp;
        private System.Windows.Forms.TabPage tabPageSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveText;
        private System.Windows.Forms.TextBox tBoxImageFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxTextFilePath;
    }
}