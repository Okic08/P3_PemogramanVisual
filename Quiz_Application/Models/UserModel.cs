using MySql.Data.MySqlClient;

namespace Quiz_Application.Models
{
    public class UserModel
    {
        private readonly string connectionString = "server=localhost;user=root;password=;database=winformquest;";

        public bool AuthenticateUser(string username, string password)
        {
            bool result = false;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password); // Pastikan hash/enkripsi sesuai kebutuhan

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        result = count > 0;
                    }
                }
                catch
                {
                    // Bisa lempar exception atau handle di Controller
                    throw;
                }
            }
            return result;
        }
    }
}
