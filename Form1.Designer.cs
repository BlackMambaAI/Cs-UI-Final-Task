namespace UIFinalTask
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            labelWelcome = new Label();
            labelUsername = new Label();
            labelPassword = new Label();
            BTNLogin = new Button();
            BTNCancel = new Button();
            LLCreateNewUser = new LinkLabel();
            TBPassword = new TextBox();
            TBUsername = new TextBox();
            TTUsername = new ToolTip(components);
            CBShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWelcome.ForeColor = SystemColors.Highlight;
            labelWelcome.Location = new Point(59, 9);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(250, 31);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Log into your account";
            labelWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = SystemColors.Highlight;
            labelUsername.Location = new Point(59, 77);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(99, 20);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "* User name:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = SystemColors.Highlight;
            labelPassword.Location = new Point(59, 131);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(91, 20);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "* Password:";
            // 
            // BTNLogin
            // 
            BTNLogin.Location = new Point(59, 210);
            BTNLogin.Name = "BTNLogin";
            BTNLogin.Size = new Size(94, 29);
            BTNLogin.TabIndex = 3;
            BTNLogin.Text = "Login";
            BTNLogin.UseVisualStyleBackColor = true;
            BTNLogin.Click += BTNLogin_Click;
            // 
            // BTNCancel
            // 
            BTNCancel.Location = new Point(171, 210);
            BTNCancel.Name = "BTNCancel";
            BTNCancel.Size = new Size(94, 29);
            BTNCancel.TabIndex = 4;
            BTNCancel.Text = "Cancel";
            BTNCancel.UseVisualStyleBackColor = true;
            BTNCancel.Click += BTNCancel_Click;
            // 
            // LLCreateNewUser
            // 
            LLCreateNewUser.AutoSize = true;
            LLCreateNewUser.Location = new Point(59, 289);
            LLCreateNewUser.Name = "LLCreateNewUser";
            LLCreateNewUser.Size = new Size(242, 20);
            LLCreateNewUser.TabIndex = 5;
            LLCreateNewUser.TabStop = true;
            LLCreateNewUser.Text = "Don't have an account? Create one.";
            LLCreateNewUser.LinkClicked += LLCreateNewUser_LinkClicked;
            // 
            // TBPassword
            // 
            TBPassword.Location = new Point(59, 156);
            TBPassword.Name = "TBPassword";
            TBPassword.PlaceholderText = "Enter Password";
            TBPassword.Size = new Size(206, 27);
            TBPassword.TabIndex = 1;
            TTUsername.SetToolTip(TBPassword, "Enter your password here");
            TBPassword.UseSystemPasswordChar = true;
            // 
            // TBUsername
            // 
            TBUsername.Location = new Point(59, 102);
            TBUsername.Name = "TBUsername";
            TBUsername.PlaceholderText = "Enter User name";
            TBUsername.Size = new Size(206, 27);
            TBUsername.TabIndex = 0;
            TTUsername.SetToolTip(TBUsername, "Enter your username here");
            // 
            // CBShowPassword
            // 
            CBShowPassword.AutoSize = true;
            CBShowPassword.Location = new Point(289, 159);
            CBShowPassword.Name = "CBShowPassword";
            CBShowPassword.Size = new Size(132, 24);
            CBShowPassword.TabIndex = 2;
            CBShowPassword.Text = "Show Password";
            CBShowPassword.UseVisualStyleBackColor = true;
            CBShowPassword.CheckedChanged += CBShowPassword_CheckedChanged;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CBShowPassword);
            Controls.Add(TBUsername);
            Controls.Add(TBPassword);
            Controls.Add(LLCreateNewUser);
            Controls.Add(BTNCancel);
            Controls.Add(BTNLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Controls.Add(labelWelcome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome;
        private Label labelUsername;
        private Label labelPassword;
        private Button BTNLogin;
        private Button BTNCancel;
        private LinkLabel LLCreateNewUser;
        private TextBox TBPassword;
        private TextBox TBUsername;
        private ToolTip TTUsername;
        private CheckBox CBShowPassword;
    }
}
