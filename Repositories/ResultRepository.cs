using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repositories
{
    internal class ResultRepository:BaseRepository
    {
        //private string connectionString = "your_connection_string_here";

        public void AddResult(int studentId, int examId, decimal marksObtained, string grade)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Results (StudentId, ExamId, MarksObtained, Grade) VALUES (@StudentId, @ExamId, @MarksObtained, @Grade)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentId", studentId);
                cmd.Parameters.AddWithValue("@ExamId", examId);
                cmd.Parameters.AddWithValue("@MarksObtained", marksObtained);
                cmd.Parameters.AddWithValue("@Grade", grade);
                cmd.ExecuteNonQuery();
            }
        }


        public List<Result> GetAllResults()
        {
            List<Result> results = new List<Result>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Result", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        results.Add(new Result
                        {
                            ResultId = (int)reader["ResultId"],
                            StudentId = (int)reader["StudentId"],
                            SubjectId = (int)reader["SubjectId"],
                            Score = (decimal)reader["Score"]
                        });
                    }
                }
            }
            return results;
        }

        public void UpdateResult(int resultId, decimal marksObtained, string grade)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Results SET MarksObtained = @MarksObtained, Grade = @Grade WHERE ResultId = @ResultId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MarksObtained", marksObtained);
                cmd.Parameters.AddWithValue("@Grade", grade);
                cmd.Parameters.AddWithValue("@ResultId", resultId);
                cmd.ExecuteNonQuery();
            }
        }


        public void DeleteResult(int resultId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Results WHERE ResultId = @ResultId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ResultId", resultId);
                cmd.ExecuteNonQuery();
            }
        }


    }
}
