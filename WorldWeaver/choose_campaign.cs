using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing.Text;

namespace WorldWeaver
{
    public partial class choose_campaign : Form
    {
        private readonly string connectionString;

        public choose_campaign()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;

            PopulateCmpDropdown();

        }

        

        private void choose_campaign_Load(object sender, EventArgs e)
        {
            
            

        }

        private void PopulateCmpDropdown()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT campaign_name FROM campaigns;";
                using(SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<string> campaignNames = new List<string> { "---select campaign---" };

                        while (reader.Read())
                        {
                            string campaignName = reader.GetString(0);
                            campaignNames.Add(campaignName);
                        }

                        comboBox1.DataSource = campaignNames;
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nxtBtn_Click(object sender, EventArgs e)
        {
            DM_info_sheet dM_Info_Sheet = new DM_info_sheet();
            dM_Info_Sheet.Show();
            this.Hide();
        }
    }
}
