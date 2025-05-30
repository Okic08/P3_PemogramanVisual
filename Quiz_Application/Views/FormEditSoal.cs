using Quiz_Application.Controllers;
using Quiz_Application.Models;
using System;
using System.Windows.Forms;

namespace Quiz_Application
{
    public partial class FormEditSoal : Form
    {
        private readonly EditSoalController controller = new EditSoalController();
        private int selectedSoalId = 0;

        public FormEditSoal()
        {
            InitializeComponent();
        }

        private void FormEditSoal_Load(object? sender, EventArgs e)
        {
            listBoxSoal.SelectedIndexChanged += listBoxSoal_SelectedIndexChanged;
            btnEditSoal.Click += btnEditSoal_Click;
            LoadSoalKeListBox();
        }

        private void LoadSoalKeListBox()
        {
            listBoxSoal.Items.Clear();
            try
            {
                var soalList = controller.LoadSoalRingkas();
                foreach (var soal in soalList)
                {
                    listBoxSoal.Items.Add(soal);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat soal: " + ex.Message);
            }
        }

        private void listBoxSoal_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (listBoxSoal.SelectedItem is SoalModel.QuestionItem soal)
            {
                selectedSoalId = soal.Id;
                try
                {
                    var detail = controller.LoadDetailSoal(selectedSoalId);
                    if (detail != null)
                    {
                        textBoxQuestion.Text = detail.QuestionText;
                        textBoxOption1.Text = detail.Option1;
                        textBoxOption2.Text = detail.Option2;
                        textBoxOption3.Text = detail.Option3;
                        textBoxOption4.Text = detail.Option4;
                        textBoxCorrectAnswer.Text = detail.CorrectAnswer.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menampilkan soal: " + ex.Message);
                }
            }
        }

        private void btnEditSoal_Click(object? sender, EventArgs e)
        {
            if (selectedSoalId == 0)
            {
                MessageBox.Show("Pilih soal terlebih dahulu.");
                return;
            }

            var soal = new SoalModel.QuestionDetail
            {
                Id = selectedSoalId,
                QuestionText = textBoxQuestion.Text.Trim(),
                Option1 = textBoxOption1.Text.Trim(),
                Option2 = textBoxOption2.Text.Trim(),
                Option3 = textBoxOption3.Text.Trim(),
                Option4 = textBoxOption4.Text.Trim(),
            };

            if (!int.TryParse(textBoxCorrectAnswer.Text.Trim(), out int correct))
            {
                MessageBox.Show("Jawaban benar harus berupa angka.");
                return;
            }
            soal.CorrectAnswer = correct;

            try
            {
                bool success = controller.SimpanPerubahan(soal);
                if (success)
                {
                    MessageBox.Show("Soal berhasil diperbarui.");
                    LoadSoalKeListBox();
                }
                else
                {
                    MessageBox.Show("Tidak ada perubahan data.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menyimpan perubahan: " + ex.Message);
            }
        }
    }
}
