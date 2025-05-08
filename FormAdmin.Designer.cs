namespace Quiz_Application
{
    partial class FormAdmin
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnAddSoal;
        private Button btnEditSoal;
        private Button btnDeleteSoal;
        private Button btnViewSoal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void btnEditSoal_Click(object sender, EventArgs e)
        {
            // Tambahkan kode yang diperlukan ketika tombol "Edit Soal" diklik
            FormEditSoal formEditSoal = new FormEditSoal();
            formEditSoal.ShowDialog(); // Atau formEditSoal.Show() jika ingin membuka di jendela yang sama
        }


        private void InitializeComponent()
        {
            this.btnAddSoal = new System.Windows.Forms.Button();
            this.btnEditSoal = new System.Windows.Forms.Button();
            this.btnDeleteSoal = new System.Windows.Forms.Button();
            this.btnViewSoal = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // btnAddSoal
            this.btnAddSoal.Location = new System.Drawing.Point(50, 50);
            this.btnAddSoal.Name = "btnAddSoal";
            this.btnAddSoal.Size = new System.Drawing.Size(150, 50);
            this.btnAddSoal.TabIndex = 0;
            this.btnAddSoal.Text = "Add Soal";
            this.btnAddSoal.UseVisualStyleBackColor = true;
            this.btnAddSoal.Click += new System.EventHandler(this.btnAddSoal_Click);

            // btnEditSoal
            this.btnEditSoal.Location = new System.Drawing.Point(50, 120);
            this.btnEditSoal.Name = "btnEditSoal";
            this.btnEditSoal.Size = new System.Drawing.Size(150, 50);
            this.btnEditSoal.TabIndex = 1;
            this.btnEditSoal.Text = "Edit Soal";
            this.btnEditSoal.UseVisualStyleBackColor = true;
            this.btnEditSoal.Click += new System.EventHandler(this.btnEditSoal_Click);

            // btnDeleteSoal
            this.btnDeleteSoal.Location = new System.Drawing.Point(50, 190);
            this.btnDeleteSoal.Name = "btnDeleteSoal";
            this.btnDeleteSoal.Size = new System.Drawing.Size(150, 50);
            this.btnDeleteSoal.TabIndex = 2;
            this.btnDeleteSoal.Text = "Delete Soal";
            this.btnDeleteSoal.UseVisualStyleBackColor = true;
            this.btnDeleteSoal.Click += new System.EventHandler(this.btnDeleteSoal_Click);

            // btnViewSoal
            this.btnViewSoal.Location = new System.Drawing.Point(50, 260);
            this.btnViewSoal.Name = "btnViewSoal";
            this.btnViewSoal.Size = new System.Drawing.Size(150, 50);
            this.btnViewSoal.TabIndex = 3;
            this.btnViewSoal.Text = "View Soal";
            this.btnViewSoal.UseVisualStyleBackColor = true;
            this.btnViewSoal.Click += new System.EventHandler(this.btnViewSoal_Click);

            // FormAdmin
            this.ClientSize = new System.Drawing.Size(250, 350);
            this.Controls.Add(this.btnAddSoal);
            this.Controls.Add(this.btnEditSoal);
            this.Controls.Add(this.btnDeleteSoal);
            this.Controls.Add(this.btnViewSoal);
            this.Name = "FormAdmin";
            this.Text = "Form Admin";
            this.ResumeLayout(false);
        }
    }
}
