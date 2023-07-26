using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldWeaver
{
    public partial class DM_info_sheet : Form
    {
        private readonly string connectionString;
        public DM_info_sheet()
        {
            InitializeComponent();
        }

        private void DM_info_sheet_Load(object sender, EventArgs e)
        {
            


            //Rough draft of the DM info sheet. I want to make it a little more compact, but I'm not sure if it'll fit all of the info since it's one table with several columns

            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-CD77NKS;Initial Catalog=worldweaver;Integrated Security=True");
            connection.Open();
            
            connection.Close();

        }   

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void charaBtn_Click(object sender, EventArgs e)
        {
            //Button to show character info

            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-CD77NKS;Initial Catalog=worldweaver;Integrated Security=True");
            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT player_id, name, race, level, class FROM player;";
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void npcBtn_Click(object sender, EventArgs e)
        {
            //Button to show NPC info.

            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-CD77NKS;Initial Catalog=worldweaver;Integrated Security=True");
            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM npc;";
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            connection.Close();
        }

        private void stsBtn_Click(object sender, EventArgs e)
        {
            //View stats

            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-CD77NKS;Initial Catalog=worldweaver;Integrated Security=True");
            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT player_id, hit_points, strength, dexterity, constitution, intelligence, wisdom, charisma, proficiency_bonus, walking_speed, initiative, armor_class FROM player;";
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            connection.Close();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void notesBtn_Click(object sender, EventArgs e)
        {
            //View notes

            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-CD77NKS;Initial Catalog=worldweaver;Integrated Security=True");
            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT player_id, name, notes_to_dm FROM player;";
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            connection.Close();
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            main_menu main_Menu = new main_menu();
            main_Menu.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT campaign_name FROM campaigns;";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
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
    }
}
