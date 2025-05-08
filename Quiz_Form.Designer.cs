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
            this.label_QuestionNumber = new System.Windows.Forms.Label();
            this.richTextBox_Question = new System.Windows.Forms.RichTextBox();
            this.radioButton_Option1 = new System.Windows.Forms.RadioButton();
            this.radioButton_Option2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Option3 = new System.Windows.Forms.RadioButton();
            this.radioButton_Option4 = new System.Windows.Forms.RadioButton();
            this.button_Next = new System.Windows.Forms.Button();
            this.button_Previous = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_QuestionNumber
            // 
            this.label_QuestionNumber.AutoSize = true;
            this.label_QuestionNumber.Location = new System.Drawing.Point(20, 20);
            this.label_QuestionNumber.Name = "label_QuestionNumber";
            this.label_QuestionNumber.Size = new System.Drawing.Size(50, 13);
            this.label_QuestionNumber.Text = "Question";
            // 
            // richTextBox_Question
            // 
            this.richTextBox_Question.Location = new System.Drawing.Point(20, 50);
            this.richTextBox_Question.Size = new System.Drawing.Size(400, 100);
            this.richTextBox_Question.ReadOnly = true;
            // 
            // radioButton_Option1
            // 
            this.radioButton_Option1.Location = new System.Drawing.Point(20, 170);
            this.radioButton_Option1.Size = new System.Drawing.Size(400, 24);
            // 
            // radioButton_Option2
            // 
            this.radioButton_Option2.Location = new System.Drawing.Point(20, 200);
            this.radioButton_Option2.Size = new System.Drawing.Size(400, 24);
            // 
            // radioButton_Option3
            // 
            this.radioButton_Option3.Location = new System.Drawing.Point(20, 230);
            this.radioButton_Option3.Size = new System.Drawing.Size(400, 24);
            // 
            // radioButton_Option4
            // 
            this.radioButton_Option4.Location = new System.Drawing.Point(20, 260);
            this.radioButton_Option4.Size = new System.Drawing.Size(400, 24);
            // 
            // button_Previous
            // 
            this.button_Previous.Location = new System.Drawing.Point(20, 300);
            this.button_Previous.Size = new System.Drawing.Size(100, 30);
            this.button_Previous.Text = "Previous";
            this.button_Previous.Click += new System.EventHandler(this.Button_Previous_Click);
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(320, 300);
            this.button_Next.Size = new System.Drawing.Size(100, 30);
            this.button_Next.Text = "Next";
            this.button_Next.Click += new System.EventHandler(this.Button_Next_Click);
            // 
            // Quiz_Form
            // 
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.label_QuestionNumber);
            this.Controls.Add(this.richTextBox_Question);
            this.Controls.Add(this.radioButton_Option1);
            this.Controls.Add(this.radioButton_Option2);
            this.Controls.Add(this.radioButton_Option3);
            this.Controls.Add(this.radioButton_Option4);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.button_Previous);
            this.Name = "Quiz_Form";
            this.Text = "Quiz Application";
            this.Load += new System.EventHandler(this.Quiz_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
