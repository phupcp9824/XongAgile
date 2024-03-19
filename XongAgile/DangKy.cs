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

namespace XongAgile
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        private bool CheckSDT(string mess)
        {
            return Regex.IsMatch(mess, @"^0\d{9}$");
        }
        private bool Checkemail(string mess)
        {
            return Regex.IsMatch(mess, @"^(?=.*@gmail\.com$|@fpt\.edu\.vn$).*");
        }
        private bool CheckMK(string mess)
        {
            return Regex.IsMatch(mess, @"^(?=.*[A-Z]).+$");
        }
        private void btndangky_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txthotengv.Text))
            {
                MessageBox.Show("không được để trống tên ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtemail.Text))
            {
                MessageBox.Show("không được để trống email", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Checkemail(txtemail.Text))
            {
                MessageBox.Show("Email không đúng định dạng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtphone.Text))
            {
                MessageBox.Show("không được để trống số điện thoại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!CheckSDT(txtphone.Text))
            {
                MessageBox.Show("không đúng định dạng số điện thoại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txttaikhoan.Text))
            {
                MessageBox.Show("không được để trống tài khoản", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtmatkhau.Text))
            {
                MessageBox.Show("không được để trống mật khẩu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!CheckMK(txtmatkhau.Text))
            {
                MessageBox.Show("Không đúng định dạng mật khẩu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtxacnhanmkgv.Text))
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool check = true; // tạo 1 biến check để validate dữ liệu
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox && item.Text == "") // nếu controls là textbox rỗng
                    {

                        MessageBox.Show("Hãy điền đủ thông tin");
                        check = false;
                        break;
                    }
                }
                DialogResult result = MessageBox.Show("Do you want to save ?", "", MessageBoxButtons.YesNoCancel);
                if (check = true && result == DialogResult.Yes)
                {
                    string name = txthotengv.Text;
                    string address = txtemail.Text;
                    string username = txttaikhoan.Text;
                    string password = txtmatkhau.Text;
                    string phone = txtphone.Text;
                    string xnmk = txtxacnhanmkgv.Text;

                    account ac = new account(name, address, phone, username, password, xnmk);
                    string accountFile = ac.CreateAccount();
                    File.AppendAllText("account.txt", accountFile);

                    foreach (Control c in this.Controls)
                    {
                        if (c is TextBox)
                        { c.Text = ""; }
                    }
                    DangNhap dangNhap = new DangNhap();
                    dangNhap.ShowDialog();
                }
            }
        }

        private void btndangkysv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txthotensV.Text))
            {
                MessageBox.Show("không được để trống tên nhân viên", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtemailsV.Text))
            {
                MessageBox.Show("không được để trống email", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Checkemail(txtemailsV.Text))
            {
                MessageBox.Show("Email không đúng định dạng", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtphoneE.Text))
            {
                MessageBox.Show("không được để trống số điện thoại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!CheckSDT(txtphoneE.Text))
            {
                MessageBox.Show("không được đúng định dạng số điện thoại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txttaikhoansV.Text))
            {
                MessageBox.Show("không được để trống tài khoản", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtmatkausV.Text))
            {
                MessageBox.Show("không được để trống mật khẩu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!CheckMK(txtmatkausV.Text))
            {
                MessageBox.Show("không đúng định dạng mật khẩu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtxacnhanmksV.Text))
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool checkk = true; // tạo 1 biến check để validate dữ liệu

                DialogResult result = MessageBox.Show("Do you want to save ?", "", MessageBoxButtons.YesNoCancel);
                if (checkk && result == DialogResult.Yes)
                {
                    string name = txthotensV.Text;
                    string address = txtemailsV.Text;
                    string phonee = txtphoneE.Text;
                    string username = txttaikhoansV.Text;
                    string password = txtmatkausV.Text;
                    string xnmk = txtxacnhanmksV.Text;

                    accountSV ac = new accountSV(name, address, phonee, username, password, xnmk);
                    string accountFile = ac.CreateAccount();

                    // Thay đổi path để bao gồm tên tập tin hoặc thay đổi tên tập tin trong File.AppendAllText
                    File.AppendAllText("danhchosv.txt", accountFile);

                    foreach (Control c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            c.Text = "";
                        }
                    }

                    DangNhap dangNhap = new DangNhap();
                    dangNhap.ShowDialog();
                }
            }
        }

        private void checkmksv_CheckedChanged(object sender, EventArgs e)
        {
            if (checkmksv.Checked)
            {
                txtmatkausV.PasswordChar = '\0';
            }
            else txtmatkausV.PasswordChar = '*';
        }

        private void checkxnsv_CheckedChanged(object sender, EventArgs e)
        {
            if (checkxnsv.Checked)
            {
                txtxacnhanmksV.PasswordChar = '\0';
            }
            else txtxacnhanmksV.PasswordChar = '*';
        }

        private void checkmkgv_CheckedChanged(object sender, EventArgs e)
        {
            if (checkmkgv.Checked)
            {
                txtmatkhau.PasswordChar = '\0';
            }
            else txtmatkhau.PasswordChar = '*';
        }

        private void checkxngv_CheckedChanged(object sender, EventArgs e)
        {
            if (checkxngv.Checked)
            {
                txtxacnhanmkgv.PasswordChar = '\0';
            }
            else txtxacnhanmkgv.PasswordChar = '*';
        }
    }
}
