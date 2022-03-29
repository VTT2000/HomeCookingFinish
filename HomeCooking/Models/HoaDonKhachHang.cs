using System;
using System.Collections.Generic;

#nullable disable

namespace HomeCooking.Models
{
    public partial class HoaDonKhachHang
    {
        public HoaDonKhachHang()
        {
            ChiTietHoaDonKhachHangs = new HashSet<ChiTietHoaDonKhachHang>();
            ChiTietKhoBeps = new HashSet<ChiTietKhoBep>();
        }

        public string IdInvoice { get; set; }
        public string IdKh { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int? TongTien { get; set; }
        public string PhuongThucThanhToan { get; set; }
        public string Status { get; set; }
        public string IdNv { get; set; }

        public virtual KhachHang IdKhNavigation { get; set; }
        public virtual NhanVien IdNvNavigation { get; set; }
        public virtual ICollection<ChiTietHoaDonKhachHang> ChiTietHoaDonKhachHangs { get; set; }
        public virtual ICollection<ChiTietKhoBep> ChiTietKhoBeps { get; set; }
    }
}
