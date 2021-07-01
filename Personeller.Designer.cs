
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
            ((System.ComponentModel.ISupportInitialize)(this.nudMaas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDegerler)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPersonelGuncelle
            // 
            this.btnPersonelGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPersonelGuncelle.Location = new System.Drawing.Point(509, 683);
            this.btnPersonelGuncelle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPersonelGuncelle.Name = "btnPersonelGuncelle";
            this.btnPersonelGuncelle.Size = new System.Drawing.Size(244, 78);
            this.btnPersonelGuncelle.TabIndex = 21;
            this.btnPersonelGuncelle.Text = "Personel Güncelle";
            this.btnPersonelGuncelle.UseVisualStyleBackColor = false;
            this.btnPersonelGuncelle.Click += new System.EventHandler(this.btnPersonelGuncelle_Click);
            // 
            // nudMaas
            // 
            this.nudMaas.DecimalPlaces = 2;
            this.nudMaas.Location = new System.Drawing.Point(841, 626);
            this.nudMaas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudMaas.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudMaas.Name = "nudMaas";
            this.nudMaas.Size = new System.Drawing.Size(327, 26);
            this.nudMaas.TabIndex = 20;
            this.nudMaas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudMaas.ThousandsSeparator = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(981, 559);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Maaşı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(577, 561);
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
            this.cbbMeslegi.Location = new System.Drawing.Point(464, 624);
            this.cbbMeslegi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbMeslegi.Name = "cbbMeslegi";
            this.cbbMeslegi.Size = new System.Drawing.Size(325, 28);
            this.cbbMeslegi.TabIndex = 18;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(843, 489);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(325, 26);
            this.txtSoyad.TabIndex = 15;
            this.txtSoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(975, 437);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Soyadı";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(464, 492);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(325, 26);
            this.txtAdi.TabIndex = 14;
            this.txtAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(594, 439);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Adı";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(59, 624);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(325, 26);
            this.txtSifre.TabIndex = 17;
            this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 559);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Şifre";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(59, 492);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(325, 26);
            this.txtKullaniciAdi.TabIndex = 13;
            this.txtKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 437);
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
            this.dgvDegerler.ColumnHeadersHeight = 30;
            this.dgvDegerler.Location = new System.Drawing.Point(27, 12);
            this.dgvDegerler.Name = "dgvDegerler";
            this.dgvDegerler.ReadOnly = true;
            this.dgvDegerler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDegerler.Size = new System.Drawing.Size(1204, 412);
            this.dgvDegerler.TabIndex = 36;
            this.dgvDegerler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDegerler_CellClick);
            // 
            // Personeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 796);
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
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.Personeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDegerler)).EndInit();
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
    }
}