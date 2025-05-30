using Quiz_Application.Controllers;
using Quiz_Application.Models;
using System;
using System.Windows.Forms;

namespace Quiz_Application
{
    public partial class FormDeleteSoal : Form
    {
        private DeleteSoalController controller;

        public FormDeleteSoal()
        {
            InitializeComponent();
            controller = new DeleteSoalController();
            LoadQuestions();
        }

        private void LoadQuestions()
        {
            listBoxQuestions.Items.Clear();
            try
            {
                var questions = controller.GetQuestions();
                foreach (var question in questions)
                {
                    listBoxQuestions.Items.Add(question);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading questions: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxQuestions.SelectedItem == null)
            {
                MessageBox.Show("Please select a question to delete.");
                return;
            }

            var selectedItem = (SoalModel.QuestionItem)listBoxQuestions.SelectedItem;
            var confirmResult = MessageBox.Show("Are you sure you want to delete this question?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    bool success = controller.DeleteQuestion(selectedItem.Id);
                    if (success)
                    {
                        MessageBox.Show("Question deleted successfully.");
                        LoadQuestions();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete question.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting question: " + ex.Message);
                }
            }
        }

        private void FormDeleteSoal_Load(object sender, EventArgs e)
        {
            // Optional: LoadQuestions(); sudah dipanggil di constructor
        }
    }
}
