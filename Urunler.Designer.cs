
namespace Optikci_Otomasyonu
{
    partial class Urunler
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
            this.dgvDegerler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDetay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.urunEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.nudFiyati = new System.Windows.Forms.NumericUpDown();
            this.nudStokSayisi = new System.Windows.Forms.NumericUpDown();
            this.btnResimDegistir = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDegerler)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStokSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDegerler
            // 
            this.dgvDegerler.AllowUserToAddRows = false;
            this.dgvDegerler.AllowUserToDeleteRows = false;
            this.dgvDegerler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDegerler.Location = new System.Drawing.Point(62, 32);
            this.dgvDegerler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDegerler.Name = "dgvDegerler";
            this.dgvDegerler.ReadOnly = true;
            this.dgvDegerler.Size = new System.Drawing.Size(755, 224);
            this.dgvDegerler.TabIndex = 0;
            this.dgvDegerler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDegerler_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(132, 300);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(623, 26);
            this.txtAdi.TabIndex = 2;
            this.txtAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 415);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stok Sayısı";
            // 
            // txtDetay
            // 
            this.txtDetay.Location = new System.Drawing.Point(132, 514);
            this.txtDetay.Multiline = true;
            this.txtDetay.Name = "txtDetay";
            this.txtDetay.Size = new System.Drawing.Size(623, 121);
            this.txtDetay.TabIndex = 8;
            this.txtDetay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 488);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Detay";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuncelle.Location = new System.Drawing.Point(450, 858);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(305, 41);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.urunEkleToolStripMenuItem,
            this.cikisYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // urunEkleToolStripMenuItem
            // 
            this.urunEkleToolStripMenuItem.Name = "urunEkleToolStripMenuItem";
            this.urunEkleToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.urunEkleToolStripMenuItem.Text = "Ürün Ekle";
            this.urunEkleToolStripMenuItem.Click += new System.EventHandler(this.urunEkleToolStripMenuItem_Click);
            // 
            // cikisYapToolStripMenuItem
            // 
            this.cikisYapToolStripMenuItem.Name = "cikisYapToolStripMenuItem";
            this.cikisYapToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cikisYapToolStripMenuItem.Text = "Çıkış Yap";
            this.cikisYapToolStripMenuItem.Click += new System.EventHandler(this.cikisYapToolStripMenuItem_Click);
            // 
            // pbResim
            // 
            this.pbResim.Location = new System.Drawing.Point(132, 646);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(623, 200);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 11;
            this.pbResim.TabStop = false;
            // 
            // nudFiyati
            // 
            this.nudFiyati.DecimalPlaces = 2;
            this.nudFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudFiyati.Location = new System.Drawing.Point(132, 373);
            this.nudFiyati.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudFiyati.Name = "nudFiyati";
            this.nudFiyati.Size = new System.Drawing.Size(623, 30);
            this.nudFiyati.TabIndex = 32;
            this.nudFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudFiyati.ThousandsSeparator = true;
            // 
            // nudStokSayisi
            // 
            this.nudStokSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nudStokSayisi.Location = new System.Drawing.Point(132, 451);
            this.nudStokSayisi.Name = "nudStokSayisi";
            this.nudStokSayisi.Size = new System.Drawing.Size(623, 30);
            this.nudStokSayisi.TabIndex = 31;
            this.nudStokSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnResimDegistir
            // 
            this.btnResimDegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnResimDegistir.Location = new System.Drawing.Point(279, 858);
            this.btnResimDegistir.Name = "btnResimDegistir";
            this.btnResimDegistir.Size = new System.Drawing.Size(165, 41);
            this.btnResimDegistir.TabIndex = 33;
            this.btnResimDegistir.Text = "Resmi Değiştir";
            this.btnResimDegistir.UseVisualStyleBackColor = false;
            this.btnResimDegistir.Click += new System.EventHandler(this.btnResimDegistir_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSil.Location = new System.Drawing.Point(132, 858);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(141, 41);
            this.btnSil.TabIndex = 34;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 911);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnResimDegistir);
            this.Controls.Add(this.nudFiyati);
            this.Controls.Add(this.nudStokSayisi);
            this.Controls.Add(this.pbResim);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtDetay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDegerler);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Urunler";
            this.Text = "Urunler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Urunler_FormClosing);
            this.Load += new System.EventHandler(this.Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDegerler)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFiyati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStokSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDegerler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDetay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem urunEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisYapToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.NumericUpDown nudFiyati;
        private System.Windows.Forms.NumericUpDown nudStokSayisi;
        private System.Windows.Forms.Button btnResimDegistir;
        private System.Windows.Forms.Button btnSil;
    }
}