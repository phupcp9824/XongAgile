namespace XongAgile
{
    partial class MenuSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSV));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnload = new Button();
            dgvDanhSachSV = new DataGridView();
            txttimkiem = new TextBox();
            btntimkiem = new Button();
            btnthoat = new Button();
            tphotro = new TabPage();
            button2 = new Button();
            button3 = new Button();
            label13 = new Label();
            cbodanhmuc = new ComboBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            txtcauhoi = new TextBox();
            label17 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSV).BeginInit();
            tphotro.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tphotro);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(862, 627);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnload);
            tabPage1.Controls.Add(dgvDanhSachSV);
            tabPage1.Controls.Add(txttimkiem);
            tabPage1.Controls.Add(btntimkiem);
            tabPage1.Controls.Add(btnthoat);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(854, 594);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Bảng nhân viên";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnload
            // 
            btnload.BackColor = SystemColors.ControlLight;
            btnload.Location = new Point(637, 452);
            btnload.Name = "btnload";
            btnload.Size = new Size(94, 49);
            btnload.TabIndex = 73;
            btnload.Text = "Load";
            btnload.UseVisualStyleBackColor = false;
            btnload.Click += btnload_Click;
            // 
            // dgvDanhSachSV
            // 
            dgvDanhSachSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachSV.Location = new Point(18, 14);
            dgvDanhSachSV.Margin = new Padding(2);
            dgvDanhSachSV.Name = "dgvDanhSachSV";
            dgvDanhSachSV.RowHeadersWidth = 62;
            dgvDanhSachSV.RowTemplate.Height = 33;
            dgvDanhSachSV.Size = new Size(821, 341);
            dgvDanhSachSV.TabIndex = 72;
            // 
            // txttimkiem
            // 
            txttimkiem.Font = new Font("Segoe UI", 10.8F);
            txttimkiem.Location = new Point(448, 393);
            txttimkiem.Name = "txttimkiem";
            txttimkiem.Size = new Size(151, 31);
            txttimkiem.TabIndex = 12;
            txttimkiem.TextChanged += txttimkiem_TextChanged;
            // 
            // btntimkiem
            // 
            btntimkiem.BackColor = SystemColors.ControlLight;
            btntimkiem.Location = new Point(637, 386);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(94, 49);
            btntimkiem.TabIndex = 10;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = false;
            // 
            // btnthoat
            // 
            btnthoat.BackColor = SystemColors.ControlLight;
            btnthoat.Location = new Point(637, 526);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(94, 49);
            btnthoat.TabIndex = 11;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = false;
            btnthoat.Click += btnthoat_Click;
            // 
            // tphotro
            // 
            tphotro.Controls.Add(button2);
            tphotro.Controls.Add(button3);
            tphotro.Controls.Add(label13);
            tphotro.Controls.Add(cbodanhmuc);
            tphotro.Controls.Add(label14);
            tphotro.Controls.Add(label15);
            tphotro.Controls.Add(label16);
            tphotro.Controls.Add(txtcauhoi);
            tphotro.Controls.Add(label17);
            tphotro.Location = new Point(4, 29);
            tphotro.Name = "tphotro";
            tphotro.Padding = new Padding(3);
            tphotro.Size = new Size(854, 594);
            tphotro.TabIndex = 1;
            tphotro.Text = "Hỗ trợ";
            tphotro.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(426, 188);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 30);
            button2.TabIndex = 35;
            button2.Text = "Gửi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(701, 464);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(89, 34);
            button3.TabIndex = 34;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 10F, FontStyle.Bold | FontStyle.Italic);
            label13.Location = new Point(296, 291);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(433, 160);
            label13.TabIndex = 33;
            label13.Text = resources.GetString("label13.Text");
            // 
            // cbodanhmuc
            // 
            cbodanhmuc.FormattingEnabled = true;
            cbodanhmuc.Items.AddRange(new object[] { "DvSV", "Khảo Thí", "Đào Tạo ", "Hành Chính", "IT" });
            cbodanhmuc.Location = new Point(69, 269);
            cbodanhmuc.Margin = new Padding(2);
            cbodanhmuc.Name = "cbodanhmuc";
            cbodanhmuc.Size = new Size(147, 28);
            cbodanhmuc.TabIndex = 32;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label14.Location = new Point(416, 251);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(154, 23);
            label14.TabIndex = 29;
            label14.Text = "Thông tin liên hệ ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label15.Location = new Point(68, 161);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(79, 23);
            label15.TabIndex = 30;
            label15.Text = "Câu Hỏi";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label16.Location = new Point(68, 244);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(98, 23);
            label16.TabIndex = 31;
            label16.Text = "Danh mục ";
            // 
            // txtcauhoi
            // 
            txtcauhoi.Location = new Point(69, 191);
            txtcauhoi.Margin = new Padding(2);
            txtcauhoi.Name = "txtcauhoi";
            txtcauhoi.Size = new Size(321, 27);
            txtcauhoi.TabIndex = 28;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Times New Roman", 14F);
            label17.ForeColor = Color.Red;
            label17.Location = new Point(383, 51);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(81, 27);
            label17.TabIndex = 27;
            label17.Text = "Hỗ Trợ";
            // 
            // MenuSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 673);
            Controls.Add(tabControl1);
            Name = "MenuSV";
            Text = "MenuSV";
            Load += MenuSV_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachSV).EndInit();
            tphotro.ResumeLayout(false);
            tphotro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnload;
        private DataGridView dgvDanhSachSV;
        private TextBox txttimkiem;
        private Button btntimkiem;
        private Button btnthoat;
        private TabPage tphotro;
        private Button button2;
        private Button button3;
        private Label label13;
        private ComboBox cbodanhmuc;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox txtcauhoi;
        private Label label17;
    }
}