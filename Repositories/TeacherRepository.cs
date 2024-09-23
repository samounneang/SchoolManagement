using SchoolManagement.Models;
using System.Data.SqlClient;


namespace SchoolManagement.Repositories
{
    internal class TeacherRepository:BaseRepository
    {
        public void AddTeacher(Teacher teacher)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("INSERT INTO Teacher (Name, Subject, Email, Phone) VALUES (@Name, @Subject, @Email, @Phone)", connection);
                command.Parameters.AddWithValue("@Name", teacher.Name);
                command.Parameters.AddWithValue("@Subject", teacher.Subject);
                command.Parameters.AddWithValue("@Email", teacher.Email);
                command.Parameters.AddWithValue("@Phone", teacher.Phone);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public List<Teacher> GetAllTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Teacher", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        teachers.Add(new Teacher
                        {
                            TeacherId = (int)reader["TeacherId"],
                            Name = reader["Name"].ToString(),
                            Subject = reader["Subject"].ToString(),
                            Email = reader["Email"].ToString(),
                            Phone = reader["Phone"].ToString()
                        });
                    }
                }
            }
            return teachers;
        }
        public void UpdateTeacher(int teacherId, string teacherName, string subject, string phoneNumber)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string updateTeacherQuery = "UPDATE Teachers SET TeacherName = @TeacherName, Subject = @Subject, PhoneNumber = @PhoneNumber WHERE TeacherId = @TeacherId";
                SqlCommand cmd = new SqlCommand(updateTeacherQuery, conn);
                cmd.Parameters.AddWithValue("@TeacherId", teacherId);
                cmd.Parameters.AddWithValue("@TeacherName", teacherName);
                cmd.Parameters.AddWithValue("@Subject", subject);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                cmd.ExecuteNonQuery();
            }
        }
        public void DeleteTeacher(int teacherId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string deleteTeacherQuery = "DELETE FROM Teachers WHERE TeacherId = @TeacherId";
                SqlCommand cmd = new SqlCommand(deleteTeacherQuery, conn);
                cmd.Parameters.AddWithValue("@TeacherId", teacherId);

                cmd.ExecuteNonQuery();
            }
        }
        public Teacher GetTeacherById(int teacherId)
        {
            Teacher teacher = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string getTeacherQuery = "SELECT * FROM Teachers WHERE TeacherId = @TeacherId";
                SqlCommand cmd = new SqlCommand(getTeacherQuery, conn);
                cmd.Parameters.AddWithValue("@TeacherId", teacherId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        teacher = new Teacher
                        {
                            TeacherId = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Subject = reader.GetString(2),
                            Phone = reader.GetString(3)
                        };
                    }
                }
            }

            return teacher;
        }

    }
}
