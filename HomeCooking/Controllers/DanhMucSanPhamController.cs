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
    public class DanhMucSanPhamController : Controller
    {
        public IActionResult Index(string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();

            LoaiThucPham a = context.LoaiThucPhams.FirstOrDefault(p => p.IdLoai == id);
            if (a == null)
            {
                return NotFound();
            }
            ViewBag.KhuyenMais = context.KhuyenMais.ToList();
            ViewBag.ThucPhams = context.ThucPhams.ToList();
            ViewBag.LoHangs = context.LoHangs.ToList();

            return View(a);
        }
    }
}
