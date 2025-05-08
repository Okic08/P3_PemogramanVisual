using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Quiz_Application
{
    public partial class FormEditSoal : Form
    {
        private int soalId;
        private string connectionString = "server=localhost;user id=root;password=;database=winformquest;";

        public FormEditSoal()
        {
            InitializeComponent();
        }

        private void FormEditSoal_Load(object sender, EventArgs e)
        {
            LoadSoalKeListBox();
            listBoxSoal.SelectedIndexChanged += listBoxSoal_SelectedIndexChanged;
            btnEditSoal.Click += btnSaveChanges_Click;
        }

        private void LoadSoalKeListBox()
        {
            listBoxSoal.Items.Clear();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, question_text FROM questions";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32("id");
                        string text = reader.GetString("question_text");
                        listBoxSoal.Items.Add(new SoalItem(id, text));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat soal: " + ex.Message);
                }
            }
        }

        private void listBoxSoal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSoal.SelectedItem != null)
            {
                SoalItem selected = (SoalItem)listBoxSoal.SelectedItem;
                soalId = selected.Id;

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT * FROM questions WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", soalId);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            textBoxQuestion.Text = reader["question_text"].ToString();
                            textBoxOption1.Text = reader["option1"].ToString();
                            textBoxOption2.Text = reader["option2"].ToString();
                            textBoxOption3.Text = reader["option3"].ToString();
                            textBoxOption4.Text = reader["option4"].ToString();
                            textBoxCorrectAnswer.Text = reader["correct_answer"].ToString();
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal menampilkan soal: " + ex.Message);
                    }
                }
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (soalId == 0)
            {
                MessageBox.Show("Pilih soal terlebih dahulu.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxQuestion.Text) ||
                string.IsNullOrWhiteSpace(textBoxOption1.Text) ||
                string.IsNullOrWhiteSpace(textBoxOption2.Text) ||
                string.IsNullOrWhiteSpace(textBoxOption3.Text) ||
                string.IsNullOrWhiteSpace(textBoxOption4.Text) ||
                string.IsNullOrWhiteSpace(textBoxCorrectAnswer.Text))
            {
                MessageBox.Show("Semua kolom harus diisi.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE questions SET 
                        question_text = @question, 
                        option1 = @opt1,
                        option2 = @opt2,
                        option3 = @opt3,
                        option4 = @opt4,
                        correct_answer = @correct
                        WHERE id = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@question", textBoxQuestion.Text);
                    cmd.Parameters.AddWithValue("@opt1", textBoxOption1.Text);
                    cmd.Parameters.AddWithValue("@opt2", textBoxOption2.Text);
                    cmd.Parameters.AddWithValue("@opt3", textBoxOption3.Text);
                    cmd.Parameters.AddWithValue("@opt4", textBoxOption4.Text);
                    cmd.Parameters.AddWithValue("@correct", textBoxCorrectAnswer.Text);
                    cmd.Parameters.AddWithValue("@id", soalId);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Soal berhasil diperbarui.");
                        LoadSoalKeListBox(); // refresh list
                    }
                    else
                    {
                        MessageBox.Show("Tidak ada perubahan data.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan perubahan: " + ex.Message);
                }
            }
        }

        private class SoalItem
        {
            public int Id { get; }
            public string Text { get; }

            public SoalItem(int id, string text)
            {
                Id = id;
                Text = text;
            }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}
