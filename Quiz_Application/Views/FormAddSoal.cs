using System;
using System.Windows.Forms;

namespace Quiz_Application
{
    public partial class FormAddSoal : Form
    {
        public event EventHandler? OnTambahSoal; // Ubah jadi nullable

        public FormAddSoal()
        {
            InitializeComponent();
        }

        public string Question => textBoxQuestion.Text;
        public string Option1 => textBoxOption1.Text;
        public string Option2 => textBoxOption2.Text;
        public string Option3 => textBoxOption3.Text;
        public string Option4 => textBoxOption4.Text;
        public string CorrectAnswerText => textBoxCorrectAnswer.Text;

        public void ShowMessage(string pesan)
        {
            MessageBox.Show(pesan);
        }

        public void ClearForm()
        {
            textBoxQuestion.Clear();
            textBoxOption1.Clear();
            textBoxOption2.Clear();
            textBoxOption3.Clear();
            textBoxOption4.Clear();
            textBoxCorrectAnswer.Clear();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            OnTambahSoal?.Invoke(this, EventArgs.Empty);
        }

        // Tambahkan ini jika memang dikaitkan di Designer
        private void textBoxQuestion_TextChanged(object sender, EventArgs e)
        {
            // Kosongkan jika tidak ada logika
        }
    }
   }
