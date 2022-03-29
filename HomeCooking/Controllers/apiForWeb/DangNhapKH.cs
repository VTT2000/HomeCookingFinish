using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeCooking.Models;
using Newtonsoft.Json;

namespace HomeCooking.Controllers.apiForWeb
{
    [Route("api/[controller]")]
    [ApiController]
    public class DangNhapKH : ControllerBase
    {
        [HttpPost]
        public string Login([FromBody] TaiKhoan taiKhoan)
        {
            HomeCooking0Context context = new HomeCooking0Context();
            string phanHoi = "";
            KhachHang kh = context.KhachHangs.ToList().FirstOrDefault(p => p.Email == taiKhoan.email);
            if (kh == null)
            {
                phanHoi = "Tài khoản không tồn tại";
            }
            else
            {
                if (kh.Password.CompareTo(taiKhoan.pass) == 0)
                {
                    
                    if (taiKhoan.remember == false)
                    {
                        // Session
                        HttpContext.Session.SetString("KhachHangName", kh.Name);
                        HttpContext.Session.SetString("KhachHangIdKH", kh.IdKh);
                        // Read Session
                        //HttpContext.Session.GetString("KhachHang");
                    }
                    else
                    {
                        HttpContext.Session.SetString("KhachHangName", kh.Name);
                        HttpContext.Session.SetString("KhachHangIdKH", kh.IdKh);
                        // Cookies
                        CookieOptions option = new CookieOptions
                        {
                            Expires = DateTime.Now.AddYears(100)
                        };
                        Response.Cookies.Append("KhachHangIdKH", kh.IdKh, option);
                        Response.Cookies.Append("KhachHangName", kh.Name, option);
                        // Read Cookies
                        // HttpContext.Request.Cookies["Key Name"];
                    }

                    phanHoi = "OK";
                }
                else
                {
                    phanHoi = "Sai mật khẩu";
                }
            }

            return phanHoi;
        }
        public partial class TaiKhoan
        {
            public TaiKhoan() { }
            public string email { get; set; }
            public string pass { get; set; }

            public bool remember{ get; set;}
        }
    }
}
