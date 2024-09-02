using System.Data.SqlClient;


namespace SchoolManagement.Views
{
    public partial class UserLogin : Form
    {
        private string connectionString = "your_connection_string_here"; // Replace with your SQL Server connection string

        public UserLogin()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = "";// = txtUsername.Text;
            string password = "";// = txtPassword.Text;

            if (AuthenticateUser(username, password, out string role))
            {
                MessageBox.Show($"Login successful! Role: {role}");
                //LoadRoleBasedForm(role);
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private bool AuthenticateUser(string username, string password, out string role)
        {
            role = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT PasswordHash, PasswordSalt, RoleName FROM Users INNER JOIN Roles ON Users.RoleID = Roles.RoleID WHERE Username = @Username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            byte[] storedHash = (byte[])reader["PasswordHash"];
                            byte[] storedSalt = (byte[])reader["PasswordSalt"];
                            role = reader["RoleName"].ToString();

                            if (PasswordHelper.VerifyPasswordHash(password, storedHash, storedSalt))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        //private void LoadRoleBasedForm(string role)
        //{
        //    Form dashboardForm = null;

        //    switch (role)
        //    {
        //        case "Administrator":
        //            dashboardForm = new AdminDashboard();
        //            break;
        //        case "Teacher":
        //            dashboardForm = new TeacherDashboard();
        //            break;
        //        case "Student":
        //            dashboardForm = new StudentDashboard();
        //            break;
        //        case "Parent":
        //            dashboardForm = new ParentDashboard();
        //            break;
        //        default:
        //            MessageBox.Show("Unknown role!");
        //            return;
        //    }

        //    if (dashboardForm != null)
        //    {
        //        dashboardForm.Show();
        //        this.Hide();
        //    }
        //}

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(((Label)sender).Text, DragDropEffects.All);
            //label1.Cursor = Cursors.SizeAll;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new UserRegister().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Login!");
            //StudentDashboard studentDashboard = new StudentDashboard();
            //ParentDashboard parent = new ParentDashboard();
            //TeacherDashboard teacher = new TeacherDashboard();
            //AdminDashboard admin = new AdminDashboard();

            //string role = "Admin";// cboRole.Text;

            //if (txtUsername.Text != "" && txtPassword.Text != "")
            //{

            //    switch (role)
            //    {
            //        case "Admin":
            //            admin.Show();
            //            this.Hide();
            //            break;

            //        case "Student":
            //            studentDashboard.Show();
            //            this.Hide();
            //            break; break;

            //        case "Staff":
            //        case "Teacher":
            //            teacher.Show();
            //            this.Hide();
            //            break;

            //        case "Parents":
            //            teacher.Show();
            //            this.Hide();
            //            break;
            //    }

            //}
            //else
            //    MessageBox.Show("Wrong user or password!");
            //this.Hide();



            // Subscribe to the Shown event of the MainForm
            //mainForm.Shown += (s, args) =>
            //{
            //    // Close the LoginForm when the MainForm is shown
            //    this.Close();
            //};

            // Show the MainForm

            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();

        }
        public void closeLoginForm(Form e)
        {
            e.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}
