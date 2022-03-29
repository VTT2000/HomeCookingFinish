using System;
using System.Collections.Generic;

#nullable disable

namespace HomeCooking.Models
{
    public partial class ChuDeCongThuc
    {
        public ChuDeCongThuc()
        {
            ChiTietChuDeCongThucs = new HashSet<ChiTietChuDeCongThuc>();
        }

        public string IdChuDe { get; set; }
        public string TenChuDe { get; set; }
        public string MoTaChuDe { get; set; }
        public string LinkHinhAnh { get; set; }

        public virtual ICollection<ChiTietChuDeCongThuc> ChiTietChuDeCongThucs { get; set; }
    }
}
