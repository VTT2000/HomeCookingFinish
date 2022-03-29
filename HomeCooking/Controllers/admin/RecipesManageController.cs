using HomeCooking.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeCooking.Controllers
{
    public class RecipesManageController : Controller
    {
        public RecipesManageController(IHttpContextAccessor httpContextAccessor)
        {
            // bo dau cham thang de tra ve dang nhap
            if (String.IsNullOrEmpty(httpContextAccessor.HttpContext.Session.GetString("IdQuanLy")))
            {
                httpContextAccessor.HttpContext.Response.Redirect("../Admin/Login");
            }
        }
        public IActionResult Index()
        {
            HomeCooking0Context context = new HomeCooking0Context();
            var list = context.CongThucNauAns.ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            HomeCooking0Context context = new HomeCooking0Context();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CongThucNauAn congThucNauAn)
        {
            congThucNauAn.NgayTao = DateTime.Now;
            congThucNauAn.TacGia = HttpContext.Session.GetString("NameQuanLy");
            HomeCooking0Context context = new HomeCooking0Context();
            context.CongThucNauAns.Add(congThucNauAn);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit([FromRoute] string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            CongThucNauAn a = context.CongThucNauAns.ToList().FirstOrDefault(p => p.IdCongThuc == id);
            return View(a);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CongThucNauAn congThucNauAn)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            context.Update<CongThucNauAn>(congThucNauAn);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Details([FromRoute] string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            CongThucNauAn a = context.CongThucNauAns.ToList().FirstOrDefault(p => p.IdCongThuc == id);
            return View(a);
        }
        [HttpGet]
        public IActionResult Delete([FromRoute] string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            CongThucNauAn a = context.CongThucNauAns.ToList().FirstOrDefault(p => p.IdCongThuc == id);
            return View(a);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Xoa(string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            var listRemove = context.ChiTietChuDeCongThucs.Where(p => p.IdCongThuc == id);
            if(listRemove.Count() != 0)
            {
                context.ChiTietChuDeCongThucs.RemoveRange(listRemove);
                context.SaveChanges();
            }
            var listRemove2 = context.ChiTietCongThucNauAns.Where(p => p.IdCongThuc == id);
            if (listRemove2.Count() != 0)
            {
                context.ChiTietCongThucNauAns.RemoveRange(listRemove2);
                context.SaveChanges();
            }

            CongThucNauAn a = context.CongThucNauAns.ToList().FirstOrDefault(p => p.IdCongThuc == id);
            context.CongThucNauAns.Remove(a);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
