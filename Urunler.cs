﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Optikci_Otomasyonu
{
    public partial class Urunler : Form
    {
        SqlBaglantisi baglan = new SqlBaglantisi();
        string EskiResimYolu, YeniResimYolu;
        bool ResimDegistiMi;
        public Urunler()
        {
            InitializeComponent();
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            urunEkleToolStripMenuItem.Click += new EventHandler(FormIslemleri.UrunEkleOpen);
            urunSatisiToolStripMenuItem.Click += new EventHandler(FormIslemleri.UrunSatisOpen);
            urunSatislariniGosterToolStripMenuItem.Click += new EventHandler(FormIslemleri.UrunSatislariOpen);
            urunSatisGrafikleriToolStripMenuItem.Click += new EventHandler(FormIslemleri.UrunSatisGrafikleriOpen);
            personelEkleToolStripMenuItem.Click += new EventHandler(FormIslemleri.PersonelEkleOpen);
            personelListeleGuncelleToolStripMenuItem.Click += new EventHandler(FormIslemleri.PersonellerOpen);
            cikisYapToolStripMenuItem.Click += new EventHandler(FormIslemleri.Close);
            this.FormClosing += new FormClosingEventHandler(FormIslemleri.FormClosing);
            UrunleriListele();
        }
        private void UrunleriListele()
        {
            //bütün ürünleri listeleme sorgusu
            string sorgu = "select ID, Urun_Adi as 'Ürun Adı',Urun_Fiyati as 'Fiyatı'," +
                "Urun_Stok_Sayisi as 'Stok Sayısı',Urun_Detay as 'Detay'," +
                "Urun_Fotograf as 'Ürünün Fotoğrafı',Urun_Eklenme_Tarihi as 'Eklenme Tarihi'," +
                "Urun_Guncellenme_Tarihi as 'Güncellenme Tarihi' from Urunler";
            Listele(sorgu);
        }
        private void Listele(string sorgu)
        {
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
        private int ID;

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (ID != 0 && txtAdi.Text != "" && txtDetay.Text != "")
            {
                string s = "update Urunler set Urun_Adi=@Urun_Adi,Urun_Fiyati=@Urun_Fiyati," +
                "Urun_Stok_Sayisi=@Urun_Stok_Sayisi,Urun_Detay=@Urun_Detay,Urun_Fotograf=@Urun_Fotograf," +
                "Urun_Guncellenme_Tarihi=@Urun_Guncellenme_Tarihi where ID = '" + ID + "'";
                SqlCommand cmd = new SqlCommand(s, baglan.baglanti());
                cmd.Parameters.AddWithValue("@Urun_Adi", txtAdi.Text);
                cmd.Parameters.AddWithValue("@Urun_Fiyati", nudFiyati.Value);
                cmd.Parameters.AddWithValue("@Urun_Stok_Sayisi", nudStokSayisi.Value);
                cmd.Parameters.AddWithValue("@Urun_Detay", txtDetay.Text);
                if (ResimDegistiMi)
                {
                    ResmiGuncelle(EskiResimYolu);
                    cmd.Parameters.AddWithValue("@Urun_Fotograf", YeniResimYolu);
                    ResimDegistiMi = false;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Urun_Fotograf", EskiResimYolu);
                }
                cmd.Parameters.AddWithValue("@Urun_Guncellenme_Tarihi", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
                baglan.Open();
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Güncelleme İşlemi Başarılı");
                UrunleriListele();
                Temizle();
            }
            else
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz");
            }
        }

        private void btnResimDegistir_Click(object sender, EventArgs e)
        {
            OpenFileDialog resim = new OpenFileDialog();
            resim.Filter = "Resim Dosyaları(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (resim.ShowDialog() == DialogResult.OK)//dosya seçildi mi ?
            {
                pbResim.ImageLocation = resim.FileName;
                ResimDegistiMi = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                ResmiSil(EskiResimYolu);
                string s = "delete from Urunler where ID = '" + ID + "'";
                SqlCommand cmd = new SqlCommand(s, baglan.baglanti());
                DialogResult c = new DialogResult();
                c = MessageBox.Show("Ürünü Silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (c == DialogResult.Yes)
                {
                    baglan.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ürün Silindi");
                    baglan.Close();
                    Temizle();                    
                }
                pbResim.Image = null;
                UrunleriListele();
            }
            else
            {
                MessageBox.Show("Lütfen Silinecek Ürünü Seçiniz");
            }
        }

        private void personelEKleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelEkle personelEkle = new PersonelEkle();
            this.Hide();
            personelEkle.Show();
        }

        private void dgvDegerler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in dgvDegerler.SelectedRows)
            {
                ID = Convert.ToInt32(item.Cells[0].Value);
                txtAdi.Text = item.Cells[1].Value.ToString();
                nudFiyati.Value = Convert.ToDecimal(item.Cells[2].Value);
                nudStokSayisi.Value = Convert.ToDecimal(item.Cells[3].Value);
                txtDetay.Text = item.Cells[4].Value.ToString();
                pbResim.ImageLocation = Application.StartupPath + item.Cells[5].Value.ToString();
                EskiResimYolu = item.Cells[5].Value.ToString();
            }
        }

        private void ResmiGuncelle(string eskiResim)
        {
            try
            {
                ResmiSil(eskiResim);//eski resmi sildirme
            }
            catch
            {
                ;
            }
            finally
            {
                //eski resim silinsede silinmesede kopyalama işlemi yapılacak.
                string kaynak = pbResim.ImageLocation;//dosya yolunu alma
                string dosyaAdi = Path.GetFileName(kaynak); //Dosya adını alma
                string hedef = Application.StartupPath + @"\Resimler\";
                string yeniad = Guid.NewGuid() + dosyaAdi; //Benzersiz isim verme
                File.Copy(kaynak, hedef + yeniad);//resmi kopyalama
                YeniResimYolu = @"\Resimler\" + yeniad;//veritabanına kaydedilecek resmin konumu
                /////////////
                //Application.StartupPath kodu projenin bin\debug dosyasının konumudur. Her projede
                //programın konumu değişiklik göstereceği için resmi veya dosyayı çağırırken
                //bu kodu başa yazıyoruz.
            }
        }
        private void ResmiSil(string eskiResim)
        {
            File.Delete(Application.StartupPath + eskiResim);//resmi sildirme
        }

        private void toolStriptxtUrunAra_TextChanged(object sender, EventArgs e)
        {
            //ürün adına göre listeleme sorgusu
            string sorgu = "select ID, Urun_Adi as 'Ürun Adı',Urun_Fiyati as 'Ürün Fiyatı'," +
                "Urun_Stok_Sayisi as 'Ürünün Stok Sayısı',Urun_Detay as 'Ürün Detay'," +
                "Urun_Fotograf as 'Ürünün Fotoğrafı',Urun_Eklenme_Tarihi as 'Ürünün Eklenme Tarihi'," +
                "Urun_Guncellenme_Tarihi as 'Ürünün Güncellenme Tarihi' from Urunler " +
                "where Urun_Adi like '%" + toolStriptxtUrunAra.Text + "%'";
            Listele(sorgu);
        }

        private void toolStriptxtUrunAra_Leave(object sender, EventArgs e)
        {
            toolStriptxtUrunAra.Text = "Ürün Ara";
        }

        private void toolStripSifirla_Click(object sender, EventArgs e)
        {
            UrunleriListele();
        }

        private void toolStriptxtUrunAra_Click(object sender, EventArgs e)
        {
            toolStriptxtUrunAra.Clear();
        }
        private void Temizle()
        {
            txtAdi.Clear();
            txtDetay.Clear();
            nudFiyati.Value = 0;
            nudStokSayisi.Value = 0;
            pbResim.Image = null;
            ID = 0;
        }
    }
}
