namespace Quiz_Application
{
    partial class FormAddSoal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.TextBox textBoxOption1;
        private System.Windows.Forms.TextBox textBoxOption2;
        private System.Windows.Forms.TextBox textBoxOption3;
        private System.Windows.Forms.TextBox textBoxOption4;
        private System.Windows.Forms.TextBox textBoxCorrectAnswer;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelOption1;
        private System.Windows.Forms.Label labelOption2;
        private System.Windows.Forms.Label labelOption3;
        private System.Windows.Forms.Label labelOption4;
        private System.Windows.Forms.Label labelCorrectAnswer;

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
            textBoxQuestion = new TextBox();
            textBoxOption1 = new TextBox();
            textBoxOption2 = new TextBox();
            textBoxOption3 = new TextBox();
            textBoxOption4 = new TextBox();
            textBoxCorrectAnswer = new TextBox();
            btnAddQuestion = new Button();
            labelQuestion = new Label();
            labelOption1 = new Label();
            labelOption2 = new Label();
            labelOption3 = new Label();
            labelOption4 = new Label();
            labelCorrectAnswer = new Label();
            SuspendLayout();
            // 
            // textBoxQuestion
            // 
            textBoxQuestion.Location = new Point(30, 30);
            textBoxQuestion.Name = "textBoxQuestion";
            textBoxQuestion.Size = new Size(300, 31);
            textBoxQuestion.TabIndex = 0;
            textBoxQuestion.TextChanged += textBoxQuestion_TextChanged;
            // 
            // textBoxOption1
            // 
            textBoxOption1.Location = new Point(30, 80);
            textBoxOption1.Name = "textBoxOption1";
            textBoxOption1.Size = new Size(300, 31);
            textBoxOption1.TabIndex = 1;
            // 
            // textBoxOption2
            // 
            textBoxOption2.Location = new Point(30, 130);
            textBoxOption2.Name = "textBoxOption2";
            textBoxOption2.Size = new Size(300, 31);
            textBoxOption2.TabIndex = 2;
            // 
            // textBoxOption3
            // 
            textBoxOption3.Location = new Point(30, 180);
            textBoxOption3.Name = "textBoxOption3";
            textBoxOption3.Size = new Size(300, 31);
            textBoxOption3.TabIndex = 3;
            // 
            // textBoxOption4
            // 
            textBoxOption4.Location = new Point(30, 230);
            textBoxOption4.Name = "textBoxOption4";
            textBoxOption4.Size = new Size(300, 31);
            textBoxOption4.TabIndex = 4;
            // 
            // textBoxCorrectAnswer
            // 
            textBoxCorrectAnswer.Location = new Point(30, 280);
            textBoxCorrectAnswer.Name = "textBoxCorrectAnswer";
            textBoxCorrectAnswer.Size = new Size(300, 31);
            textBoxCorrectAnswer.TabIndex = 5;
            // 
            // btnAddQuestion
            // 
            btnAddQuestion.Location = new Point(30, 320);
            btnAddQuestion.Name = "btnAddQuestion";
            btnAddQuestion.Size = new Size(120, 35);
            btnAddQuestion.TabIndex = 6;
            btnAddQuestion.Text = "Tambah Soal";
            btnAddQuestion.UseVisualStyleBackColor = true;
            btnAddQuestion.Click += btnAddQuestion_Click;
            // 
            // labelQuestion
            // 
            labelQuestion.Location = new Point(30, 10);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(100, 20);
            labelQuestion.TabIndex = 0;
            labelQuestion.Text = "Pertanyaan:";
            // 
            // labelOption1
            // 
            labelOption1.Location = new Point(30, 60);
            labelOption1.Name = "labelOption1";
            labelOption1.Size = new Size(100, 20);
            labelOption1.TabIndex = 1;
            labelOption1.Text = "Pilihan 1:";
            // 
            // labelOption2
            // 
            labelOption2.Location = new Point(30, 110);
            labelOption2.Name = "labelOption2";
            labelOption2.Size = new Size(100, 20);
            labelOption2.TabIndex = 2;
            labelOption2.Text = "Pilihan 2:";
            // 
            // labelOption3
            // 
            labelOption3.Location = new Point(30, 160);
            labelOption3.Name = "labelOption3";
            labelOption3.Size = new Size(100, 20);
            labelOption3.TabIndex = 3;
            labelOption3.Text = "Pilihan 3:";
            // 
            // labelOption4
            // 
            labelOption4.Location = new Point(30, 210);
            labelOption4.Name = "labelOption4";
            labelOption4.Size = new Size(100, 20);
            labelOption4.TabIndex = 4;
            labelOption4.Text = "Pilihan 4:";
            // 
            // labelCorrectAnswer
            // 
            labelCorrectAnswer.Location = new Point(30, 260);
            labelCorrectAnswer.Name = "labelCorrectAnswer";
            labelCorrectAnswer.Size = new Size(200, 20);
            labelCorrectAnswer.TabIndex = 5;
            labelCorrectAnswer.Text = "Jawaban Benar (1-4):";
            // 
            // FormAddSoal
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(400, 380);
            Controls.Add(labelQuestion);
            Controls.Add(textBoxQuestion);
            Controls.Add(labelOption1);
            Controls.Add(textBoxOption1);
            Controls.Add(labelOption2);
            Controls.Add(textBoxOption2);
            Controls.Add(labelOption3);
            Controls.Add(textBoxOption3);
            Controls.Add(labelOption4);
            Controls.Add(textBoxOption4);
            Controls.Add(labelCorrectAnswer);
            Controls.Add(textBoxCorrectAnswer);
            Controls.Add(btnAddQuestion);
            Name = "FormAddSoal";
            Text = "Tambah Soal Baru";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
