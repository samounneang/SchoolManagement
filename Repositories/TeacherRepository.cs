using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repositories
{
    internal class TeacherRepository
    {
        //private string connectionString = "your_connection_string_here";

        public void AddTeacher(Teacher teacher)
        {
            //using (var connection = new SqlConnection(connectionString))
            //{
            //    var command = new SqlCommand("INSERT INTO Teacher (Name, Subject, Email, Phone) VALUES (@Name, @Subject, @Email, @Phone)", connection);
            //    command.Parameters.AddWithValue("@Name", teacher.Name);
            //    command.Parameters.AddWithValue("@Subject", teacher.Subject);
            //    command.Parameters.AddWithValue("@Email", teacher.Email);
            //    command.Parameters.AddWithValue("@Phone", teacher.Phone);
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //}
        }

        public List<Teacher> GetAllTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();
            //using (var connection = new SqlConnection(connectionString))
            //{
            //    var command = new SqlCommand("SELECT * FROM Teacher", connection);
            //    connection.Open();
            //    using (var reader = command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            teachers.Add(new Teacher
            //            {
            //                TeacherId = (int)reader["TeacherId"],
            //                Name = reader["Name"].ToString(),
            //                Subject = reader["Subject"].ToString(),
            //                Email = reader["Email"].ToString(),
            //                Phone = reader["Phone"].ToString()
            //            });
            //        }
            //    }
            //}
            return teachers;
        }
    }
}
