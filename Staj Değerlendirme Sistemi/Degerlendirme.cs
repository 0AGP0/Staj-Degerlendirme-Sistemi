using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Staj_Değerlendirme_Sistemi
{
    public partial class Degerlendirme : Form
    {
        private string selectedKayitNo = ""; // Seçilen öğrencinin kayıt numarasını saklamak için
        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
        string query = "SELECT kayıtNo, ad, soyad, basari FROM ogrencibilgileri";
        public Degerlendirme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void Degerlendirme_Load(object sender, EventArgs e)
        {
 

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                selectedKayitNo = row.Cells["kayıtNo"].Value.ToString();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedKayitNo))
            {
                MessageBox.Show("Lütfen bir öğrenci seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int toplamPuan = 0;

            for (int i = 1; i <= 20; i++)
            {
                string numericUpDownName = "numericUpDown" + i.ToString();
                Control[] foundControls = Controls.Find(numericUpDownName, true);

                if (foundControls.Length > 0 && foundControls[0] is NumericUpDown)
                {
                    NumericUpDown numericUpDown = foundControls[0] as NumericUpDown;
                    int puan = Convert.ToInt32(numericUpDown.Value);
                    toplamPuan += puan;
                }
                else
                {
                    MessageBox.Show($"'{numericUpDownName}' adında bir NumericUpDown bulunamadı veya uygun değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            string basariDurumu = (toplamPuan > 70) ? "BAŞARILI" : "BAŞARISIZ";
            string updateQuery = $"UPDATE ogrencibilgileri SET basari='{basariDurumu}' WHERE kayıtNo='{selectedKayitNo}'";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Değerlendirme başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Menu menu = new Menu();
                        menu.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Değerlendirme kaydedilirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
