namespace UIFinalTask
{
    partial class FormUserInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserInformation));
            labelFillSignUpForm = new Label();
            labelIdNumber = new Label();
            TBId = new TextBox();
            labelFullName = new Label();
            TBFullName = new TextBox();
            labelBirthDate = new Label();
            TBBirthDate = new DateTimePicker();
            labelCalculatedAge = new Label();
            labelCellularNumber = new Label();
            TBCellularNumber = new TextBox();
            labelEmail = new Label();
            TBEmail = new TextBox();
            BTNAdd = new Button();
            BTNCancel = new Button();
            CBMajorOfStudies = new ComboBox();
            labelMajorOfStudies = new Label();
            SuspendLayout();
            // 
            // labelFillSignUpForm
            // 
            labelFillSignUpForm.AutoSize = true;
            labelFillSignUpForm.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFillSignUpForm.ForeColor = SystemColors.Highlight;
            labelFillSignUpForm.Location = new Point(41, 22);
            labelFillSignUpForm.Name = "labelFillSignUpForm";
            labelFillSignUpForm.Size = new Size(295, 31);
            labelFillSignUpForm.TabIndex = 0;
            labelFillSignUpForm.Text = "Fill Sign Up Form For User";
            // 
            // labelIdNumber
            // 
            labelIdNumber.AutoSize = true;
            labelIdNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelIdNumber.ForeColor = SystemColors.Highlight;
            labelIdNumber.Location = new Point(41, 79);
            labelIdNumber.Name = "labelIdNumber";
            labelIdNumber.Size = new Size(103, 20);
            labelIdNumber.TabIndex = 1;
            labelIdNumber.Text = "* ID Number:";
            // 
            // TBId
            // 
            TBId.Location = new Point(41, 104);
            TBId.Name = "TBId";
            TBId.PlaceholderText = "Enter Your ID Number";
            TBId.Size = new Size(194, 27);
            TBId.TabIndex = 0;
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFullName.ForeColor = SystemColors.Highlight;
            labelFullName.Location = new Point(41, 135);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(95, 20);
            labelFullName.TabIndex = 1;
            labelFullName.Text = "* Full Name:";
            // 
            // TBFullName
            // 
            TBFullName.Location = new Point(41, 160);
            TBFullName.Name = "TBFullName";
            TBFullName.PlaceholderText = "Enter Full Name";
            TBFullName.Size = new Size(194, 27);
            TBFullName.TabIndex = 1;
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBirthDate.ForeColor = SystemColors.Highlight;
            labelBirthDate.Location = new Point(41, 189);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(96, 20);
            labelBirthDate.TabIndex = 1;
            labelBirthDate.Text = "* Birth Date:";
            // 
            // TBBirthDate
            // 
            TBBirthDate.Format = DateTimePickerFormat.Short;
            TBBirthDate.Location = new Point(41, 214);
            TBBirthDate.Name = "TBBirthDate";
            TBBirthDate.Size = new Size(194, 27);
            TBBirthDate.TabIndex = 2;
            TBBirthDate.ValueChanged += TBBirthDate_ValueChanged;
            // 
            // labelCalculatedAge
            // 
            labelCalculatedAge.AutoSize = true;
            labelCalculatedAge.ForeColor = SystemColors.Highlight;
            labelCalculatedAge.Location = new Point(241, 221);
            labelCalculatedAge.Name = "labelCalculatedAge";
            labelCalculatedAge.Size = new Size(110, 20);
            labelCalculatedAge.TabIndex = 4;
            labelCalculatedAge.Text = "Calculated Age";
            // 
            // labelCellularNumber
            // 
            labelCellularNumber.AutoSize = true;
            labelCellularNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCellularNumber.ForeColor = SystemColors.Highlight;
            labelCellularNumber.Location = new Point(41, 243);
            labelCellularNumber.Name = "labelCellularNumber";
            labelCellularNumber.Size = new Size(139, 20);
            labelCellularNumber.TabIndex = 1;
            labelCellularNumber.Text = "* Cellular Number:";
            // 
            // TBCellularNumber
            // 
            TBCellularNumber.Location = new Point(41, 268);
            TBCellularNumber.Name = "TBCellularNumber";
            TBCellularNumber.PlaceholderText = "Enter Cellular Number";
            TBCellularNumber.Size = new Size(194, 27);
            TBCellularNumber.TabIndex = 3;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.ForeColor = SystemColors.Highlight;
            labelEmail.Location = new Point(41, 297);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(62, 20);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "* eMail:";
            // 
            // TBEmail
            // 
            TBEmail.Location = new Point(41, 322);
            TBEmail.Name = "TBEmail";
            TBEmail.PlaceholderText = "Enter eMail";
            TBEmail.Size = new Size(194, 27);
            TBEmail.TabIndex = 4;
            // 
            // BTNAdd
            // 
            BTNAdd.Location = new Point(41, 438);
            BTNAdd.Name = "BTNAdd";
            BTNAdd.Size = new Size(94, 29);
            BTNAdd.TabIndex = 6;
            BTNAdd.Text = "Add";
            BTNAdd.UseVisualStyleBackColor = true;
            BTNAdd.Click += BTNAdd_Click;
            // 
            // BTNCancel
            // 
            BTNCancel.Location = new Point(141, 438);
            BTNCancel.Name = "BTNCancel";
            BTNCancel.Size = new Size(94, 29);
            BTNCancel.TabIndex = 7;
            BTNCancel.Text = "Cancel";
            BTNCancel.UseVisualStyleBackColor = true;
            BTNCancel.Click += BTNCancel_Click;
            // 
            // CBMajorOfStudies
            // 
            CBMajorOfStudies.FormattingEnabled = true;
            CBMajorOfStudies.Location = new Point(41, 376);
            CBMajorOfStudies.Name = "CBMajorOfStudies";
            CBMajorOfStudies.Size = new Size(151, 28);
            CBMajorOfStudies.Sorted = true;
            CBMajorOfStudies.TabIndex = 5;
            // 
            // labelMajorOfStudies
            // 
            labelMajorOfStudies.AutoSize = true;
            labelMajorOfStudies.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMajorOfStudies.ForeColor = SystemColors.Highlight;
            labelMajorOfStudies.Location = new Point(41, 351);
            labelMajorOfStudies.Name = "labelMajorOfStudies";
            labelMajorOfStudies.Size = new Size(134, 20);
            labelMajorOfStudies.TabIndex = 8;
            labelMajorOfStudies.Text = "* Major of studies";
            labelMajorOfStudies.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormUserInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
            Controls.Add(labelMajorOfStudies);
            Controls.Add(CBMajorOfStudies);
            Controls.Add(BTNCancel);
            Controls.Add(BTNAdd);
            Controls.Add(labelCalculatedAge);
            Controls.Add(TBEmail);
            Controls.Add(labelEmail);
            Controls.Add(TBCellularNumber);
            Controls.Add(labelCellularNumber);
            Controls.Add(TBBirthDate);
            Controls.Add(labelBirthDate);
            Controls.Add(TBFullName);
            Controls.Add(labelFullName);
            Controls.Add(TBId);
            Controls.Add(labelIdNumber);
            Controls.Add(labelFillSignUpForm);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormUserInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFillSignUpForm;
        private Label labelIdNumber;
        private TextBox TBId;
        private Label labelFullName;
        private TextBox TBFullName;
        private Label labelBirthDate;
        private DateTimePicker TBBirthDate;
        private Label labelCalculatedAge;
        private Label labelCellularNumber;
        private TextBox TBCellularNumber;
        private Label labelEmail;
        private TextBox TBEmail;
        private Button BTNAdd;
        private Button BTNCancel;
        private ComboBox CBMajorOfStudies;
        private Label labelMajorOfStudies;
    }
}