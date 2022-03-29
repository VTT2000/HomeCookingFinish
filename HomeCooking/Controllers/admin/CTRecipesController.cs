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
    public class CTRecipesController : Controller
    {
        HomeCooking0Context context = new HomeCooking0Context();
        public CTRecipesController(IHttpContextAccessor httpContextAccessor)
        {
            // bo dau cham thang de tra ve dang nhap
            if (String.IsNullOrEmpty(httpContextAccessor.HttpContext.Session.GetString("IdQuanLy")))
            {
                httpContextAccessor.HttpContext.Response.Redirect("../Admin/Login");
            }
        }
        public IActionResult Index()
        {
            var list = context.ChiTietCongThucNauAns.Include(c => c.IdFoodNavigation);
            ViewBag.CongThucNauAns = context.CongThucNauAns.ToList();
            return View(list);
        }
        [HttpGet]
        public IActionResult Edit(string id)
        {
            CongThucNauAn congThuc = context.CongThucNauAns.ToList().FirstOrDefault(p=>p.IdCongThuc == id);
            if (congThuc == null)
            {
                return NotFound();
            }
            List<ChiTietCongThucNauAn> listSelected = context.ChiTietCongThucNauAns.ToList().FindAll(p => p.IdCongThuc == congThuc.IdCongThuc);

            ViewBag.ThucPhams = context.ThucPhams.ToList();
            ViewBag.ListSelected = listSelected;
            return View(congThuc);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string id, IFormCollection form)
        {
            var listThucPhams = context.ThucPhams.ToArray();
            
            // xoa
            var removeList = context.ChiTietCongThucNauAns.Where(p => p.IdCongThuc == id).ToList();
            context.ChiTietCongThucNauAns.RemoveRange(removeList);
            context.SaveChanges();
            // add
            
            foreach (ThucPham item in listThucPhams)
            {
                if(int.Parse(form[item.IdFood].ToString()) != 0)
                {
                    ChiTietCongThucNauAn temp = new ChiTietCongThucNauAn();
                    temp.IdCongThuc = id;
                    temp.IdFood = item.IdFood;
                    temp.SoLuong = int.Parse(form[item.IdFood].ToString());
                    context.ChiTietCongThucNauAns.Add(temp);
                    context.SaveChanges();
                }
                
            }

            return RedirectToAction("Index");
        }


    }
}
