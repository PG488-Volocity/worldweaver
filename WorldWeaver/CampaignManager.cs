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
        

        // Method to fetch the map file path based on the map name
        public string GetMapImagePath(string mapName)
        {
            // Write your SQL query to fetch the map file path from the maps table based on the map name
            string query = "SELECT map_file_path FROM maps WHERE map_name = @mapName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@mapName", mapName);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result?.ToString();
                }
            }
        }


        public string GetTokenImagePath(int tokenId)
        {
            // Write your SQL query to fetch the token image path from the tokens table based on the token ID
            string query = "SELECT token_filepath FROM tokens WHERE token_id = @tokenId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tokenId", tokenId);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result?.ToString();
                }
            }
        }

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

        public List<Player> GetPlayersForCampaign(int campaignId)
        {
            List<Player> players = new List<Player>();

            // SQL query to fetch the players for the given campaign ID, including their token IDs
            string query = @"
SELECT p.token_id
FROM (
    SELECT campaign_player1 AS player_id FROM campaigns WHERE campaign_id = @campaignId
    UNION
    SELECT campaign_player2 AS player_id FROM campaigns WHERE campaign_id = @campaignId
    UNION
    SELECT campaign_player3 AS player_id FROM campaigns WHERE campaign_id = @campaignId
    UNION
    SELECT campaign_player4 AS player_id FROM campaigns WHERE campaign_id = @campaignId
    UNION
    SELECT campaign_player5 AS player_id FROM campaigns WHERE campaign_id = @campaignId
    UNION
    SELECT campaign_player6 AS player_id FROM campaigns WHERE campaign_id = @campaignId
) c
JOIN player p ON c.player_id = p.player_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@campaignId", campaignId);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Fetch the token ID from the first column (index 0)
                            int tokenId = reader.GetInt32(0);
                            Console.WriteLine("Token ID: " + tokenId);

                            // Fetch the player information based on the token ID
                            Player tokenPlayer = GetPlayerByTokenId(tokenId);
                            if (tokenPlayer != null)
                            {
                                // Add the fetched player to the list
                                players.Add(tokenPlayer);
                            }
                        }
                    }
                }
            }

            return players;
        }


        // Method to fetch a player by token ID
        private Player GetPlayerByTokenId(int tokenId)
        {
            // Write your SQL query to fetch the player information from the players table based on the token ID
            string query = "SELECT player_id, name, race, level, class, notes_to_dm, hit_points, " +
                           "strength, dexterity, constitution, intelligence, wisdom, charisma, " +
                           "proficiency_bonus, walking_speed, initiative, armor_class, token_id " +
                           "FROM player WHERE token_id = @tokenId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tokenId", tokenId);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Player player = new Player
                            {
                                PlayerId = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Race = reader.GetString(2),
                                Level = reader.GetInt32(3),
                                Class = reader.GetString(4),
                                NotesToDM = reader.GetString(5),
                                HitPoints = reader.GetInt32(6),
                                Strength = reader.GetInt32(7),
                                Dexterity = reader.GetInt32(8),
                                Constitution = reader.GetInt32(9),
                                Intelligence = reader.GetInt32(10),
                                Wisdom = reader.GetInt32(11),
                                Charisma = reader.GetInt32(12),
                                ProficiencyBonus = reader.GetInt32(13),
                                WalkingSpeed = reader.GetInt32(14),
                                Initiative = reader.GetInt32(15),
                                ArmorClass = reader.GetInt32(16),
                                TokenId = reader.GetInt32(17)
                            };

                            return player;
                        }
                    }
                }
            }

            return null;
        }


        // Helper method to fetch a player by player ID
        private Player GetPlayerById(int playerId)
        {
            // Write your SQL query to fetch the player information from the players table based on the player ID
            string query = "SELECT player_id, name, race, level, class, notes_to_dm, hit_points, " +
                           "strength, dexterity, constitution, intelligence, wisdom, charisma, " +
                           "proficiency_bonus, walking_speed, initiative, armor_class, token_id " +
                           "FROM player WHERE player_id = @playerId";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@playerId", playerId);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Player player = new Player
                            {
                                PlayerId = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                Race = reader.GetString(2),
                                Level = reader.GetInt32(3),
                                Class = reader.GetString(4),
                                NotesToDM = reader.GetString(5),
                                HitPoints = reader.GetInt32(6),
                                Strength = reader.GetInt32(7),
                                Dexterity = reader.GetInt32(8),
                                Constitution = reader.GetInt32(9),
                                Intelligence = reader.GetInt32(10),
                                Wisdom = reader.GetInt32(11),
                                Charisma = reader.GetInt32(12),
                                ProficiencyBonus = reader.GetInt32(13),
                                WalkingSpeed = reader.GetInt32(14),
                                Initiative = reader.GetInt32(15),
                                ArmorClass = reader.GetInt32(16),
                                TokenId = reader.GetInt32(17)
                            };

                            return player;
                        }
                    }
                }
            }

            return null;
        }
    }

}

