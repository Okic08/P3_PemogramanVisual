using System;
using System.Windows.Forms;

namespace Quiz_Application
{
    public partial class FormAdmin : Form
    {
        // Event publik agar Controller bisa subscribe
        public event EventHandler? BtnAddSoalClicked;
        public event EventHandler? BtnEditSoalClicked;
        public event EventHandler? BtnDeleteSoalClicked;
        public event EventHandler? BtnViewSoalClicked;

        public FormAdmin()
        {
            InitializeComponent();

            // Relay event click tombol ke event publik
            btnAddSoal.Click += (s, e) => BtnAddSoalClicked?.Invoke(this, EventArgs.Empty);
            btnEditSoal.Click += (s, e) => BtnEditSoalClicked?.Invoke(this, EventArgs.Empty);
            btnDeleteSoal.Click += (s, e) => BtnDeleteSoalClicked?.Invoke(this, EventArgs.Empty);
            btnViewSoal.Click += (s, e) => BtnViewSoalClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
