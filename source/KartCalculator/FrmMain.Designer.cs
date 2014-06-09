namespace KartCalculator
{
    partial class FrmMain
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вычисленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.генерацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.картаОбобщеннойДисперсииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.картаЭВССДляОбобщеннойДисперсииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.моделированиеУвеличенияРассеянияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.вычисленияToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(784, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // вычисленияToolStripMenuItem
            // 
            this.вычисленияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.генерацияToolStripMenuItem,
            this.картаОбобщеннойДисперсииToolStripMenuItem,
            this.картаЭВССДляОбобщеннойДисперсииToolStripMenuItem,
            this.моделированиеУвеличенияРассеянияToolStripMenuItem});
            this.вычисленияToolStripMenuItem.Name = "вычисленияToolStripMenuItem";
            this.вычисленияToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.вычисленияToolStripMenuItem.Text = "Вычисления";
            // 
            // генерацияToolStripMenuItem
            // 
            this.генерацияToolStripMenuItem.Name = "генерацияToolStripMenuItem";
            this.генерацияToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.генерацияToolStripMenuItem.Text = "Генерация";
            this.генерацияToolStripMenuItem.Click += new System.EventHandler(this.генерацияToolStripMenuItem_Click);
            // 
            // картаОбобщеннойДисперсииToolStripMenuItem
            // 
            this.картаОбобщеннойДисперсииToolStripMenuItem.Name = "картаОбобщеннойДисперсииToolStripMenuItem";
            this.картаОбобщеннойДисперсииToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.картаОбобщеннойДисперсииToolStripMenuItem.Text = "Карта обобщенной дисперсии";
            this.картаОбобщеннойДисперсииToolStripMenuItem.Click += new System.EventHandler(this.картаОбобщеннойДисперсииToolStripMenuItem_Click);
            // 
            // картаЭВССДляОбобщеннойДисперсииToolStripMenuItem
            // 
            this.картаЭВССДляОбобщеннойДисперсииToolStripMenuItem.Name = "картаЭВССДляОбобщеннойДисперсииToolStripMenuItem";
            this.картаЭВССДляОбобщеннойДисперсииToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.картаЭВССДляОбобщеннойДисперсииToolStripMenuItem.Text = "Карта ЭВСС для обобщенной дисперсии";
            this.картаЭВССДляОбобщеннойДисперсииToolStripMenuItem.Click += new System.EventHandler(this.картаЭВССДляОбобщеннойДисперсииToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // openFileDlg
            // 
            this.openFileDlg.Filter = "Файл данных (*.dtk) | *.dtk";
            this.openFileDlg.RestoreDirectory = true;
            // 
            // моделированиеУвеличенияРассеянияToolStripMenuItem
            // 
            this.моделированиеУвеличенияРассеянияToolStripMenuItem.Name = "моделированиеУвеличенияРассеянияToolStripMenuItem";
            this.моделированиеУвеличенияРассеянияToolStripMenuItem.Size = new System.Drawing.Size(298, 22);
            this.моделированиеУвеличенияРассеянияToolStripMenuItem.Text = "Моделирование увеличения рассеяния";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuStripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FrmMain";
            this.Text = "Выбор типа карт для контроля рассеяния";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вычисленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.ToolStripMenuItem генерацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem картаОбобщеннойДисперсииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem картаЭВССДляОбобщеннойДисперсииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моделированиеУвеличенияРассеянияToolStripMenuItem;
    }
}

