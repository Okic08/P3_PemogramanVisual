namespace Quiz_Application
{
    partial class FormStart
    {
        private System.ComponentModel.IContainer components = null;
        private Label label1;
        private Button btnMulai;  // Tombol mulai quiz

        // Method untuk membersihkan komponen dan menginisialisasi UI
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
            label1 = new Label();
            btnMulai = new Button();
            btnAdmin = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 50);
            label1.Name = "label1";
            label1.Size = new Size(199, 25);
            label1.TabIndex = 0;
            label1.Text = "Selamat datang di quiz!";
            label1.Click += label1_Click;
            // 
            // btnMulai
            // 
            btnMulai.Location = new Point(109, 101);
            btnMulai.Name = "btnMulai";
            btnMulai.Size = new Size(100, 50);
            btnMulai.TabIndex = 1;
            btnMulai.Text = "Mulai";
            btnMulai.UseVisualStyleBackColor = true;
            btnMulai.Click += BtnMulai_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(326, 156);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(80, 32);
            btnAdmin.TabIndex = 2;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(308, 132);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 3;
            label2.Text = "Akses Admin";
            label2.Click += label2_Click;
            // 
            // FormStart
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(409, 200);
            Controls.Add(label2);
            Controls.Add(btnAdmin);
            Controls.Add(btnMulai);
            Controls.Add(label1);
            Name = "FormStart";
            Text = "Quiz Application";
            Load += FormStart_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private Button btnAdmin;
        private Label label2;
    }
}
