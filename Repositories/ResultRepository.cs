using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repositories
{
    internal class ResultRepository
    {
        //private string connectionString = "your_connection_string_here";

        public void AddResult(Result result)
        {
            //using (var connection = new SqlConnection(connectionString))
            //{
            //    var command = new SqlCommand("INSERT INTO Result (StudentId, SubjectId, Score) VALUES (@StudentId, @SubjectId, @Score)", connection);
            //    command.Parameters.AddWithValue("@StudentId", result.StudentId);
            //    command.Parameters.AddWithValue("@SubjectId", result.SubjectId);
            //    command.Parameters.AddWithValue("@Score", result.Score);
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //}
        }

        public List<Result> GetAllResults()
        {
            List<Result> results = new List<Result>();
            //using (var connection = new SqlConnection(connectionString))
            //{
            //    var command = new SqlCommand("SELECT * FROM Result", connection);
            //    connection.Open();
            //    using (var reader = command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            results.Add(new Result
            //            {
            //                ResultId = (int)reader["ResultId"],
            //                StudentId = (int)reader["StudentId"],
            //                SubjectId = (int)reader["SubjectId"],
            //                Score = (decimal)reader["Score"]
            //            });
            //        }
            //    }
            //}
            return results;
        }
    }
}
