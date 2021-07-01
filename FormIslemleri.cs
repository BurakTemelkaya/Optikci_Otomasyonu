using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Optikci_Otomasyonu
{
    public class FormIslemleri
    {
        public void PersonellerOpen(object s, EventArgs e)
        {
            Personeller personeller = new Personeller();
            personeller.Show();
        }
        public void PersonelEkleOpen(object s, EventArgs e)
        {
            PersonelEkle personelEkle = new PersonelEkle();
            personelEkle.Show();           
        }
        public void UrunlerOpen(object s, EventArgs e)
        {
            Urunler urunler = new Urunler();
            urunler.Show();
        }
        public void UrunEkleOpen(object s, EventArgs e)
        {
            UrunEkle urunEkle = new UrunEkle();
            urunEkle.Show();
        }
        public void UrunSatisOpen(object s, EventArgs e)
        {
            UrunSatis urunSatis = new UrunSatis();
            urunSatis.Show();
        }
    }
}
