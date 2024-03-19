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
    public partial class Qmk1 : Form
    {
        public Qmk1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mail = mail1.Text;
            string passmew1 = txtmkmoi1.Text; string passnew2 = txtmkmoi2.Text;
            string filePath = "E:\\fpt fpolytechnic\\học kỳ 4\\Agile\\XongAgile\\XongAgile\\bin\\Debug\\net8.0-windows\\danhchosv.txt";
            int columindex = 1;
            string newcolum = passmew1;
            string emailToChange = mail;
            string[] lines = File.ReadAllLines(filePath);
            account account = Service.CheckMail(mail);

            if (account != null && passmew1.ToLower() != passmew1 && passmew1 == passnew2)
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] columns = lines[i].Split('|');
                    if (columindex >= 0 && columindex < columns.Length && columns[1].Trim() == emailToChange)
                    {
                        columns[4] = newcolum;
                        columns[5] = newcolum;
                    }
                    lines[i] = string.Join("|", columns);
                }
                File.WriteAllLines(filePath, lines);


                MessageBox.Show("Đổi thành công", "thông báo", MessageBoxButtons.OK);
                Form1 f1 = new Form1();
                this.Hide();
                f1.Closed += (s, args) => this.Close();
                f1.ShowDialog();
            }

            string mail2 = mail1.Text;
            string passmew3 = txtmkmoi1.Text; string passnew4 = txtmkmoi2.Text;
            string filePath2 = "E:\\fpt fpolytechnic\\học kỳ 4\\Agile\\XongAgile\\XongAgile\\bin\\Debug\\net8.0-windows\\danhchosv.txt";
            int columindex2 = 1;
            string newcolum2 = passmew1;
            string emailToChange2 = mail;
            string[] lines2 = File.ReadAllLines(filePath2);
            accountSV account2 = serviceSV.CheckMail(mail2);
            if (account2 != null && passmew3.ToLower() != passmew3 && passmew3 == passnew4)
            {
                for (int i = 0; i < lines2.Length; i++)
                {
                    string[] columns1 = lines2[i].Split('|');
                    if (columindex2 >= 0 && columindex2 < columns1.Length && columns1[1].Trim() == emailToChange2)
                    {
                        columns1[4] = newcolum2;
                        columns1[5] = newcolum2;
                    }
                    lines2[i] = string.Join("|", columns1);
                }
                File.WriteAllLines(filePath2, lines2);

                MessageBox.Show("Đổi thành công", "thông báo", MessageBoxButtons.OK);
                Form1 f1 = new Form1();
                this.Hide();
                f1.Closed += (s, args) => this.Close();
                f1.ShowDialog();
            }
        }
    }
}
