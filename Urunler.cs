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
    public partial class Urunler : Form
    {
        SqlBaglantisi baglan = new SqlBaglantisi();
        string EskiResimYolu,YeniResimYolu;
        public Urunler()
        {
            InitializeComponent();
        }
        private void Urunler_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            UrunleriListele();            
        }
        private void UrunleriListele()
        {
            string sorgu = "select ID, Urun_Adi as 'Ürun Adı',Urun_Fiyati as 'Ürün Fiyatı'," +
                "Urun_Stok_Sayisi as 'Ürünün Stok Sayısı',Urun_Detay as 'Ürün Detay'," +
                "Urun_Fotograf as 'Ürünün Fotoğrafı',Urun_Eklenme_Tarihi as 'Ürünün Eklenme Tarihi'," +
                "Urun_Guncellenme_Tarihi as 'Ürünün Güncellenme Tarihi' from Urunler";
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

        private void urunEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunEkle urunEkle = new UrunEkle();
            this.Hide();
            urunEkle.Show();
        }

        private void urunleriListeleGuncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urunler urunler = new Urunler();
            this.Hide();
            urunler.Show();
        }

        private void cikisYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int ID;

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (ID!=0)
            {
                string s = "update Urunler set Urun_Adi=@Urun_Adi,Urun_Fiyati=@Urun_Fiyati," +
                "Urun_Stok_Sayisi=@Urun_Stok_Sayisi,Urun_Detay=@Urun_Detay,Urun_Fotograf=@Urun_Fotograf," +
                "Urun_Guncellenme_Tarihi=@Urun_Guncellenme_Tarihi where ID = '" + ID + "'";
                SqlCommand cmd = new SqlCommand(s, baglan.baglanti());
                cmd.Parameters.AddWithValue("@Urun_Adi", txtAdi.Text);
                cmd.Parameters.AddWithValue("@Urun_Fiyati", nudFiyati.Value);
                cmd.Parameters.AddWithValue("@Urun_Stok_Sayisi", nudStokSayisi.Value);
                cmd.Parameters.AddWithValue("@Urun_Detay", txtDetay.Text);
                if (YeniResimYolu != "")
                {
                    ResmiGuncelle(EskiResimYolu);
                    cmd.Parameters.AddWithValue("@Urun_Fotograf", YeniResimYolu);
                }
                cmd.Parameters.AddWithValue("@Urun_Guncellenme_Tarihi", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"));
                baglan.Open();
                cmd.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Güncelleme İşlemi Başarılı");
            }
            else
            {
                MessageBox.Show("Lütfen Kayıt Seçiniz");
            }            
        }

        private void btnResimDegistir_Click(object sender, EventArgs e)
        {
            OpenFileDialog resim = new OpenFileDialog();
            resim.Filter = "Tüm dosyalar | *.*";
            resim.ShowDialog();
            pbResim.ImageLocation = resim.FileName;
        }

        private void btnSil_Click(object sender, EventArgs e)
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
            }
            pbResim.Image = null;
            UrunleriListele();
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
                EskiResimYolu = Application.StartupPath + item.Cells[5].Value.ToString();
            }
        }

        private void ResmiGuncelle(string eskiResim)
        {
            ResmiSil(eskiResim);//eski resmi sildirme
            string kaynak = pbResim.ImageLocation;//dosya yolunu alma
            string dosyaAdi = Path.GetFileName(kaynak); //Dosya adını alma
            string hedef = Application.StartupPath + @"\Resimler\";
            string yeniad = Guid.NewGuid() + dosyaAdi; //Benzersiz isim verme
            File.Copy(kaynak, hedef + yeniad);//resmi kopyalama
            YeniResimYolu = @"\Resimler\" + yeniad;//veritabanına kaydedilecek resmin ismi
        }
        private void ResmiSil(string eskiResim)
        {
            File.Delete(eskiResim);//resmi sildirme
        }
    }
}
