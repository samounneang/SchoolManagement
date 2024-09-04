using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repositories
{
    internal class StudentRepository
    {
        //private string connectionString = "your_connection_string_here";

        public void AddStudent(Student student)
        {
            //using (var connection = new SqlConnection(connectionString))
            //{
            //    var command = new SqlCommand("INSERT INTO Student (Name, DateOfBirth, Grade, ParentContact) VALUES (@Name, @DateOfBirth, @Grade, @ParentContact)", connection);
            //    command.Parameters.AddWithValue("@Name", student.Name);
            //    command.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
            //    command.Parameters.AddWithValue("@Grade", student.Grade);
            //    command.Parameters.AddWithValue("@ParentContact", student.ParentContact);
            //    connection.Open();
            //    command.ExecuteNonQuery();
            //}
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            //using (var connection = new SqlConnection(connectionString))
            //{
            //    var command = new SqlCommand("SELECT * FROM Student", connection);
            //    connection.Open();
            //    using (var reader = command.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            students.Add(new Student
            //            {
            //                StudentId = (int)reader["StudentId"],
            //                Name = reader["Name"].ToString(),
            //                DateOfBirth = (DateTime)reader["DateOfBirth"],
            //                Grade = reader["Grade"].ToString(),
            //                ParentContact = reader["ParentContact"].ToString()
            //            });
            //        }
            //    }
            //}
            return students;
        }
    }
}
