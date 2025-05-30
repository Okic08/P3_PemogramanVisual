namespace Ntahlah
{
    public partial class Thumbnail : Form
    {
        public Thumbnail()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            this.Hide();
            login.Show();
        }
    }
}
