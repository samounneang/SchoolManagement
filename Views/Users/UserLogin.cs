using SchoolManagement.Repositories;

namespace SchoolManagement.Views
{
    public partial class UserLogin : Form
    {

        public UserLogin()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (UserRepository.Login(txtUserId.Text, txtPassword.Text))
            {
                string role = UserRepository.GetUserRole(txtUserId.Text);
                new MainForm(role).Show();
            }
            else
                MessageBox.Show("Invalid Username or Password!");
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
            string username = txtUserId.Text;

            //UserRepository userRepository = new UserRepository(connectionString);

            // Reset the password
            if (UserRepository.ResetPassword(username))
            {
                // Get the user's email to send the reset email
                string email = UserRepository.GetUserEmail(username);
                if (!string.IsNullOrEmpty(email))
                {
                    UserRepository.SendEmail(email, username);
                    MessageBox.Show("Password has been reset and sent to the user's email.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Email not found for this user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Failed to reset password. User may not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
