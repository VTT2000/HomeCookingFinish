using HomeCooking.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeCooking.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            HomeCooking0Context context = new HomeCooking0Context();
            string idKH = HttpContext.Session.GetString("KhachHangIdKH"); 
            string namKH = HttpContext.Session.GetString("KhachHangName");

            KhachHang a = context.KhachHangs.FirstOrDefault(p => p.IdKh == idKH);
            return View(a);
        }
        [HttpPost]
        public IActionResult Index(string nameKH, string sdtKH, string diachiKH, string emailKH, string pwKH, string repwKH)
        {
            string idKH = HttpContext.Session.GetString("KhachHangIdKH");
            string namKH = HttpContext.Session.GetString("KhachHangName");
            KhachHang a = new KhachHang();
            a.IdKh = idKH;
            a.Name = nameKH;
            a.Sdt = sdtKH;
            a.DiaChi = diachiKH;
            a.Email = emailKH;
            a.Password = pwKH;
            if (String.IsNullOrEmpty(a.Name))
            {
                ViewBag.Error = "Họ và tên không được để trống";
                return View(a);
            }
            if (String.IsNullOrEmpty(a.Email))
            {
                ViewBag.Error = "Email không được để trống";
                return View(a);
            }
            if(String.IsNullOrEmpty(a.Password))
            {
                ViewBag.Error = "Password không được để trống";
                return View(a);
            }
            if(pwKH != repwKH)
            {
                ViewBag.Error = "Password và xác nhận lại password không đúng";
                return View(a);
            }

            HomeCooking0Context context = new HomeCooking0Context();
            context.Update(a);
            context.SaveChanges();

            HttpContext.Session.SetString("KhachHangName",a.Name);

            ViewBag.Error = "Cập nhật thông tin thành công";
            
            return View(a);
        }
        
        public IActionResult Invoice()
        {
            string idKH = HttpContext.Session.GetString("KhachHangIdKH");
            string namKH = HttpContext.Session.GetString("KhachHangName");

            HomeCooking0Context context = new HomeCooking0Context();
            List<HoaDonKhachHang> list = context.HoaDonKhachHangs.Where(p => p.IdKh == idKH).OrderByDescending(p=>p.IdInvoice).ToList();

            return View(list);
        }

        [HttpGet("{id}")]
        public IActionResult DetailInvoice(string id)
        {
            // id là id hóa đơn
            string idKH = HttpContext.Session.GetString("KhachHangIdKH");
            string namKH = HttpContext.Session.GetString("KhachHangName");
            HomeCooking0Context context = new HomeCooking0Context();

            List<ChiTietHoaDonKhachHang> list = context.ChiTietHoaDonKhachHangs.Where(p=>p.IdInvoice == id).ToList();
            ViewBag.LoHangs = context.LoHangs.ToList();
            ViewBag.ThucPhams = context.ThucPhams.ToList();

            return View(list);
        }

        // to following

        public IActionResult FollowedFood()
        {
            // id là id hóa đơn
            string idKH = HttpContext.Session.GetString("KhachHangIdKH");
            string namKH = HttpContext.Session.GetString("KhachHangName");
            HomeCooking0Context context = new HomeCooking0Context();

            List<TheoDoiThucPham> list = context.TheoDoiThucPhams.Where(p => p.IdKh == idKH).ToList();
            ViewBag.ThucPhams = context.ThucPhams.ToList();

            return View(list);
        } 
        public IActionResult DeleteFollowedFood(string id)
        {
            // id là id hóa đơn
            string idKH = HttpContext.Session.GetString("KhachHangIdKH");
            string namKH = HttpContext.Session.GetString("KhachHangName");
            HomeCooking0Context context = new HomeCooking0Context();

            TheoDoiThucPham delete = context.TheoDoiThucPhams.FirstOrDefault(p=>p.IdTheoDoi == id);
            if(delete != null)
            {
                context.Remove(delete);
                context.SaveChanges();
            }

            return RedirectToAction("FollowedFood","Account");
        }
        public IActionResult DeleteKhoBep(string IdKhoBep, string IdInvoice, string IdLoHang)
        {
            string idKH = HttpContext.Session.GetString("KhachHangIdKH");
            string namKH = HttpContext.Session.GetString("KhachHangName");
            HomeCooking0Context context = new HomeCooking0Context();

            ChiTietKhoBep delete = context.ChiTietKhoBeps.FirstOrDefault(p=>p.IdKhoBep == IdKhoBep && p.IdInvoice == IdInvoice && p.IdLoHang == IdLoHang);
            context.Remove(delete);
            context.SaveChanges();

            return RedirectToAction("KhoBep","Account");
        }

        public IActionResult KhoBep()
        {
            string idKH = HttpContext.Session.GetString("KhachHangIdKH");
            string namKH = HttpContext.Session.GetString("KhachHangName");
            HomeCooking0Context context = new HomeCooking0Context();
            // kho bep
            List<ChiTietKhoBep> list = context.ChiTietKhoBeps.Where(p => p.IdKhoBepNavigation.IdKh == idKH).ToList();
            //Cac list can thiet
            ViewBag.HoaDonKhachHangs = context.HoaDonKhachHangs.ToList();
            ViewBag.ChiTietHoaDonKhachHangs = context.ChiTietHoaDonKhachHangs.ToList();
            ViewBag.LoHangs = context.LoHangs.ToList();
            ViewBag.ThucPhams = context.ThucPhams.ToList();

            List<ChiTietKhoBep> listConHanSuDung = new List<ChiTietKhoBep>();// list thuc pham kho bep con han su dung
            // update neu thuc pham hong
            for (int i = 0; i < list.Count; i++)
            {
                LoHang test = context.LoHangs.FirstOrDefault(p => p.IdLoHang == list[i].IdLoHang);
                if(test.NgayHetHan < DateTime.Now)
                {
                    list[i].Status = "Đã hỏng";
                    ChiTietKhoBep update = list[i];
                    context.Update(update);
                    context.SaveChanges();
                }
                else
                {
                    listConHanSuDung.Add(list[i]);
                }
            }
            
            // cac cong thuc phu hop
            List<CongThucNauAn> list2 = new List<CongThucNauAn>();
            foreach(CongThucNauAn item in context.CongThucNauAns.ToList())
            {
                if (XetCongThucNauAn(item.IdCongThuc, listConHanSuDung))
                {
                    list2.Add(item);
                }
            }
            ViewBag.ListAvailable = list2;

            return View(list);
        }
        
        public bool XetCongThucNauAn(string IdCongThuc, List<ChiTietKhoBep> list)//id cong thuc va list thuc pham trong kho bep 
        {
            string idKH = HttpContext.Session.GetString("KhachHangIdKH");
            string namKH = HttpContext.Session.GetString("KhachHangName");
            HomeCooking0Context context = new HomeCooking0Context();

            //danh sach idfood and so luong can cho cong thuc
            List<ChiTietCongThucNauAn> listTest = context.ChiTietCongThucNauAns.Where(p => p.IdCongThuc == IdCongThuc).ToList();
            if(listTest.Count == 0)
            {
                // doi voi cac cong thuc chua co thuc pham nau
                return false;
            }

            int demTrue = 0;
            //for(int i = 0; i < list.Count; i++)
            //{
            //    // lay thuc pham chua hong
            //    if(list[i].Status == "Chưa hỏng")
            //    {
            //        // chuyen id lo hang thanh id food trong list trong kho bep
            //        string xIdFoodht = context.LoHangs.FirstOrDefault(p => p.IdLoHang == list[i].IdLoHang).IdFood;
            //        int xSoLuonght = list[i].SoLuongTrongChiTietHoDonKhachHang.Value;
            //        if (listTest.FirstOrDefault(p => p.IdFood == xIdFoodht && p.SoLuong <= xSoLuonght) != null)
            //        {
            //            demTrue += 1;
            //        }
            //    }
            //}
            for(int i = 0; i < listTest.Count; i++)
            {
                List<LoHang> listLHx = context.LoHangs.Where(p => p.IdFood == listTest[i].IdFood).ToList();
                int xSoLuonght = 0;
                foreach(ChiTietKhoBep item in list)
                {
                    if(listLHx.Exists(p=>p.IdLoHang == item.IdLoHang))
                    {
                        xSoLuonght += item.SoLuongTrongChiTietHoDonKhachHang.Value;
                    }
                }
                if(listTest[i].SoLuong <= xSoLuonght)
                {
                    demTrue += 1;
                }
            }
            if(demTrue == listTest.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public IActionResult LuuCongThuc()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DangCongThuc()
        {
            HomeCooking0Context context = new HomeCooking0Context();
            List<ChiTietCongThucNauAn> listSelected = new List<ChiTietCongThucNauAn>();
            ViewBag.ListSelected = listSelected;
            ViewBag.ThucPhams = context.ThucPhams.ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DangCongThuc(string tenCT, string linkHA, string linkVD, string moTa, IFormCollection form)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            var listThucPhams = context.ThucPhams.ToArray();
            List<ChiTietCongThucNauAn> listSelected = new List<ChiTietCongThucNauAn>();
            foreach (ThucPham item in listThucPhams)
            {
                if (int.Parse(form[item.IdFood].ToString()) != 0)
                {
                    ChiTietCongThucNauAn temp = new ChiTietCongThucNauAn();
                    temp.IdFood = item.IdFood;
                    temp.SoLuong = int.Parse(form[item.IdFood].ToString());
                    listSelected.Add(temp);
                }

            }
            ViewBag.ThucPhams = context.ThucPhams.ToList();
            ViewBag.ListSelected = listSelected;
            ViewBag.moTa = moTa;
            ViewBag.linkVD = linkVD;
            ViewBag.linkHA = linkHA;
            ViewBag.tenCT = tenCT;
            if (String.IsNullOrEmpty(tenCT))
            {
                ViewBag.Error = "Tên công thức không được bỏ trống";
                return View();
            }
            if (String.IsNullOrEmpty(linkHA))
            {
                ViewBag.Error = "Link hình ảnh không được bỏ trống";
                return View();
            }
            if (String.IsNullOrEmpty(linkVD))
            {
                ViewBag.Error = "Link video không được bỏ trống";
                return View();
            }
            if (String.IsNullOrEmpty(moTa))
            {
                ViewBag.Error = "Mô tả không được bỏ trống";
                return View();
            }
            if (listSelected.Count < 3)
            {
                ViewBag.Error = "Công thức phải có ít nhát 3 nguyên liệu";
                return View();
            }

            ViewBag.Error = "Đăng công thức thành công";

            CongThucNauAn addX = new CongThucNauAn();
            addX.TenCongThuc = tenCT;
            addX.TacGia = HttpContext.Session.GetString("KhachHangName");
            addX.NgayTao = DateTime.Now;
            addX.LinkHinhAnh = linkHA;
            addX.LinkVideo = linkVD;
            context.CongThucNauAns.Add(addX);
            context.SaveChanges();
            foreach(ChiTietCongThucNauAn item in listSelected)
            {
                ChiTietCongThucNauAn temp = new ChiTietCongThucNauAn();
                temp.IdCongThuc = addX.IdCongThuc;
                temp.IdFood = item.IdFood;
                temp.SoLuong = item.SoLuong;
                context.ChiTietCongThucNauAns.Add(temp);
                context.SaveChanges();
            }


            return View();
        }
    }
}
