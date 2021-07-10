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
    public partial class UrunSatislari : Form
    {
        public UrunSatislari()
        {
            InitializeComponent();
        }
        SqlBaglantisi baglan = new SqlBaglantisi();
        private void UrunSatislari_Load(object sender, EventArgs e)
        {
            urunEkleToolStripMenuItem.Click += new EventHandler(FormIslemleri.UrunEkleOpen);
            urunleriListeleGuncelleToolStripMenuItem.Click += new EventHandler(FormIslemleri.UrunlerOpen);           
            urunSatisiToolStripMenuItem.Click += new EventHandler(FormIslemleri.UrunSatisOpen);
            urunSatisGrafikleriToolStripMenuItem.Click += new EventHandler(FormIslemleri.UrunSatisGrafikleriOpen);
            personelEKleToolStripMenuItem.Click += new EventHandler(FormIslemleri.PersonelEkleOpen);
            personelListeleGuncelleToolStripMenuItem.Click += new EventHandler(FormIslemleri.PersonellerOpen);            
            cikisYapToolStripMenuItem.Click += new EventHandler(FormIslemleri.Close);
            this.FormClosing += new FormClosingEventHandler(FormIslemleri.FormClosing);
            SatilanUrunleriListele();
        }
        private void SatilanUrunleriListele()
        {
            string sorgu = "select ur.Urun_Adi as 'Ürun Adı', sa.Satis_Fiyati as 'Satış Fiyatı', " +
                "sa.Satilan_Stok_Adedi as 'Satılan Stok Adedi',ur.Urun_Detay as 'Ürün Detay', " +
                "ur.Urun_Fotograf as 'Fotoğrafı',sa.Satilma_Zamani as 'Satış Zamanı'," +
                "ur.Urun_Fiyati as 'Alış Fiyatı' , " +
                "pe.Personel_Adi + ' ' + pe.Personel_Soyad as 'Satışı Yapan Personel' " +
                "from Urunler ur " +
                "inner join Satilan_Urunler sa on ur.ID = sa.Satilan_Urun_ID " +
                "inner join Personeller pe on sa.Satan_Kisi_ID = pe.ID";
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

        private void dgvDegerler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in dgvDegerler.SelectedRows)
            {
                lblUrunAdı.Text = item.Cells[0].Value.ToString();
                lblSatisFiyati.Text = item.Cells[1].Value.ToString();
                lblSatilanStokAdedi.Text = item.Cells[2].Value.ToString();
                lblUrunDetay.Text = item.Cells[3].Value.ToString();
                pbResim.ImageLocation = Application.StartupPath + item.Cells[4].Value.ToString();
                lblSatisZamani.Text = item.Cells[5].Value.ToString();               
                int satisFiyat = Convert.ToInt32(item.Cells[1].Value);
                int alisFiyat = Convert.ToInt32(item.Cells[6].Value);
                int satilanStok = Convert.ToInt32(item.Cells[2].Value);
                lblBrutGelir.Text = (satisFiyat * satilanStok).ToString();
                lblKar.Text = ((satisFiyat - alisFiyat) * satilanStok).ToString();
                lblSatanKisi.Text = item.Cells[7].Value.ToString();
            }
        }
    }
}
