using System;
using System.Collections.Generic;

#nullable disable

namespace HomeCooking.Models
{
    public partial class ChiTietKhoBep
    {
        public string IdKhoBep { get; set; }
        public string IdInvoice { get; set; }
        public string IdLoHang { get; set; }
        public int? SoLuongTrongChiTietHoDonKhachHang { get; set; }
        public string Status { get; set; }

        public virtual HoaDonKhachHang IdInvoiceNavigation { get; set; }
        public virtual KhoBepOnline IdKhoBepNavigation { get; set; }
    }
}
