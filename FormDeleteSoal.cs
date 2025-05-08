using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Quiz_Application
{
    public partial class FormDeleteSoal : Form
    {
        private string connectionString = "server=localhost;database=winformquest;uid=root;pwd=;"; // Ganti jika perlu

        public FormDeleteSoal()
        {
            InitializeComponent();
            LoadQuestions();
        }

        private void LoadQuestions()
        {
            listBoxQuestions.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT id, question_text FROM questions";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        string text = reader.GetString("question_text");
                        listBoxQuestions.Items.Add(new QuestionItem(id, text));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading questions: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxQuestions.SelectedItem == null)
            {
                MessageBox.Show("Please select a question to delete.");
                return;
            }

            var selectedItem = (QuestionItem)listBoxQuestions.SelectedItem;
            var confirmResult = MessageBox.Show("Are you sure you want to delete this question?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "DELETE FROM questions WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", selectedItem.Id);

                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Question deleted successfully.");
                        LoadQuestions();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting question: " + ex.Message);
                    }
                }
            }
        }

        private class QuestionItem
        {
            public int Id { get; }
            public string Text { get; }

            public QuestionItem(int id, string text)
            {
                Id = id;
                Text = text;
            }

            public override string ToString()
            {
                return $"[{Id}] {Text}";
            }
        }

        private void FormDeleteSoal_Load(object sender, EventArgs e)
        {
            // Optional: bisa isi dengan LoadQuestions(); jika tidak dipanggil dari constructor
        }
    }
}
