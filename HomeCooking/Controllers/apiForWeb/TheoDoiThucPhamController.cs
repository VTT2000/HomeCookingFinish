using HomeCooking.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeCooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TheoDoiThucPhamController : ControllerBase
    {
        
        [HttpGet("{id}")]
        public string Get(string id)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("KhachHangIdKH")))
            {
                return "Bạn hãy đăng nhập để theo dõi thực phẩm";
            }
            ThucPham a = context.ThucPhams.FirstOrDefault(p => p.IdFood == id);
            if (a != null)
            {
                TheoDoiThucPham x = context.TheoDoiThucPhams.FirstOrDefault(p => p.IdFood == a.IdFood && p.IdKh == HttpContext.Session.GetString("KhachHangIdKH"));
                if (x == null)
                {
                    x = new TheoDoiThucPham();
                    x.IdFood = a.IdFood;
                    x.IdKh = HttpContext.Session.GetString("KhachHangIdKH");
                    context.TheoDoiThucPhams.Add(x);
                    context.SaveChanges();
                    return "1";
                }
                else
                {
                    context.Remove(x);
                    context.SaveChanges();
                    return "0";
                }


            }
            else
            {
                return "Thực phẩm không tồn tại";
            }
        }

       
    }
}
