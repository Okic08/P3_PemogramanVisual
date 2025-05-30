using System;
using System.Windows.Forms;

namespace Quiz_Application
{
    public partial class Login : Form
    {
        public event EventHandler<LoginEventArgs>? LoginButtonClicked;

        public string Username => username.Text;
        public string Password => password.Text;

        public Login()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click;
        }

        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            LoginButtonClicked?.Invoke(this, new LoginEventArgs(Username, Password));
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }

    public class LoginEventArgs : EventArgs
    {
        public string Username { get; }
        public string Password { get; }

        public LoginEventArgs(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
