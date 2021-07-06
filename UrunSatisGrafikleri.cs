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
            urunleriListeleGuncelleToolStripMenuItem.Click += new EventHandler(FormIslemleri.UrunlerOpen);
            urunEkleToolStripMenuItem.Click += new EventHandler(FormIslemleri.UrunEkleOpen);
            urunSatisiToolStripMenuItem.Click += new EventHandler(FormIslemleri.UrunSatisOpen);
            urunSatislariniGosterToolStripMenuItem.Click += new EventHandler(FormIslemleri.UrunSatislariOpen);
            personelEKleToolStripMenuItem.Click += new EventHandler(FormIslemleri.PersonelEkleOpen);
            personelListeleGuncelleToolStripMenuItem.Click += new EventHandler(FormIslemleri.PersonellerOpen);
            cikisYapToolStripMenuItem.Click += new EventHandler(FormIslemleri.Close);
            this.FormClosing += new FormClosingEventHandler(FormIslemleri.FormClosing);
            dtpBaslangic.Value = DateTime.Now;
            dtpBitis.Value = DateTime.Now.AddMonths(1);
            GrafikGetir();
        }
        private void GrafikGetir()
        {           
            ChartClear();            
            int toplamBrut = 0;
            int toplamKar = 0;
            int toplamUrun = 0;
            int adet = 0;
            int satisFiyat = 0;
            int alisFiyat = 0;
            int topSatis = 0;
            string UrununAdi = "";
            DateTime tarih;
            DateTime baslangic = Convert.ToDateTime(dtpBitis.Value);
            DateTime bitis = Convert.ToDateTime(dtpBaslangic.Value);
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select ur.Urun_Adi,ur.Urun_Fiyati,sa.Satis_Fiyati," +
            "sa.Satilan_Stok_Adedi,sa.Satan_Kisi_ID,sa.Satilma_Zamani" +
            " from Urunler ur" +
            " inner join Satilan_Urunler sa on ur.ID = sa.Satilan_Urun_ID " +
            "where sa.Satilma_Zamani between '" + dtpBaslangic.Value.ToString("yyyy-MM-dd") + "' " +
            " and '" + dtpBitis.Value.ToString("yyyy-MM-dd") + "' order by sa.Satilma_Zamani ASC", baglan.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                int brut = 0;
                int kar = 0;
                UrununAdi = oku[0].ToString();
                tarih = Convert.ToDateTime(oku[5]);
                alisFiyat = Convert.ToInt32(oku[1]);
                satisFiyat = Convert.ToInt32(oku[2]);
                adet = Convert.ToInt32(oku[3]);
                topSatis += adet;
                brut = satisFiyat * adet;
                kar = (satisFiyat - alisFiyat) * adet;
                toplamBrut += brut;
                toplamKar += kar;
                chart1.Series["Brüt Gelir"].Points.AddXY(tarih.ToString("dd-MM-yyyy HH:mm"), brut);
                chart1.Series["Kâr"].Points.AddXY(tarih.ToString("dd-MM-yyyy HH:mm"), kar);                
                toplamUrun++;
            }
            lblBrutGelir.Text = toplamBrut.ToString();
            lblToplamKar.Text = toplamKar.ToString();
            lblTopSatis.Text = topSatis.ToString();
            baglan.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            GrafikGetir();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            GrafikGetir();
        }
        private void ChartClear()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
        }
    }
}
