using System;
using Quiz_Application.Models;

namespace Quiz_Application.Controllers
{
    public class AddSoalController
    {
        private readonly FormAddSoal _view;

        public AddSoalController(FormAddSoal view)
        {
            _view = view ?? throw new ArgumentNullException(nameof(view));
            _view.OnTambahSoal += HandleTambahSoal;
        }

        private void HandleTambahSoal(object? sender, EventArgs e)
        {
            // Ambil input dari view
            string question = _view.Question?.Trim() ?? string.Empty;
            string option1 = _view.Option1?.Trim() ?? string.Empty;
            string option2 = _view.Option2?.Trim() ?? string.Empty;
            string option3 = _view.Option3?.Trim() ?? string.Empty;
            string option4 = _view.Option4?.Trim() ?? string.Empty;
            string correctAnswerText = _view.CorrectAnswerText?.Trim() ?? string.Empty;

            // Validasi input
            if (string.IsNullOrWhiteSpace(question) ||
                string.IsNullOrWhiteSpace(option1) ||
                string.IsNullOrWhiteSpace(option2) ||
                string.IsNullOrWhiteSpace(option3) ||
                string.IsNullOrWhiteSpace(option4) ||
                !int.TryParse(correctAnswerText, out int correctAnswer) ||
                correctAnswer < 1 || correctAnswer > 4)
            {
                _view.ShowMessage("Mohon isi semua field dengan benar! Jawaban benar harus angka antara 1 hingga 4.");
                return;
            }

            try
            {
                // Panggil model untuk tambah soal
                bool sukses = SoalModel.TambahSoal(question, option1, option2, option3, option4, correctAnswer);

                if (sukses)
                {
                    _view.ShowMessage("Soal berhasil ditambahkan!");
                    _view.ClearForm();
                }
                else
                {
                    _view.ShowMessage("Gagal menambahkan soal. Silakan coba lagi.");
                }
            }
            catch (Exception ex)
            {
                // Tangani error dengan menampilkan pesan ke user
                _view.ShowMessage($"Terjadi kesalahan saat menambahkan soal: {ex.Message}");
            }
        }
    }
}
