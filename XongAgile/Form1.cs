namespace XongAgile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btngiangvien_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();

            dangNhap.ShowDialog();
        }

        private void btnsinhvien_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
   
            dangNhap.ShowDialog();
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            DangKy dangKy = new DangKy();
            this.Hide();
            dangKy.Closed += (s, args) => this.Close();
            dangKy.ShowDialog();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("bạn có muốn thoát không", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dr == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
