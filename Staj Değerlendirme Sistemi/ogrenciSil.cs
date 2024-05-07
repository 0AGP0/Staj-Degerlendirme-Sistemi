using MySql.Data.MySqlClient;
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
    public partial class ogrenciSil : Form
    {
        string connectionString = "datasource=127.0.0.1; database=loginphp; port = 3307;user=root;";

        public ogrenciSil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // Silme işlemi için seçilen satırı kontrol et
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Kullanıcıya silme işleminin onayını sormak için MessageBox göster
                DialogResult result = MessageBox.Show("Seçilen öğrenciyi silmek istediğinizden emin misiniz?", "Öğrenci Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Seçilen satırın öğrenci numarasını al
                    string ogrenciNo = dataGridView1.SelectedRows[0].Cells["ogrenciNo"].Value.ToString();

                    // Veritabanı bağlantısını oluştur
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        // Silme sorgusunu hazırla
                        string query = "DELETE FROM ogrencibilgileri WHERE ogrenciNo = @ogrenciNo";

                        // Komut oluştur ve parametreleri ayarla
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@ogrenciNo", ogrenciNo);

                            try
                            {
                                // Bağlantıyı aç ve sorguyu çalıştır
                                connection.Open();
                                int rowsAffected = command.ExecuteNonQuery();

                                // Silme işlemi başarılıysa kullanıcıya bilgi ver
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Öğrenci başarıyla silindi.");
                                    // DataGridView'ı güncelle
                                    RefreshDataGridView();
                                }
                                else
                                {
                                    MessageBox.Show("Öğrenci silinirken bir hata oluştu.");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Hata: " + ex.Message);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir öğrenci seçin.");
            }
        }


        // DataGridView'ı güncelleyen metot
        private void RefreshDataGridView()
        {
            string query = "SELECT * FROM ogrencibilgileri";

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


        private void ogrenciSil_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ogrencibilgileri";

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
    }
}
