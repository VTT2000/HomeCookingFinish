using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeCooking.Models;

namespace HomeCooking.Controllers
{
    public class AdminController : Controller
    {
        
        public IActionResult admin()
        {
            //HttpContext.Session.SetString("IdQuanLy","111");// cai dat vao dang nhap Khi dang nhap = quyen admin
            //HttpContext.Session.SetString("NameQuanLy", "111");
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("IdQuanLy")))
            {
                return RedirectToAction("Login", "Admin");
            }

            return View();
        }
        public IActionResult nhanvien()
        {
            //HttpContext.Session.SetString("IdNhanVien", "111");// cai dat vao dang nhap Khi dang nhap = quyen nhanvien
            //HttpContext.Session.SetString("NameNhanVien", "111");
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("IdNhanVien")))
            {
                return RedirectToAction("Login", "Admin");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            form["username"].ToString();
            form["password"].ToString();
            NhanVien x = context.NhanViens.ToList().FirstOrDefault(p => p.Username == form["username"].ToString() && p.Password == form["password"].ToString());
            if(x == null)
            {
                ViewBag.Error = "Thông tin username và password không đúng";
                return View();
            }
            else
            {
                if (x.IdPermission.Equals("PER000001"))
                {
                    HttpContext.Session.SetString("IdNhanVien", x.IdNv);
                    HttpContext.Session.SetString("NameNhanVien", x.Ten);
                    return RedirectToAction("nhanvien", "Admin");
                }
                if (x.IdPermission.Equals("PER000002"))
                {
                    HttpContext.Session.SetString("IdQuanLy", x.IdNv);
                    HttpContext.Session.SetString("NameQuanLy", x.Ten);
                    HttpContext.Session.SetString("IdNhanVien", x.IdNv);
                    HttpContext.Session.SetString("NameNhanVien", x.Ten);
                    return RedirectToAction("admin", "Admin");
                }
            }
            return NotFound();
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.SetString("IdQuanLy", "");
            HttpContext.Session.SetString("NameQuanLy", "");
            HttpContext.Session.SetString("IdNhanVien", "");
            HttpContext.Session.SetString("NameNhanVien", "");
            
            return RedirectToAction("Login","Admin");
        }
    }
}
