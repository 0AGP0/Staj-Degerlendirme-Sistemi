using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Staj_Değerlendirme_Sistemi
{
    public partial class OgrenciEkle : Form
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;
        public OgrenciEkle()
        {
            InitializeComponent();
            InitializeDatabase();

        }
        private void InitializeDatabase()
        {
            string connectionString = "datasource=127.0.0.1; database=loginphp; port = 3307;user=root;";


            conn = new MySqlConnection(connectionString);
        }
        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Veritabanına bağlanılamadı: " + ex.Message);
                return false;
            }
        }
        private bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Veritabanı bağlantısı kapatılamadı: " + ex.Message);
                return false;
            }
        }

        private void OgrenciEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string tc = txtTC.Text;
            string ogrenciNo = txtOgrenciNo.Text;
            int sinif = Convert.ToInt32(cmbSinif.SelectedIndex);
            string tel = txtTel.Text;
            string ePosta = txtEPosta.Text;
            string stajKodu = cmbStajKodu.SelectedItem != null ? cmbStajKodu.SelectedItem.ToString() : "";
            string stajYeri = txtStajYeri.Text;
            string stajBas = dt1.Value.ToString("yyyy-MM-dd");
            string stajBitis = dt2.Value.ToString("yyyy-MM-dd");
            string aciklama = txtAciklama.Text;

            int dilek = cbDilek.Checked ? 1 : 0;
            int kabul = cbKabul.Checked ? 1 : 0;
            int mustehak = cbMustehak.Checked ? 1 : 0;
            int foto = cbFotoko.Checked ? 1 : 0;
            int degerlendirme = cbDegerlendirme.Checked ? 1 : 0;
            int rapor = cbRapor.Checked ? 1 : 0;

            if (string.IsNullOrWhiteSpace(ad) || string.IsNullOrWhiteSpace(soyad) || string.IsNullOrWhiteSpace(tc) ||
                string.IsNullOrWhiteSpace(ogrenciNo) || string.IsNullOrWhiteSpace(sinif.ToString()) || string.IsNullOrWhiteSpace(tel) ||
                string.IsNullOrWhiteSpace(ePosta) || string.IsNullOrWhiteSpace(stajKodu) || string.IsNullOrWhiteSpace(stajYeri) ||
                string.IsNullOrWhiteSpace(stajBas) || string.IsNullOrWhiteSpace(stajBitis) ||
                string.IsNullOrWhiteSpace(aciklama))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            if (OpenConnection())
            {
                string query = "INSERT INTO ogrencibilgileri ( tc, ad, soyad, ogrenciNo, sınıf, tel, ePosta, stajKodu, stajYeri, stajBasTarihi, stajBitisTarihi, " +
                               "dilekce, kabulYazısı, mustehaklık, kimlikFoto, stajDegerlendirme, stajRaporu, aciklama) " +
                               "VALUES (@tc, @ad, @soyad, @ogrenciNo, @sinif, @tel, @ePosta, @stajKodu, @stajYeri, @stajBasTarihi, @stajBitisTarihi, " +
                               "@dilek, @kabul, @mustehak, @foto, @degerlendirme, @rapor, @aciklama)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@tc", tc);
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@soyad", soyad);
                cmd.Parameters.AddWithValue("@ogrenciNo", ogrenciNo);
                cmd.Parameters.AddWithValue("@sinif", sinif);
                cmd.Parameters.AddWithValue("@tel", tel);
                cmd.Parameters.AddWithValue("@ePosta", ePosta);
                cmd.Parameters.AddWithValue("@stajKodu", stajKodu);
                cmd.Parameters.AddWithValue("@stajYeri", stajYeri);
                cmd.Parameters.AddWithValue("@stajBasTarihi", stajBas);
                cmd.Parameters.AddWithValue("@stajBitisTarihi", stajBitis);
                cmd.Parameters.AddWithValue("@dilek", dilek);
                cmd.Parameters.AddWithValue("@kabul", kabul);
                cmd.Parameters.AddWithValue("@mustehak", mustehak);
                cmd.Parameters.AddWithValue("@foto", foto);
                cmd.Parameters.AddWithValue("@degerlendirme", degerlendirme);
                cmd.Parameters.AddWithValue("@rapor", rapor);
                cmd.Parameters.AddWithValue("@aciklama", aciklama);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Öğrenci başarıyla eklendi.");
                    txtTC.Text = "";
                    txtAd.Text = "";
                    txtSoyad.Text = "";
                    txtOgrenciNo.Text = "";
                    txtAciklama.Text = "";
                    txtEND.Text = "";
                    txtEPosta.Text = "";
                    txtStajYazı.Text = "";
                    txtStajYeri.Text = "";
                    txtTel.Text = "";
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }

                CloseConnection();
            }

        }
    }
}
