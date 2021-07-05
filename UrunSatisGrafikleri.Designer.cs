
namespace Optikci_Otomasyonu
{
    partial class UrunSatisGrafikleri
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.urunEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunleriListeleGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunSatisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunSatislariniGosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEKleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListeleGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplamKar = new System.Windows.Forms.Label();
            this.lblBrutGelir = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTopSatis = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urunEkleToolStripMenuItem,
            this.urunleriListeleGuncelleToolStripMenuItem,
            this.urunSatisiToolStripMenuItem,
            this.urunSatislariniGosterToolStripMenuItem,
            this.personelEKleToolStripMenuItem,
            this.personelListeleGuncelleToolStripMenuItem,
            this.cikisYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1233, 29);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // urunEkleToolStripMenuItem
            // 
            this.urunEkleToolStripMenuItem.Name = "urunEkleToolStripMenuItem";
            this.urunEkleToolStripMenuItem.Size = new System.Drawing.Size(69, 19);
            this.urunEkleToolStripMenuItem.Text = "Ürün Ekle";
            // 
            // urunleriListeleGuncelleToolStripMenuItem
            // 
            this.urunleriListeleGuncelleToolStripMenuItem.Name = "urunleriListeleGuncelleToolStripMenuItem";
            this.urunleriListeleGuncelleToolStripMenuItem.Size = new System.Drawing.Size(148, 19);
            this.urunleriListeleGuncelleToolStripMenuItem.Text = "Ürunleri Listele/Güncelle";
            // 
            // urunSatisiToolStripMenuItem
            // 
            this.urunSatisiToolStripMenuItem.Name = "urunSatisiToolStripMenuItem";
            this.urunSatisiToolStripMenuItem.Size = new System.Drawing.Size(75, 19);
            this.urunSatisiToolStripMenuItem.Text = "Ürün Satışı";
            // 
            // urunSatislariniGosterToolStripMenuItem
            // 
            this.urunSatislariniGosterToolStripMenuItem.Name = "urunSatislariniGosterToolStripMenuItem";
            this.urunSatislariniGosterToolStripMenuItem.Size = new System.Drawing.Size(135, 19);
            this.urunSatislariniGosterToolStripMenuItem.Text = "Ürün Satışlarını Göster";
            // 
            // personelEKleToolStripMenuItem
            // 
            this.personelEKleToolStripMenuItem.Name = "personelEKleToolStripMenuItem";
            this.personelEKleToolStripMenuItem.Size = new System.Drawing.Size(89, 19);
            this.personelEKleToolStripMenuItem.Text = "Personel EKle";
            // 
            // personelListeleGuncelleToolStripMenuItem
            // 
            this.personelListeleGuncelleToolStripMenuItem.Name = "personelListeleGuncelleToolStripMenuItem";
            this.personelListeleGuncelleToolStripMenuItem.Size = new System.Drawing.Size(168, 19);
            this.personelListeleGuncelleToolStripMenuItem.Text = "Personel Listele/Sil/Güncelle";
            // 
            // cikisYapToolStripMenuItem
            // 
            this.cikisYapToolStripMenuItem.Name = "cikisYapToolStripMenuItem";
            this.cikisYapToolStripMenuItem.Size = new System.Drawing.Size(66, 19);
            this.cikisYapToolStripMenuItem.Text = "Çıkış Yap";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(184)))), ((int)(((byte)(219)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 29);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Legend = "Legend1";
            series1.Name = "Kâr";
            series1.YValuesPerPoint = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.Legend = "Legend1";
            series2.Name = "Brüt Gelir";
            series2.YValuesPerPoint = 4;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1233, 668);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            title1.Name = "Satış Zamanı";
            this.chart1.Titles.Add(title1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1107, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Toplam Kar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToplamKar
            // 
            this.lblToplamKar.AutoSize = true;
            this.lblToplamKar.Location = new System.Drawing.Point(1107, 279);
            this.lblToplamKar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplamKar.Name = "lblToplamKar";
            this.lblToplamKar.Size = new System.Drawing.Size(89, 20);
            this.lblToplamKar.TabIndex = 16;
            this.lblToplamKar.Text = "Toplam Kar";
            this.lblToplamKar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBrutGelir
            // 
            this.lblBrutGelir.AutoSize = true;
            this.lblBrutGelir.Location = new System.Drawing.Point(1107, 198);
            this.lblBrutGelir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrutGelir.Name = "lblBrutGelir";
            this.lblBrutGelir.Size = new System.Drawing.Size(76, 20);
            this.lblBrutGelir.TabIndex = 18;
            this.lblBrutGelir.Text = "Brüt Gelir";
            this.lblBrutGelir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1082, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Toplam Brüt Gelir:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTopSatis
            // 
            this.lblTopSatis.AutoSize = true;
            this.lblTopSatis.Location = new System.Drawing.Point(1103, 359);
            this.lblTopSatis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTopSatis.Name = "lblTopSatis";
            this.lblTopSatis.Size = new System.Drawing.Size(101, 20);
            this.lblTopSatis.TabIndex = 20;
            this.lblTopSatis.Text = "Toplam Satış";
            this.lblTopSatis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1103, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Toplam Satış:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaslangic.Location = new System.Drawing.Point(1097, 436);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(121, 26);
            this.dtpBaslangic.TabIndex = 21;
            this.dtpBaslangic.Value = new System.DateTime(2021, 7, 1, 0, 0, 0, 0);
            this.dtpBaslangic.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpBitis
            // 
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBitis.Location = new System.Drawing.Point(1097, 510);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(121, 26);
            this.dtpBitis.TabIndex = 22;
            this.dtpBitis.Value = new System.DateTime(2021, 8, 1, 0, 0, 0, 0);
            this.dtpBitis.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1124, 475);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Arasında";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UrunSatisGrafikleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 697);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.lblTopSatis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBrutGelir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblToplamKar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UrunSatisGrafikleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Satış Grafikleri";
            this.Load += new System.EventHandler(this.UrunSatisGrafikleri_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem urunEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunleriListeleGuncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEKleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelListeleGuncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunSatisiToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblToplamKar;
        private System.Windows.Forms.Label lblBrutGelir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTopSatis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem urunSatislariniGosterToolStripMenuItem;
    }
}