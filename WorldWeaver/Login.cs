using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldWeaver
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();


        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            Login login = new Login();
            login.ShowDialog();*/

            if (string.IsNullOrEmpty(usertxtBox.Text))
            {
                MessageBox.Show("Please Enter a Username", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrEmpty(passtxtBox.Text))
            {
                MessageBox.Show("Please Enter a Password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

            if (passtxtBox.Text != string.Empty || usertxtBox.Text != string.Empty)
            {
                
                string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
                string query = "SELECT * FROM users WHERE username='" + usertxtBox.Text + "' and password='" + passtxtBox.Text + "'";

                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using(SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using(SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                reader.Close();
                                this.Hide();
                                main_menu main_Menu = new main_menu();
                                main_Menu.ShowDialog();
                            }

                            else
                            {
                                reader.Close();
                                MessageBox.Show("Please Check Username/Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            




                        }
                    }
                }
            }
        }

        


        private void Login_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            
        }

        private void passtxtBox_TextChanged(object sender, EventArgs e)
        {
            passtxtBox.UseSystemPasswordChar = true;
            passtxtBox.PasswordChar = '*';
        }

        private void haBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passtxtBox.Text))
            {
                MessageBox.Show("Ha you thought you could gain access without credentials? Better luck next time!", "HA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (string.IsNullOrEmpty(usertxtBox.Text))
            {
                MessageBox.Show("Ha you thought you could gain access without credentials? Better luck next time!", "HA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
