using HomeCooking.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HomeCooking.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult Index(string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            
            ThucPham a = context.ThucPhams.FirstOrDefault(p => p.IdFood == id);
            if(a == null)
            {
                return NotFound();
            }

            if (String.IsNullOrEmpty(HttpContext.Session.GetString("listSPdaXem")))
            {
                List<string> listDaXem = new List<string>();
                listDaXem.Add(a.IdFood);
                HttpContext.Session.SetString("listSPdaXem", JsonConvert.SerializeObject(listDaXem));
            }
            else
            {
                List<string> listDaXem = JsonConvert.DeserializeObject<List<string>>(HttpContext.Session.GetString("listSPdaXem"));
                if (!listDaXem.Contains(a.IdFood))
                {
                    listDaXem.Add(a.IdFood);
                    HttpContext.Session.SetString("listSPdaXem", JsonConvert.SerializeObject(listDaXem));
                }
            }
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("KhachHangIdKH")))
            {
                ViewBag.TheoDoi = false;
            }
            else
            {
                ViewBag.TheoDoi = context.TheoDoiThucPhams.ToList().Exists(p => p.IdFood == id && p.IdKh == HttpContext.Session.GetString("KhachHangIdKH"));
            }
            
            ViewBag.LoaiThucPhams = context.LoaiThucPhams.ToList();
            ViewBag.KhuyenMais = context.KhuyenMais.ToList();
            ViewBag.NhaSanXuats = context.NhaSanXuats.ToList();
            ViewBag.ThucPhams = context.ThucPhams.ToList();
            ViewBag.LoHangs = context.LoHangs.ToList();

            return View(a);
        }
    }
}
