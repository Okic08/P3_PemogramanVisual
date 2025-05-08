using MySql.Data.MySqlClient;

namespace Quiz_Application
{
    public partial class Login : Form
    {
        private string connectionString = "server=localhost;user=root;password=;database=winformquest;"; // Ganti sesuai konfigurasi Anda

        public Login()
        {
            InitializeComponent();
            btnLogin.Click += btnLogin_Click;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = password.Text;

            if (AuthenticateUser(user, pass))
            {
                MessageBox.Show("Login berhasil!");
                this.Hide();
                FormAdmin adminForm = new FormAdmin();
                adminForm.Show();
            }
            else
            {
                MessageBox.Show("Username atau password salah!");
            }
        }

        private bool AuthenticateUser(string user, string pass)
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
                        cmd.Parameters.AddWithValue("@username", user);
                        cmd.Parameters.AddWithValue("@password", pass); // Pastikan ini terenkripsi jika perlu

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        result = count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return result;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
