using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HomeCooking.Models;
using Microsoft.AspNetCore.Http;

namespace HomeCooking.Controllers
{
    public class CTTittleRecipesController : Controller
    {
        HomeCooking0Context context = new HomeCooking0Context();
        public CTTittleRecipesController(IHttpContextAccessor httpContextAccessor)
        {
            // bo dau cham thang de tra ve dang nhap
            if (String.IsNullOrEmpty(httpContextAccessor.HttpContext.Session.GetString("IdQuanLy")))
            {
                httpContextAccessor.HttpContext.Response.Redirect("../Admin/Login");
            }
        }
        public IActionResult Index()
        {
            var list = context.ChiTietChuDeCongThucs.Include(c => c.IdChuDeNavigation);
            ViewBag.CongThucNauAns = context.CongThucNauAns.ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult Edit(string id)
        {
            CongThucNauAn congThuc = context.CongThucNauAns.ToList().FirstOrDefault(p=>p.IdCongThuc == id);
            if (congThuc == null)
            {
                return NotFound();
            }
            List<ChiTietChuDeCongThuc> listSelected = context.ChiTietChuDeCongThucs.ToList().FindAll(p => p.IdCongThuc == congThuc.IdCongThuc);

            ViewBag.ChuDeCongThucs = context.ChuDeCongThucs.ToList();
            ViewBag.ListSelected = listSelected;
            return View(congThuc);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string id, IFormCollection form)
        {
            string[] list = form["list"].ToArray();
            // xoa
            var removeList = context.ChiTietChuDeCongThucs.Where(p => p.IdCongThuc == id).ToList();
            context.ChiTietChuDeCongThucs.RemoveRange(removeList);
            context.SaveChanges();
            // add
            foreach(string item in list)
            {
                ChiTietChuDeCongThuc temp = new ChiTietChuDeCongThuc();
                temp.IdCongThuc = id;
                temp.IdChuDe = item;
                context.ChiTietChuDeCongThucs.Add(temp);
                context.SaveChanges();
            }

            return RedirectToAction("Index");
        }


    }
}
