using System;
using System.Windows.Forms;

namespace Quiz_Application
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
            label1.Text = "Selamat datang di quiz!";
        }

        private void BtnMulai_Click(object sender, EventArgs e)
        {
            Quiz_Form quiz = new Quiz_Form();
            this.Hide();
            quiz.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Login adminForm = new Login();
            this.Hide();
            adminForm.Show();
        }

        // Jika tidak ingin aksi apapun pada klik label1, hapus method ini
        private void label1_Click(object sender, EventArgs e)
        {
            // Aksi bisa ditambahkan jika diperlukan
        }

        // Jika tidak ingin aksi apapun pada klik label2, hapus method ini
        private void label2_Click(object sender, EventArgs e)
        {
            // Aksi bisa ditambahkan jika diperlukan
        }

        private void FormStart_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
