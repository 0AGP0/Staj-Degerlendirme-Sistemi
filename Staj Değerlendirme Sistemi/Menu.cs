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
        }

        private void btnDeğerlendirme_Click(object sender, EventArgs e)
        {
            Degerlendirme degerlendirme = new Degerlendirme();
            degerlendirme.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lblName.BackColor = Color.Transparent;
        }
    }
}
