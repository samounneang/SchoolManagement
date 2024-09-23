using SchoolManagement.Helper;
using SchoolManagement.Models;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace SchoolManagement.Repositories
{
    internal class UserRepository: BaseRepository
    {
        private const string DefaultPassword = "DefaultPass123"; // Set your default password here

        public static bool Login(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT PasswordHash FROM Users WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);

                var storedPassword = cmd.ExecuteScalar() as string;

                if (storedPassword != null)
                {
                    // Decrypt the stored password and compare
                    string decryptedPassword = PasswordEncryption.DecryptPassword(storedPassword);
                    return decryptedPassword == password; // You may want to use a hash comparison instead
                }

                return false; // User not found
            }
        }
        public static string GetUserRole(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT r.RoleName FROM Users u INNER JOIN UserRoles ur ON u.UserId = ur.UserId INNER JOIN Roles r ON ur.RoleId = r.RoleId where Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);

                var role = cmd.ExecuteScalar() as string;
                return role;
            }
        }
        public static void AddUser(string userId, string username,string email, string password, string role)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string insertUserQuery = @"INSERT INTO Users (UserName, Email, PasswordHash) VALUES 
                (@Username,@Email,@PasswordHash)
";

                SqlCommand cmd = new SqlCommand(insertUserQuery, conn);
               // cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@PasswordHash",PasswordEncryption.EncryptPassword(password)); // Assume you have a HashPassword method
                cmd.Parameters.AddWithValue("@Email", email);
                //cmd.Parameters.AddWithValue("@FullName", "");
                //cmd.Parameters.AddWithValue("@IsActive", 1);
                //cmd.Parameters.AddWithValue("@CreatedAt", new DateTime().ToString());
                //cmd.Parameters.AddWithValue("@UpdatedAt", new DateTime().ToString());
                cmd.ExecuteNonQuery();
            }
        }
        public static List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(@$"select * from users", connection);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read()) {
                    users.Add(new User
                    {
                        Username = reader["Username"].ToString(),
                        Password = reader["PasswordHash"].ToString(),
                        Email = reader["Email"].ToString(),
                        Fullname = reader["Fullname"].ToString(),
                        CreateAt = reader["CreatedAt"].ToString(),
                        UpdateAt = reader["UpdatedAt"].ToString(),
                    });
                }
                connection.Close();
                return users;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return users;
            }
            //return users;
        }
        public static void UpdateUser(int userId, string username, string password, string role)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string updateUserQuery = "UPDATE Users SET Username = @Username, PasswordHash = @PasswordHash, Role = @Role WHERE UserId = @UserId";
                SqlCommand cmd = new SqlCommand(updateUserQuery, conn);
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@PasswordHash", PasswordEncryption.EncryptPassword(password));
                cmd.Parameters.AddWithValue("@Role", role);

                cmd.ExecuteNonQuery();
            }
        }
        public static void DeleteUser(int userId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string deleteUserQuery = "DELETE FROM Users WHERE UserId = @UserId";
                SqlCommand cmd = new SqlCommand(deleteUserQuery, conn);
                cmd.Parameters.AddWithValue("@UserId", userId);

                cmd.ExecuteNonQuery();
            }
        }
        public static User GetUserById(int userId)
        {
            User user = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string getUserQuery = "SELECT * FROM Users WHERE UserId = @UserId";
                SqlCommand cmd = new SqlCommand(getUserQuery, conn);
                cmd.Parameters.AddWithValue("@UserId", userId);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new User
                        {
                            //UserId = reader.GetString(0),
                            //Username = reader.GetString(1),
                            //Password = reader.GetString(2),
                            //Role = reader.GetString(3)
                        };
                    }
                }
            }

            return user;
        }
        public static string CreateUserId()
        {
            string NewUserId = "";
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(@$"select top 1 UserId from users", connection);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                    NewUserId = reader["UserId"].ToString();
                        
                connection.Close();
                return NewUserId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return NewUserId = "Erorr";
            }
        }
        public static bool ResetPassword(string username)
        {
            string newEncryptedPassword = PasswordEncryption.EncryptPassword(DefaultPassword);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Users SET Password = @Password WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Password", newEncryptedPassword);
                cmd.Parameters.AddWithValue("@Username", username);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0; // Return true if the password was reset
            }
        }
        public static string GetUserEmail(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Email FROM Users WHERE Username = @Username";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", username);

                return cmd.ExecuteScalar() as string; // Return the user's email
            }
        }
        public static void SendEmail(string toEmail, string username)
        {
            var fromAddress = new MailAddress("somoun.neang@gmail.com", "SchoolManagementSystem");
            var toAddress = new MailAddress(toEmail);
            const string fromPassword = "123"; // Use secure methods to store passwords
            const string subject = "Password Reset";
            string body = $"Hello {username},\n\nYour password has been reset to: {DefaultPassword}\n\nPlease change it after logging in.";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com", // Set your SMTP host
                Port = 587, // Set your SMTP port
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
        public static List<string> GetMenuItemsByRole(string role)
        {
            var menuItems = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MenuItem FROM MenuRole WHERE Role = @Role AND IsVisible = 1";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Role", role);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        menuItems.Add(reader["MenuItem"].ToString());
                    }
                }
            }
            return menuItems;
        }
    }
}