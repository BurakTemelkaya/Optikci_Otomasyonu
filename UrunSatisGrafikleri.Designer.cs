
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.urunEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunleriListeleGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunSatisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEKleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListeleGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplamKar = new System.Windows.Forms.Label();
            this.lblBrutGelir = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 29);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Brüt Gelir";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Kâr";
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1233, 668);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            title2.Name = "Satış Zamanı";
            this.chart1.Titles.Add(title2);
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
            // UrunSatisGrafikleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 697);
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
    }
}