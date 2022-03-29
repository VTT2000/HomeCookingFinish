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
    public class SaleManageController : Controller
    {
        public SaleManageController(IHttpContextAccessor httpContextAccessor)
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
            var list = context.KhuyenMais.ToList();
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
        public IActionResult Create(KhuyenMai khuyenMai)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            context.KhuyenMais.Add(khuyenMai);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit([FromRoute] string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            KhuyenMai a = context.KhuyenMais.ToList().FirstOrDefault(p => p.IdKhuyenMai == id);
            return View(a);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(KhuyenMai khuyenMai)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            context.Update<KhuyenMai>(khuyenMai);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Details([FromRoute] string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            KhuyenMai a = context.KhuyenMais.ToList().FirstOrDefault(p => p.IdKhuyenMai == id);
            return View(a);
        }
        [HttpGet]
        public IActionResult Delete([FromRoute] string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            KhuyenMai a = context.KhuyenMais.ToList().FirstOrDefault(p => p.IdKhuyenMai == id);
            return View(a);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Xoa(string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            KhuyenMai a = context.KhuyenMais.ToList().FirstOrDefault(p => p.IdKhuyenMai == id);
            context.KhuyenMais.Remove(a);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}
