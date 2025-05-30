using Quiz_Application.Models;
using System;
using System.Collections.Generic;

namespace Quiz_Application.Controllers
{
    public class EditSoalController
    {
        // Load semua soal ringkas untuk listbox
        public List<SoalModel.QuestionItem> LoadSoalRingkas()
        {
            return SoalModel.GetAllQuestions();
        }

        // Load detail soal lengkap berdasarkan id
        public SoalModel.QuestionDetail? LoadDetailSoal(int id)
        {
            return SoalModel.GetQuestionDetailById(id);
        }

        // Simpan perubahan soal
        public bool SimpanPerubahan(SoalModel.QuestionDetail soal)
        {
            if (string.IsNullOrWhiteSpace(soal.QuestionText)
                || string.IsNullOrWhiteSpace(soal.Option1)
                || string.IsNullOrWhiteSpace(soal.Option2)
                || string.IsNullOrWhiteSpace(soal.Option3)
                || string.IsNullOrWhiteSpace(soal.Option4))
            {
                throw new ArgumentException("Semua field harus diisi");
            }

            if (soal.CorrectAnswer < 1 || soal.CorrectAnswer > 4)
            {
                throw new ArgumentException("Jawaban benar harus antara 1 sampai 4");
            }

            return SoalModel.UpdateQuestion(soal);
        }
    }
}
