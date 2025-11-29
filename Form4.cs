using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace UIFinalTask
{
    public partial class FormShowInformation : Form
    {
        private readonly string _username;
        private string _pendingReceiverUsername;

        public FormShowInformation(string username)
        {
            InitializeComponent();
            _username = username;

            // Lifecycle
            this.Load += FormShowInformation_Load;
            this.FormClosing += FormShowInformation_FormClosing;

            // Actions
            BTNSearch.Click += BTNSearch_Click;
            // Wire settings buttons to ColorDialog
            BTNLabelForeColor.Click += BTNLabelForeColor_Click;
            BTNTextBoxBackColor.Click += BTNTextBoxBackColor_Click;

            // Ensure button column shows its text ("Send")
            var sendCol = DGVUsers.Columns["SendNotification"] as DataGridViewButtonColumn;
            if (sendCol != null)
                sendCol.UseColumnTextForButtonValue = true;

            // We add rows manually to DGVUsers
            DGVUsers.AutoGenerateColumns = false;

            // Hidden by default (redundant with Designer but safe)
            SetNotificationInputVisible(false);
        }

        private void FormShowInformation_Load(object sender, EventArgs e)
        {
            string projectFolder = AppDomain.CurrentDomain.BaseDirectory;
            string userFilePath = Path.Combine(projectFolder, "usersinfo", "UserInfo.json");
            string majorsFilePath = Path.Combine(projectFolder, "usersinfo", "Majors.json");
            string notificationsFilePath = Path.Combine(projectFolder, "usersinfo", "Notifications.json");

            // --- Load user info ---
            if (!File.Exists(userFilePath))
            {
                MessageBox.Show("User data file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Dictionary<string, UserInfo> users;
            try
            {
                string userJson = File.ReadAllText(userFilePath);
                users = JsonSerializer.Deserialize<Dictionary<string, UserInfo>>(userJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load user data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (users == null || users.Count == 0)
            {
                MessageBox.Show("User data is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = users.Values.FirstOrDefault(u =>
                string.Equals(u.Username?.Trim(), _username.Trim(), StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                MessageBox.Show("User not found in data file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- Populate personal info ---
            labelIDNumberData.Text = user.IdNumber;
            labelFullNameData.Text = user.FullName;
            labelBirthDateData.Text = user.BirthDate.ToShortDateString();
            labelCellularNumberData.Text = user.CellularNumber;
            labeleMailData.Text = user.Email;
            labelMajorOfStudiesData.Text = user.Major;

            int age = DateTime.Now.Year - user.BirthDate.Year;
            if (DateTime.Now.DayOfYear < user.BirthDate.DayOfYear)
                age--;
            labelCalculatedAge.Text = $"{age} years old";

            // --- Load courses for user's major ---
            if (File.Exists(majorsFilePath))
            {
                try
                {
                    string majorsJson = File.ReadAllText(majorsFilePath);
                    MajorsData majorsData = JsonSerializer.Deserialize<MajorsData>(majorsJson);

                    if (majorsData?.MajorOfStudies != null)
                    {
                        var major = majorsData.MajorOfStudies
                            .FirstOrDefault(m => string.Equals(m.Name?.Trim(), user.Major.Trim(), StringComparison.OrdinalIgnoreCase));

                        if (major != null)
                        {
                            listViewCourses.View = View.Details;
                            listViewCourses.FullRowSelect = false;
                            listViewCourses.GridLines = true;
                            listViewCourses.Columns.Clear();
                            listViewCourses.Columns.Add("Course Name", 400);
                            listViewCourses.Columns.Add("Credit Points", 100);
                            listViewCourses.Items.Clear();

                            foreach (var course in major.Courses)
                            {
                                var item = new ListViewItem(course.CourseName);
                                item.SubItems.Add(course.CreditPoints.ToString());
                                listViewCourses.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load majors data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // --- Load notifications (filtered by ReceiverUsername) ---
            if (File.Exists(notificationsFilePath))
            {
                try
                {
                    string notificationsJson = File.ReadAllText(notificationsFilePath);
                    var allNotifications = JsonSerializer.Deserialize<List<Notification>>(notificationsJson);

                    if (allNotifications != null)
                    {
                        var userNotifications = allNotifications
                            .Where(n => string.Equals(n.ReceiverUsername?.Trim(), _username.Trim(), StringComparison.OrdinalIgnoreCase))
                            .ToList();

                        DGVNotifications.AutoGenerateColumns = false;
                        DGVNotifications.DataSource = new BindingList<Notification>(userNotifications);

                        // Configure columns
                        DGVNotifications.Columns.Clear();

                        DGVNotifications.Columns.Add(new DataGridViewTextBoxColumn
                        {
                            DataPropertyName = "Timestamp",
                            HeaderText = "Date",
                            Width = 150,
                            ReadOnly = true
                        });

                        DGVNotifications.Columns.Add(new DataGridViewCheckBoxColumn
                        {
                            DataPropertyName = "Starred",
                            HeaderText = "Starred",
                            Width = 80
                        });

                        DGVNotifications.Columns.Add(new DataGridViewTextBoxColumn
                        {
                            DataPropertyName = "SenderUsername",
                            HeaderText = "Sender",
                            Width = 120,
                            ReadOnly = true
                        });

                        DGVNotifications.Columns.Add(new DataGridViewTextBoxColumn
                        {
                            DataPropertyName = "NotificationText",
                            HeaderText = "Notification",
                            Width = 300,
                            ReadOnly = true
                        });

                        DGVNotifications.AllowUserToOrderColumns = true;
                        DGVNotifications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                        // Fix checkbox commit issue
                        DGVNotifications.CurrentCellDirtyStateChanged += DGVNotifications_CurrentCellDirtyStateChanged;
                        DGVNotifications.CellContentClick += DGVNotifications_CellContentClick;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load notifications: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- Search by FullName or Email only ---
        private void BTNSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = TBSearchCriteria.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm)) return;

            string userFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usersinfo", "UserInfo.json");
            if (!File.Exists(userFilePath))
            {
                MessageBox.Show("User data file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var users = JsonSerializer.Deserialize<Dictionary<string, UserInfo>>(File.ReadAllText(userFilePath));
            if (users == null) return;

            var results = users.Values
                .Where(u =>
                    (u.FullName ?? string.Empty).IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    (u.Email ?? string.Empty).IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            DGVUsers.Rows.Clear();
            foreach (var user in results)
            {
                DGVUsers.Rows.Add(user.FullName, user.Email, user.Major, user.Username, "Send");
            }

            // Show input controls right after search
            SetNotificationInputVisible(true);
            _pendingReceiverUsername = null;
            TBNotification2Send.Clear();
        }

        // --- Handle Send Notification button in Search results ---
        private void DGVUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGVUsers.Columns[e.ColumnIndex].Name == "SendNotification")
            {
                string receiverUsername = DGVUsers.Rows[e.RowIndex].Cells["Username"].Value?.ToString();
                if (string.IsNullOrEmpty(receiverUsername))
                {
                    MessageBox.Show("Selected row does not have a valid username.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _pendingReceiverUsername = receiverUsername;

                if (!TBNotification2Send.Visible)
                    SetNotificationInputVisible(true);

                TBNotification2Send.PlaceholderText = $"Type message to {receiverUsername}...";
                TBNotification2Send.Focus();
            }
        }

        // --- Save notification using TBNotification2Send text and selected receiver ---
        private void BTNSave_Click(object sender, EventArgs e)
        {
            string notificationText = TBNotification2Send.Text.Trim();

            if (string.IsNullOrEmpty(_pendingReceiverUsername))
            {
                MessageBox.Show("Please select a user by clicking 'Send' in the grid.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(notificationText))
            {
                MessageBox.Show("Please enter a notification message before saving.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TBNotification2Send.Focus();
                return;
            }

            var notification = new Notification
            {
                SenderUsername = _username,
                ReceiverUsername = _pendingReceiverUsername,
                NotificationText = notificationText,
                Timestamp = DateTime.Now,
                Starred = false
            };

            SaveNotification(notification);

            // Hide controls and reset state after saving
            SetNotificationInputVisible(false);
            TBNotification2Send.Clear();
            _pendingReceiverUsername = null;

            MessageBox.Show("Notification sent successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // --- Helper to show/hide input controls together ---
        private void SetNotificationInputVisible(bool visible)
        {
            TBNotification2Send.Visible = visible;
            labelNotificationContent2Send.Visible = visible;
            BTNSave.Visible = visible;
        }

        // --- Append notification to Notifications.json ---
        private void SaveNotification(Notification notification)
        {
            string notificationsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usersinfo", "Notifications.json");
            List<Notification> notifications = new List<Notification>();

            try
            {
                if (File.Exists(notificationsFilePath))
                {
                    string existing = File.ReadAllText(notificationsFilePath);
                    notifications = JsonSerializer.Deserialize<List<Notification>>(existing) ?? new List<Notification>();
                }

                notifications.Add(notification);

                string json = JsonSerializer.Serialize(notifications, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(notificationsFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save notification: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Persist Starred changes back to file on close ---
        private void FormShowInformation_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveNotifications();
        }

        private void SaveNotifications()
        {
            string notificationsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "usersinfo", "Notifications.json");

            try
            {
                if (!File.Exists(notificationsFilePath))
                    return;

                var allNotifications = JsonSerializer.Deserialize<List<Notification>>(File.ReadAllText(notificationsFilePath));
                if (allNotifications == null) return;

                if (DGVNotifications.DataSource is BindingList<Notification> userNotifications)
                {
                    foreach (var notif in userNotifications)
                    {
                        var existing = allNotifications.FirstOrDefault(n =>
                            n.SenderUsername == notif.SenderUsername &&
                            n.ReceiverUsername == notif.ReceiverUsername &&
                            n.Timestamp == notif.Timestamp);

                        if (existing != null)
                        {
                            existing.Starred = notif.Starred;
                        }
                    }

                    string json = JsonSerializer.Serialize(allNotifications, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(notificationsFilePath, json);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save notifications: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Checkbox commit handlers for Notifications grid ---
        private void DGVNotifications_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (DGVNotifications.IsCurrentCellDirty &&
                DGVNotifications.CurrentCell is DataGridViewCheckBoxCell)
            {
                DGVNotifications.CommitEdit(DataGridViewDataErrorContexts.Commit);
                DGVNotifications.EndEdit();
            }
        }

        private void DGVNotifications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && DGVNotifications.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                DGVNotifications.CommitEdit(DataGridViewDataErrorContexts.Commit);
                DGVNotifications.EndEdit();
            }
        }

        // --- Settings: apply colors via ColorDialog ---
        private void BTNLabelForeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ApplyColorToControls(this, applyToLabels: true, applyToTextBoxes: false, colorDialog1.Color);
            }
        }

        private void BTNTextBoxBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ApplyColorToControls(this, applyToLabels: false, applyToTextBoxes: true, colorDialog1.Color);
            }
        }

        // Recursively apply chosen color to all nested controls across tabs/panels
        private void ApplyColorToControls(Control parent, bool applyToLabels, bool applyToTextBoxes, System.Drawing.Color color)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (applyToLabels && ctrl is Label lbl)
                {
                    lbl.ForeColor = color;
                }

                if (applyToTextBoxes && ctrl is TextBox tb)
                {
                    tb.BackColor = color;
                }

                // Recurse into children (TabPages, Panels, GroupBoxes, etc.)
                if (ctrl.HasChildren)
                {
                    ApplyColorToControls(ctrl, applyToLabels, applyToTextBoxes, color);
                }
            }
        }

        // Existing handlers referenced by Designer
        private void BTNLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Optional: add interactivity or help tooltip
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // No selection logic needed for read-only display
        }
    }

    // Note: UserInfo, MajorsData, and Notification classes are assumed to exist elsewhere in your project.
    // If they aren't present, define them accordingly to match your JSON structure.
}