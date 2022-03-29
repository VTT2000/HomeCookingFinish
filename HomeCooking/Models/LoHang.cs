using System;
using System.Collections.Generic;

#nullable disable

namespace HomeCooking.Models
{
    public partial class LoHang
    {
        public LoHang()
        {
            ChiTietHoaDonKhachHangs = new HashSet<ChiTietHoaDonKhachHang>();
        }

        public string IdLoHang { get; set; }
        public string IdFood { get; set; }
        public int? SoLuong { get; set; }
        public DateTime? NgaySanXuat { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public DateTime? NgayNhapLoHang { get; set; }

        public virtual ThucPham IdFoodNavigation { get; set; }
        public virtual ICollection<ChiTietHoaDonKhachHang> ChiTietHoaDonKhachHangs { get; set; }
    }
}
