using System.Data.SqlClient;
using System.Configuration;

namespace WorldWeaver
{
    public class PlayerManager
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnectionString"].ConnectionString;

        // Method to fetch the file path of a player's token image based on its token ID
        public string GetTokenImagePath(int tokenId)
        {
            // Write your SQL query to fetch the token file path from the tokens table based on the token ID
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
    }
}
