namespace Quiz_Application
{
    partial class FormEditSoal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            listBoxSoal = new ListBox();
            labelQuestion = new Label();
            textBoxQuestion = new TextBox();
            labelOption1 = new Label();
            textBoxOption1 = new TextBox();
            labelOption2 = new Label();
            textBoxOption2 = new TextBox();
            labelOption3 = new Label();
            textBoxOption3 = new TextBox();
            labelOption4 = new Label();
            textBoxOption4 = new TextBox();
            labelCorrectAnswer = new Label();
            textBoxCorrectAnswer = new TextBox();
            btnEditSoal = new Button();
            SuspendLayout();
            // 
            // listBoxSoal
            // 
            listBoxSoal.BackColor = SystemColors.ActiveBorder;
            listBoxSoal.FormattingEnabled = true;
            listBoxSoal.ItemHeight = 25;
            listBoxSoal.Location = new Point(445, 38);
            listBoxSoal.Name = "listBoxSoal";
            listBoxSoal.Size = new Size(332, 329);
            listBoxSoal.TabIndex = 0;
            // 
            // labelQuestion
            // 
            labelQuestion.Location = new Point(37, 31);
            labelQuestion.Name = "labelQuestion";
            labelQuestion.Size = new Size(100, 20);
            labelQuestion.TabIndex = 1;
            labelQuestion.Text = "Pertanyaan:";
            // 
            // textBoxQuestion
            // 
            textBoxQuestion.Location = new Point(37, 51);
            textBoxQuestion.Name = "textBoxQuestion";
            textBoxQuestion.Size = new Size(300, 31);
            textBoxQuestion.TabIndex = 2;
            // 
            // labelOption1
            // 
            labelOption1.Location = new Point(37, 81);
            labelOption1.Name = "labelOption1";
            labelOption1.Size = new Size(100, 23);
            labelOption1.TabIndex = 3;
            labelOption1.Text = "Pilihan 1:";
            // 
            // textBoxOption1
            // 
            textBoxOption1.Location = new Point(37, 101);
            textBoxOption1.Name = "textBoxOption1";
            textBoxOption1.Size = new Size(300, 31);
            textBoxOption1.TabIndex = 4;
            // 
            // labelOption2
            // 
            labelOption2.Location = new Point(37, 131);
            labelOption2.Name = "labelOption2";
            labelOption2.Size = new Size(100, 23);
            labelOption2.TabIndex = 5;
            labelOption2.Text = "Pilihan 2:";
            // 
            // textBoxOption2
            // 
            textBoxOption2.Location = new Point(37, 151);
            textBoxOption2.Name = "textBoxOption2";
            textBoxOption2.Size = new Size(300, 31);
            textBoxOption2.TabIndex = 6;
            // 
            // labelOption3
            // 
            labelOption3.Location = new Point(37, 181);
            labelOption3.Name = "labelOption3";
            labelOption3.Size = new Size(100, 23);
            labelOption3.TabIndex = 7;
            labelOption3.Text = "Pilihan 3:";
            // 
            // textBoxOption3
            // 
            textBoxOption3.Location = new Point(37, 201);
            textBoxOption3.Name = "textBoxOption3";
            textBoxOption3.Size = new Size(300, 31);
            textBoxOption3.TabIndex = 8;
            // 
            // labelOption4
            // 
            labelOption4.Location = new Point(37, 231);
            labelOption4.Name = "labelOption4";
            labelOption4.Size = new Size(100, 23);
            labelOption4.TabIndex = 9;
            labelOption4.Text = "Pilihan 4:";
            // 
            // textBoxOption4
            // 
            textBoxOption4.Location = new Point(37, 251);
            textBoxOption4.Name = "textBoxOption4";
            textBoxOption4.Size = new Size(300, 31);
            textBoxOption4.TabIndex = 10;
            // 
            // labelCorrectAnswer
            // 
            labelCorrectAnswer.Location = new Point(37, 281);
            labelCorrectAnswer.Name = "labelCorrectAnswer";
            labelCorrectAnswer.Size = new Size(100, 23);
            labelCorrectAnswer.TabIndex = 11;
            labelCorrectAnswer.Text = "Jawaban Benar (1-4):";
            // 
            // textBoxCorrectAnswer
            // 
            textBoxCorrectAnswer.Location = new Point(37, 301);
            textBoxCorrectAnswer.Name = "textBoxCorrectAnswer";
            textBoxCorrectAnswer.Size = new Size(300, 31);
            textBoxCorrectAnswer.TabIndex = 12;
            // 
            // btnEditSoal
            // 
            btnEditSoal.Location = new Point(125, 360);
            btnEditSoal.Name = "btnEditSoal";
            btnEditSoal.Size = new Size(112, 34);
            btnEditSoal.TabIndex = 0;
            btnEditSoal.Text = "EDIT";
            btnEditSoal.UseVisualStyleBackColor = true;
            // 
            // FormEditSoal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditSoal);
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
            Controls.Add(listBoxSoal);
            Name = "FormEditSoal";
            Text = "Edit Soal";
            Load += FormEditSoal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxSoal;
        private Label labelQuestion;
        private TextBox textBoxQuestion;
        private Label labelOption1;
        private TextBox textBoxOption1;
        private Label labelOption2;
        private TextBox textBoxOption2;
        private Label labelOption3;
        private TextBox textBoxOption3;
        private Label labelOption4;
        private TextBox textBoxOption4;
        private Label labelCorrectAnswer;
        private TextBox textBoxCorrectAnswer;
        private Button btnEditSoal;
    }
}
