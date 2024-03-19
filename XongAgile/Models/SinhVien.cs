using System;
using System.Collections.Generic;

namespace XongAgile.Models
{
    public partial class SinhVien
    {
        public string MaSv { get; set; } = null!;
        public string? HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? GioiTinh { get; set; }
        public string? Email { get; set; }
        public string? Lop { get; set; }
        public string? MaMh { get; set; }
        public double? DiemTa { get; set; }
        public double? DiemDuAn { get; set; }
        public double? DiemIt { get; set; }
        public double? DiemTb { get; set; }

        public virtual MonHoc? MaMhNavigation { get; set; }
    }
}
