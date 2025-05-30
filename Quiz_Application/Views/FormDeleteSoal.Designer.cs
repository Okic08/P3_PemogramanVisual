namespace Quiz_Application
{
    partial class FormDeleteSoal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnDelete = new Button();
            listBoxQuestions = new ListBox();
            labelTitle = new Label();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DodgerBlue;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(220, 50);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 40);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Hapus Soal";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // listBoxQuestions
            // 
            listBoxQuestions.Font = new Font("Segoe UI", 10F);
            listBoxQuestions.FormattingEnabled = true;
            listBoxQuestions.ItemHeight = 28;
            listBoxQuestions.Location = new Point(20, 50);
            listBoxQuestions.Name = "listBoxQuestions";
            listBoxQuestions.Size = new Size(180, 312);
            listBoxQuestions.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTitle.Location = new Point(20, 10);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(350, 30);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Daftar Soal";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormDeleteSoal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(400, 400);
            Controls.Add(labelTitle);
            Controls.Add(listBoxQuestions);
            Controls.Add(btnDelete);
            Name = "FormDeleteSoal";
            Text = "Hapus Soal";
            Load += FormDeleteSoal_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox listBoxQuestions;
        private System.Windows.Forms.Label labelTitle;
    }
}
