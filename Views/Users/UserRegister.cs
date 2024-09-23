using SchoolManagement.Repositories;

namespace SchoolManagement.Views
{
    public partial class UserRegister : Form
    {
        public UserRegister()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new UserLogin().Show();
            this.Hide();
        }

        private void linkForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Your password has been reset.");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConPassword.Text)
            {
                MessageBox.Show("Password does not match.");
                return;
            }
            string UserId = UserRepository.CreateUserId(); // Get new User ID from DB
            UserRepository.AddUser(UserId,txtUsername.Text,txtEmail.Text,txtPassword.Text,txtConPassword.Text);
        }
    }
}