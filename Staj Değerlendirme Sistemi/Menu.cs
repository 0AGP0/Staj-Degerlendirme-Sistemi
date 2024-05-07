using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staj_Değerlendirme_Sistemi
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }



        private void btnKayıt_Click(object sender, EventArgs e)
        {
            OgrenciEkle ogrenciEkle = new OgrenciEkle();
            ogrenciEkle.Show();
            this.Close();
        }

        private void btnDeğerlendirme_Click(object sender, EventArgs e)
        {
            Degerlendirme degerlendirme = new Degerlendirme();
            degerlendirme.Show();
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lblName.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciListesi ogr = new OgrenciListesi();
            ogr.Show();
            this.Close();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOgrSil_Click(object sender, EventArgs e)
        {
            ogrenciSil ogrenci = new ogrenciSil();
            ogrenci.Show();
            this.Close();
        }
    }
}
