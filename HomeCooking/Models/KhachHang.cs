using System;
using System.Collections.Generic;

#nullable disable

namespace HomeCooking.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDonKhachHangs = new HashSet<HoaDonKhachHang>();
            KhoBepOnlines = new HashSet<KhoBepOnline>();
            TheoDoiThucPhams = new HashSet<TheoDoiThucPham>();
        }

        public string IdKh { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public string Password { get; set; }
        public DateTime? DateCreated { get; set; }

        public virtual ICollection<HoaDonKhachHang> HoaDonKhachHangs { get; set; }
        public virtual ICollection<KhoBepOnline> KhoBepOnlines { get; set; }
        public virtual ICollection<TheoDoiThucPham> TheoDoiThucPhams { get; set; }
    }
}
