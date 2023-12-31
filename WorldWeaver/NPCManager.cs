﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using WorldWeaver.Models;

public class NPCManager
{
    private string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;

    public List<NPC> GetAllNPCs()
    {
        List<NPC> npcs = new List<NPC>();

        string query = @"
    SELECT name, race, class, hit_points, strength, dexterity, constitution, intelligence, wisdom, charisma, character_notes, skills, abilities, attacks
    FROM npc";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        NPC npc = new NPC
                        {
                            Name = reader["name"].ToString(),
                            Race = reader["race"].ToString(),
                            Class = reader["class"].ToString(),
                            HitPoints = SafeIntFromReader(reader, "hit_points"),
                            Strength = SafeIntFromReader(reader, "strength"),
                            Dexterity = SafeIntFromReader(reader, "dexterity"),
                            Constitution = SafeIntFromReader(reader, "constitution"),
                            Intelligence = SafeIntFromReader(reader, "intelligence"),
                            Wisdom = SafeIntFromReader(reader, "wisdom"),
                            Charisma = SafeIntFromReader(reader, "charisma"),
                            CharacterNotes = reader["character_notes"].ToString(),
                            Skills = reader["skills"].ToString(),
                            Abilities = reader["abilities"].ToString(),
                            Attacks = reader["attacks"].ToString()
                        };

                        npcs.Add(npc);
                    }
                }
            }
        }

        return npcs;
    }

    private int SafeIntFromReader(SqlDataReader reader, string columnName)
    {
        int result = 0;
        try
        {
            if (!reader.IsDBNull(reader.GetOrdinal(columnName)))
            {
                result = Convert.ToInt32(reader[columnName]);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error reading integer value from column {columnName}: {e.Message}");
        }
        return result;
    }

}
