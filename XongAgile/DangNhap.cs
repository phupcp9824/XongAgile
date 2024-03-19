using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace XongAgile
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        public bool CheckCount(string message) // check m?t kh?u và tài kho?n
        {
            return Regex.IsMatch(message, @"^[A-Za-z0-9]{8,24}$");
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string username = txtname.Text; string password = txtpassword.Text;
            accountSV accounts = serviceSV.CheckLogin(username, password);
            account account = Service.CheckLogin(username, password);
            if (username.Length > 8 && password.ToLower() != password && account != null)
            {
                MessageBox.Show("Đăng nhập thành công", "thông báo", MessageBoxButtons.OK);
                Menu menu = new Menu();
                this.Hide();
                menu.Closed += (s, args) => this.Close();
                menu.ShowDialog();

            }
            else if (username.Length > 8 && password.ToLower() != password && accounts != null)
            {
                MessageBox.Show("Đăng nhập thành công", "thông báo", MessageBoxButtons.OK);
                MenuSV menu1 = new MenuSV();
                this.Hide();
                menu1.Closed += (s, args) => this.Close();
                menu1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else txtpassword.PasswordChar = '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMK quenMK = new QuenMK();
            this.Hide();
            quenMK.Closed += (s, args) => this.Close();
            quenMK.ShowDialog();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
