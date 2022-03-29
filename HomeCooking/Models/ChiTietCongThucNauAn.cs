using System;
using System.Collections.Generic;

#nullable disable

namespace HomeCooking.Models
{
    public partial class ChiTietCongThucNauAn
    {
        public string IdCongThuc { get; set; }
        public string IdFood { get; set; }
        public int? SoLuong { get; set; }

        public virtual CongThucNauAn IdCongThucNavigation { get; set; }
        public virtual ThucPham IdFoodNavigation { get; set; }
    }
}
