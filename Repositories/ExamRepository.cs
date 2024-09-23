using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repositories
{
    internal class ExamRepository:BaseRepository
    {
        public void AddExam(string examName, DateTime examDate, string subject, int classId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Exams (ExamName, ExamDate, Subject, ClassId) VALUES (@ExamName, @ExamDate, @Subject, @ClassId)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ExamName", examName);
                cmd.Parameters.AddWithValue("@ExamDate", examDate);
                cmd.Parameters.AddWithValue("@Subject", subject);
                cmd.Parameters.AddWithValue("@ClassId", classId);
                cmd.ExecuteNonQuery();
            }
        }
        public void UpdateExam(int examId, string examName, DateTime examDate, string subject, int classId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Exams SET ExamName = @ExamName, ExamDate = @ExamDate, Subject = @Subject, ClassId = @ClassId WHERE ExamId = @ExamId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ExamName", examName);
                cmd.Parameters.AddWithValue("@ExamDate", examDate);
                cmd.Parameters.AddWithValue("@Subject", subject);
                cmd.Parameters.AddWithValue("@ClassId", classId);
                cmd.Parameters.AddWithValue("@ExamId", examId);
                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteExam(int examId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Exams WHERE ExamId = @ExamId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ExamId", examId);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
