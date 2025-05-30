namespace Quiz_Application
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            username = new System.Windows.Forms.TextBox();
            password = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // username
            // 
            username.Font = new System.Drawing.Font("Segoe UI", 12F);
            username.Location = new System.Drawing.Point(250, 150);
            username.Name = "username";
            username.Size = new System.Drawing.Size(300, 39);
            username.TabIndex = 0;
            // 
            // password
            // 
            password.Font = new System.Drawing.Font("Segoe UI", 12F);
            password.Location = new System.Drawing.Point(250, 230);
            password.Name = "password";
            password.PasswordChar = '●';
            password.Size = new System.Drawing.Size(300, 39);
            password.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.MediumSlateBlue;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Segoe UI", 14F);
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.Location = new System.Drawing.Point(320, 310);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(160, 50);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            label1.Location = new System.Drawing.Point(250, 120);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(121, 32);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            label2.Location = new System.Drawing.Point(250, 200);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(111, 32);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(800, 400);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(username);
            Controls.Add(password);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Login";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
