using HomeCooking.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeCooking.Controllers
{
    public class SupplierManageController : Controller
    {
        public SupplierManageController(IHttpContextAccessor httpContextAccessor)
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
            var list = context.NhaSanXuats.ToList();
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
        public IActionResult Create(NhaSanXuat nhaSanXuat)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            context.NhaSanXuats.Add(nhaSanXuat);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit([FromRoute] string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            NhaSanXuat a = context.NhaSanXuats.ToList().FirstOrDefault(p => p.IdNsx == id);
            return View(a);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(NhaSanXuat nhaSanXuat)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            context.Update<NhaSanXuat>(nhaSanXuat);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Details([FromRoute] string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            NhaSanXuat a = context.NhaSanXuats.ToList().FirstOrDefault(p => p.IdNsx == id);
            return View(a);
        }
        [HttpGet]
        public IActionResult Delete([FromRoute] string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            NhaSanXuat a = context.NhaSanXuats.ToList().FirstOrDefault(p => p.IdNsx == id);
            return View(a);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Xoa(string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            NhaSanXuat a = context.NhaSanXuats.ToList().FirstOrDefault(p => p.IdNsx == id);
            context.NhaSanXuats.Remove(a);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
