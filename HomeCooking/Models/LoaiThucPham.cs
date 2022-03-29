using System;
using System.Collections.Generic;

#nullable disable

namespace HomeCooking.Models
{
    public partial class LoaiThucPham
    {
        public LoaiThucPham()
        {
            ThucPhams = new HashSet<ThucPham>();
        }

        public string IdLoai { get; set; }
        public string TenLoai { get; set; }
        public string LinkHinhAnh { get; set; }

        public virtual ICollection<ThucPham> ThucPhams { get; set; }
    }
}
