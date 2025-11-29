using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace UIFinalTask
{
    partial class FormShowInformation
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(FormShowInformation));
            label1 = new Label();
            TABCTRLInformation = new TabControl();
            TABPersonal = new TabPage();
            labeleMailData = new Label();
            labeleMail = new Label();
            labelCellularNumberData = new Label();
            labelCellularNumber = new Label();
            labelCalculatedAge = new Label();
            labelBirthDateData = new Label();
            labelBirthDate = new Label();
            labelFullNameData = new Label();
            labelFullName = new Label();
            labelIDNumberData = new Label();
            labelIDNumber = new Label();
            TABCourses = new TabPage();
            labelMajorOfStudiesData = new Label();
            labelMajorOfStudies = new Label();
            listViewCourses = new ListView();
            CourseName = new ColumnHeader();
            CreditPoints = new ColumnHeader();
            TABNotifications = new TabPage();
            DGVNotifications = new DataGridView();
            Timestamp = new DataGridViewTextBoxColumn();
            Starred = new DataGridViewCheckBoxColumn();
            SenderUsername = new DataGridViewTextBoxColumn();
            NotificationText = new DataGridViewTextBoxColumn();
            TABSearch = new TabPage();
            BTNSave = new Button();
            TBNotification2Send = new TextBox();
            labelNotificationContent2Send = new Label();
            BTNSearch = new Button();
            DGVUsers = new DataGridView();
            FullName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Major = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            SendNotification = new DataGridViewButtonColumn();
            TBSearchCriteria = new TextBox();
            labelSearchCriteria = new Label();
            TABSettings = new TabPage();
            BTNLogout = new Button();
            BTNLabelForeColor = new Button();
            BTNTextBoxBackColor = new Button();
            colorDialog1 = new ColorDialog();
            TABCTRLInformation.SuspendLayout();
            TABPersonal.SuspendLayout();
            TABCourses.SuspendLayout();
            TABNotifications.SuspendLayout();
            ((ISupportInitialize)DGVNotifications).BeginInit();
            TABSearch.SuspendLayout();
            ((ISupportInitialize)DGVUsers).BeginInit();
            TABSettings.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(41, 21);
            label1.Name = "label1";
            label1.Size = new Size(144, 31);
            label1.TabIndex = 0;
            label1.Text = "Information";
            label1.Click += label1_Click;
            // 
            // TABCTRLInformation
            // 
            TABCTRLInformation.Controls.Add(TABPersonal);
            TABCTRLInformation.Controls.Add(TABCourses);
            TABCTRLInformation.Controls.Add(TABNotifications);
            TABCTRLInformation.Controls.Add(TABSearch);
            TABCTRLInformation.Controls.Add(TABSettings);
            TABCTRLInformation.Location = new Point(41, 65);
            TABCTRLInformation.Name = "TABCTRLInformation";
            TABCTRLInformation.SelectedIndex = 0;
            TABCTRLInformation.Size = new Size(730, 317);
            TABCTRLInformation.TabIndex = 1;
            // 
            // TABPersonal
            // 
            TABPersonal.Controls.Add(labeleMailData);
            TABPersonal.Controls.Add(labeleMail);
            TABPersonal.Controls.Add(labelCellularNumberData);
            TABPersonal.Controls.Add(labelCellularNumber);
            TABPersonal.Controls.Add(labelCalculatedAge);
            TABPersonal.Controls.Add(labelBirthDateData);
            TABPersonal.Controls.Add(labelBirthDate);
            TABPersonal.Controls.Add(labelFullNameData);
            TABPersonal.Controls.Add(labelFullName);
            TABPersonal.Controls.Add(labelIDNumberData);
            TABPersonal.Controls.Add(labelIDNumber);
            TABPersonal.Location = new Point(4, 29);
            TABPersonal.Name = "TABPersonal";
            TABPersonal.Padding = new Padding(3);
            TABPersonal.Size = new Size(722, 284);
            TABPersonal.TabIndex = 0;
            TABPersonal.Text = "Personal";
            TABPersonal.UseVisualStyleBackColor = true;
            // 
            // labeleMailData
            // 
            labeleMailData.AutoSize = true;
            labeleMailData.Location = new Point(147, 131);
            labeleMailData.Name = "labeleMailData";
            labeleMailData.Size = new Size(46, 20);
            labeleMailData.TabIndex = 10;
            labeleMailData.Text = "eMail";
            // 
            // labeleMail
            // 
            labeleMail.AutoSize = true;
            labeleMail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeleMail.ForeColor = SystemColors.Highlight;
            labeleMail.Location = new Point(6, 131);
            labeleMail.Name = "labeleMail";
            labeleMail.Size = new Size(51, 20);
            labeleMail.TabIndex = 9;
            labeleMail.Text = "eMail:";
            // 
            // labelCellularNumberData
            // 
            labelCellularNumberData.AutoSize = true;
            labelCellularNumberData.Location = new Point(147, 102);
            labelCellularNumberData.Name = "labelCellularNumberData";
            labelCellularNumberData.Size = new Size(113, 20);
            labelCellularNumberData.TabIndex = 8;
            labelCellularNumberData.Text = "CellularNumber";
            // 
            // labelCellularNumber
            // 
            labelCellularNumber.AutoSize = true;
            labelCellularNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCellularNumber.ForeColor = SystemColors.Highlight;
            labelCellularNumber.Location = new Point(6, 102);
            labelCellularNumber.Name = "labelCellularNumber";
            labelCellularNumber.Size = new Size(128, 20);
            labelCellularNumber.TabIndex = 7;
            labelCellularNumber.Text = "Cellular Number:";
            // 
            // labelCalculatedAge
            // 
            labelCalculatedAge.AutoSize = true;
            labelCalculatedAge.Location = new Point(260, 72);
            labelCalculatedAge.Name = "labelCalculatedAge";
            labelCalculatedAge.Size = new Size(106, 20);
            labelCalculatedAge.TabIndex = 6;
            labelCalculatedAge.Text = "CalculatedAge";
            // 
            // labelBirthDateData
            // 
            labelBirthDateData.AutoSize = true;
            labelBirthDateData.Location = new Point(147, 72);
            labelBirthDateData.Name = "labelBirthDateData";
            labelBirthDateData.Size = new Size(72, 20);
            labelBirthDateData.TabIndex = 5;
            labelBirthDateData.Text = "BirthDate";
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBirthDate.ForeColor = SystemColors.Highlight;
            labelBirthDate.Location = new Point(6, 72);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(85, 20);
            labelBirthDate.TabIndex = 4;
            labelBirthDate.Text = "Birth Date:";
            // 
            // labelFullNameData
            // 
            labelFullNameData.AutoSize = true;
            labelFullNameData.Font = new Font("Segoe UI", 9F);
            labelFullNameData.ForeColor = SystemColors.ControlText;
            labelFullNameData.Location = new Point(147, 43);
            labelFullNameData.Name = "labelFullNameData";
            labelFullNameData.Size = new Size(72, 20);
            labelFullNameData.TabIndex = 3;
            labelFullNameData.Text = "FullName";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFullName.ForeColor = SystemColors.Highlight;
            labelFullName.Location = new Point(6, 43);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(84, 20);
            labelFullName.TabIndex = 2;
            labelFullName.Text = "Full Name:";
            // 
            // labelIDNumberData
            // 
            labelIDNumberData.AutoSize = true;
            labelIDNumberData.Location = new Point(147, 14);
            labelIDNumberData.Name = "labelIDNumberData";
            labelIDNumberData.Size = new Size(78, 20);
            labelIDNumberData.TabIndex = 1;
            labelIDNumberData.Text = "IDNumber";
            // 
            // labelIDNumber
            // 
            labelIDNumber.AutoSize = true;
            labelIDNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIDNumber.ForeColor = SystemColors.Highlight;
            labelIDNumber.Location = new Point(6, 14);
            labelIDNumber.Name = "labelIDNumber";
            labelIDNumber.Size = new Size(92, 20);
            labelIDNumber.TabIndex = 0;
            labelIDNumber.Text = "ID Number:";
            // 
            // TABCourses
            // 
            TABCourses.Controls.Add(labelMajorOfStudiesData);
            TABCourses.Controls.Add(labelMajorOfStudies);
            TABCourses.Controls.Add(listViewCourses);
            TABCourses.Location = new Point(4, 29);
            TABCourses.Name = "TABCourses";
            TABCourses.Padding = new Padding(3);
            TABCourses.Size = new Size(722, 284);
            TABCourses.TabIndex = 1;
            TABCourses.Text = "Courses";
            TABCourses.UseVisualStyleBackColor = true;
            // 
            // labelMajorOfStudiesData
            // 
            labelMajorOfStudiesData.AutoSize = true;
            labelMajorOfStudiesData.Location = new Point(142, 16);
            labelMajorOfStudiesData.Name = "labelMajorOfStudiesData";
            labelMajorOfStudiesData.Size = new Size(112, 20);
            labelMajorOfStudiesData.TabIndex = 2;
            labelMajorOfStudiesData.Text = "MajorOfStudies";
            // 
            // labelMajorOfStudies
            // 
            labelMajorOfStudies.AutoSize = true;
            labelMajorOfStudies.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMajorOfStudies.ForeColor = SystemColors.Highlight;
            labelMajorOfStudies.Location = new Point(6, 16);
            labelMajorOfStudies.Name = "labelMajorOfStudies";
            labelMajorOfStudies.Size = new Size(130, 20);
            labelMajorOfStudies.TabIndex = 1;
            labelMajorOfStudies.Text = "Major Of Studies:";
            // 
            // listViewCourses
            // 
            listViewCourses.Columns.AddRange(new ColumnHeader[] { CourseName, CreditPoints });
            listViewCourses.Location = new Point(6, 39);
            listViewCourses.Name = "listViewCourses";
            listViewCourses.Size = new Size(710, 239);
            listViewCourses.TabIndex = 0;
            listViewCourses.UseCompatibleStateImageBehavior = false;
            listViewCourses.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // TABNotifications
            // 
            TABNotifications.Controls.Add(DGVNotifications);
            TABNotifications.Location = new Point(4, 29);
            TABNotifications.Name = "TABNotifications";
            TABNotifications.Size = new Size(722, 284);
            TABNotifications.TabIndex = 2;
            TABNotifications.Text = "Notifications";
            TABNotifications.UseVisualStyleBackColor = true;
            // 
            // DGVNotifications
            // 
            DGVNotifications.AllowUserToAddRows = false;
            DGVNotifications.AllowUserToDeleteRows = false;
            DGVNotifications.AllowUserToOrderColumns = true;
            DGVNotifications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVNotifications.Columns.AddRange(new DataGridViewColumn[] { Timestamp, Starred, SenderUsername, NotificationText });
            DGVNotifications.Dock = DockStyle.Fill;
            DGVNotifications.Location = new Point(0, 0);
            DGVNotifications.Name = "DGVNotifications";
            DGVNotifications.RowHeadersWidth = 51;
            DGVNotifications.Size = new Size(722, 284);
            DGVNotifications.TabIndex = 0;
            DGVNotifications.CellContentClick += DGVNotifications_CellContentClick;
            // 
            // Timestamp
            // 
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            Timestamp.DefaultCellStyle = dataGridViewCellStyle1;
            Timestamp.HeaderText = "Timestamp";
            Timestamp.MinimumWidth = 6;
            Timestamp.Name = "Timestamp";
            Timestamp.ReadOnly = true;
            Timestamp.Width = 150;
            // 
            // Starred
            // 
            Starred.HeaderText = "Starred";
            Starred.MinimumWidth = 6;
            Starred.Name = "Starred";
            Starred.Resizable = DataGridViewTriState.True;
            Starred.SortMode = DataGridViewColumnSortMode.Automatic;
            Starred.Width = 80;
            // 
            // SenderUsername
            // 
            SenderUsername.HeaderText = "Sender";
            SenderUsername.MinimumWidth = 6;
            SenderUsername.Name = "SenderUsername";
            SenderUsername.ReadOnly = true;
            SenderUsername.Width = 120;
            // 
            // NotificationText
            // 
            NotificationText.HeaderText = "Notification";
            NotificationText.MinimumWidth = 6;
            NotificationText.Name = "NotificationText";
            NotificationText.ReadOnly = true;
            NotificationText.Width = 300;
            // 
            // TABSearch
            // 
            TABSearch.Controls.Add(BTNSave);
            TABSearch.Controls.Add(TBNotification2Send);
            TABSearch.Controls.Add(labelNotificationContent2Send);
            TABSearch.Controls.Add(BTNSearch);
            TABSearch.Controls.Add(DGVUsers);
            TABSearch.Controls.Add(TBSearchCriteria);
            TABSearch.Controls.Add(labelSearchCriteria);
            TABSearch.Location = new Point(4, 29);
            TABSearch.Name = "TABSearch";
            TABSearch.Size = new Size(722, 284);
            TABSearch.TabIndex = 3;
            TABSearch.Text = "Search";
            TABSearch.UseVisualStyleBackColor = true;
            // 
            // BTNSave
            // 
            BTNSave.Location = new Point(670, 253);
            BTNSave.Name = "BTNSave";
            BTNSave.Size = new Size(49, 29);
            BTNSave.TabIndex = 6;
            BTNSave.Text = "Save";
            BTNSave.UseVisualStyleBackColor = true;
            BTNSave.Visible = false;
            BTNSave.Click += BTNSave_Click;
            // 
            // TBNotification2Send
            // 
            TBNotification2Send.Location = new Point(106, 253);
            TBNotification2Send.Name = "TBNotification2Send";
            TBNotification2Send.PlaceholderText = "Notification to send...";
            TBNotification2Send.Size = new Size(558, 27);
            TBNotification2Send.TabIndex = 5;
            TBNotification2Send.Visible = false;
            // 
            // labelNotificationContent2Send
            // 
            labelNotificationContent2Send.AutoSize = true;
            labelNotificationContent2Send.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNotificationContent2Send.ForeColor = SystemColors.Highlight;
            labelNotificationContent2Send.Location = new Point(3, 256);
            labelNotificationContent2Send.Name = "labelNotificationContent2Send";
            labelNotificationContent2Send.Size = new Size(97, 20);
            labelNotificationContent2Send.TabIndex = 4;
            labelNotificationContent2Send.Text = "Notification:";
            labelNotificationContent2Send.Visible = false;
            // 
            // BTNSearch
            // 
            BTNSearch.Location = new Point(364, 8);
            BTNSearch.Name = "BTNSearch";
            BTNSearch.Size = new Size(62, 29);
            BTNSearch.TabIndex = 2;
            BTNSearch.Text = "Search";
            BTNSearch.UseVisualStyleBackColor = true;
            // 
            // DGVUsers
            // 
            DGVUsers.AllowUserToAddRows = false;
            DGVUsers.AllowUserToDeleteRows = false;
            DGVUsers.AllowUserToOrderColumns = true;
            DGVUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVUsers.Columns.AddRange(new DataGridViewColumn[] { FullName, Email, Major, Username, SendNotification });
            DGVUsers.Location = new Point(3, 41);
            DGVUsers.MultiSelect = false;
            DGVUsers.Name = "DGVUsers";
            DGVUsers.ReadOnly = true;
            DGVUsers.RowHeadersWidth = 51;
            DGVUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVUsers.Size = new Size(716, 206);
            DGVUsers.TabIndex = 3;
            DGVUsers.CellContentClick += DGVUsers_CellContentClick;
            // 
            // FullName
            // 
            FullName.HeaderText = "Full Name";
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 125;
            // 
            // Major
            // 
            Major.HeaderText = "Major";
            Major.MinimumWidth = 6;
            Major.Name = "Major";
            Major.ReadOnly = true;
            Major.Width = 125;
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            Username.ReadOnly = true;
            Username.Width = 125;
            // 
            // SendNotification
            // 
            SendNotification.HeaderText = "Send Notification";
            SendNotification.MinimumWidth = 6;
            SendNotification.Name = "SendNotification";
            SendNotification.ReadOnly = true;
            SendNotification.Text = "Send";
            SendNotification.Width = 125;
            // 
            // TBSearchCriteria
            // 
            TBSearchCriteria.Location = new Point(123, 8);
            TBSearchCriteria.Name = "TBSearchCriteria";
            TBSearchCriteria.PlaceholderText = "Type any text to search a user ...";
            TBSearchCriteria.Size = new Size(235, 27);
            TBSearchCriteria.TabIndex = 1;
            // 
            // labelSearchCriteria
            // 
            labelSearchCriteria.AutoSize = true;
            labelSearchCriteria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSearchCriteria.ForeColor = SystemColors.Highlight;
            labelSearchCriteria.Location = new Point(3, 11);
            labelSearchCriteria.Name = "labelSearchCriteria";
            labelSearchCriteria.Size = new Size(114, 20);
            labelSearchCriteria.TabIndex = 0;
            labelSearchCriteria.Text = "Search Criteria:";
            // 
            // TABSettings
            // 
            TABSettings.Controls.Add(BTNTextBoxBackColor);
            TABSettings.Controls.Add(BTNLabelForeColor);
            TABSettings.Location = new Point(4, 29);
            TABSettings.Name = "TABSettings";
            TABSettings.Size = new Size(722, 284);
            TABSettings.TabIndex = 4;
            TABSettings.Text = "Settings";
            TABSettings.UseVisualStyleBackColor = true;
            // 
            // BTNLogout
            // 
            BTNLogout.Location = new Point(45, 397);
            BTNLogout.Name = "BTNLogout";
            BTNLogout.Size = new Size(94, 29);
            BTNLogout.TabIndex = 10;
            BTNLogout.Text = "Logout";
            BTNLogout.UseVisualStyleBackColor = true;
            BTNLogout.Click += BTNLogout_Click;
            // 
            // BTNLabelForeColor
            // 
            BTNLabelForeColor.Location = new Point(205, 227);
            BTNLabelForeColor.Name = "BTNLabelForeColor";
            BTNLabelForeColor.Size = new Size(165, 29);
            BTNLabelForeColor.TabIndex = 0;
            BTNLabelForeColor.Text = "Label Fore Color";
            BTNLabelForeColor.UseVisualStyleBackColor = true;
            // 
            // BTNTextBoxBackColor
            // 
            BTNTextBoxBackColor.Location = new Point(385, 227);
            BTNTextBoxBackColor.Name = "BTNTextBoxBackColor";
            BTNTextBoxBackColor.Size = new Size(165, 29);
            BTNTextBoxBackColor.TabIndex = 1;
            BTNTextBoxBackColor.Text = "Text Box Back Color";
            BTNTextBoxBackColor.UseVisualStyleBackColor = true;
            // 
            // FormShowInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNLogout);
            Controls.Add(TABCTRLInformation);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormShowInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Information";
            TABCTRLInformation.ResumeLayout(false);
            TABPersonal.ResumeLayout(false);
            TABPersonal.PerformLayout();
            TABCourses.ResumeLayout(false);
            TABCourses.PerformLayout();
            TABNotifications.ResumeLayout(false);
            ((ISupportInitialize)DGVNotifications).EndInit();
            TABSearch.ResumeLayout(false);
            TABSearch.PerformLayout();
            ((ISupportInitialize)DGVUsers).EndInit();
            TABSettings.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl TABCTRLInformation;
        private TabPage TABPersonal;
        private TabPage TABCourses;
        private TabPage TABNotifications;
        private TabPage TABSearch;
        private TabPage TABSettings;
        private Button BTNLogout;
        private Label labelIDNumber;
        private Label labelIDNumberData;
        private Label labelFullNameData;
        private Label labelFullName;
        private Label labelBirthDate;
        private Label labelBirthDateData;
        private Label labelCalculatedAge;
        private Label labelCellularNumberData;
        private Label labelCellularNumber;
        private Label labeleMail;
        private Label labeleMailData;
        private ListView listViewCourses;
        private Label labelMajorOfStudies;
        private ColumnHeader CourseName;
        private ColumnHeader CreditPoints;
        private Label labelMajorOfStudiesData;
        private DataGridView DGVNotifications;
        private DataGridViewTextBoxColumn Timestamp;
        private DataGridViewCheckBoxColumn Starred;
        private DataGridViewTextBoxColumn SenderUsername;
        private DataGridViewTextBoxColumn NotificationText;
        private Label labelSearchCriteria;
        private DataGridView DGVUsers;
        private TextBox TBSearchCriteria;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Major;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewButtonColumn SendNotification;
        private Button BTNSearch;
        private TextBox TBNotification2Send;
        private Label labelNotificationContent2Send;
        private Button BTNSave;
        private Button BTNLabelForeColor;
        private Button BTNTextBoxBackColor;
        private ColorDialog colorDialog1;
    }
}