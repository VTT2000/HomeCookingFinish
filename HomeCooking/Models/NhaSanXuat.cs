using System;
using System.Collections.Generic;

#nullable disable

namespace HomeCooking.Models
{
    public partial class NhaSanXuat
    {
        public NhaSanXuat()
        {
            ThucPhams = new HashSet<ThucPham>();
        }

        public string IdNsx { get; set; }
        public string NameNsx { get; set; }
        public string Address { get; set; }
        public string SoDienThoai { get; set; }

        public virtual ICollection<ThucPham> ThucPhams { get; set; }
    }
}
