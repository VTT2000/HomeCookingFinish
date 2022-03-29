using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeCooking.Models;

namespace HomeCooking.Views.Shared.Components.ViewLoaiThucPham
{
    [ViewComponent]
    public class ViewLoaiThucPham : ViewComponent
    {
        // product là sản phẩm hiện thị, dùng dynamic cho nhanh ở ví dụ này,
        // thống nhất nó có cấu trúc gồm các thuộc tính: Name, Description, Price

        // Nếu khởi tạo có tham số, thì nó là dịch vụ cần được Inject và
        // Dịch vụ Inject vào cũng cần đăng ký ở ConfigureServices trong Startup
        
        public ViewLoaiThucPham()
        {
            
        }

        // Dùng async Task<IViewComponentResult> InvokeAsync
        // nếu dùng kỹ thuật bất đồng bộ
        public IViewComponentResult Invoke()
        {
            HomeCooking0Context context = new HomeCooking0Context();
            List<LoaiThucPham> list = context.LoaiThucPhams.ToList();
            return View(list); // Nếu khác Default.cshtml thì trả về View("abc", product) cho abc.cshtml
        }
    }
}
