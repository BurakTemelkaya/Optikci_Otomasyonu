using System;
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
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }
        SqlBaglantisi baglan = new SqlBaglantisi();
        string resimYolu;
        private void btnResimEkle_Click(object sender, EventArgs e)
        {            
            OpenFileDialog resim = new OpenFileDialog();
            resim.Filter = "Resim Dosyaları(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (resim.ShowDialog() == DialogResult.OK)//dosya seçildi mi ?
            {                
                pbResim.ImageLocation = resim.FileName;
            }
        }
        //@"~Resimler\
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if (txtAdi.Text != "" && nudFiyati.Value != 0 && nudStokSayisi.Value != 0 && pbResim.Image != null)
            {
                ResmiKaydet();
                string sorgu = "insert into Urunler(Urun_Adi,Urun_Fiyati,Urun_Stok_Sayisi,Urun_Detay,Urun_Fotograf,Urun_Eklenme_Tarihi)" +
                " values (@Urun_Adi,@Urun_Fiyati,@Urun_Stok_Sayisi,@Urun_Detay,@Urun_Fotograf,@Urun_Eklenme_Tarihi)";
                KayitIslemi(sorgu);
                Temizle();
                MessageBox.Show("Ürün Eklendi");
            }
            else
            {
                MessageBox.Show("Ürün Eklenemedi Girilen Değerlerden Herhangi Biri Boş Olamaz");
            }

        }
        private void ResmiKaydet()
        {
            string dosyaYolu = pbResim.ImageLocation;
            string dosyaAdi = Path.GetFileName(dosyaYolu); //Dosya adını alma
            string kaynak = dosyaYolu;
            string hedef = Application.StartupPath + @"\Resimler\";
            string yeniad = Guid.NewGuid() + dosyaAdi; //Benzersiz isim verme
            File.Copy(kaynak, hedef + yeniad);
            resimYolu = @"\Resimler\" + yeniad;//veritabanına kaydedilecek resmin ismi
        }
        private void KayitIslemi(string sorgu)
        {
            SqlCommand cmd = new SqlCommand(sorgu, baglan.baglanti());
            cmd.Parameters.AddWithValue("@Urun_Adi", txtAdi.Text);
            cmd.Parameters.AddWithValue("@Urun_Fiyati", nudFiyati.Value);
            cmd.Parameters.AddWithValue("@Urun_Stok_Sayisi", nudStokSayisi.Value);
            cmd.Parameters.AddWithValue("@Urun_Detay", txtDetay.Text);
            cmd.Parameters.AddWithValue("@Urun_Fotograf", resimYolu);
            cmd.Parameters.AddWithValue("@Urun_Eklenme_Tarihi", DateTime.Now);
            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
        }
        private void Temizle()
        {
            txtAdi.Clear();
            nudFiyati.Value = 0;
            nudStokSayisi.Value = 0;
            txtDetay.Clear();
            if (pbResim.Image != null)
            {
                pbResim.Image.Dispose();
                pbResim.Image = null;
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            urunleriListeleGuncelleToolStripMenuItem.Click += new EventHandler(FormIslemleri.UrunlerOpen);
            urunSatisiToolStripMenuItem.Click += new EventHandler(FormIslemleri.UrunSatisOpen);
            urunSatislariniGosterToolStripMenuItem.Click += new EventHandler(FormIslemleri.UrunSatislariOpen);
            urunSatisGrafikleriToolStripMenuItem.Click += new EventHandler(FormIslemleri.UrunSatisGrafikleriOpen);
            personelEkleToolStripMenuItem.Click += new EventHandler(FormIslemleri.PersonelEkleOpen);
            personelListeleGuncelleToolStripMenuItem.Click += new EventHandler(FormIslemleri.PersonellerOpen);
            cikisYapToolStripMenuItem.Click += new EventHandler(FormIslemleri.Close);
            this.FormClosing += new FormClosingEventHandler(FormIslemleri.FormClosing);
        }
    }
}
