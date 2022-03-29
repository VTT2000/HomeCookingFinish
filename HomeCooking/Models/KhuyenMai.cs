using System;
using System.Collections.Generic;

#nullable disable

namespace HomeCooking.Models
{
    public partial class KhuyenMai
    {
        public KhuyenMai()
        {
            ThucPhams = new HashSet<ThucPham>();
        }

        public string IdKhuyenMai { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public string MoTaKhuyenMai { get; set; }
        public int? PhanTramKhuyenMai { get; set; }

        public virtual ICollection<ThucPham> ThucPhams { get; set; }
    }
}
