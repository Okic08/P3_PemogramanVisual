using Quiz_Application.Models;
using System;
using System.Data;

namespace Quiz_Application.Controllers
{
    public class ViewSoalController
    {
        public DataTable LoadAllQuestions()
        {
            try
            {
                return SoalModel.GetAllQuestionsTable();
            }
            catch (Exception ex)
            {
                throw new Exception("Gagal memuat soal: " + ex.Message, ex);
            }
        }
    }
}
