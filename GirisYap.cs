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
        int hak;
        public static int Personel_ID;
        SqlBaglantisi baglan = new SqlBaglantisi();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text!="" && txtSifre.Text!="")
            {
                string sorgu = "select ID,Personel_Kullanici_Adi,Personel_Sifre,Personel_Meslek from Personeller where Personel_Kullanici_Adi='" + txtKullaniciAdi.Text + "'";
                SqlCommand cmd = new SqlCommand(sorgu, baglan.baglanti());
                baglan.Open();
                SqlDataReader oku = cmd.ExecuteReader();
                if (oku.Read())
                {
                    if (txtSifre.Text == oku[2].ToString())
                    {
                        Personel_ID = Convert.ToInt32(oku[0]);
                        FormIslemleri.Meslek = oku[3].ToString();
                        Urunler urunler = new Urunler();
                        FormIslemleri.ClosingForm = urunler;
                        urunler.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Şifreniz Hatalı Lütfen Tekrar Deneyin");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı adınız hatalı. Lütfen Tekrar Deneyiniz");
                    hak++;
                }
                if (hak > 9)
                {
                    MessageBox.Show("Giriş Yapma Hakkınız Bitti Program Kapatılıyor...");
                }
                oku.Close();
                baglan.Close();
            }
            else if (txtKullaniciAdi.Text=="")
            {
                MessageBox.Show("Lütfen Kullanıcı Adını Boş Bırakmayın.");
            }
            else
            {
                MessageBox.Show("Lütfen Şifreyi Boş Bırakmayın");
            }            
        }

        private void GirisYap_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(FormIslemleri.FormClosing);
        }
    }
}
