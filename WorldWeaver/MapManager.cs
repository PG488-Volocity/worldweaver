using System.Data.SqlClient;
using System.Configuration;

namespace WorldWeaver
{
    public class MapManager
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;

        // Method to fetch the file path of a map image based on its name
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
    }
}
