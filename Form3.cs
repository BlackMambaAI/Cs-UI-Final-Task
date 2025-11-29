using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace UIFinalTask
{
    public partial class FormUserInformation : Form
    {
        private readonly string _username;
        private readonly string _password;
        private readonly FormCreateNewAccount _form2;

        public FormUserInformation(string username, string password, FormCreateNewAccount form2)
        {
            InitializeComponent();
            LoadMajors();
            CBMajorOfStudies.SelectedIndex = -1; // Optional: forces user to choose
            _username = username;
            _password = password;
            _form2 = form2;
            labelFillSignUpForm.Text = $"Sign Up Form for {_username}";

        }
        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            if (!IsValidId(TBId.Text))
            {
                MessageBox.Show("ID must be a 9-digit number.");
                return;
            }

            if (!IsValidFullName(TBFullName.Text))
            {
                MessageBox.Show("Full name must contain first and last name separated by a space.");
                return;
            }

            if (!IsValidCellular(TBCellularNumber.Text))
            {
                MessageBox.Show("Cellular number must be in the format 05X-XXXXXXX.");
                return;
            }

            if (!IsValidEmail(TBEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }
            
            if (CBMajorOfStudies.SelectedItem == null)
            {
                MessageBox.Show("Please select a major of studies.");
                return;
            }

            UpdateCalculatedAge();
            SaveUserInfoToJson(); // Call after validation
            MessageBox.Show("User information is valid and processed.");
            _form2.Close(); // Close FormCreateNewAccount
            this.Close();   // Close FormUserInformation
        }

        private void BTNCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SaveUserInfoToJson()
        {
            DateTime birthDate = TBBirthDate.Value;
            int age = DateTime.Today.Year - birthDate.Year;
            if (birthDate > DateTime.Today.AddYears(-age)) age--;

            var userInfo = new UserInfo
            {
                Username = _username,
                Password = HashPassword(_password), // 🔒 hashed password
                IdNumber = TBId.Text,
                FullName = TBFullName.Text,
                BirthDate = birthDate,
                Age = age,
                CellularNumber = TBCellularNumber.Text,
                Email = TBEmail.Text,
                Major = (CBMajorOfStudies.SelectedItem as Major)?.Name ?? string.Empty
            };

            string projectFolder = AppDomain.CurrentDomain.BaseDirectory;
            string usersInfoFolder = Path.Combine(projectFolder, "usersinfo");
            Directory.CreateDirectory(usersInfoFolder);

            string filePath = Path.Combine(usersInfoFolder, "UserInfo.json");

            Dictionary<string, UserInfo> users;

            if (File.Exists(filePath))
            {
                string existingJson = File.ReadAllText(filePath);
                users = JsonSerializer.Deserialize<Dictionary<string, UserInfo>>(existingJson) ?? new Dictionary<string, UserInfo>();

                // Check for duplicate ID
                if (users.ContainsKey(userInfo.IdNumber))
                {
                    MessageBox.Show("This ID number is already registered.");
                    return;
                }

                // Check for duplicate username or email
                bool usernameExists = users.Values.Any(u => u.Username.Equals(userInfo.Username, StringComparison.OrdinalIgnoreCase));
                bool emailExists = users.Values.Any(u => u.Email.Equals(userInfo.Email, StringComparison.OrdinalIgnoreCase));

                if (usernameExists)
                {
                    MessageBox.Show("This username is already taken.");
                    return;
                }

                if (emailExists)
                {
                    MessageBox.Show("This email is already registered.");
                    return;
                }
            }
            else
            {
                users = new Dictionary<string, UserInfo>();
            }

            users[userInfo.IdNumber] = userInfo;

            string updatedJson = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, updatedJson);

            MessageBox.Show($"User info for ID {userInfo.IdNumber} saved to:\n{filePath}");
        }

        private void TBBirthDate_ValueChanged(object sender, EventArgs e)
        {
            UpdateCalculatedAge();
        }

        private void UpdateCalculatedAge()
        {
            DateTime birthDate = TBBirthDate.Value;
            DateTime now = DateTime.Now;
            double totalMonths = (now.Year - birthDate.Year) * 12 + now.Month - birthDate.Month;
            double decimalAge = totalMonths / 12.0;
            labelCalculatedAge.Text = $"Age: {decimalAge:F1} years";
        }

        private bool IsValidId(string id) => Regex.IsMatch(id, @"^\d{9}$");

        private bool IsValidFullName(string fullName) => Regex.IsMatch(fullName.Trim(), @"^[A-Za-z]+ [A-Za-z]+$");

        private bool IsValidCellular(string number) => Regex.IsMatch(number, @"^05\d-\d{7}$");

        private bool IsValidEmail(string email) => Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);

        private void LoadMajors()
        {
            string projectFolder = AppDomain.CurrentDomain.BaseDirectory;
            string majorsFilePath = Path.Combine(projectFolder, "usersinfo", "Majors.json");

            if (!File.Exists(majorsFilePath))
            {
                MessageBox.Show("Majors file not found.");
                return;
            }

            string json = File.ReadAllText(majorsFilePath);
            var majorsData = JsonSerializer.Deserialize<MajorsData>(json);

            if (majorsData?.MajorOfStudies != null)
            {
                CBMajorOfStudies.DataSource = majorsData.MajorOfStudies;
                CBMajorOfStudies.DisplayMember = "Name";
                CBMajorOfStudies.ValueMember = "Name";
            }
        }

    }
}

