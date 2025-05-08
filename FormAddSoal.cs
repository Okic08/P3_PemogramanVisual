using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Quiz_Application
{
    public partial class FormAddSoal : Form
    {
        // Ganti sesuai konfigurasi database Anda
        private string connectionString = "server=localhost;user=root;password=;database=winformquest;";

        public FormAddSoal()
        {
            InitializeComponent();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            string question = textBoxQuestion.Text;
            string option1 = textBoxOption1.Text;
            string option2 = textBoxOption2.Text;
            string option3 = textBoxOption3.Text;
            string option4 = textBoxOption4.Text;
            int correctAnswer;

            // Validasi input
            if (string.IsNullOrWhiteSpace(question) ||
                string.IsNullOrWhiteSpace(option1) ||
                string.IsNullOrWhiteSpace(option2) ||
                string.IsNullOrWhiteSpace(option3) ||
                string.IsNullOrWhiteSpace(option4) ||
                !int.TryParse(textBoxCorrectAnswer.Text, out correctAnswer) ||
                correctAnswer < 1 || correctAnswer > 4)
            {
                MessageBox.Show("Mohon isi semua field dengan benar!");
                return;
            }

            // Simpan ke database
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO questions
                                    (question_text, option1, option2, option3, option4, correct_answer) 
                                    VALUES (@question, @option1, @option2, @option3, @option4, @correctAnswer)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@question", question);
                        cmd.Parameters.AddWithValue("@option1", option1);
                        cmd.Parameters.AddWithValue("@option2", option2);
                        cmd.Parameters.AddWithValue("@option3", option3);
                        cmd.Parameters.AddWithValue("@option4", option4);
                        cmd.Parameters.AddWithValue("@correctAnswer", correctAnswer);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Soal berhasil ditambahkan!");
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("Gagal menambahkan soal.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ClearForm()
        {
            textBoxQuestion.Clear();
            textBoxOption1.Clear();
            textBoxOption2.Clear();
            textBoxOption3.Clear();
            textBoxOption4.Clear();
            textBoxCorrectAnswer.Clear();
        }

        private void textBoxQuestion_TextChanged(object sender, EventArgs e) { }
    }
}
