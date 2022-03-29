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
    public class CongThucNauAnController : Controller
    {
        public IActionResult Index(string? id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            List<CongThucNauAn> list = new List<CongThucNauAn>();
            if (String.IsNullOrEmpty(id))
            {
                list = context.CongThucNauAns.ToList();
                ViewBag.IdChuDe = "";
            }
            else
            {
                List<ChiTietChuDeCongThuc> listcd = context.ChiTietChuDeCongThucs.Where(p => p.IdChuDe == id).ToList();
                
                for(int i =0; i < context.CongThucNauAns.ToList().Count; i++)
                {
                    String tentemp = context.CongThucNauAns.ToList()[i].IdCongThuc;
                    if (listcd.Exists(p => p.IdCongThuc == tentemp))
                    {
                        list.Add(context.CongThucNauAns.ToList()[i]);
                    }
                }
                ViewBag.IdChuDe = id;
            }
            ViewBag.ChuDeCongThucs = context.ChuDeCongThucs.ToList();
            ViewBag.ChiTietChuDeCongThucs = context.ChiTietChuDeCongThucs.ToList();

            return View(list);
        }
    public IActionResult CongThucTheoChuDe()
    {
      return View();
    }
  }
    
}
