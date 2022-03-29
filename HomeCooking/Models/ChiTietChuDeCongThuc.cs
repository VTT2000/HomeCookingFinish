using System;
using System.Collections.Generic;

#nullable disable

namespace HomeCooking.Models
{
    public partial class ChiTietChuDeCongThuc
    {
        public string IdChuDe { get; set; }
        public string IdCongThuc { get; set; }

        public virtual ChuDeCongThuc IdChuDeNavigation { get; set; }
        public virtual CongThucNauAn IdCongThucNavigation { get; set; }
    }
}
