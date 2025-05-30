using Quiz_Application.Models;
using System;
using System.Collections.Generic;

namespace Quiz_Application.Controllers
{
    public class DeleteSoalController
    {
        // Ambil daftar soal singkat (id dan teks soal)
        public List<SoalModel.QuestionItem> GetQuestions()
        {
            try
            {
                return SoalModel.GetAllQuestions();
            }
            catch (Exception ex)
            {
                // Logging error bisa ditambahkan di sini
                throw new Exception("Gagal mengambil daftar soal: " + ex.Message, ex);
            }
        }

        // Hapus soal berdasarkan id, return true jika berhasil
        public bool DeleteQuestion(int id)
        {
            try
            {
                return SoalModel.DeleteQuestionById(id);
            }
            catch (Exception ex)
            {
                // Logging error bisa ditambahkan di sini
                throw new Exception("Gagal menghapus soal: " + ex.Message, ex);
            }
        }
    }
}
