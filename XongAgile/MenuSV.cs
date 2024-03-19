using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XongAgile.Models;

namespace XongAgile
{
    public partial class MenuSV : Form
    {
        public MenuSV()
        {
            InitializeComponent();
        }
        QLDiemSVContext db = new QLDiemSVContext();
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string timkiem = txttimkiem.Text;

            if (!string.IsNullOrEmpty(timkiem))
            {
                var result = from sv in db.SinhViens
                             join mh in db.MonHocs on sv.MaMh equals mh.MaMh
                             where sv.MaSv.ToLower().Contains(timkiem) || sv.HoTen.ToLower().Contains(timkiem)
                             select
                             new
                             {
                                 ID = sv.MaSv,
                                 sv.HoTen,
                                 sv.NgaySinh,
                                 sv.GioiTinh,
                                 sv.Email,
                                 sv.Lop,
                                 mh.TenMh,
                                 sv.DiemTa,
                                 sv.DiemDuAn,
                                 sv.DiemIt,
                                 sv.DiemTb
                             };
                dgvDanhSachSV.DataSource = result.ToList();
            }
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            LoadDataSV();
        }

        private void MenuSV_Load(object sender, EventArgs e)
        {
            LoadDataSV();
        }

        public void LoadDataSV()
        {
            var resurl = from sv in db.SinhViens
                         join mh in db.MonHocs on sv.MaMh equals mh.MaMh
                         select new
                         {
                             ID = sv.MaSv,
                             sv.HoTen,
                             sv.NgaySinh,
                             sv.GioiTinh,
                             sv.Email,
                             sv.Lop,
                             mh.TenMh,
                             sv.DiemTa,
                             sv.DiemDuAn,
                             sv.DiemIt,
                             sv.DiemTb
                         };

            dgvDanhSachSV.DataSource = resurl.ToList();

            dgvDanhSachSV.Columns[0].HeaderText = "Mã Sv";
            dgvDanhSachSV.Columns[1].HeaderText = "Tên Sv";
            dgvDanhSachSV.Columns[2].HeaderText = "Ngày sinh";
            dgvDanhSachSV.Columns[3].HeaderText = "Giới tính";
            dgvDanhSachSV.Columns[4].HeaderText = "Email";
            dgvDanhSachSV.Columns[5].HeaderText = "Lớp";
            dgvDanhSachSV.Columns[6].HeaderText = "Môn học";
            dgvDanhSachSV.Columns[7].HeaderText = "Diểm TA";
            dgvDanhSachSV.Columns[8].HeaderText = "Điểm DuAN";
            dgvDanhSachSV.Columns[9].HeaderText = "Điểm IT";
            dgvDanhSachSV.Columns[10].HeaderText = "Điểm TB";

            dgvDanhSachSV.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            var Thoat = MessageBox.Show("Bạn có chắc chắn muốn thoát không ", "Thông báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Thoat == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool check = true;
            string text = txtcauhoi.Text;
            string cbo = cbodanhmuc.Text;
            string filepath = "E:\\fpt fpolytechnic\\học kỳ 4\\Agile\\XongAgile\\XongAgile\\hotro.txt";
            if (text == "")
            {
                check = false;
                MessageBox.Show("Hãy điền câu hỏi hỗ trợ", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbo == "")
            {
                check = false;
                MessageBox.Show("Hãy chọn danh mục", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                check = true;
                File.WriteAllText(filepath, text);
                MessageBox.Show("Đã gửi hỗ trợ");
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    { c.Text = ""; }
                }
                foreach (Control c in this.Controls)
                {
                    if (c is ComboBox)
                    {
                        c.Text = "";
                    }
                }
            }
        }
    }
}
