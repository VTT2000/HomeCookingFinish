using HomeCooking.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeCooking.Controllers
{
    public class UserManageController : Controller
    {
        public UserManageController(IHttpContextAccessor httpContextAccessor)
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
            var list = context.KhachHangs.ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(KhachHang khachHang)
        {
            khachHang.DateCreated = DateTime.Now;
            HomeCooking0Context context = new HomeCooking0Context();
            context.KhachHangs.Add(khachHang);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit([FromRoute] string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            KhachHang a = context.KhachHangs.ToList().FirstOrDefault(p => p.IdKh == id);
            return View(a);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(KhachHang khachHang)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            context.Update<KhachHang>(khachHang);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Details([FromRoute] string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            KhachHang a = context.KhachHangs.ToList().FirstOrDefault(p => p.IdKh == id);
            return View(a);
        }
        [HttpGet]
        public IActionResult Delete([FromRoute] string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            KhachHang a = context.KhachHangs.ToList().FirstOrDefault(p => p.IdKh == id);
            return View(a);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Xoa(string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            KhachHang a = context.KhachHangs.ToList().FirstOrDefault(p => p.IdKh == id);
            context.KhachHangs.Remove(a);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
