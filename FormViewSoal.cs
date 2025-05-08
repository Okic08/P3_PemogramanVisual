using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Tambahkan untuk MySQL

namespace Quiz_Application
{
    public partial class FormViewSoal : Form
    {
        // Ganti dengan connection string Anda
        private string connectionString = "Server=localhost;Database=winformquest;User ID=root;Password=";

        public FormViewSoal()
        {
            InitializeComponent();
            LoadQuestions(); // Panggil fungsi untuk memuat soal saat form pertama kali dibuka
        }

        // Fungsi untuk memuat soal dari database ke DataGridView
        private void LoadQuestions()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT id, question_text, option1, option2, option3, option4, correct_answer FROM questions";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable table = new DataTable();

                try
                {
                    adapter.Fill(table);
                    dataGridViewQuestions.DataSource = table;

                    // Menyembunyikan kolom 'id' yang tidak perlu ditampilkan
                    dataGridViewQuestions.Columns["id"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading questions: " + ex.Message);
                }
            }
        }

        // Event handler untuk tombol Refresh
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadQuestions(); // Memuat ulang soal dari database
        }

        // Event handler untuk klik sel pada DataGridView (tidak digunakan dalam contoh ini)
        private void dataGridViewQuestions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Anda bisa menambahkan kode di sini jika perlu menangani klik pada cell
        }
    }
}
