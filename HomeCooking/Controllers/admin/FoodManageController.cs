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
    public class FoodManageController : Controller
    {
        public FoodManageController(IHttpContextAccessor httpContextAccessor)
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
            var list = context.ThucPhams.ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult Create()
        {
            HomeCooking0Context context = new HomeCooking0Context();

            //KhuyenMai GTnull = new KhuyenMai();
            //GTnull.IdKhuyenMai = "";
            //GTnull.MoTaKhuyenMai = "Trống";
            //List<KhuyenMai> list = context.KhuyenMais.ToList();
            //list.Add(GTnull);
            //ViewBag.KhuyenMais = new SelectList(list, "IdKhuyenMai", "MoTaKhuyenMai", "");
            ViewBag.NSXs = new SelectList(context.NhaSanXuats.ToList(), "IdNsx", "NameNsx");
            ViewBag.LoaiThucPhams = new SelectList(context.LoaiThucPhams.ToList(), "IdLoai", "TenLoai");

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ThucPham thucPham)
        {
            thucPham.DateCreated = DateTime.Now;
            HomeCooking0Context context = new HomeCooking0Context();
            context.ThucPhams.Add(thucPham);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit([FromRoute] string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            ThucPham a = context.ThucPhams.ToList().FirstOrDefault(p => p.IdFood == id);

            KhuyenMai GTnull = new KhuyenMai();
            GTnull.IdKhuyenMai = null;
            GTnull.MoTaKhuyenMai = "Trống";
            List<KhuyenMai> list = new List<KhuyenMai>();
            list.Add(GTnull);
            list.AddRange(context.KhuyenMais.ToList());
            ViewBag.KhuyenMais = new SelectList(list, "IdKhuyenMai", "MoTaKhuyenMai");
            ViewBag.NSXs = new SelectList(context.NhaSanXuats.ToList(), "IdNsx", "NameNsx");
            ViewBag.LoaiThucPhams = new SelectList(context.LoaiThucPhams.ToList(), "IdLoai", "TenLoai");

            return View(a);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ThucPham thucPham)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            context.Update<ThucPham>(thucPham);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Details([FromRoute] string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            ThucPham a = context.ThucPhams.ToList().FirstOrDefault(p => p.IdFood == id);

            KhuyenMai GTnull = new KhuyenMai();
            GTnull.IdKhuyenMai = null;
            GTnull.MoTaKhuyenMai = "Trống";
            List<KhuyenMai> list = new List<KhuyenMai>();
            list.Add(GTnull);
            list.AddRange(context.KhuyenMais.ToList());
            ViewBag.KhuyenMais = new SelectList(list, "IdKhuyenMai", "MoTaKhuyenMai");
            ViewBag.NhaSanXuats = context.NhaSanXuats.ToList();
            ViewBag.LoaiSanPham = context.LoaiThucPhams.ToList();

            return View(a);
        }
        [HttpGet]
        public IActionResult Delete([FromRoute] string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            ThucPham a = context.ThucPhams.ToList().FirstOrDefault(p => p.IdFood == id);

            KhuyenMai GTnull = new KhuyenMai();
            GTnull.IdKhuyenMai = null;
            GTnull.MoTaKhuyenMai = "Trống";
            List<KhuyenMai> list = new List<KhuyenMai>();
            list.Add(GTnull);
            list.AddRange(context.KhuyenMais.ToList());
            ViewBag.KhuyenMais = new SelectList(list, "IdKhuyenMai", "MoTaKhuyenMai");
            ViewBag.NhaSanXuats = context.NhaSanXuats.ToList();
            ViewBag.LoaiSanPham = context.LoaiThucPhams.ToList();

            return View(a);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Xoa(string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            
            ThucPham x = context.ThucPhams.ToList().FirstOrDefault(p => p.IdFood == id);
            context.ThucPhams.Remove(x);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
