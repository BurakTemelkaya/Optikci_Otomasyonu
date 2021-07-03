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
    public partial class UrunSatisGrafikleri : Form
    {
        public UrunSatisGrafikleri()
        {
            InitializeComponent();
        }
        SqlBaglantisi baglan = new SqlBaglantisi();
        private void UrunSatisGrafikleri_Load(object sender, EventArgs e)
        {
            urunleriListeleGuncelleToolStripMenuItem.Click += new EventHandler(FormuKapat);
            urunEkleToolStripMenuItem.Click += new EventHandler(FormuKapat);
            personelEKleToolStripMenuItem.Click += new EventHandler(FormuKapat);
            personelListeleGuncelleToolStripMenuItem.Click += new EventHandler(FormuKapat);
            urunSatisiToolStripMenuItem.Click += new EventHandler(FormuKapat);

            urunleriListeleGuncelleToolStripMenuItem.Click += new EventHandler(FormIslemleri.UrunlerOpen);
            urunEkleToolStripMenuItem.Click += new EventHandler(FormIslemleri.UrunEkleOpen);
            urunSatisiToolStripMenuItem.Click += new EventHandler(FormIslemleri.UrunSatisOpen);
            personelEKleToolStripMenuItem.Click += new EventHandler(FormIslemleri.PersonelEkleOpen);
            personelListeleGuncelleToolStripMenuItem.Click += new EventHandler(FormIslemleri.PersonellerOpen);
            GrafikGetir();
        }
        private void FormuKapat(object s, EventArgs e)
        {
            this.Hide();
        }
        private void cikisYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void UrunSatisGrafikleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void GrafikGetir()
        {
            int brut = 0;
            int kar = 0;
            int toplamBrut = 0;
            int toplamKar = 0;
            int toplamUrun=0;
            int adet = 0;
            int satisFiyat = 0;
            int alisFiyat = 0;
            string UrununAdi = "";
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select ur.Urun_Adi,ur.Urun_Fiyati,sa.Satis_Fiyati," +
            "sa.Satilan_Stok_Adedi,sa.Satan_Kisi_ID,sa.Satilma_Zamani" +
            " from Urunler ur" +
            " inner join Satilan_Urunler sa on ur.ID = sa.Satilan_Urun_ID ", baglan.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                alisFiyat= Convert.ToInt32(oku[1]);
                satisFiyat = Convert.ToInt32(oku[2]);
                adet = Convert.ToInt32(oku[3]);
                UrununAdi = oku[0].ToString();
                brut = satisFiyat * adet;
                kar = (satisFiyat - alisFiyat) * adet;
                toplamBrut += brut;
                toplamKar += kar;
                chart1.Series["Kâr"].Points.AddXY(UrununAdi , kar);
                chart1.Series["Brüt Gelir"].Points.AddXY(UrununAdi + oku[5].ToString(), brut);
                toplamUrun++;
            }
            lblBrutGelir.Text = toplamBrut.ToString();
            lblToplamKar.Text = toplamKar.ToString();
            baglan.Close();
        }
    }
}
