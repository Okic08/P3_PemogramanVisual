namespace Quiz_Application
{
    partial class Quiz_Form
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label_QuestionNumber;
        private System.Windows.Forms.RichTextBox richTextBox_Question;
        private System.Windows.Forms.RadioButton radioButton_Option1;
        private System.Windows.Forms.RadioButton radioButton_Option2;
        private System.Windows.Forms.RadioButton radioButton_Option3;
        private System.Windows.Forms.RadioButton radioButton_Option4;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.Button button_Previous;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label_QuestionNumber = new Label();
            richTextBox_Question = new RichTextBox();
            radioButton_Option1 = new RadioButton();
            radioButton_Option2 = new RadioButton();
            radioButton_Option3 = new RadioButton();
            radioButton_Option4 = new RadioButton();
            button_Next = new Button();
            button_Previous = new Button();
            SuspendLayout();
            // 
            // label_QuestionNumber
            // 
            label_QuestionNumber.AutoSize = true;
            label_QuestionNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label_QuestionNumber.Location = new Point(20, 20);
            label_QuestionNumber.Name = "label_QuestionNumber";
            label_QuestionNumber.Size = new Size(164, 32);
            label_QuestionNumber.TabIndex = 0;
            label_QuestionNumber.Text = "Pertanyaan 1";
            // 
            // richTextBox_Question
            // 
            richTextBox_Question.BackColor = SystemColors.ButtonShadow;
            richTextBox_Question.Font = new Font("Segoe UI", 10F);
            richTextBox_Question.Location = new Point(20, 60);
            richTextBox_Question.Name = "richTextBox_Question";
            richTextBox_Question.ReadOnly = true;
            richTextBox_Question.Size = new Size(540, 100);
            richTextBox_Question.TabIndex = 1;
            richTextBox_Question.Text = "";
            // 
            // radioButton_Option1
            // 
            radioButton_Option1.Font = new Font("Segoe UI", 10F);
            radioButton_Option1.Location = new Point(20, 180);
            radioButton_Option1.Name = "radioButton_Option1";
            radioButton_Option1.Size = new Size(540, 30);
            radioButton_Option1.TabIndex = 2;
            // 
            // radioButton_Option2
            // 
            radioButton_Option2.Font = new Font("Segoe UI", 10F);
            radioButton_Option2.Location = new Point(20, 215);
            radioButton_Option2.Name = "radioButton_Option2";
            radioButton_Option2.Size = new Size(540, 30);
            radioButton_Option2.TabIndex = 3;
            // 
            // radioButton_Option3
            // 
            radioButton_Option3.Font = new Font("Segoe UI", 10F);
            radioButton_Option3.Location = new Point(20, 250);
            radioButton_Option3.Name = "radioButton_Option3";
            radioButton_Option3.Size = new Size(540, 30);
            radioButton_Option3.TabIndex = 4;
            // 
            // radioButton_Option4
            // 
            radioButton_Option4.Font = new Font("Segoe UI", 10F);
            radioButton_Option4.Location = new Point(20, 285);
            radioButton_Option4.Name = "radioButton_Option4";
            radioButton_Option4.Size = new Size(540, 30);
            radioButton_Option4.TabIndex = 5;
            // 
            // button_Next
            // 
            button_Next.BackColor = Color.RoyalBlue;
            button_Next.FlatStyle = FlatStyle.Flat;
            button_Next.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button_Next.ForeColor = Color.White;
            button_Next.Location = new Point(441, 340);
            button_Next.Name = "button_Next";
            button_Next.Size = new Size(101, 40);
            button_Next.TabIndex = 6;
            button_Next.Text = "Next";
            button_Next.UseVisualStyleBackColor = false;
            button_Next.Click += Button_Next_Click;
            // 
            // button_Previous
            // 
            button_Previous.BackColor = Color.RoyalBlue;
            button_Previous.FlatStyle = FlatStyle.Flat;
            button_Previous.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button_Previous.ForeColor = Color.White;
            button_Previous.Location = new Point(20, 340);
            button_Previous.Name = "button_Previous";
            button_Previous.Size = new Size(104, 40);
            button_Previous.TabIndex = 7;
            button_Previous.Text = "Previous";
            button_Previous.UseVisualStyleBackColor = false;
            button_Previous.Click += Button_Previous_Click;
            // 
            // Quiz_Form
            // 
            BackColor = Color.RosyBrown;
            ClientSize = new Size(600, 410);
            Controls.Add(label_QuestionNumber);
            Controls.Add(richTextBox_Question);
            Controls.Add(radioButton_Option1);
            Controls.Add(radioButton_Option2);
            Controls.Add(radioButton_Option3);
            Controls.Add(radioButton_Option4);
            Controls.Add(button_Next);
            Controls.Add(button_Previous);
            Name = "Quiz_Form";
            Text = "Quiz Application";
            Load += Quiz_Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
