using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System;

namespace WorldWeaver
{
    public class CampaignPlayerManager
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;

        private int SafeIntFromReader(SqlDataReader reader, string fieldName)
        {
            object value = reader[fieldName];
            if (value == DBNull.Value) return 0;
            else return Convert.ToInt32(value);
        }

        public List<Player> GetPlayersForCampaign(int campaignId)
        {
            List<Player> players = new List<Player>();

            string query = @"
        SELECT p.player_id, p.name, p.race, p.level, p.class, p.notes_to_dm, p.hit_points, 
               p.strength, p.dexterity, p.constitution, p.intelligence, p.wisdom, p.charisma, 
               p.proficiency_bonus, p.walking_speed, p.initiative, p.armor_class, p.token_id
        FROM player p
        WHERE p.player_id IN (
            SELECT campaign_player1 FROM campaigns WHERE campaign_id = @campaignId
            UNION
            SELECT campaign_player2 FROM campaigns WHERE campaign_id = @campaignId
            UNION
            SELECT campaign_player3 FROM campaigns WHERE campaign_id = @campaignId
            UNION
            SELECT campaign_player4 FROM campaigns WHERE campaign_id = @campaignId
            UNION
            SELECT campaign_player5 FROM campaigns WHERE campaign_id = @campaignId
            UNION
            SELECT campaign_player6 FROM campaigns WHERE campaign_id = @campaignId
        )";

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
                            Player player = new Player
                            {
                                PlayerId = SafeIntFromReader(reader, "player_id"),
                                Name = reader["name"].ToString(),
                                Race = reader["race"].ToString(),
                                Level = SafeIntFromReader(reader, "level"),
                                Class = reader["class"].ToString(),
                                NotesToDM = reader["notes_to_dm"].ToString(),
                                HitPoints = SafeIntFromReader(reader, "hit_points"),
                                Strength = SafeIntFromReader(reader, "strength"),
                                Dexterity = SafeIntFromReader(reader, "dexterity"),
                                Constitution = SafeIntFromReader(reader, "constitution"),
                                Intelligence = SafeIntFromReader(reader, "intelligence"),
                                Wisdom = SafeIntFromReader(reader, "wisdom"),
                                Charisma = SafeIntFromReader(reader, "charisma"),
                                ProficiencyBonus = SafeIntFromReader(reader, "proficiency_bonus"),
                                WalkingSpeed = SafeIntFromReader(reader, "walking_speed"),
                                Initiative = SafeIntFromReader(reader, "initiative"),
                                ArmorClass = SafeIntFromReader(reader, "armor_class"),
                                TokenId = SafeIntFromReader(reader, "token_id") // added this line
                            };

                            players.Add(player);
                        }
                    }
                }
            }

            return players;
        }
    }
}
