﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Optikci_Otomasyonu
{
    public partial class UrunSatis : Form
    {
        public UrunSatis()
        {
            InitializeComponent();
        }
        SqlBaglantisi baglan = new SqlBaglantisi();
        private void UrunSatis_Load(object sender, EventArgs e)
        {
            urunEkleToolStripMenuItem.Click += new EventHandler(FormIslemleri.UrunEkleOpen);
            urunleriListeleGuncelleToolStripMenuItem.Click += new EventHandler(FormIslemleri.UrunlerOpen);
            urunSatislariniGosterToolStripMenuItem.Click += new EventHandler(FormIslemleri.UrunSatislariOpen);
            urunSatisGrafikleriToolStripMenuItem.Click += new EventHandler(FormIslemleri.UrunSatisGrafikleriOpen);
            personelEKleToolStripMenuItem.Click += new EventHandler(FormIslemleri.PersonelEkleOpen);
            personelListeleGuncelleToolStripMenuItem.Click += new EventHandler(FormIslemleri.PersonellerOpen);
            cikisYapToolStripMenuItem.Click += new EventHandler(FormIslemleri.Close);
            this.FormClosing += new FormClosingEventHandler(FormIslemleri.FormClosing);
            UrunleriListele();
        }
        private void UrunleriListele()
        {
            string sorgu = "select ID, Urun_Adi as 'Ürun Adı',Urun_Fiyati as 'Fiyatı'," +
                "Urun_Stok_Sayisi as 'Stok Sayısı',Urun_Detay as 'Detay'," +
                "Urun_Fotograf as 'Fotoğrafı',Urun_Eklenme_Tarihi as 'Eklenme Tarihi'," +
                "Urun_Guncellenme_Tarihi as 'Güncellenme Tarihi' from Urunler";
            SqlDataAdapter adp = new SqlDataAdapter(sorgu, baglan.baglanti());
            DataSet ds = new DataSet();
            baglan.Open();
            adp.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)//veri varsa//dt.Rows.Count
            {
                dgvDegerler.DataSource = ds.Tables[0];
            }
            baglan.Close();
        }
        int ID;
        private void dgvDegerler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in dgvDegerler.SelectedRows)
            {
                ID = Convert.ToInt32(item.Cells[0].Value);
                txtAdi.Text = item.Cells[1].Value.ToString();
                nudFiyati.Value = Convert.ToDecimal(item.Cells[2].Value);                
                nudStokSayisi.Value = Convert.ToDecimal(item.Cells[3].Value);
                nudSatilacakStokSayisi.Maximum = Convert.ToDecimal(item.Cells[3].Value);
                txtDetay.Text = item.Cells[4].Value.ToString();
                pbResim.ImageLocation = Application.StartupPath + item.Cells[5].Value.ToString();
            }
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            if (ID != 0 && nudSatisFiyati.Value != 0 && nudSatilacakStokSayisi.Value != 0)
            {
                string sorgu = "insert into Satilan_Urunler(Satilan_Urun_ID,Satis_Fiyati," +
                "Satilan_Stok_Adedi,Satan_Kisi_ID,Satilan_Kisi,Satilma_Zamani)" +
                "values(@Satilan_Urun_ID,@Satis_Fiyati,@Satilan_Stok_Adedi,@Satan_Kisi_ID," +
                "@Satilan_Kisi,@Satilma_Zamani)";
                UrunStokGuncelleme();
                KayitIslemi(sorgu);                
                MessageBox.Show("Satış İşlemi Başarılı");
                Temizle();
            }
            else
            {
                MessageBox.Show("Ürün Satışı Yapılamadı. Girilen Değerlerden Herhangi Biri Boş Olamaz");
            }
        }
        private void KayitIslemi(string sorgu)
        {
            SqlCommand cmd = new SqlCommand(sorgu, baglan.baglanti());
            cmd.Parameters.AddWithValue("@Satilan_Urun_ID", ID);
            cmd.Parameters.AddWithValue("@Satis_Fiyati", nudSatisFiyati.Value);
            cmd.Parameters.AddWithValue("@Satilan_Stok_Adedi", nudSatilacakStokSayisi.Value);
            cmd.Parameters.AddWithValue("@Satan_Kisi_ID", GirisYap.Personel_ID);
            cmd.Parameters.AddWithValue("@Satilan_Kisi", txtSatilacakMusterininAdi.Text);
            cmd.Parameters.AddWithValue("@Satilma_Zamani", DateTime.Now);
            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
        }
        private void UrunStokGuncelleme()
        {
            string s = "update Urunler set Urun_Stok_Sayisi=@Urun_Stok_Sayisi where ID = '" + ID + "'";
            SqlCommand cmd = new SqlCommand(s, baglan.baglanti());
            cmd.Parameters.AddWithValue("@Urun_Stok_Sayisi", nudStokSayisi.Value - nudSatilacakStokSayisi.Value);
            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
        }
        private void Temizle()
        {
            txtAdi.Clear();
            txtDetay.Clear();
            txtSatilacakMusterininAdi.Clear();
            nudFiyati.Value = 0;
            nudSatilacakStokSayisi.Value = 0;
            nudSatisFiyati.Value = 0;
            nudStokSayisi.Value = 0;
        }
    }
}
