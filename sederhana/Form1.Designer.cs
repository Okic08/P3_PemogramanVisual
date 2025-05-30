using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace sederhana
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnTambah = new Button();
            btnKali = new Button();
            btnKurang = new Button();
            btnBagi = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            labelHasil = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(152, 180);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(78, 55);
            btnTambah.TabIndex = 7;
            btnTambah.Text = "+";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // btnKali
            // 
            btnKali.Location = new Point(320, 180);
            btnKali.Name = "btnKali";
            btnKali.Size = new Size(78, 55);
            btnKali.TabIndex = 6;
            btnKali.Text = "*";
            btnKali.UseVisualStyleBackColor = true;
            btnKali.Click += btnKali_Click;
            // 
            // btnKurang
            // 
            btnKurang.Location = new Point(236, 180);
            btnKurang.Name = "btnKurang";
            btnKurang.Size = new Size(78, 55);
            btnKurang.TabIndex = 5;
            btnKurang.Text = "-";
            btnKurang.UseVisualStyleBackColor = true;
            btnKurang.Click += btnKurang_Click;
            // 
            // btnBagi
            // 
            btnBagi.Location = new Point(404, 180);
            btnBagi.Name = "btnBagi";
            btnBagi.Size = new Size(78, 55);
            btnBagi.TabIndex = 4;
            btnBagi.Text = "/";
            btnBagi.UseVisualStyleBackColor = true;
            btnBagi.Click += btnBagi_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(236, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(236, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LightGoldenrodYellow;
            textBox3.Location = new Point(236, 369);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 1;
            // 
            // labelHasil
            // 
            labelHasil.AutoSize = true;
            labelHasil.Location = new Point(236, 320);
            labelHasil.Name = "labelHasil";
            labelHasil.Size = new Size(54, 25);
            labelHasil.TabIndex = 0;
            labelHasil.Text = "Hasil:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 38);
            label1.Name = "label1";
            label1.Size = new Size(211, 21);
            label1.TabIndex = 8;
            label1.Text = "Masukkan Bilangan Pertama";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 89);
            label2.Name = "label2";
            label2.Size = new Size(196, 21);
            label2.TabIndex = 9;
            label2.Text = "Masukkan Bilangan Kedua";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelHasil);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnBagi);
            Controls.Add(btnKurang);
            Controls.Add(btnKali);
            Controls.Add(btnTambah);
            Name = "Form1";
            Text = "Kalkulator Sederhana";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTambah;
        private Button btnKali;
        private Button btnKurang;
        private Button btnBagi;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label labelHasil;
        private Label label1;
        private Label label2;
    }
}
