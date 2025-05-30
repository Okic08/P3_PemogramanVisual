using System;
using System.Windows.Forms;

namespace sederhana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Anjay Kalkulator";
        }


        private void btnTambah_Click(object sender, EventArgs e)
        {
            Hitung("+");
        }

        private void btnKurang_Click(object sender, EventArgs e)
        {
            Hitung("-");
        }

        private void btnKali_Click(object sender, EventArgs e)
        {
            Hitung("*");
        }

        private void btnBagi_Click(object sender, EventArgs e)
        {
            Hitung("/");
        }

        private void Hitung(string operasi)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);
                double hasil = 0;

                switch (operasi)
                {
                    case "+": hasil = num1 + num2; break;
                    case "-": hasil = num1 - num2; break;
                    case "*": hasil = num1 * num2; break;
                    case "/":
                        if (num2 == 0)
                        {
                            MessageBox.Show("Tidak bisa dibagi dengan nol!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        hasil = num1 / num2;
                        break;
                }

                textBox3.Text = hasil.ToString();
            }
            catch
            {
                MessageBox.Show("Masukkan angka yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
