using System;
using System.Collections.Generic;

#nullable disable

namespace HomeCooking.Models
{
    public partial class ThucPham
    {
        public ThucPham()
        {
            ChiTietCongThucNauAns = new HashSet<ChiTietCongThucNauAn>();
            LoHangs = new HashSet<LoHang>();
            TheoDoiThucPhams = new HashSet<TheoDoiThucPham>();
        }

        public string IdFood { get; set; }
        public string NameFood { get; set; }
        public int? SoLuong { get; set; }
        public string DonViTinh { get; set; }
        public int? PurchasePrice { get; set; }
        public int? Price { get; set; }
        public string IdNsx { get; set; }
        public DateTime? DateCreated { get; set; }
        public string Status { get; set; }
        public string IdLoai { get; set; }
        public string IdKhuyenMai { get; set; }
        public string LinkHinhAnh { get; set; }

        public virtual KhuyenMai IdKhuyenMaiNavigation { get; set; }
        public virtual LoaiThucPham IdLoaiNavigation { get; set; }
        public virtual NhaSanXuat IdNsxNavigation { get; set; }
        public virtual ICollection<ChiTietCongThucNauAn> ChiTietCongThucNauAns { get; set; }
        public virtual ICollection<LoHang> LoHangs { get; set; }
        public virtual ICollection<TheoDoiThucPham> TheoDoiThucPhams { get; set; }
    }
}
