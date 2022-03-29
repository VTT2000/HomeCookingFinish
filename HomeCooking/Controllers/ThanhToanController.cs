using HomeCooking.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeCooking.Controllers
{
    public class ThanhToanController : Controller
    {
        HomeCooking0Context context = new HomeCooking0Context();
        public List<GioHang> LayGioHang()
        {
            List<GioHang> listGioHang = new List<GioHang>();
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("GioHang")))
            {
                HttpContext.Session.SetString("GioHang", JsonConvert.SerializeObject(listGioHang));
            }
            else
            {
                listGioHang = JsonConvert.DeserializeObject<List<GioHang>>(HttpContext.Session.GetString("GioHang"));
            }
            return listGioHang;
        }
        public IActionResult Index()
        {
            string idkh = HttpContext.Session.GetString("KhachHangIdKH");
            List<GioHang> listGH = LayGioHang();
            if (idkh == null || listGH.Count == 0)
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.KhachHang = context.KhachHangs.FirstOrDefault(p => p.IdKh == idkh);
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();

            return View(listGH);
        }
        
        public IActionResult ThanhToanPaypal(string dateDelivery)
        {
            // sb-hr8yk8650165@personal.example.com
            // p679$K6^
            // tai khoan va password thu nghiem paypal nguyen van a
            string namekh = HttpContext.Session.GetString("KhachHangName");
            string idkh = HttpContext.Session.GetString("KhachHangIdKH");
            List<GioHang> listGH = LayGioHang();
            // tao hoa don khach hang
            HoaDonKhachHang hoaDonKhachHang = new HoaDonKhachHang();
            hoaDonKhachHang.IdKh = idkh;
            hoaDonKhachHang.CreatedDate = DateTime.Now;
            hoaDonKhachHang.DeliveryDate = DateTime.Parse(dateDelivery);//***Chọn ngay nhận trên form thanh toán
            hoaDonKhachHang.TongTien = (int)TongTien();
            hoaDonKhachHang.PhuongThucThanhToan = "Paypal";
            hoaDonKhachHang.Status = "Chưa giao";

            context.HoaDonKhachHangs.Add(hoaDonKhachHang);
            context.SaveChanges();
            // tao chi tiet hoa don khach hang
            for (int i = 0; i < listGH.Count; i++)
            {
                ChiTietHoaDonKhachHang temp = new ChiTietHoaDonKhachHang();
                LoHang a = context.LoHangs.FirstOrDefault(p => p.IdFood == listGH[i].zIdFood && p.SoLuong > listGH[i].zSoLuong);
                if (a == null)
                {
                    // tim ko thay lo hang cho san pham // da chan ko cho vao gio hang neu het hang // truong hop nay ko bao gio xay ra
                }
                else
                {
                    temp.IdInvoice = hoaDonKhachHang.IdInvoice;
                    temp.IdLoHang = a.IdLoHang;
                    temp.SoLuong = listGH[i].zSoLuong;
                    temp.GiaTien = (int)listGH[i].zThanhTien;

                    context.ChiTietHoaDonKhachHangs.Add(temp);
                    context.SaveChanges();
                }
            }
            // lam sach gio hang
            listGH = new List<GioHang>();
            HttpContext.Session.SetString("GioHang", JsonConvert.SerializeObject(listGH));

            // khi xac nhan tu nhan vien tu dong trừ vao lo hang va them chi tiet kho bep

            return RedirectToAction("Invoice", "Account");
        }



        [HttpPost]
        public IActionResult ThanhToanThuong([FromForm]string dateDelivery)// thanh toan gio hang
        {
            string namekh = HttpContext.Session.GetString("KhachHangName");
            string idkh = HttpContext.Session.GetString("KhachHangIdKH");
            List<GioHang> listGH = LayGioHang();
            // tao hoa don khach hang
            HoaDonKhachHang hoaDonKhachHang = new HoaDonKhachHang();
            hoaDonKhachHang.IdKh = idkh;
            hoaDonKhachHang.CreatedDate = DateTime.Now;
            hoaDonKhachHang.DeliveryDate = DateTime.Parse(dateDelivery);//***Chọn ngay nhận trên form thanh toán
            hoaDonKhachHang.TongTien = (int)TongTien();
            hoaDonKhachHang.PhuongThucThanhToan = "Thường";
            hoaDonKhachHang.Status = "Chưa giao";

            context.HoaDonKhachHangs.Add(hoaDonKhachHang);
            context.SaveChanges();
            // tao chi tiet hoa don khach hang
            for (int i = 0; i < listGH.Count; i++)
            {
                ChiTietHoaDonKhachHang temp = new ChiTietHoaDonKhachHang();
                LoHang a = context.LoHangs.FirstOrDefault(p => p.IdFood == listGH[i].zIdFood && p.SoLuong > listGH[i].zSoLuong);
                if (a == null)
                {
                    // tim ko thay lo hang cho san pham // da chan ko cho vao gio hang neu het hang // truong hop nay ko bao gio xay ra
                }
                else
                {
                    temp.IdInvoice = hoaDonKhachHang.IdInvoice;
                    temp.IdLoHang = a.IdLoHang;
                    temp.SoLuong = listGH[i].zSoLuong;
                    temp.GiaTien = (int)listGH[i].zThanhTien;

                    context.ChiTietHoaDonKhachHangs.Add(temp);
                    context.SaveChanges();
                }
            }
            // lam sach gio hang
            listGH = new List<GioHang>();
            HttpContext.Session.SetString("GioHang", JsonConvert.SerializeObject(listGH));

            // khi xac nhan tu nhan vien tu dong trừ vao lo hang va them chi tiet kho bep

            return RedirectToAction("Invoice", "Account");
        }
        private int? TongSoLuong()
        {
            int? zTongSoLuong = 0;
            List<GioHang> listGH = JsonConvert.DeserializeObject<List<GioHang>>(HttpContext.Session.GetString("GioHang"));
            if (listGH != null)
            {
                zTongSoLuong = listGH.Sum(p => p.zSoLuong);
            }
            return zTongSoLuong;
        }

        private double? TongTien()
        {
            double? zTongTien = 0;
            List<GioHang> listGH = JsonConvert.DeserializeObject<List<GioHang>>(HttpContext.Session.GetString("GioHang"));
            if (listGH != null)
            {
                zTongTien = listGH.Sum(p => p.zThanhTien);
            }
            return zTongTien;
        }
    }
}
