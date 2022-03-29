using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeCooking.Models;

namespace HomeCooking.Controllers.apiForWeb
{
    [Route("api/[controller]")]
    [ApiController]
    public class DangKyKHController : ControllerBase
    {
        [HttpPost]
        public string Register([FromBody]KhachHang khachHang)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            KhachHang findKH = context.KhachHangs.FirstOrDefault(p => p.Email == khachHang.Email);
            if(findKH == null)
            {
                if(khachHang.Password.Length >= 6)
                {
                    khachHang.DateCreated = DateTime.Now;
                    context.KhachHangs.Add(khachHang);
                    context.SaveChanges();
                    // tao kho bep lun
                    KhoBepOnline khoBep = new KhoBepOnline();
                    khoBep.IdKh = khachHang.IdKh;
                    context.KhoBepOnlines.Add(khoBep);
                    context.SaveChanges();

                    return "OK";
                }
                else
                {
                    return "Password tối thiểu 6 kí tự";
                }
                
            }
            else
            {
                return "Email đã được đăng ký, bạn hãy nhập Email khác";
            }
        }
    }
}
