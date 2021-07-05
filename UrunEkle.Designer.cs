
namespace Optikci_Otomasyonu
{
    partial class UrunEkle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.nudFiyati = new System.Windows.Forms.NumericUpDown();
            this.nudStokSayisi = new System.Windows.Forms.NumericUpDown();
            this.btnResimEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.txtDetay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.urunleriListeleGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunSatisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunSatislariniGosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunSatisGrafikleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListeleGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStokSayisi)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.pbResim);
            this.panel1.Controls.Add(this.nudFiyati);
            this.panel1.Controls.Add(this.nudStokSayisi);
            this.panel1.Controls.Add(this.btnResimEkle);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnUrunEkle);
            this.panel1.Controls.Add(this.txtDetay);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAdi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(103, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 908);
            this.panel1.TabIndex = 19;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(108)))), ((int)(((byte)(143)))));
            this.btnTemizle.Location = new System.Drawing.Point(549, 842);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(244, 41);
            this.btnTemizle.TabIndex = 32;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(170, 518);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(623, 237);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 31;
            this.pbResim.TabStop = false;
            // 
            // nudFiyati
            // 
            this.nudFiyati.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(172)))), ((int)(((byte)(68)))));
            this.nudFiyati.DecimalPlaces = 2;
            this.nudFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudFiyati.Location = new System.Drawing.Point(170, 200);
            this.nudFiyati.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudFiyati.Name = "nudFiyati";
            this.nudFiyati.Size = new System.Drawing.Size(623, 30);
            this.nudFiyati.TabIndex = 30;
            this.nudFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudFiyati.ThousandsSeparator = true;
            // 
            // nudStokSayisi
            // 
            this.nudStokSayisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(172)))), ((int)(((byte)(68)))));
            this.nudStokSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudStokSayisi.Location = new System.Drawing.Point(170, 286);
            this.nudStokSayisi.Name = "nudStokSayisi";
            this.nudStokSayisi.Size = new System.Drawing.Size(623, 30);
            this.nudStokSayisi.TabIndex = 29;
            this.nudStokSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnResimEkle
            // 
            this.btnResimEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(173)))), ((int)(((byte)(52)))));
            this.btnResimEkle.Location = new System.Drawing.Point(241, 775);
            this.btnResimEkle.Name = "btnResimEkle";
            this.btnResimEkle.Size = new System.Drawing.Size(487, 41);
            this.btnResimEkle.TabIndex = 28;
            this.btnResimEkle.Text = "Resim Ekle";
            this.btnResimEkle.UseVisualStyleBackColor = false;
            this.btnResimEkle.Click += new System.EventHandler(this.btnResimEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(375, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 39);
            this.label5.TabIndex = 20;
            this.label5.Text = "ÜRÜN EKLE";
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.btnUrunEkle.Location = new System.Drawing.Point(170, 842);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(373, 41);
            this.btnUrunEkle.TabIndex = 27;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = false;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // txtDetay
            // 
            this.txtDetay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(172)))), ((int)(((byte)(68)))));
            this.txtDetay.Location = new System.Drawing.Point(170, 375);
            this.txtDetay.Multiline = true;
            this.txtDetay.Name = "txtDetay";
            this.txtDetay.Size = new System.Drawing.Size(623, 121);
            this.txtDetay.TabIndex = 26;
            this.txtDetay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "DETAY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "STOK SAYISI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "FİYATI";
            // 
            // txtAdi
            // 
            this.txtAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(172)))), ((int)(((byte)(68)))));
            this.txtAdi.Location = new System.Drawing.Point(170, 119);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(623, 26);
            this.txtAdi.TabIndex = 20;
            this.txtAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "ADI";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urunleriListeleGuncelleToolStripMenuItem,
            this.urunSatisiToolStripMenuItem,
            this.urunSatislariniGosterToolStripMenuItem,
            this.urunSatisGrafikleriToolStripMenuItem,
            this.personelEkleToolStripMenuItem,
            this.personelListeleGuncelleToolStripMenuItem,
            this.cikisYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // urunleriListeleGuncelleToolStripMenuItem
            // 
            this.urunleriListeleGuncelleToolStripMenuItem.Name = "urunleriListeleGuncelleToolStripMenuItem";
            this.urunleriListeleGuncelleToolStripMenuItem.Size = new System.Drawing.Size(148, 20);
            this.urunleriListeleGuncelleToolStripMenuItem.Text = "Ürunleri Listele/Güncelle";
            // 
            // urunSatisiToolStripMenuItem
            // 
            this.urunSatisiToolStripMenuItem.Name = "urunSatisiToolStripMenuItem";
            this.urunSatisiToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.urunSatisiToolStripMenuItem.Text = "Ürün Satışı";
            // 
            // urunSatislariniGosterToolStripMenuItem
            // 
            this.urunSatislariniGosterToolStripMenuItem.Name = "urunSatislariniGosterToolStripMenuItem";
            this.urunSatislariniGosterToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.urunSatislariniGosterToolStripMenuItem.Text = "Ürün Satışlarını Göster";
            // 
            // urunSatisGrafikleriToolStripMenuItem
            // 
            this.urunSatisGrafikleriToolStripMenuItem.Name = "urunSatisGrafikleriToolStripMenuItem";
            this.urunSatisGrafikleriToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.urunSatisGrafikleriToolStripMenuItem.Text = "Ürün Satış Grafikleri";
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.personelEkleToolStripMenuItem.Text = "Personel Ekle";
            // 
            // personelListeleGuncelleToolStripMenuItem
            // 
            this.personelListeleGuncelleToolStripMenuItem.Name = "personelListeleGuncelleToolStripMenuItem";
            this.personelListeleGuncelleToolStripMenuItem.Size = new System.Drawing.Size(168, 20);
            this.personelListeleGuncelleToolStripMenuItem.Text = "Personel Listele/Sil/Güncelle";
            // 
            // cikisYapToolStripMenuItem
            // 
            this.cikisYapToolStripMenuItem.Name = "cikisYapToolStripMenuItem";
            this.cikisYapToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cikisYapToolStripMenuItem.Text = "Çıkış Yap";
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(92)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1200, 932);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürun Ekle";
            this.Load += new System.EventHandler(this.UrunEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStokSayisi)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.TextBox txtDetay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudFiyati;
        private System.Windows.Forms.NumericUpDown nudStokSayisi;
        private System.Windows.Forms.Button btnResimEkle;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem urunleriListeleGuncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelListeleGuncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunSatisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunSatisGrafikleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunSatislariniGosterToolStripMenuItem;
    }
}