using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XongAgile
{
    public partial class QuenMK : Form
    {
        public QuenMK()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mail = txtMail.Text;
            account account = Service.CheckMail(mail);
            accountSV account1 = serviceSV.CheckMail(mail);
            if (account != null && mail != "")
            {
                MessageBox.Show("Nhấn Ok dể đổi mật khẩu", "thông báo", MessageBoxButtons.OK);
               
                Qmk1 qmk1 = new Qmk1();
                this.Hide();
                qmk1.Closed += (s, args) => this.Close();
                qmk1.ShowDialog();
            }
            else if (account1 != null && mail != "")
            {
                MessageBox.Show("Nhấn Ok dể đổi mật khẩu", "thông báo", MessageBoxButtons.OK);
                Qmk1 qmk1 = new Qmk1();
                this.Hide();
                qmk1.Closed += (s, args) => this.Close();
                qmk1.ShowDialog();
            }
            else MessageBox.Show("Email không tồn tại");
        }
    }
}
