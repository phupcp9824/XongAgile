using System;
using System.Collections.Generic;

namespace XongAgile.Models
{
    public partial class MonHoc
    {
        public MonHoc()
        {
            SinhViens = new HashSet<SinhVien>();
        }

        public string MaMh { get; set; } = null!;
        public string? TenMh { get; set; }

        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}
