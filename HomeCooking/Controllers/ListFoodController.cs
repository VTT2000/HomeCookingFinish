using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeCooking.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace HomeCooking.Controllers
{
    public class ListFoodController : Controller
    {
        public IActionResult Index(int? sapxep)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            List<ThucPham> list = context.ThucPhams.ToList();

            
            ViewBag.NhaSanXuats = context.NhaSanXuats.ToList();
            ViewBag.LoaiThucPhams = context.LoaiThucPhams.ToList();
            ViewBag.LoHangs = context.LoHangs.ToList();
            ViewBag.KhuyenMais = context.KhuyenMais.ToList();

            if(sapxep == 1)
            {
                list = list.OrderBy(p => p.Price).ToList();
            }

            return View(list);
        }
        public IActionResult FoodTheoNCC(string id, int? sapxep)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            List<ThucPham> list = context.ThucPhams.Where(p=>p.IdNsx == id).ToList();

            ViewBag.NameId = context.NhaSanXuats.FirstOrDefault(p => p.IdNsx == id).NameNsx;
            ViewBag.NhaSanXuats = context.NhaSanXuats.ToList();
            ViewBag.LoaiThucPhams = context.LoaiThucPhams.ToList();
            ViewBag.LoHangs = context.LoHangs.ToList();
            ViewBag.KhuyenMais = context.KhuyenMais.ToList();

            if (sapxep == 1)
            {
                list = list.OrderBy(p => p.Price).ToList();
            }
            ViewBag.Id = id;

            return View(list);
        }

        public IActionResult FoodTheoLoai(string id, int? sapxep)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            List<ThucPham> list = context.ThucPhams.Where(p=>p.IdLoai == id).ToList();

            ViewBag.NameId = context.LoaiThucPhams.FirstOrDefault(p => p.IdLoai == id).TenLoai;
            ViewBag.NhaSanXuats = context.NhaSanXuats.ToList();
            ViewBag.LoaiThucPhams = context.LoaiThucPhams.ToList();
            ViewBag.LoHangs = context.LoHangs.ToList();
            ViewBag.KhuyenMais = context.KhuyenMais.ToList();

            if (sapxep == 1)
            {
                list = list.OrderBy(p => p.Price).ToList();
            }
            ViewBag.Id = id;

            return View(list);
        }
        public IActionResult FoodDuocKM(int? sapxep)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            List<ThucPham> list = context.ThucPhams.Where(p => p.IdKhuyenMai != null && p.IdKhuyenMai.Length > 0).ToList();

            ViewBag.NhaSanXuats = context.NhaSanXuats.ToList();
            ViewBag.LoaiThucPhams = context.LoaiThucPhams.ToList();
            ViewBag.LoHangs = context.LoHangs.ToList();
            ViewBag.KhuyenMais = context.KhuyenMais.ToList();

            if (sapxep == 1)
            {
                list = list.OrderBy(p => p.Price).ToList();
            }

            return View(list);
        }
        
    }
}
