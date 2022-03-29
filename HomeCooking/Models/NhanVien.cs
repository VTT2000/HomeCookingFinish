using System;
using System.Collections.Generic;

#nullable disable

namespace HomeCooking.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDonKhachHangs = new HashSet<HoaDonKhachHang>();
        }

        public string IdNv { get; set; }
        public string Ten { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime? DateCreated { get; set; }
        public string IdPermission { get; set; }

        public virtual Permission IdPermissionNavigation { get; set; }
        public virtual ICollection<HoaDonKhachHang> HoaDonKhachHangs { get; set; }
    }
}
