using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repositories
{
    internal class SubjectRepository
    {
        //private string connectionString = "your_connection_string_here";

        public void AddSubject(Subject subject)
        {
            //using (var connection = new SqlConnection(connectionString))
            //{
            //    var command = new SqlCommand("INSERT INTO Subject (SubjectName, Credits) VALUES (@SubjectName, @Credits)", connection);
            //    command.Parameters.AddWithValue("@SubjectName", subject.SubjectName);
            //    command.Parameters.AddWithValue("@Credits", subject.Credits);
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //}
        }

        public List<Subject> GetAllSubjects()
        {
            List<Subject> subjects = new List<Subject>();
            //using (var connection = new SqlConnection(connectionString))
            //{
            //    var command = new SqlCommand("SELECT * FROM Subject", connection);
            //    connection.Open();
            //    using (var reader = command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            subjects.Add(new Subject
            //            {
            //                SubjectId = (int)reader["SubjectId"],
            //                SubjectName = reader["SubjectName"].ToString(),
            //                Credits = (int)reader["Credits"]
            //            });
            //        }
            //    }
            //}
            return subjects;
        }
    }
}
