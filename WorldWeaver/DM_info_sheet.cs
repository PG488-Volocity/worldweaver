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
        public DM_info_sheet()
        {
            InitializeComponent();
        }

        private void DM_info_sheet_Load(object sender, EventArgs e)
        {
            


            
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
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-CD77NKS;Initial Catalog=worldweaver;Integrated Security=True");
            connection.Open();
            
            command.Connection = connection;
            command.CommandText = "select * from player";
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            

            connection.Close();
        }

        private void npcBtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-CD77NKS;Initial Catalog=worldweaver;Integrated Security=True");
            connection.Open();

            command.Connection = connection;
            command.CommandText = "select * from npc";
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;


            connection.Close();
        }
    }
}
