﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Text; // Add this namespace for StringBuilder

namespace WorldWeaver
{
    public partial class CampaignPlayersForm : Form
    {
        private CampaignPlayerManager campaignPlayerManager;

        public CampaignPlayersForm()
        {
            InitializeComponent();
            campaignPlayerManager = new CampaignPlayerManager();

            listViewPlayers.View = View.Details;
            listViewPlayers.Columns.Add("Name", 150);
            listViewPlayers.Columns.Add("Race", 50);
            listViewPlayers.Columns.Add("Level", 50);
            listViewPlayers.Columns.Add("Class", 50);
            listViewPlayers.Columns.Add("Notes", 200);
            listViewPlayers.Columns.Add("Hit Pionts", 50);
            listViewPlayers.Columns.Add("dexterity", 50);
            listViewPlayers.Columns.Add("Constitution", 50);
            listViewPlayers.Columns.Add("Intelligence", 50);
            listViewPlayers.Columns.Add("Wisdom", 50);
            listViewPlayers.Columns.Add("Charisma", 50);
            listViewPlayers.Columns.Add("Profeciency Bonus", 50);
            listViewPlayers.Columns.Add("Walking Speed", 50);
            listViewPlayers.Columns.Add("Initiatve", 50);
            listViewPlayers.Columns.Add("Armor Class", 50);

            PopulateCampaignsComboBox();
        }


        private void PopulateCampaignsComboBox()
        {
            // Load campaign_ids from the campaigns table and populate the ComboBox
            string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;
            string selectQuery = "SELECT campaign_id FROM campaigns";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbCampaigns.Items.Add(reader["campaign_id"]);
                        }
                    }
                }
            }
        }

        private void btnLoadPlayers_Click(object sender, EventArgs e)
        {
            if (cmbCampaigns.SelectedItem != null)
            {
                MessageBox.Show(cmbCampaigns.SelectedItem.ToString(), "Selected Campaign ID");
            }
            else
            {
                MessageBox.Show("No campaign selected", "Error");
            }



            if (int.TryParse(cmbCampaigns.SelectedItem?.ToString(), out int selectedCampaignId))
            {
                // Load players for the selected campaign_id and display them in the ListView
                List<Player> players = campaignPlayerManager.GetPlayersForCampaign(selectedCampaignId);

                // Clear existing data in the ListView
                listViewPlayers.Items.Clear();

                // Populate the ListView with players' information
                foreach (Player player in players)
                {
                    ListViewItem item = new ListViewItem(player.Name);
                    item.SubItems.Add(player.Race);
                    item.SubItems.Add(player.Level.ToString());
                    item.SubItems.Add(player.Class);
                    item.SubItems.Add(player.NotesToDM);
                    item.SubItems.Add(player.Strength.ToString());
                    item.SubItems.Add(player.Dexterity.ToString());
                    item.SubItems.Add(player.Constitution.ToString());
                    item.SubItems.Add(player.Intelligence.ToString());
                    item.SubItems.Add(player.Wisdom.ToString());
                    item.SubItems.Add(player.Charisma.ToString());
                    item.SubItems.Add(player.ProficiencyBonus.ToString());
                    item.SubItems.Add(player.WalkingSpeed.ToString());
                    item.SubItems.Add(player.Initiative.ToString());
                    item.SubItems.Add(player.ArmorClass.ToString());

                    listViewPlayers.Items.Add(item);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(cmbCampaigns.SelectedItem?.ToString(), out int selectedCampaignId))
            {
                // Load players for the selected campaign_id and display them in the ListView
                List<Player> players = campaignPlayerManager.GetPlayersForCampaign(selectedCampaignId);

                // Clear existing data in the ListView
                listViewPlayers.Items.Clear();

                // Populate the ListView with players' information
                foreach (Player player in players)
                {
                    ListViewItem item = new ListViewItem(player.Name);
                    item.SubItems.Add(player.Race);
                    item.SubItems.Add(player.Level.ToString());
                    item.SubItems.Add(player.Class);
                    item.SubItems.Add(player.NotesToDM);
                    item.SubItems.Add(player.Strength.ToString());
                    item.SubItems.Add(player.Dexterity.ToString());
                    item.SubItems.Add(player.Constitution.ToString());
                    item.SubItems.Add(player.Intelligence.ToString());
                    item.SubItems.Add(player.Wisdom.ToString());
                    item.SubItems.Add(player.Charisma.ToString());
                    item.SubItems.Add(player.ProficiencyBonus.ToString());
                    item.SubItems.Add(player.WalkingSpeed.ToString());
                    item.SubItems.Add(player.Initiative.ToString());
                    item.SubItems.Add(player.ArmorClass.ToString());

                    listViewPlayers.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No campaign selected", "Error");
            }
        }


    }
}
