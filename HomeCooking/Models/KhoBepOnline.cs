using System;
using System.Collections.Generic;

#nullable disable

namespace HomeCooking.Models
{
    public partial class KhoBepOnline
    {
        public KhoBepOnline()
        {
            ChiTietKhoBeps = new HashSet<ChiTietKhoBep>();
        }

        public string IdKhobep { get; set; }
        public string IdKh { get; set; }

        public virtual KhachHang IdKhNavigation { get; set; }
        public virtual ICollection<ChiTietKhoBep> ChiTietKhoBeps { get; set; }
    }
}
