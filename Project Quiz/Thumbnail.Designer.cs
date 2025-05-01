namespace Ntahlah
{
    partial class Thumbnail
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnLogin;

        private void InitializeComponent()
        {
            btnLogin = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.HotTrack;
            btnLogin.Location = new Point(312, 203);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(206, 48);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "LOGIN COY";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += this.btnLogin_Click;
            // 
            // Thumbnail
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Name = "Thumbnail";
            Text = "Form1";
            ResumeLayout(false);
        }
    }
}
