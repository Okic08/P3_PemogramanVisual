namespace Quiz_Application
{
    partial class FormViewSoal
    {
        private System.ComponentModel.IContainer components = null;

        // Komponen UI
        private System.Windows.Forms.DataGridView dataGridViewQuestions;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnRefresh;

        // Menghapus semua komponen yang digunakan
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Inisialisasi komponen UI
        private void InitializeComponent()
        {
            dataGridViewQuestions = new DataGridView();
            labelTitle = new Label();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewQuestions).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewQuestions
            // 
            dataGridViewQuestions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewQuestions.Location = new Point(12, 41);
            dataGridViewQuestions.Name = "dataGridViewQuestions";
            dataGridViewQuestions.RowHeadersWidth = 62;
            dataGridViewQuestions.Size = new Size(776, 365);
            dataGridViewQuestions.TabIndex = 0;
            dataGridViewQuestions.CellContentClick += dataGridViewQuestions_CellContentClick;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(226, 32);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "View Questions";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(12, 412);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 35);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // FormViewSoal
            // 
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRefresh);
            Controls.Add(labelTitle);
            Controls.Add(dataGridViewQuestions);
            Name = "FormViewSoal";
            Text = "View Questions";
            ((System.ComponentModel.ISupportInitialize)dataGridViewQuestions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
