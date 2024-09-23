using SchoolManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repositories
{
    internal class StudentRepository:BaseRepository
    {

        public void AddStudent(Student student)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("INSERT INTO Student (Name, DateOfBirth, Grade, ParentContact) VALUES (@Name, @DateOfBirth, @Grade, @ParentContact)", connection);
                command.Parameters.AddWithValue("@Name", student.Name);
                command.Parameters.AddWithValue("@DateOfBirth", student.DateOfBirth);
                command.Parameters.AddWithValue("@Grade", student.Grade);
                command.Parameters.AddWithValue("@ParentContact", student.ParentContact);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Student", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            StudentId = (int)reader["StudentId"],
                            Name = reader["Name"].ToString(),
                            DateOfBirth = (DateTime)reader["DateOfBirth"],
                            Grade = reader["Grade"].ToString(),
                            ParentContact = reader["ParentContact"].ToString()
                        });
                    }
                }
            }
            return students;
        }
        private const long MaxFileSize = 2 * 1024 * 1024; // 2 MB in bytes
        public void UploadStudentPhoto(int studentId, string photoPath)
        {
            //if (!string.IsNullOrEmpty(photoPath))
            //{
            //    // Define the path to save the photo
            //    string uploadsFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "uploads", "photos");
            //    string fileName = $"{studentId}_{Path.GetFileName(photoPath)}";
            //    string fullPath = Path.Combine(uploadsFolder, fileName);

            //    // Ensure the uploads folder exists
            //    if (!Directory.Exists(uploadsFolder))
            //    {
            //        Directory.CreateDirectory(uploadsFolder);
            //    }

            //    // Copy the photo file
            //    File.Copy(photoPath, fullPath, true);

            //    // Update the database with the file path
            //    using (SqlConnection conn = new SqlConnection(connectionString))
            //    {
            //        conn.Open();
            //        string query = "UPDATE Students SET PhotoPath = @PhotoPath WHERE StudentId = @StudentId";
            //        SqlCommand cmd = new SqlCommand(query, conn);
            //        cmd.Parameters.AddWithValue("@PhotoPath", $"/uploads/photos/{fileName}");
            //        cmd.Parameters.AddWithValue("@StudentId", studentId);
            //        cmd.ExecuteNonQuery();
            //    }
            //}

            if (!string.IsNullOrEmpty(photoPath))
            {
                // Check the file size
                FileInfo fileInfo = new FileInfo(photoPath);
                if (fileInfo.Length > MaxFileSize)
                {
                    MessageBox.Show("File size must be less than 2 MB.", "File Size Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Define the path to save the photo
                string uploadsFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "uploads", "photos");
                string fileName = $"{studentId}_{Path.GetFileName(photoPath)}";
                string fullPath = Path.Combine(uploadsFolder, fileName);

                // Ensure the uploads folder exists
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                // Copy the photo file
                File.Copy(photoPath, fullPath, true);

                // Update the database with the file path
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Students SET PhotoPath = @PhotoPath WHERE StudentId = @StudentId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@PhotoPath", $"/uploads/photos/{fileName}");
                    cmd.Parameters.AddWithValue("@StudentId", studentId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public string GetStudentPhotoPath(int studentId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT PhotoPath FROM Students WHERE StudentId = @StudentId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentId", studentId);

                return cmd.ExecuteScalar() as string;
            }
        }
    }
}
