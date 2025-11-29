using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace UIFinalTask
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void LLCreateNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCreateNewAccount form2 = new();
            form2.ShowDialog(); // modal
        }
        private void BTNLogin_Click(object sender, EventArgs e)
        {
            string username = TBUsername.Text.Trim();
            string password = TBPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string projectFolder = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(projectFolder, "usersinfo", "UserInfo.json");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("No user data found. Please sign up first.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string json = File.ReadAllText(filePath);
            var users = JsonSerializer.Deserialize<Dictionary<string, UserInfo>>(json);

            if (users == null || users.Count == 0)
            {
                MessageBox.Show("User data is empty.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashedPassword = HashPassword(password);

            bool isValidUser = users.Values.Any(u =>
                u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) &&
                u.Password == hashedPassword);

            if (isValidUser)
            {
                FormShowInformation form4 = new(username);
                form4.ShowDialog(); // modal
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Are you sure you want to exit the application?",
            "Confirm Exit",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            // If No is selected, do nothing and return to the login form

        }

        private void CBShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            TBPassword.UseSystemPasswordChar = !((CheckBox)sender).Checked;
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }
    }
}
