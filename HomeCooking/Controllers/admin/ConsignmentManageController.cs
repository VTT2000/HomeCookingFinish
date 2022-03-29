using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeCooking.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace HomeCooking.Controllers
{
    public class ConsignmentManageController : Controller
    {
        public ConsignmentManageController(IHttpContextAccessor httpContextAccessor)
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
            var list = context.LoHangs.ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            HomeCooking0Context context = new HomeCooking0Context();
            ViewBag.ThucPhams = new SelectList(context.ThucPhams.ToList(), "IdFood", "NameFood");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(LoHang loHang)
        {
            loHang.NgayNhapLoHang = DateTime.Now;
            HomeCooking0Context context = new HomeCooking0Context();
            context.LoHangs.Add(loHang);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit([FromRoute] string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            LoHang a = context.LoHangs.ToList().FirstOrDefault(p => p.IdLoHang == id);
            ViewBag.ThucPhams = new SelectList(context.ThucPhams.ToList(), "IdFood", "NameFood");
            return View(a);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(LoHang loHang)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            context.Update<LoHang>(loHang);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Details([FromRoute] string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            LoHang a = context.LoHangs.ToList().FirstOrDefault(p => p.IdLoHang == id);
            ViewBag.ThucPhams = new SelectList(context.ThucPhams.ToList(), "IdFood", "NameFood");
            return View(a);
        }
        [HttpGet]
        public IActionResult Delete([FromRoute] string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            LoHang a = context.LoHangs.ToList().FirstOrDefault(p => p.IdLoHang == id);
            ViewBag.ThucPhams = new SelectList(context.ThucPhams.ToList(), "IdFood", "NameFood");
            return View(a);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Xoa(string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            LoHang x = context.LoHangs.ToList().FirstOrDefault(p => p.IdLoHang == id);
            context.LoHangs.Remove(x);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
