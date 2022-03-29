using System;
using System.Collections.Generic;

#nullable disable

namespace HomeCooking.Models
{
    public partial class CongThucNauAn
    {
        public CongThucNauAn()
        {
            ChiTietChuDeCongThucs = new HashSet<ChiTietChuDeCongThuc>();
            ChiTietCongThucNauAns = new HashSet<ChiTietCongThucNauAn>();
        }

        public string IdCongThuc { get; set; }
        public string TenCongThuc { get; set; }
        public string TacGia { get; set; }
        public string MoTaMonAn { get; set; }
        public string LinkVideo { get; set; }
        public string LinkHinhAnh { get; set; }
        public DateTime? NgayTao { get; set; }

        public virtual ICollection<ChiTietChuDeCongThuc> ChiTietChuDeCongThucs { get; set; }
        public virtual ICollection<ChiTietCongThucNauAn> ChiTietCongThucNauAns { get; set; }
    }
}
