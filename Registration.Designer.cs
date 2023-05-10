namespace C_Auth
{
    partial class Registration
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
            Username = new Label();
            email = new Label();
            pass = new Label();
            register = new Button();
            login = new Button();
            label1 = new Label();
            txtUserName = new TextBox();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            confirmpass = new Label();
            txtConfirmPass = new TextBox();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(34, 80);
            Username.Name = "Username";
            Username.Size = new Size(113, 20);
            Username.TabIndex = 0;
            Username.Text = "Enter Username";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(34, 151);
            email.Name = "email";
            email.Size = new Size(84, 20);
            email.TabIndex = 1;
            email.Text = "Enter Email";
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.Location = new Point(35, 221);
            pass.Name = "pass";
            pass.Size = new Size(112, 20);
            pass.TabIndex = 2;
            pass.Text = "Enter Password ";
            // 
            // register
            // 
            register.FlatAppearance.BorderColor = Color.Black;
            register.FlatStyle = FlatStyle.Flat;
            register.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            register.Location = new Point(162, 411);
            register.Margin = new Padding(3, 4, 3, 4);
            register.Name = "register";
            register.Size = new Size(159, 48);
            register.TabIndex = 3;
            register.Text = "Register now";
            register.UseVisualStyleBackColor = true;
            register.Click += register_Click;
            // 
            // login
            // 
            login.FlatAppearance.BorderColor = Color.Black;
            login.FlatStyle = FlatStyle.Flat;
            login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            login.Location = new Point(171, 520);
            login.Margin = new Padding(3, 4, 3, 4);
            login.Name = "login";
            login.Size = new Size(150, 45);
            login.TabIndex = 4;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(162, 481);
            label1.Name = "label1";
            label1.Size = new Size(165, 21);
            label1.TabIndex = 5;
            label1.Text = "Already have an account?";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(218, 73);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(114, 27);
            txtUserName.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(218, 144);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(114, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(218, 214);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(114, 27);
            txtPass.TabIndex = 8;
            // 
            // confirmpass
            // 
            confirmpass.AutoSize = true;
            confirmpass.Location = new Point(34, 300);
            confirmpass.Name = "confirmpass";
            confirmpass.Size = new Size(127, 20);
            confirmpass.TabIndex = 9;
            confirmpass.Text = "Confirm Password";
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Location = new Point(218, 293);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(125, 27);
            txtConfirmPass.TabIndex = 10;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 599);
            Controls.Add(txtConfirmPass);
            Controls.Add(confirmpass);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Controls.Add(login);
            Controls.Add(register);
            Controls.Add(pass);
            Controls.Add(email);
            Controls.Add(Username);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Registration";
            Text = "Registration";
            Load += Registration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private Label email;
        private Label pass;
        private Button register;
        private Button login;
        private Label label1;
        private TextBox txtUserName;
        private TextBox txtEmail;
        private TextBox txtPass;
        private Label confirmpass;
        private TextBox txtConfirmPass;
    }
}