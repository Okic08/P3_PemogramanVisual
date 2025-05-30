using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Quiz_Application.Models
{
    public class SoalModel
    {
        private static readonly string connectionString = "server=localhost;user=root;password=;database=winformquest;";

        /// <summary>
        /// Representasi data soal singkat (id dan teks soal).
        /// </summary>
        public class QuestionItem
        {
            public int Id { get; set; }
            public string Text { get; set; } = string.Empty;

            public override string ToString() => Text;
        }

        /// <summary>
        /// Representasi data soal lengkap (detail).
        /// </summary>
        public class QuestionDetail
        {
            public int Id { get; set; }
            public string QuestionText { get; set; } = string.Empty;
            public string Option1 { get; set; } = string.Empty;
            public string Option2 { get; set; } = string.Empty;
            public string Option3 { get; set; } = string.Empty;
            public string Option4 { get; set; } = string.Empty;
            public int CorrectAnswer { get; set; }
        }

        /// <summary>
        /// Mengambil semua soal singkat (id dan question_text).
        /// </summary>
        /// <returns>List QuestionItem</returns>
        public static List<QuestionItem> GetAllQuestions()
        {
            var questions = new List<QuestionItem>();
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    const string query = "SELECT id, question_text FROM questions";
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                questions.Add(new QuestionItem
                                {
                                    Id = reader.GetInt32("id"),
                                    Text = reader.GetString("question_text") ?? string.Empty
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil data soal: " + ex.Message, ex);
            }
            return questions;
        }

        /// <summary>
        /// Mengambil detail soal berdasarkan id.
        /// </summary>
        /// <param name="id">Id soal</param>
        /// <returns>QuestionDetail atau null jika tidak ditemukan</returns>
        public static QuestionDetail? GetQuestionDetailById(int id)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    const string query = "SELECT * FROM questions WHERE id = @id";
                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new QuestionDetail
                                {
                                    Id = reader.GetInt32("id"),
                                    QuestionText = reader.GetString("question_text") ?? string.Empty,
                                    Option1 = reader.GetString("option1") ?? string.Empty,
                                    Option2 = reader.GetString("option2") ?? string.Empty,
                                    Option3 = reader.GetString("option3") ?? string.Empty,
                                    Option4 = reader.GetString("option4") ?? string.Empty,
                                    CorrectAnswer = reader.GetInt32("correct_answer")
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil detail soal: " + ex.Message, ex);
            }
            return null;
        }

        /// <summary>
        /// Mengambil semua soal lengkap dalam bentuk DataTable (untuk binding DataGridView).
        /// </summary>
        /// <returns>DataTable berisi data soal lengkap</returns>
        public static DataTable GetAllQuestionsTable()
        {
            var dt = new DataTable();
            try
            {
                using var conn = new MySqlConnection(connectionString);
                string query = "SELECT id, question_text, option1, option2, option3, option4, correct_answer FROM questions";
                using var cmd = new MySqlCommand(query, conn);
                using var adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal mengambil data soal: " + ex.Message, ex);
            }
            return dt;
        }

        /// <summary>
        /// Memperbarui data soal di database.
        /// </summary>
        /// <param name="question">Object QuestionDetail</param>
        /// <returns>True jika berhasil update, false jika gagal</returns>
        public static bool UpdateQuestion(QuestionDetail question)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    const string query = @"
                        UPDATE questions SET 
                        question_text = @question, 
                        option1 = @opt1,
                        option2 = @opt2,
                        option3 = @opt3,
                        option4 = @opt4,
                        correct_answer = @correct
                        WHERE id = @id";

                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@question", question.QuestionText);
                        cmd.Parameters.AddWithValue("@opt1", question.Option1);
                        cmd.Parameters.AddWithValue("@opt2", question.Option2);
                        cmd.Parameters.AddWithValue("@opt3", question.Option3);
                        cmd.Parameters.AddWithValue("@opt4", question.Option4);
                        cmd.Parameters.AddWithValue("@correct", question.CorrectAnswer);
                        cmd.Parameters.AddWithValue("@id", question.Id);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memperbarui soal: " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Menambah soal baru ke database.
        /// </summary>
        /// <param name="question">Teks soal</param>
        /// <param name="option1">Pilihan 1</param>
        /// <param name="option2">Pilihan 2</param>
        /// <param name="option3">Pilihan 3</param>
        /// <param name="option4">Pilihan 4</param>
        /// <param name="correctAnswer">Nomor jawaban benar (1-4)</param>
        /// <returns>True jika berhasil tambah, false jika gagal</returns>
        public static bool TambahSoal(string question, string option1, string option2, string option3, string option4, int correctAnswer)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    const string query = @"
                        INSERT INTO questions
                        (question_text, option1, option2, option3, option4, correct_answer) 
                        VALUES (@question, @option1, @option2, @option3, @option4, @correctAnswer)";

                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@question", question);
                        cmd.Parameters.AddWithValue("@option1", option1);
                        cmd.Parameters.AddWithValue("@option2", option2);
                        cmd.Parameters.AddWithValue("@option3", option3);
                        cmd.Parameters.AddWithValue("@option4", option4);
                        cmd.Parameters.AddWithValue("@correctAnswer", correctAnswer);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menambah soal baru: " + ex.Message, ex);
            }
        }

        /// <summary>
        /// Menghapus soal berdasarkan id.
        /// </summary>
        /// <param name="id">Id soal</param>
        /// <returns>True jika berhasil hapus, false jika gagal</returns>
        public static bool DeleteQuestionById(int id)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    const string query = "DELETE FROM questions WHERE id = @id";

                    conn.Open();
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal menghapus soal: " + ex.Message, ex);
            }
        }
    }
}
