using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HomeCooking.Models;
using Microsoft.AspNetCore.Http;

namespace HomeCooking
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddMvc();
            services.AddDbContext<HomeCooking0Context>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("HomeCooking0Database")));


            services.AddDistributedMemoryCache();           // Đăng ký dịch vụ lưu cache trong bộ nhớ (Session sẽ sử dụng nó)
            services.AddSession(cfg =>
            {   // Đăng ký dịch vụ Session
                cfg.Cookie.Name = "SessionKhachHang";             // Đặt tên Session - tên này sử dụng ở Browser (Cookie)
                cfg.IdleTimeout = new TimeSpan(24, 0, 0);    // Thời gian tồn tại của Session
            });

            services.AddHttpContextAccessor(); // dang ky dich vu cho cookies

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

        }

       

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            
            // For mobile apps, allow http traffic.
            app.UseHttpsRedirection();

            //app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();

            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Trang nhân viên",
                    pattern: "NhanVien",
                    defaults: new { controller = "Admin", action = "nhanvien" });

                endpoints.MapControllerRoute(
                    name: "Trang quản trị quản lý chi tiết kho bếp",
                    pattern: "Admin/CTKhoBepManage",
                    defaults: new { controller = "CTKhoBepManage", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "Trang quản trị quản lý kho bếp",
                    pattern: "Admin/KhoBepManage",
                    defaults: new { controller = "KhoBepManage", action = "Index" });
                
                endpoints.MapControllerRoute(
                    name: "Trang quản trị quản lý quyền",
                    pattern: "Admin/PermissionManage",
                    defaults: new { controller = "PermissionManage", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "Trang quản trị quản lý chi tiết hóa đơn khách hàng",
                    pattern: "Admin/CTInvoiceManage",
                    defaults: new { controller = "CTInvoiceManage", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "Trang quản trị quản lý theo dõi thực phẩm",
                    pattern: "Admin/FoodFollowedManage",
                    defaults: new { controller = "FoodFollowedManage", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "Trang quản trị quản lý chọn thực phẩm cho công thức nấu ăn",
                    pattern: "Admin/CTRecipes",
                    defaults: new { controller = "CTRecipes", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "Trang quản trị quản lý chọn chủ đề cho công thức nấu ăn",
                    pattern: "Admin/CTTittleRecipes",
                    defaults: new { controller = "CTTittleRecipes", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "Trang quản trị quản lý chủ đề cho công thức nấu ăn",
                    pattern: "Admin/TittleRecipesManage",
                    defaults: new { controller = "TittleRecipesManage", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "Trang quản trị quản lý hóa đơn khách hàng",
                    pattern: "Admin/InvoiceManage",
                    defaults: new { controller = "InvoiceManage", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "Trang quản trị quản lý khuyến mãi",
                    pattern: "Admin/SaleManage",
                    defaults: new { controller = "SaleManage", action = "Index" });
                
                endpoints.MapControllerRoute(
                    name: "Trang quản trị quản lý nhà sản xuất",
                    pattern: "Admin/SupplierManage",
                    defaults: new { controller = "SupplierManage", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "Trang quản trị quản lý người dùng",
                    pattern: "Admin/UserManage",
                    defaults: new { controller = "UserManage", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "Trang quản trị quản lý công thức",
                    pattern: "Admin/RecipesManage",
                    defaults: new { controller = "RecipesManage", action = "Index" });
                
                endpoints.MapControllerRoute(
                    name: "Trang quản trị quản lý nhân viên",
                    pattern: "Admin/EmployeeManage",
                    defaults: new { controller = "EmployeeManage", action = "Index" });
                
                endpoints.MapControllerRoute(
                    name: "Trang quản trị quản lý lô hàng",
                    pattern: "Admin/ConsignmentManage",
                    defaults: new { controller = "ConsignmentManage", action = "Index" });
                
                endpoints.MapControllerRoute(
                    name: "Trang quản trị quản lý loại thực phẩm",
                    pattern: "Admin/TypeManage",
                    defaults: new { controller = "TypeManage", action = "Index" });
                
                endpoints.MapControllerRoute(
                    name: "Trang quản trị quản lý thực phẩm",
                    pattern: "Admin/FoodManage",
                    defaults: new { controller = "FoodManage", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "Trang quản trị",
                    pattern: "Admin",
                    defaults: new { controller = "Admin", action = "admin" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                
            });

        }


    }
}
