using HomeCooking.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeCooking.Controllers
{
    public class TypeManageController : Controller
    {
        public TypeManageController(IHttpContextAccessor httpContextAccessor)
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
            var list = context.LoaiThucPhams.ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(LoaiThucPham loaiThucPham)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            context.LoaiThucPhams.Add(loaiThucPham);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit([FromRoute] string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            LoaiThucPham a = context.LoaiThucPhams.ToList().FirstOrDefault(p => p.IdLoai == id);
            return View(a);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(LoaiThucPham loaiThucPham)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            context.Update<LoaiThucPham>(loaiThucPham);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Details([FromRoute] string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            LoaiThucPham a = context.LoaiThucPhams.ToList().FirstOrDefault(p => p.IdLoai == id);
            return View(a);
        }
        [HttpGet]
        public IActionResult Delete([FromRoute] string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            LoaiThucPham a = context.LoaiThucPhams.ToList().FirstOrDefault(p => p.IdLoai == id);
            return View(a);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Xoa(string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            LoaiThucPham x = context.LoaiThucPhams.ToList().FirstOrDefault(p => p.IdLoai == id);
            context.LoaiThucPhams.Remove(x);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
