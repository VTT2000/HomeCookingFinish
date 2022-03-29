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
    public class GioHangController : Controller
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

        

        public IActionResult ThemGioHang([FromQuery]string IdFood, [FromQuery]string strURL, [FromQuery]int? soLuong)
        {
            List<GioHang> listGH = LayGioHang();
            GioHang sanPham = listGH.ToList().FirstOrDefault(p => p.zIdFood == IdFood);
            if(sanPham == null)
            {
                ThucPham a = context.ThucPhams.FirstOrDefault(p => p.IdFood == IdFood);
                sanPham = new GioHang();
                
                sanPham.zIdFood = a.IdFood;
                if (String.IsNullOrEmpty(a.IdKhuyenMai))
                {
                    sanPham.zDonGia = double.Parse(a.Price.ToString());
                }
                else
                {
                    KhuyenMai b = context.KhuyenMais.FirstOrDefault(p => p.IdKhuyenMai == a.IdKhuyenMai);
                    sanPham.zDonGia = double.Parse(a.Price.ToString()) * (100 - b.PhanTramKhuyenMai) / 100;
                }
                sanPham.zNameFood = a.NameFood;
                sanPham.zLinkHinhAnh = a.LinkHinhAnh;
                sanPham.zSoLuong = 1;

                if (soLuong.HasValue)
                {
                    sanPham.zSoLuong = soLuong;
                }
                listGH.Add(sanPham);
                HttpContext.Session.SetString("GioHang", JsonConvert.SerializeObject(listGH));
                return Redirect(strURL);
            }
            else
            {
                for(int i = 0; i < listGH.Count; i++)
                {
                    if(listGH[i].zIdFood == IdFood)
                    {
                        if (soLuong.HasValue)
                        {
                            listGH[i].zSoLuong += soLuong;
                        }
                        else
                        {
                            listGH[i].zSoLuong += 1;
                        }
                    }
                }
                HttpContext.Session.SetString("GioHang", JsonConvert.SerializeObject(listGH));
                return Redirect(strURL);
            }
        }
        public IActionResult Index()
        {
            string idkh = HttpContext.Session.GetString("KhachHangIdKH");
            List<GioHang> listGH = LayGioHang();

            ViewBag.KhachHang = context.KhachHangs.FirstOrDefault(p => p.IdKh == idkh);
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();

            return View(listGH);
        }

        
        [HttpGet]
        public IActionResult ThemMot([FromQuery] string IdFood)
        {
            List<GioHang> listGioHang = JsonConvert.DeserializeObject<List<GioHang>>(HttpContext.Session.GetString("GioHang"));
            for (int i = 0; i < listGioHang.Count; i++)
            {
                if (listGioHang[i].zIdFood == IdFood)
                {
                    if(listGioHang[i].zSoLuong + 1 > 10)
                    {
                        listGioHang[i].zSoLuong = 10;
                    }
                    else
                    {
                        listGioHang[i].zSoLuong = listGioHang[i].zSoLuong + 1;
                    }
                }
            }
            HttpContext.Session.SetString("GioHang", JsonConvert.SerializeObject(listGioHang));
            return RedirectToAction("Index", "GioHang");
        }

        [HttpGet]
        public IActionResult GiamMot([FromQuery] string IdFood)
        {
            List<GioHang> listGioHang = JsonConvert.DeserializeObject<List<GioHang>>(HttpContext.Session.GetString("GioHang"));
            for (int i = 0; i < listGioHang.Count; i++)
            {
                if (listGioHang[i].zIdFood == IdFood)
                {
                    if (listGioHang[i].zSoLuong - 1 < 1)
                    {
                        listGioHang[i].zSoLuong = 1;
                    }
                    else
                    {
                        listGioHang[i].zSoLuong = listGioHang[i].zSoLuong - 1;
                    }
                }
            }
            HttpContext.Session.SetString("GioHang", JsonConvert.SerializeObject(listGioHang));
            return RedirectToAction("Index", "GioHang");
        }


        [HttpGet]
        public IActionResult CapNhatGioHang([FromQuery]string IdFood, [FromQuery]int soLuong)
        {
            List<GioHang> listGioHang = JsonConvert.DeserializeObject<List<GioHang>>(HttpContext.Session.GetString("GioHang"));
            for (int i = 0; i < listGioHang.Count; i++)
            {
                if (listGioHang[i].zIdFood == IdFood)
                {
                    listGioHang[i].zSoLuong = soLuong;
                }
            }
            HttpContext.Session.SetString("GioHang", JsonConvert.SerializeObject(listGioHang));
            return RedirectToAction("Index", "GioHang");
        }

        public IActionResult DeleteGH(string id)
        {
            List<GioHang> listGH = LayGioHang();

            GioHang delete = listGH.FirstOrDefault(p => p.zIdFood == id);
            if(delete != null)
            {
                listGH.Remove(delete);
            }
            HttpContext.Session.SetString("GioHang", JsonConvert.SerializeObject(listGH));
            return RedirectToAction("Index","GioHang");
        }


        private int? TongSoLuong()
        {
            int? zTongSoLuong = 0;
            List<GioHang> listGH = JsonConvert.DeserializeObject<List<GioHang>>(HttpContext.Session.GetString("GioHang"));
            if(listGH != null)
            {
                zTongSoLuong = listGH.Sum(p => p.zSoLuong);
            }
            return zTongSoLuong;
        }

        private double? TongTien()
        {
            double? zTongTien = 0;
            List<GioHang> listGH = JsonConvert.DeserializeObject<List<GioHang>>(HttpContext.Session.GetString("GioHang"));
            if(listGH != null)
            {
                zTongTien = listGH.Sum(p => p.zThanhTien);
            }
            return zTongTien;
        }
    }
}
