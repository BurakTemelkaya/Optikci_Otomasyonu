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
    public partial class GirisYap : Form
    {
        public GirisYap()
        {
            InitializeComponent();
        }
        string con = @"Data Source=DESKTOP-899RAQ8\SQLEXPRESS;Initial Catalog=Optikci;Integrated Security=True";
        int hak;
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection(con);
            baglan.Open();
            string sorgu = "select Personel_Kullanici_Adi,Personel_Sifre from Personeller where Personel_Kullanici_Adi='"+txtKullaniciAdi.Text+"' and Personel_Sifre='"+txtSifre.Text+"'";
            SqlCommand cmd = new SqlCommand(sorgu, baglan);
            SqlDataReader oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                Urunler urunler = new Urunler();                
                urunler.Show();
                this.Hide();
            }
            else
            {
                if (hak<10)
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı. Lütfen Tekrar Deneyiniz");
                    hak++;
                }
                else
                {
                    MessageBox.Show("Giriş Hakkınız Bitti. Program Kapatılıyor.");
                    Application.Exit();
                }               
            }
            oku.Close();
            baglan.Close();
        }

        private void GirisYap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();//tamamen çıkmak için kullanılan kod
        }
    }
}
