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
        SqlConnection baglan = new SqlConnection(@"Data Source =DESKTOP-899RAQ8\SQLEXPRESS; Initial Catalog = Optikci; Integrated Security = True");
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
            string sorgu = "select * from Urunler";
            SqlDataAdapter adp = new SqlDataAdapter(sorgu, baglan);
            DataSet ds = new DataSet();
            baglan.Open();
            adp.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)//veri varsa//dt.Rows.Count
            {
                dgvDegerler.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Veritabanında Veri Bulunamadı");
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (ID!=0)
            {
                string s = "update Urunler set Urun_Adi=@Urun_Adi,Urun_Fiyati=@Urun_Fiyati," +
                "Urun_Stok_Sayisi=@Urun_Stok_Sayisi,Urun_Detay=@Urun_Detay,Urun_Fotograf=@Urun_Fotograf," +
                "Urun_Guncellenme_Tarihi=@Urun_Guncellenme_Tarihi where ID = '" + ID + "'";
                SqlCommand cmd = new SqlCommand(s, baglan);
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
            string s = "delete from Urunler where ID = '" + ID + "'";
            SqlCommand cmd = new SqlCommand(s, baglan);
            DialogResult c = new DialogResult();
            c = MessageBox.Show("Ürünü Silmek istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (c == DialogResult.Yes)
            {
                baglan.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ürün Silindi");
                baglan.Close();
            }
        }

        private void ResmiGuncelle(string eskiResim)
        {
            File.Delete(eskiResim);//eski resmi sildirme
            string dosyaYolu = pbResim.ImageLocation;
            string dosyaAdi = Path.GetFileName(dosyaYolu); //Dosya adını alma
            string kaynak = dosyaYolu;
            string hedef = Application.StartupPath + @"\Resimler\";
            string yeniad = Guid.NewGuid() + dosyaAdi; //Benzersiz isim verme
            File.Copy(kaynak, hedef + yeniad);
            YeniResimYolu = @"\Resimler\" + yeniad;//veritabanına kaydedilecek resmin ismi
        }
    }
}
