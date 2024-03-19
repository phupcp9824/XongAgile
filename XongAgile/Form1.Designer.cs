namespace XongAgile
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btndangky = new Button();
            btnthoat = new Button();
            btnsinhvien = new Button();
            btngiangvien = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btndangky
            // 
            btndangky.BackColor = SystemColors.ControlLight;
            btndangky.Location = new Point(609, 321);
            btndangky.Margin = new Padding(3, 4, 3, 4);
            btndangky.Name = "btndangky";
            btndangky.Size = new Size(152, 60);
            btndangky.TabIndex = 35;
            btndangky.Text = "Đăng Ký";
            btndangky.UseVisualStyleBackColor = false;
            btndangky.Click += btndangky_Click;
            // 
            // btnthoat
            // 
            btnthoat.BackColor = SystemColors.ControlLight;
            btnthoat.Location = new Point(321, 321);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(152, 60);
            btnthoat.TabIndex = 34;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = false;
            btnthoat.Click += btnthoat_Click;
            // 
            // btnsinhvien
            // 
            btnsinhvien.BackColor = SystemColors.ControlLight;
            btnsinhvien.Location = new Point(479, 189);
            btnsinhvien.Name = "btnsinhvien";
            btnsinhvien.Size = new Size(152, 60);
            btnsinhvien.TabIndex = 33;
            btnsinhvien.Text = "Sinh viên";
            btnsinhvien.UseVisualStyleBackColor = false;
            btnsinhvien.Click += btnsinhvien_Click;
            // 
            // btngiangvien
            // 
            btngiangvien.BackColor = SystemColors.ControlLight;
            btngiangvien.Location = new Point(180, 189);
            btngiangvien.Name = "btngiangvien";
            btngiangvien.Size = new Size(152, 60);
            btngiangvien.TabIndex = 32;
            btngiangvien.Text = "Giảng viên";
            btngiangvien.UseVisualStyleBackColor = false;
            btngiangvien.Click += btngiangvien_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            label1.Location = new Point(128, 61);
            label1.Name = "label1";
            label1.Size = new Size(581, 46);
            label1.TabIndex = 31;
            label1.Text = "Chương trình quản lý điểm sinh viên";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 589);
            Controls.Add(btndangky);
            Controls.Add(btnthoat);
            Controls.Add(btnsinhvien);
            Controls.Add(btngiangvien);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btndangky;
        private Button btnthoat;
        private Button btnsinhvien;
        private Button btngiangvien;
        private Label label1;
    }
}
