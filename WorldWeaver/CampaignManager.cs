using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System;
using WorldWeaver.Models;
namespace WorldWeaver
{
    public class CampaignManager
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;

        // Method to fetch all campaigns from the database
        public List<Campaign> GetAllCampaigns()
        {
            List<Campaign> campaigns = new List<Campaign>();

            // Write your SQL query to fetch all campaigns from the campaigns table
            string query = "SELECT campaign_id, campaign_name, campaign_map, campaign_player_count " +
                           "FROM campaigns";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Campaign campaign = new Campaign
                            {
                                CampaignId = Convert.ToInt32(reader["campaign_id"]),
                                CampaignName = reader["campaign_name"].ToString(),
                                CampaignMap = reader["campaign_map"].ToString(),
                                CampaignPlayerCount = Convert.ToInt32(reader["campaign_player_count"])
                            };

                            campaigns.Add(campaign);
                        }
                    }
                }
            }

            return campaigns;
        }
    }
}
