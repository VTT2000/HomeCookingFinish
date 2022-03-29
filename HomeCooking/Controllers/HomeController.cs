using HomeCooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace HomeCooking.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if(!String.IsNullOrEmpty(HttpContext.Request.Cookies["KhachHangIdKH"]) && !String.IsNullOrEmpty(HttpContext.Request.Cookies["KhachHangName"]))
            {
                HttpContext.Session.SetString("KhachHangName", HttpContext.Request.Cookies["KhachHangName"].ToString());
                HttpContext.Session.SetString("KhachHangIdKH", HttpContext.Request.Cookies["KhachHangIdKH"].ToString());                
            }
            
            HomeCooking0Context context = new HomeCooking0Context();

            ViewBag.LoHangs = context.LoHangs.ToList();
            ViewBag.KhuyenMais = context.KhuyenMais.ToList();
            var list = context.ThucPhams.ToList().OrderBy(p=>p.NameFood).Take(8);
            
            return View(list);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult LogOut()
        {
            if (!String.IsNullOrEmpty(HttpContext.Request.Cookies["KhachHangIdKH"]) && !String.IsNullOrEmpty(HttpContext.Request.Cookies["KhachHangName"]))
            {
                HttpContext.Response.Cookies.Delete("KhachHangIdKH");
                HttpContext.Response.Cookies.Delete("KhachHangName");
            }
            HttpContext.Session.SetString("KhachHangName", "");
            HttpContext.Session.SetString("KhachHangIdKH", "");
            
            return RedirectToAction("Index","Home");
        }
        public IActionResult DangNhapFB(string fname, string lname, string email)
        {
            string fullname = fname + " " + lname; 
            HomeCooking0Context context = new HomeCooking0Context();
            KhachHang kh = context.KhachHangs.FirstOrDefault(p => p.Email == email && p.Name == fullname);
            if(kh == null)
            {
                kh = new KhachHang();
                kh.Name = fullname;
                kh.Email = email;
                kh.DateCreated = DateTime.Now;
                context.KhachHangs.Add(kh);
                context.SaveChanges();
                // tao kho bep lun
                KhoBepOnline khoBep = new KhoBepOnline();
                khoBep.IdKh = kh.IdKh;
                context.KhoBepOnlines.Add(khoBep);
                context.SaveChanges();
            }

            HttpContext.Session.SetString("KhachHangName", kh.Name);
            HttpContext.Session.SetString("KhachHangIdKH", kh.IdKh);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult DangNhapGG(string name, string email)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            KhachHang kh = context.KhachHangs.FirstOrDefault(p => p.Email == email && p.Name == name);
            if (kh == null)
            {
                kh = new KhachHang();
                kh.Name = name;
                kh.Email = email;
                kh.DateCreated = DateTime.Now;
                context.KhachHangs.Add(kh);
                context.SaveChanges();
                // tao kho bep lun
                KhoBepOnline khoBep = new KhoBepOnline();
                khoBep.IdKh = kh.IdKh;
                context.KhoBepOnlines.Add(khoBep);
                context.SaveChanges();
            }

            HttpContext.Session.SetString("KhachHangName", kh.Name);
            HttpContext.Session.SetString("KhachHangIdKH", kh.IdKh);

            return RedirectToAction("Index", "Home");
        }
    }
}
