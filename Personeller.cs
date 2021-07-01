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
    public partial class Personeller : Form
    {
        public Personeller()
        {
            InitializeComponent();
        }
        SqlBaglantisi baglan = new SqlBaglantisi();
        private void Personeller_Load(object sender, EventArgs e)
        {
            PersonelleriListele();
            FormIslemleri formIslemleri = new FormIslemleri();
            urunleriListeleGuncelleToolStripMenuItem.Click += new EventHandler(FormuKapat);
            urunEkleToolStripMenuItem.Click += new EventHandler(FormuKapat);
            urunSatisiToolStripMenuItem.Click += new EventHandler(FormuKapat);
            personelEkleToolStripMenuItem.Click += new EventHandler(FormuKapat);

            urunleriListeleGuncelleToolStripMenuItem.Click += new EventHandler(formIslemleri.UrunlerOpen);
            urunEkleToolStripMenuItem.Click += new EventHandler(formIslemleri.UrunEkleOpen);
            urunSatisiToolStripMenuItem.Click += new EventHandler(formIslemleri.UrunSatisOpen);
            personelEkleToolStripMenuItem.Click += new EventHandler(formIslemleri.PersonelEkleOpen);
        }
        private void FormuKapat(object s, EventArgs e)
        {
            this.Hide();
        }
        private void PersonelleriListele()
        {
            string sorgu = "select ID,Personel_Kullanici_Adi as 'Kullanıcı Adı',Personel_Sifre as 'Şifre'," +
            "Personel_Adi as 'Ad',Personel_Soyad as 'Soyad',Personel_Meslek as 'Meslek'," +
            "Personel_Maas as 'Maaş',Personel_Giris_Tarihi as 'Personel Giriş Tarihi' from Personeller";
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
                txtKullaniciAdi.Text = item.Cells[1].Value.ToString();
                txtSifre.Text= item.Cells[2].Value.ToString();
                txtAdi.Text = item.Cells[3].Value.ToString();
                txtSoyad.Text= item.Cells[4].Value.ToString();
                cbbMeslegi.Text = item.Cells[5].Value.ToString();
                nudMaas.Value= Convert.ToDecimal(item.Cells[6].Value);
            }
        }

        private void btnPersonelGuncelle_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                string s = "update Personeller set Personel_Kullanici_Adi=@Personel_Kullanici_Adi,Personel_Sifre=@Personel_Sifre," +
                "Personel_Adi=@Personel_Adi,Personel_Soyad=@Personel_Soyad,Personel_Meslek=@Personel_Meslek," +
                "Personel_Maas=@Personel_Maas where ID = '" + ID + "'";
                SqlCommand cmd = new SqlCommand(s, baglan.baglanti());
                cmd.Parameters.AddWithValue("@Personel_Kullanici_Adi", txtKullaniciAdi.Text);
                cmd.Parameters.AddWithValue("@Personel_Sifre", txtSifre.Text);
                cmd.Parameters.AddWithValue("@Personel_Adi", txtAdi.Text);
                cmd.Parameters.AddWithValue("@Personel_Soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@Personel_Meslek", cbbMeslegi.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@Personel_Maas", nudMaas.Value);
                baglan.Open();
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Güncelleme İşlemi Başarılı");
                PersonelleriListele();
            }
            else
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz");
            }
        }

        private void Personeller_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
