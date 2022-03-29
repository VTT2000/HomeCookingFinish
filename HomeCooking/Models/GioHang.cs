using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeCooking.Models
{
    public class GioHang
    {
        
        public string zIdFood { set; get; }

        public string zNameFood { set; get; }

        public string zLinkHinhAnh { set; get; }

        public Double? zDonGia { set; get; }

        public int? zSoLuong { set; get; }

        public Double? zThanhTien { get { return zSoLuong * zDonGia; } }

        public GioHang()
        {
            
        }

    }
}
