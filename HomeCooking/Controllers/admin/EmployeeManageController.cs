using HomeCooking.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeCooking.Controllers
{
    public class EmployeeManageController : Controller
    {
        public EmployeeManageController(IHttpContextAccessor httpContextAccessor)
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
            ViewBag.Permissions = new SelectList(context.Permissions.ToList(), "IdPermission", "Ten");
            var list = context.NhanViens.ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            HomeCooking0Context context = new HomeCooking0Context();
            ViewBag.Permissions = new SelectList(context.Permissions.ToList(), "IdPermission", "Ten");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(NhanVien nhanVien)
        {
            nhanVien.DateCreated = DateTime.Now;
            HomeCooking0Context context = new HomeCooking0Context();
            context.NhanViens.Add(nhanVien);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit([FromRoute] string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            NhanVien a = context.NhanViens.ToList().FirstOrDefault(p => p.IdNv == id);
            ViewBag.Permissions = new SelectList(context.Permissions.ToList(), "IdPermission", "Ten");
            return View(a);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(NhanVien nhanVien)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            context.Update<NhanVien>(nhanVien);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Details([FromRoute] string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            NhanVien a = context.NhanViens.ToList().FirstOrDefault(p => p.IdNv == id);
            ViewBag.Permissions = new SelectList(context.Permissions.ToList(), "IdPermission", "Ten");
            return View(a);
        }
        [HttpGet]
        public IActionResult Delete([FromRoute] string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            NhanVien a = context.NhanViens.ToList().FirstOrDefault(p => p.IdNv == id);
            ViewBag.Permissions = new SelectList(context.Permissions.ToList(), "IdPermission", "Ten");
            return View(a);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Xoa(string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            NhanVien a = context.NhanViens.ToList().FirstOrDefault(p => p.IdNv == id);
            context.NhanViens.Remove(a);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
