using System;
using System.Windows.Forms;

namespace Quiz_Application
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        // Fungsi untuk membuka Form Add Soal
        private void btnAddSoal_Click(object sender, EventArgs e)
        {
            FormAddSoal formAddSoal = new FormAddSoal();
            formAddSoal.Show();
        }

        // Fungsi untuk membuka Form Edit Soal
        

        // Fungsi untuk membuka Form Delete Soal
        private void btnDeleteSoal_Click(object sender, EventArgs e)
        {
            FormDeleteSoal formDeleteSoal = new FormDeleteSoal();
            formDeleteSoal.Show();
        }

        // Fungsi untuk membuka Form View Soal
        private void btnViewSoal_Click(object sender, EventArgs e)
        {
            FormViewSoal formViewSoal = new FormViewSoal();
            formViewSoal.Show();
        }
    }
}
