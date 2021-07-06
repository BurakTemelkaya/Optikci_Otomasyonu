using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Optikci_Otomasyonu
{
    public class FormIslemleri
    {
        //Müdür
        //Müdür Yardımcısı
        //Satış Müdürü
        //Satış Müdür Yardımcısı
        //Satış Uzmanı
        //Satış Danışmanı
        //Pazarlama Müdürü
        //Pazarlama Uzmanı
        //İnsan Kaynakları Müdürü
        //İnsan Kaynakları Uzmanı
        public static Form ClosingForm;//kapatılacak form
        private static string Meslek = GirisYap.Personel_Meslek;
        public static void PersonellerOpen(object s, EventArgs e)
        {
            if (Meslek== "Müdür" || Meslek == "Müdür Yardımcısı" || Meslek == "Satış Müdürü" || Meslek == "Satış Müdür Yardımcısı" || Meslek== "İnsan Kaynakları Müdürü" || Meslek == "İnsan Kaynakları Uzmanı")
            {
                FormHide();
                Personeller personeller = new Personeller();
                ClosingForm = personeller;
                personeller.Show();
            }
            else
            {
                MessageBox.Show("Bu Formu Görüntüleme Yetkiniz Bulunmamaktadır.");
            }           
        }
        public static void PersonelEkleOpen(object s, EventArgs e)
        {           
            if (Meslek == "Müdür" || Meslek == "Müdür Yardımcısı" || Meslek == "Satış Müdürü" || Meslek == "Satış Müdür Yardımcısı" || Meslek == "İnsan Kaynakları Müdürü" || Meslek == "İnsan Kaynakları Uzmanı")
            {
                FormHide();
                PersonelEkle personelEkle = new PersonelEkle();
                ClosingForm = personelEkle;
                personelEkle.Show();
            }
            else
            {
                MessageBox.Show("Bu Formu Görüntüleme Yetkiniz Bulunmamaktadır.");
            }
        }
        public static void UrunlerOpen(object s, EventArgs e)
        {
            FormHide();
            Urunler urunler = new Urunler();
            ClosingForm = urunler;
            urunler.Show();
        }
        public static void UrunEkleOpen(object s, EventArgs e)
        {
            FormHide();
            UrunEkle urunEkle = new UrunEkle();
            ClosingForm = urunEkle;
            urunEkle.Show();
        }
        public static void UrunSatisOpen(object s, EventArgs e)
        {
            FormHide();
            UrunSatis urunSatis = new UrunSatis();
            ClosingForm = urunSatis;
            urunSatis.Show();
        }
        public static void UrunSatisGrafikleriOpen(object s, EventArgs e)
        {
            FormHide();
            UrunSatisGrafikleri urunSatisGrafikleri = new UrunSatisGrafikleri();
            ClosingForm = urunSatisGrafikleri;
            urunSatisGrafikleri.Show();
        }

        public static void UrunSatislariOpen(object s, EventArgs e)
        {
            FormHide();
            UrunSatislari urunSatislari = new UrunSatislari();
            ClosingForm = urunSatislari;
            urunSatislari.Show();
        }
        public static void Close(object s, EventArgs e)
        {
            Application.Exit();
        }
        public static void FormClosing(object s, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public static void FormHide()
        {
            ClosingForm.Hide();
        }
    }
}
