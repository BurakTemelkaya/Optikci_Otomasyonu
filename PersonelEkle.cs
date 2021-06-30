using System;
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
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection(@"Data Source =DESKTOP-899RAQ8\SQLEXPRESS; Initial Catalog = Optikci; Integrated Security = True");

        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            cbbMeslegi.SelectedIndex = 0;
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text != "" && nudMaas.Value != 0 && txtAdi.Text != "" && txtSoyad.Text != "" && txtSifre.Text!="")
            {
                string sorgu = "insert into Personeller(Personel_Kullanici_Adi,Personel_Sifre," +
                    "Personel_Adi,Personel_Soyad,Personel_Meslek,Personel_Maas,Personel_Giris_Tarihi)" +
                    " values (@Personel_Kullanici_Adi,@Personel_Sifre,@Personel_Adi,@Personel_Soyad," +
                    "@Personel_Meslek,@Personel_Maas,@Personel_Giris_Tarihi)";
                KayitIslemi(sorgu);
                Temizle();
            }
            else
            {
                MessageBox.Show("Ürün Eklenemedi Girilen Değerlerden Herhangi Biri Boş Olamaz");
            }
        }

        private void KayitIslemi(string sorgu)
        {
            SqlCommand cmd = new SqlCommand(sorgu, baglan);
            cmd.Parameters.AddWithValue("@Personel_Kullanici_Adi", txtKullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@Personel_Sifre", txtSifre.Text);
            cmd.Parameters.AddWithValue("@Personel_Adi", txtAdi.Text);            
            cmd.Parameters.AddWithValue("@Personel_Soyad",txtSoyad.Text);
            cmd.Parameters.AddWithValue("@Personel_Meslek", cbbMeslegi.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Personel_Maas", nudMaas.Value);
            cmd.Parameters.AddWithValue("@Personel_Giris_Tarihi", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
            if (baglan.State == ConnectionState.Closed)
            {
                baglan.Open();
            }
            cmd.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Personel Ekleme İşlemi Başarıyla Tamamlandı.");
        }

        private void Temizle()
        {
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
            txtAdi.Clear();
            txtSoyad.Clear();
            cbbMeslegi.SelectedIndex = 0;
            nudMaas.Value = 0;
        }
        private void urunEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urunler urunler = new Urunler();
            this.Hide();
            urunler.Show();
        }

        private void urunleriListeleGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urunler urunler = new Urunler();
            this.Hide();
            urunler.Show();
        }

        private void PersonelEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
