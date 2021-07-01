using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Optikci_Otomasyonu
{
    public class SqlBaglantisi
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-899RAQ8\SQLEXPRESS;Initial Catalog=Optikci;Integrated Security=True");
        public SqlConnection baglanti()
        {
            return baglan;
        }
        public void Open()
        {
            baglan.Open();
        }
        public void Close()
        {
            baglan.Close();
        }
        //SqlBaglantisi class'ı sayesinde projemiz başka bir bilgisayara yüklendiğinde
        //veritabanının yerini sadece bir kez yazarak bütün projede değişmesini sağlıyoruz.
    }
}
