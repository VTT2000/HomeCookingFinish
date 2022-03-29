using HomeCooking.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HomeCooking.Controllers
{
    public class ChiTietCongThucNauAnController : Controller
    {
        public IActionResult Index(string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();

            CongThucNauAn a = context.CongThucNauAns.FirstOrDefault(p => p.IdCongThuc == id);
            if (a == null)
            {
                return NotFound();
            }
            ViewBag.ChiTietCongThucNauAns = context.ChiTietCongThucNauAns.Where(p => p.IdCongThuc == id).ToList();
            ViewBag.ThucPhams = context.ThucPhams.ToList();

            
            if (!String.IsNullOrEmpty(HttpContext.Session.GetString("KhachHangIdKH"))){
                // nau an cho nguoi dang nhap
                ViewBag.ListNLBepCoSan = getlistNguyenLieuThieu(id);
                if (String.IsNullOrEmpty(HttpContext.Session.GetString("NauAnIdCongThuc")))
                {
                    if (String.IsNullOrEmpty(HttpContext.Session.GetString("GioHang")))
                    {
                        ViewBag.ListGHThieu = getlistNguyenLieuThieu(id);
                    }
                    else
                    {
                        List<GioHang> listGioHang = JsonConvert.DeserializeObject<List<GioHang>>(HttpContext.Session.GetString("GioHang"));
                        if(listGioHang.Count == 0)
                        {
                            ViewBag.ListGHThieu = getlistNguyenLieuThieu(id);
                        }
                        else
                        {
                            List<GioHang> listThieu = getlistNguyenLieuThieu(id);
                            for(int i = 0; i < listThieu.Count; i++)
                            {
                                GioHang trongGio = listGioHang.FirstOrDefault(p => p.zIdFood == listThieu[i].zIdFood);
                                if (trongGio != null)
                                {
                                    listThieu[i].zSoLuong -= trongGio.zSoLuong;
                                }
                            }
                            ViewBag.ListGHThieu = listThieu.FindAll(p => p.zSoLuong > 0);
                        }
                    }
                    
                }
            }

            return View(a);
        }

        public IActionResult NauXong(string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();

            CongThucNauAn a = context.CongThucNauAns.FirstOrDefault(p => p.IdCongThuc == id);
            if (a == null)
            {
                return NotFound();
            }
            // list nglieu cua cong thuc
            List<ChiTietCongThucNauAn> list0 = context.ChiTietCongThucNauAns.Where(p => p.IdCongThuc == id).ToList();
            // list nglieu cua kho bep chua hong
            string idkh = HttpContext.Session.GetString("KhachHangIdKH");
            string idkb = context.KhoBepOnlines.FirstOrDefault(p => p.IdKh == idkh).IdKhobep;
            List<ChiTietKhoBep> list1 = context.ChiTietKhoBeps.Where(p => p.IdKhoBep == idkb && p.Status == "Chưa hỏng").ToList();
            
            // up date chi tiet kho bep khi nau xong
            foreach(ChiTietCongThucNauAn item in list0)
            {
                // tim list id lo hang
                List<LoHang> loHangTemp = context.LoHangs.Where(p => p.IdFood == item.IdFood).ToList();
                // tim list chitietbep co id lo hang tren
                int sotru = (int)item.SoLuong;
                for (int i=0;i<list1.Count;i++)
                {
                    if(loHangTemp.Exists(p=>p.IdLoHang == list1[i].IdLoHang)){
                        if(list1[i].SoLuongTrongChiTietHoDonKhachHang > 0)
                        {
                            list1[i].SoLuongTrongChiTietHoDonKhachHang = list1[i].SoLuongTrongChiTietHoDonKhachHang - sotru;
                            if(list1[i].SoLuongTrongChiTietHoDonKhachHang < 0)
                            {
                                sotru = 0-(int)list1[i].SoLuongTrongChiTietHoDonKhachHang;
                                list1[i].SoLuongTrongChiTietHoDonKhachHang = 0;
                            }
                            else
                            {
                                sotru = 0;
                                break;
                            }
                        }
                    }
                }
            }

            context.UpdateRange(list1);
            context.SaveChanges();

            HttpContext.Session.SetString("NauAnIdCongThuc", "");
            HttpContext.Session.SetString("NauAnNameCongThuc", "");

            return RedirectToAction("KhoBep", "Account");
            //return RedirectToAction("Index", "ChiTietCongThucNauAn", new { id = id });
        }

        public IActionResult HuyBoNauAn(string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();

            CongThucNauAn a = context.CongThucNauAns.FirstOrDefault(p => p.IdCongThuc == id);
            if (a == null)
            {
                return NotFound();
            }

            HttpContext.Session.SetString("NauAnIdCongThuc", "");
            HttpContext.Session.SetString("NauAnNameCongThuc", "");

            return RedirectToAction("Index", "ChiTietCongThucNauAn", new { id = id });
        }

        public IActionResult AddThucPhamThieuVaoGH(string id)
        {
            List<GioHang> listGH = getlistNguyenLieuThieu(id);
            HttpContext.Session.SetString("GioHang", JsonConvert.SerializeObject(listGH));
            return RedirectToAction("Index", "GioHang");
        }

        public IActionResult NauAnVoiCongThuc(string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();

            CongThucNauAn a = context.CongThucNauAns.FirstOrDefault(p => p.IdCongThuc == id);
            if (a == null)
            {
                return NotFound();
            }

            HttpContext.Session.SetString("NauAnIdCongThuc", a.IdCongThuc);
            HttpContext.Session.SetString("NauAnNameCongThuc", a.TenCongThuc);

            return RedirectToAction("Index", "ChiTietCongThucNauAn", new { id = id });
        }

        public List<GioHang> getlistNguyenLieuThieu(string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            List<GioHang> list = new List<GioHang>();
            // list nglieu cua cong thuc
            List<ChiTietCongThucNauAn> list0 = context.ChiTietCongThucNauAns.Where(p => p.IdCongThuc == id).ToList();
            // list nglieu cua kho bep chua hong
            string idkh = HttpContext.Session.GetString("KhachHangIdKH");
            string idkb = context.KhoBepOnlines.FirstOrDefault(p => p.IdKh == idkh).IdKhobep;
            List<ChiTietKhoBep> list1 = context.ChiTietKhoBeps.Where(p => p.IdKhoBep == idkb && p.Status == "Chưa hỏng").ToList();
            // lay list0 - list1 de co list cong thuc cac nguyen lieu con thieu
            List<ChiTietCongThucNauAn> list2 = new List<ChiTietCongThucNauAn>();
            for (int i = 0; i < list0.Count; i++)
            {
                ChiTietCongThucNauAn tempX = new ChiTietCongThucNauAn();
                tempX.IdFood = list0[i].IdFood;
                int sotru = 0;
                //Tim cac idLohang thuoc idfood
                List<LoHang> loHangsTemp = context.LoHangs.Where(p => p.IdFood == tempX.IdFood).ToList();
                //loc chi tiet kho bep thuoc lo hang
                foreach(ChiTietKhoBep item in list1)
                {
                    if(loHangsTemp.Exists(p=>p.IdLoHang == item.IdLoHang))
                    {
                        sotru += (int)item.SoLuongTrongChiTietHoDonKhachHang;
                    }
                }
                tempX.SoLuong = list0[i].SoLuong - sotru;

                list2.Add(tempX);
            }
            // list gio hang thieu
            // list thuc pham ho tro
            List<ThucPham> list3 = context.ThucPhams.ToList();
            foreach(ChiTietCongThucNauAn line in list2)
            {
                if(line.SoLuong <= 0)
                {
                    // thuc pham nay du va thua
                }
                else
                {
                    ThucPham a = context.ThucPhams.FirstOrDefault(p => p.IdFood == line.IdFood);
                    GioHang addX = new GioHang();
                    addX.zIdFood = a.IdFood;
                    if (String.IsNullOrEmpty(a.IdKhuyenMai))
                    {
                        addX.zDonGia = double.Parse(a.Price.ToString());
                    }
                    else
                    {
                        KhuyenMai b = context.KhuyenMais.FirstOrDefault(p => p.IdKhuyenMai == a.IdKhuyenMai);
                        addX.zDonGia = double.Parse(a.Price.ToString()) * (100 - b.PhanTramKhuyenMai) / 100;
                    }
                    addX.zNameFood = a.NameFood;
                    addX.zLinkHinhAnh = a.LinkHinhAnh;
                    
                    for(int i=1; ; i++)
                    {
                        if(i*a.SoLuong >= line.SoLuong)
                        {
                            addX.zSoLuong = i;
                            break;
                        }
                    }

                    list.Add(addX);
                }
            }

            return list;
        }


    }
}
