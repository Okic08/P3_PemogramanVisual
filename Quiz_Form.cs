using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Quiz_Application
{
    public partial class Quiz_Form : Form
    {
        private List<Question> questions = new List<Question>();
        private int currentQuestionIndex = 0;
        private int[] userAnswers;

        public Quiz_Form()
        {
            InitializeComponent();
        }

        private void Quiz_Form_Load(object sender, EventArgs e)
        {
            LoadQuestionsFromDatabase();
            userAnswers = new int[questions.Count];
            DisplayQuestion();
        }

        private void LoadQuestionsFromDatabase()
        {
            string connStr = "server=localhost;user=root;password=;database=winformquest;";
            using (var conn = new MySqlConnection(connStr))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM questions";
                    using (var cmd = new MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            questions.Add(new Question
                            {
                                Text = reader.GetString("question_text"),
                                Options = new string[]
                                {
                                    reader.GetString("option1"),
                                    reader.GetString("option2"),
                                    reader.GetString("option3"),
                                    reader.GetString("option4")
                                },
                                CorrectAnswer = reader.GetInt32("correct_answer")
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                    Application.Exit();
                }
            }
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < 0 || currentQuestionIndex >= questions.Count)
                return;

            var question = questions[currentQuestionIndex];
            label_QuestionNumber.Text = $"Question {currentQuestionIndex + 1}/{questions.Count}";
            richTextBox_Question.Text = question.Text;
            radioButton_Option1.Text = question.Options[0];
            radioButton_Option2.Text = question.Options[1];
            radioButton_Option3.Text = question.Options[2];
            radioButton_Option4.Text = question.Options[3];

            radioButton_Option1.Checked = userAnswers[currentQuestionIndex] == 1;
            radioButton_Option2.Checked = userAnswers[currentQuestionIndex] == 2;
            radioButton_Option3.Checked = userAnswers[currentQuestionIndex] == 3;
            radioButton_Option4.Checked = userAnswers[currentQuestionIndex] == 4;
        }

        private void SaveUserAnswer()
        {
            if (radioButton_Option1.Checked) userAnswers[currentQuestionIndex] = 1;
            else if (radioButton_Option2.Checked) userAnswers[currentQuestionIndex] = 2;
            else if (radioButton_Option3.Checked) userAnswers[currentQuestionIndex] = 3;
            else if (radioButton_Option4.Checked) userAnswers[currentQuestionIndex] = 4;
        }

        private void Button_Next_Click(object sender, EventArgs e)
        {
            SaveUserAnswer();
            if (currentQuestionIndex < questions.Count - 1)
            {
                currentQuestionIndex++;
                DisplayQuestion();
            }
            else
            {
                ShowResult();
            }
        }

        private void Button_Previous_Click(object sender, EventArgs e)
        {
            SaveUserAnswer();
            if (currentQuestionIndex > 0)
            {
                currentQuestionIndex--;
                DisplayQuestion();
            }
        }

        private void ShowResult()
        {
            int correct = 0;
            for (int i = 0; i < questions.Count; i++)
            {
                if (userAnswers[i] == questions[i].CorrectAnswer)
                    correct++;
            }

            MessageBox.Show($"You got {correct} out of {questions.Count} correct!", "Result");
        }
    }

    public class Question
    {
        public string Text { get; set; }
        public string[] Options { get; set; }
        public int CorrectAnswer { get; set; }
    }
}
