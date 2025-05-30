using Org.BouncyCastle.Asn1.Crmf;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Quiz_Application
{
    partial class FormAdmin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddSoal;
        private System.Windows.Forms.Button btnEditSoal;
        private System.Windows.Forms.Button btnDeleteSoal;
        private System.Windows.Forms.Button btnViewSoal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnAddSoal = new System.Windows.Forms.Button();
            btnEditSoal = new System.Windows.Forms.Button();
            btnDeleteSoal = new System.Windows.Forms.Button();
            btnViewSoal = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnAddSoal
            // 
            btnAddSoal.BackColor = System.Drawing.Color.MediumSlateBlue;
            btnAddSoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddSoal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnAddSoal.ForeColor = System.Drawing.Color.White;
            btnAddSoal.Location = new System.Drawing.Point(50, 40);
            btnAddSoal.Name = "btnAddSoal";
            btnAddSoal.Size = new System.Drawing.Size(220, 60);
            btnAddSoal.TabIndex = 0;
            btnAddSoal.Text = "➕ Tambah Soal";
            btnAddSoal.UseVisualStyleBackColor = false;
            // NOTE: Tidak ada btnAddSoal.Click += ... di sini
            // 
            // btnEditSoal
            // 
            btnEditSoal.BackColor = System.Drawing.Color.CadetBlue;
            btnEditSoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditSoal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnEditSoal.ForeColor = System.Drawing.Color.White;
            btnEditSoal.Location = new System.Drawing.Point(50, 120);
            btnEditSoal.Name = "btnEditSoal";
            btnEditSoal.Size = new System.Drawing.Size(220, 60);
            btnEditSoal.TabIndex = 1;
            btnEditSoal.Text = "✏️ Edit Soal";
            btnEditSoal.UseVisualStyleBackColor = false;
            // Tidak ada btnEditSoal.Click += ...
            // 
            // btnDeleteSoal
            // 
            btnDeleteSoal.BackColor = System.Drawing.Color.IndianRed;
            btnDeleteSoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteSoal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnDeleteSoal.ForeColor = System.Drawing.Color.White;
            btnDeleteSoal.Location = new System.Drawing.Point(50, 200);
            btnDeleteSoal.Name = "btnDeleteSoal";
            btnDeleteSoal.Size = new System.Drawing.Size(220, 60);
            btnDeleteSoal.TabIndex = 2;
            btnDeleteSoal.Text = "🗑️ Hapus Soal";
            btnDeleteSoal.UseVisualStyleBackColor = false;
            // Tidak ada btnDeleteSoal.Click += ...
            // 
            // btnViewSoal
            // 
            btnViewSoal.BackColor = System.Drawing.Color.DarkOliveGreen;
            btnViewSoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnViewSoal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            btnViewSoal.ForeColor = System.Drawing.Color.White;
            btnViewSoal.Location = new System.Drawing.Point(50, 280);
            btnViewSoal.Name = "btnViewSoal";
            btnViewSoal.Size = new System.Drawing.Size(220, 60);
            btnViewSoal.TabIndex = 3;
            btnViewSoal.Text = "👁️ Lihat Soal";
            btnViewSoal.UseVisualStyleBackColor = false;
            // Tidak ada btnViewSoal.Click += ...
            // 
            // FormAdmin
            // 
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(400, 400);
            Controls.Add(btnAddSoal);
            Controls.Add(btnEditSoal);
            Controls.Add(btnDeleteSoal);
            Controls.Add(btnViewSoal);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormAdmin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form Admin";
            ResumeLayout(false);
        }
    }
}
