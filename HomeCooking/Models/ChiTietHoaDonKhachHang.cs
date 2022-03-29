using System;
using System.Collections.Generic;

#nullable disable

namespace HomeCooking.Models
{
    public partial class ChiTietHoaDonKhachHang
    {
        public string IdInvoice { get; set; }
        public string IdLoHang { get; set; }
        public int? SoLuong { get; set; }
        public int? GiaTien { get; set; }

        public virtual HoaDonKhachHang IdInvoiceNavigation { get; set; }
        public virtual LoHang IdLoHangNavigation { get; set; }
    }
}
