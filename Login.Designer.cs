namespace C_Auth
{
    partial class Login
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
            btnLogin = new Button();
            button2 = new Button();
            label1 = new Label();
            username = new Label();
            pass = new Label();
            txtUserName = new TextBox();
            txtPass = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(181, 304);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(140, 39);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(181, 397);
            button2.Name = "button2";
            button2.Size = new Size(140, 41);
            button2.TabIndex = 1;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 362);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 2;
            label1.Text = "Don't have an account?";
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(37, 87);
            username.Name = "username";
            username.Size = new Size(144, 20);
            username.TabIndex = 3;
            username.Text = "Enter your username";
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.Location = new Point(37, 189);
            pass.Name = "pass";
            pass.Size = new Size(143, 20);
            pass.TabIndex = 4;
            pass.Text = "Enter your password";
            pass.Click += label3_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(210, 84);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(125, 27);
            txtUserName.TabIndex = 5;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(210, 182);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(125, 27);
            txtPass.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 450);
            Controls.Add(txtPass);
            Controls.Add(txtUserName);
            Controls.Add(pass);
            Controls.Add(username);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(btnLogin);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button button2;
        private Label label1;
        private Label username;
        private Label pass;
        private TextBox txtUserName;
        private TextBox txtPass;
    }
}