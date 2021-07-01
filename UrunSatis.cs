using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Optikci_Otomasyonu
{
    public partial class UrunSatis : Form
    {
        public UrunSatis()
        {
            InitializeComponent();
        }

        private void UrunSatis_Load(object sender, EventArgs e)
        {
            FormIslemleri formIslemleri = new FormIslemleri();
            urunleriListeleGuncelleToolStripMenuItem.Click += new EventHandler(FormuKapat);
            urunEkleToolStripMenuItem.Click += new EventHandler(FormuKapat);
            personelEKleToolStripMenuItem.Click += new EventHandler(FormuKapat);
            personelListeleGuncelleToolStripMenuItem.Click += new EventHandler(FormuKapat);

            urunleriListeleGuncelleToolStripMenuItem.Click += new EventHandler(formIslemleri.UrunlerOpen);
            urunEkleToolStripMenuItem.Click += new EventHandler(formIslemleri.UrunEkleOpen);
            personelEKleToolStripMenuItem.Click += new EventHandler(formIslemleri.PersonelEkleOpen);
            personelListeleGuncelleToolStripMenuItem.Click += new EventHandler(formIslemleri.PersonellerOpen);
        }
        private void FormuKapat(object s, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
