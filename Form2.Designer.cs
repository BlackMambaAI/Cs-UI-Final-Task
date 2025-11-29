namespace UIFinalTask
{
    partial class FormCreateNewAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateNewAccount));
            labelSignUp = new Label();
            TBUsername = new TextBox();
            TBPassword = new TextBox();
            TBReEnterPassword = new TextBox();
            BTNSignUp = new Button();
            BTNCancel = new Button();
            labelUserName = new Label();
            labelPassword = new Label();
            labelReEnterPassword = new Label();
            SuspendLayout();
            // 
            // labelSignUp
            // 
            labelSignUp.AutoSize = true;
            labelSignUp.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSignUp.ForeColor = SystemColors.Highlight;
            labelSignUp.Location = new Point(50, 28);
            labelSignUp.Name = "labelSignUp";
            labelSignUp.Size = new Size(96, 31);
            labelSignUp.TabIndex = 0;
            labelSignUp.Text = "Sign up";
            // 
            // TBUsername
            // 
            TBUsername.Location = new Point(50, 106);
            TBUsername.Name = "TBUsername";
            TBUsername.PlaceholderText = "Enter User Name";
            TBUsername.Size = new Size(206, 27);
            TBUsername.TabIndex = 1;
            // 
            // TBPassword
            // 
            TBPassword.Location = new Point(50, 160);
            TBPassword.Name = "TBPassword";
            TBPassword.PlaceholderText = "Enter Password";
            TBPassword.Size = new Size(206, 27);
            TBPassword.TabIndex = 2;
            TBPassword.UseSystemPasswordChar = true;
            // 
            // TBReEnterPassword
            // 
            TBReEnterPassword.Location = new Point(50, 214);
            TBReEnterPassword.Name = "TBReEnterPassword";
            TBReEnterPassword.PlaceholderText = "Re-Enter Password";
            TBReEnterPassword.Size = new Size(206, 27);
            TBReEnterPassword.TabIndex = 3;
            TBReEnterPassword.UseSystemPasswordChar = true;
            // 
            // BTNSignUp
            // 
            BTNSignUp.Location = new Point(50, 292);
            BTNSignUp.Name = "BTNSignUp";
            BTNSignUp.Size = new Size(94, 29);
            BTNSignUp.TabIndex = 4;
            BTNSignUp.Text = "Sign up";
            BTNSignUp.UseVisualStyleBackColor = true;
            BTNSignUp.Click += BTSignUp_Click;
            // 
            // BTNCancel
            // 
            BTNCancel.Location = new Point(162, 292);
            BTNCancel.Name = "BTNCancel";
            BTNCancel.Size = new Size(94, 29);
            BTNCancel.TabIndex = 5;
            BTNCancel.Text = "Cancel";
            BTNCancel.UseVisualStyleBackColor = true;
            BTNCancel.Click += BtCancel_Click;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUserName.ForeColor = SystemColors.Highlight;
            labelUserName.Location = new Point(50, 81);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(102, 20);
            labelUserName.TabIndex = 6;
            labelUserName.Text = "* User Name:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = SystemColors.Highlight;
            labelPassword.Location = new Point(50, 135);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(91, 20);
            labelPassword.TabIndex = 7;
            labelPassword.Text = "* Password:";
            // 
            // labelReEnterPassword
            // 
            labelReEnterPassword.AutoSize = true;
            labelReEnterPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelReEnterPassword.ForeColor = SystemColors.Highlight;
            labelReEnterPassword.Location = new Point(50, 189);
            labelReEnterPassword.Name = "labelReEnterPassword";
            labelReEnterPassword.Size = new Size(156, 20);
            labelReEnterPassword.TabIndex = 8;
            labelReEnterPassword.Text = "* Re-Enter Password:";
            // 
            // FormCreateNewAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelReEnterPassword);
            Controls.Add(labelPassword);
            Controls.Add(labelUserName);
            Controls.Add(BTNCancel);
            Controls.Add(BTNSignUp);
            Controls.Add(TBReEnterPassword);
            Controls.Add(TBPassword);
            Controls.Add(TBUsername);
            Controls.Add(labelSignUp);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCreateNewAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create new account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSignUp;
        private TextBox TBUsername;
        private TextBox TBPassword;
        private TextBox TBReEnterPassword;
        private Button BTNSignUp;
        private Button BTNCancel;
        private Label labelUserName;
        private Label labelPassword;
        private Label labelReEnterPassword;
    }
}