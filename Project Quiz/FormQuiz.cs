using System;
using System.Windows.Forms;

namespace Ntahlah
{
    public partial class FormQuiz : Form
    {
        private string _username;

        public FormQuiz(string username)
        {
            InitializeComponent();
            _username = username;
            label1.Text = $"Semangat mengerjakan quiz, {_username}!";
        }

        private void FormQuiz_Load(object sender, EventArgs e)
        {
            // You can handle form load logic here if necessary
        }
    }
}
