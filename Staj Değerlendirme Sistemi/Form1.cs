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
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();

        }

        string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;

        public void login()
        {
            string query = "SELECT * FROM giris WHERE UserName ='"+txtName.Text+"' AND Password = '"+ txtPassword.Text+"'";
            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, conn);
            command.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MessageBox.Show("Başarılı giriş yapıldı");
                        Menu menu = new Menu();
                        menu.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Yanlış Girildi");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblName.BackColor = Color.Transparent;
            lblPassword.BackColor = Color.Transparent;
            groupBox1.BackColor = Color.Transparent;
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
