
namespace Optikci_Otomasyonu
{
    partial class Personeller
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
            this.btnPersonelGuncelle = new System.Windows.Forms.Button();
            this.nudMaas = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbMeslegi = new System.Windows.Forms.ComboBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDegerler = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunleriListeleGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunSatisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunSatislariniGosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunSatisGrafikleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTxtPersonelAra = new System.Windows.Forms.ToolStripTextBox();
            this.sifirlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDegerler)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPersonelGuncelle
            // 
            this.btnPersonelGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPersonelGuncelle.Location = new System.Drawing.Point(380, 642);
            this.btnPersonelGuncelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPersonelGuncelle.Name = "btnPersonelGuncelle";
            this.btnPersonelGuncelle.Size = new System.Drawing.Size(244, 60);
            this.btnPersonelGuncelle.TabIndex = 21;
            this.btnPersonelGuncelle.Text = "Personeli Güncelle";
            this.btnPersonelGuncelle.UseVisualStyleBackColor = false;
            this.btnPersonelGuncelle.Click += new System.EventHandler(this.btnPersonelGuncelle_Click);
            // 
            // nudMaas
            // 
            this.nudMaas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(139)))), ((int)(((byte)(129)))));
            this.nudMaas.DecimalPlaces = 2;
            this.nudMaas.Location = new System.Drawing.Point(662, 593);
            this.nudMaas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudMaas.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMaas.Name = "nudMaas";
            this.nudMaas.Size = new System.Drawing.Size(285, 26);
            this.nudMaas.TabIndex = 20;
            this.nudMaas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMaas.ThousandsSeparator = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(774, 543);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Maaşı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 543);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Mesleği";
            // 
            // cbbMeslegi
            // 
            this.cbbMeslegi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMeslegi.FormattingEnabled = true;
            this.cbbMeslegi.Items.AddRange(new object[] {
            "Müdür",
            "Müdür Yardımcısı",
            "Satış Müdürü",
            "Satış Müdür Yardımcısı",
            "Satış Uzmanı",
            "Satış Danışmanı",
            "Pazarlama Müdürü",
            "Pazarlama Uzmanı",
            "İnsan Kaynakları Müdürü",
            "İnsan Kaynakları Uzmanı"});
            this.cbbMeslegi.Location = new System.Drawing.Point(360, 593);
            this.cbbMeslegi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbMeslegi.Name = "cbbMeslegi";
            this.cbbMeslegi.Size = new System.Drawing.Size(283, 28);
            this.cbbMeslegi.TabIndex = 18;
            // 
            // txtSoyad
            // 
            this.txtSoyad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(139)))), ((int)(((byte)(129)))));
            this.txtSoyad.Location = new System.Drawing.Point(664, 494);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(283, 26);
            this.txtSoyad.TabIndex = 15;
            this.txtSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(768, 439);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Soyadı";
            // 
            // txtAdi
            // 
            this.txtAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(139)))), ((int)(((byte)(129)))));
            this.txtAdi.Location = new System.Drawing.Point(360, 494);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(283, 26);
            this.txtAdi.TabIndex = 14;
            this.txtAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 439);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Adı";
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(139)))), ((int)(((byte)(129)))));
            this.txtSifre.Location = new System.Drawing.Point(32, 595);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(283, 26);
            this.txtSifre.TabIndex = 17;
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 543);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Şifre";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(139)))), ((int)(((byte)(129)))));
            this.txtKullaniciAdi.Location = new System.Drawing.Point(32, 494);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(283, 26);
            this.txtKullaniciAdi.TabIndex = 13;
            this.txtKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 439);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // dgvDegerler
            // 
            this.dgvDegerler.AllowUserToAddRows = false;
            this.dgvDegerler.AllowUserToDeleteRows = false;
            this.dgvDegerler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(173)))), ((int)(((byte)(47)))));
            this.dgvDegerler.ColumnHeadersHeight = 30;
            this.dgvDegerler.Location = new System.Drawing.Point(27, 45);
            this.dgvDegerler.Name = "dgvDegerler";
            this.dgvDegerler.ReadOnly = true;
            this.dgvDegerler.Size = new System.Drawing.Size(945, 379);
            this.dgvDegerler.TabIndex = 36;
            this.dgvDegerler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDegerler_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEkleToolStripMenuItem,
            this.urunEkleToolStripMenuItem,
            this.urunleriListeleGuncelleToolStripMenuItem,
            this.urunSatisiToolStripMenuItem,
            this.urunSatislariniGosterToolStripMenuItem,
            this.urunSatisGrafikleriToolStripMenuItem,
            this.cikisYapToolStripMenuItem,
            this.toolStripTxtPersonelAra,
            this.sifirlaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 27);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personelEkleToolStripMenuItem
            // 
            this.personelEkleToolStripMenuItem.Name = "personelEkleToolStripMenuItem";
            this.personelEkleToolStripMenuItem.Size = new System.Drawing.Size(88, 23);
            this.personelEkleToolStripMenuItem.Text = "Personel Ekle";
            // 
            // urunEkleToolStripMenuItem
            // 
            this.urunEkleToolStripMenuItem.Name = "urunEkleToolStripMenuItem";
            this.urunEkleToolStripMenuItem.Size = new System.Drawing.Size(69, 23);
            this.urunEkleToolStripMenuItem.Text = "Ürün Ekle";
            // 
            // urunleriListeleGuncelleToolStripMenuItem
            // 
            this.urunleriListeleGuncelleToolStripMenuItem.Name = "urunleriListeleGuncelleToolStripMenuItem";
            this.urunleriListeleGuncelleToolStripMenuItem.Size = new System.Drawing.Size(165, 23);
            this.urunleriListeleGuncelleToolStripMenuItem.Text = "Ürunleri Listele/Güncelle/Sil";
            // 
            // urunSatisiToolStripMenuItem
            // 
            this.urunSatisiToolStripMenuItem.Name = "urunSatisiToolStripMenuItem";
            this.urunSatisiToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.urunSatisiToolStripMenuItem.Text = "Ürün Satışı";
            // 
            // urunSatislariniGosterToolStripMenuItem
            // 
            this.urunSatislariniGosterToolStripMenuItem.Name = "urunSatislariniGosterToolStripMenuItem";
            this.urunSatislariniGosterToolStripMenuItem.Size = new System.Drawing.Size(135, 23);
            this.urunSatislariniGosterToolStripMenuItem.Text = "Ürün Satışlarını Göster";
            // 
            // urunSatisGrafikleriToolStripMenuItem
            // 
            this.urunSatisGrafikleriToolStripMenuItem.Name = "urunSatisGrafikleriToolStripMenuItem";
            this.urunSatisGrafikleriToolStripMenuItem.Size = new System.Drawing.Size(122, 23);
            this.urunSatisGrafikleriToolStripMenuItem.Text = "Ürün Satış Grafikleri";
            // 
            // cikisYapToolStripMenuItem
            // 
            this.cikisYapToolStripMenuItem.Name = "cikisYapToolStripMenuItem";
            this.cikisYapToolStripMenuItem.Size = new System.Drawing.Size(66, 23);
            this.cikisYapToolStripMenuItem.Text = "Çıkış Yap";
            // 
            // toolStripTxtPersonelAra
            // 
            this.toolStripTxtPersonelAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toolStripTxtPersonelAra.Name = "toolStripTxtPersonelAra";
            this.toolStripTxtPersonelAra.Size = new System.Drawing.Size(100, 23);
            this.toolStripTxtPersonelAra.Text = "Personel Ara";
            this.toolStripTxtPersonelAra.Leave += new System.EventHandler(this.toolStripTxtPersonelAra_Leave);
            this.toolStripTxtPersonelAra.Click += new System.EventHandler(this.toolStripTxtPersonelAra_Click);
            this.toolStripTxtPersonelAra.TextChanged += new System.EventHandler(this.toolStripTxtPersonelAra_TextChanged);
            // 
            // sifirlaToolStripMenuItem
            // 
            this.sifirlaToolStripMenuItem.Name = "sifirlaToolStripMenuItem";
            this.sifirlaToolStripMenuItem.Size = new System.Drawing.Size(48, 23);
            this.sifirlaToolStripMenuItem.Text = "Sıfırla";
            this.sifirlaToolStripMenuItem.Click += new System.EventHandler(this.sifirlaToolStripMenuItem_Click);
            // 
            // Personeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(95)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(984, 716);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvDegerler);
            this.Controls.Add(this.btnPersonelGuncelle);
            this.Controls.Add(this.nudMaas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbMeslegi);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Personeller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.Personeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDegerler)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPersonelGuncelle;
        private System.Windows.Forms.NumericUpDown nudMaas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbMeslegi;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDegerler;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem urunEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunleriListeleGuncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunSatisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunSatisGrafikleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTxtPersonelAra;
        private System.Windows.Forms.ToolStripMenuItem sifirlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunSatislariniGosterToolStripMenuItem;
    }
}