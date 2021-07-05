using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Optikci_Otomasyonu
{
    public class FormIslemleri
    {
        public static void PersonellerOpen(object s, EventArgs e)
        {
            Personeller personeller = new Personeller();
            personeller.Show();
        }
        public static void PersonelEkleOpen(object s, EventArgs e)
        {
            PersonelEkle personelEkle = new PersonelEkle();
            personelEkle.Show();           
        }
        public static void UrunlerOpen(object s, EventArgs e)
        {
            Urunler urunler = new Urunler();
            urunler.Show();
        }
        public static void UrunEkleOpen(object s, EventArgs e)
        {
            UrunEkle urunEkle = new UrunEkle();
            urunEkle.Show();
        }
        public static void UrunSatisOpen(object s, EventArgs e)
        {
            UrunSatis urunSatis = new UrunSatis();
            urunSatis.Show();
        }
        public static void UrunSatisGrafikleriOpen(object s, EventArgs e)
        {
            UrunSatisGrafikleri urunSatisGrafikleri = new UrunSatisGrafikleri();
            urunSatisGrafikleri.Show();
        }

        public static void UrunSatislariOpen(object s, EventArgs e)
        {
            UrunSatislari urunSatislari = new UrunSatislari();
            urunSatislari.Show();
        }
        public static void Close(object s,EventArgs e)
        {
            Application.Exit();
        }
        public static void FormClosing(object s, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
