using System;
using System.Collections.Generic;

#nullable disable

namespace HomeCooking.Models
{
    public partial class TheoDoiThucPham
    {
        public string IdTheoDoi { get; set; }
        public string IdKh { get; set; }
        public string IdFood { get; set; }

        public virtual ThucPham IdFoodNavigation { get; set; }
        public virtual KhachHang IdKhNavigation { get; set; }
    }
}
