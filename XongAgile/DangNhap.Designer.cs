namespace XongAgile
{
    partial class DangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            linkLabel1 = new LinkLabel();
            checkBox1 = new CheckBox();
            btnDangnhap = new Button();
            txtpassword = new TextBox();
            txtname = new TextBox();
            lbpassword = new Label();
            lbname = new Label();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(458, 233);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(111, 20);
            linkLabel1.TabIndex = 35;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên Mật Khẩu";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(274, 231);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(127, 24);
            checkBox1.TabIndex = 34;
            checkBox1.Text = "Hiện mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnDangnhap
            // 
            btnDangnhap.BackColor = SystemColors.ControlLight;
            btnDangnhap.Location = new Point(368, 294);
            btnDangnhap.Margin = new Padding(3, 2, 3, 2);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(105, 54);
            btnDangnhap.TabIndex = 33;
            btnDangnhap.Text = "Đăng Nhập";
            btnDangnhap.UseVisualStyleBackColor = false;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 10.8F);
            txtpassword.Location = new Point(274, 157);
            txtpassword.Margin = new Padding(3, 2, 3, 2);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(329, 31);
            txtpassword.TabIndex = 31;
            // 
            // txtname
            // 
            txtname.Font = new Font("Segoe UI", 10.8F);
            txtname.Location = new Point(274, 77);
            txtname.Margin = new Padding(3, 2, 3, 2);
            txtname.Name = "txtname";
            txtname.Size = new Size(329, 31);
            txtname.TabIndex = 32;
            // 
            // lbpassword
            // 
            lbpassword.AutoSize = true;
            lbpassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbpassword.Location = new Point(147, 158);
            lbpassword.Name = "lbpassword";
            lbpassword.Size = new Size(97, 28);
            lbpassword.TabIndex = 29;
            lbpassword.Text = "Password";
            // 
            // lbname
            // 
            lbname.AutoSize = true;
            lbname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbname.Location = new Point(147, 78);
            lbname.Name = "lbname";
            lbname.Size = new Size(107, 28);
            lbname.TabIndex = 30;
            lbname.Text = "UserName";
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(checkBox1);
            Controls.Add(btnDangnhap);
            Controls.Add(txtpassword);
            Controls.Add(txtname);
            Controls.Add(lbpassword);
            Controls.Add(lbname);
            Name = "DangNhap";
            Text = "DangNhap";
            Load += DangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private CheckBox checkBox1;
        private Button btnDangnhap;
        private TextBox txtpassword;
        private TextBox txtname;
        private Label lbpassword;
        private Label lbname;
    }
}