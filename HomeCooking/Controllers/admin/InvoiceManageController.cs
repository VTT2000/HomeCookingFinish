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
    public class InvoiceManageController : Controller
    {
        private readonly HomeCooking0Context _context;

        public InvoiceManageController(HomeCooking0Context context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            // bo dau cham thang de tra ve dang nhap
            if (String.IsNullOrEmpty(httpContextAccessor.HttpContext.Session.GetString("IdQuanLy")))
            {
                httpContextAccessor.HttpContext.Response.Redirect("../Admin/Login");
            }
        }
        
        // GET: InvoiceManage
        public async Task<IActionResult> Index()
        {
            var homeCooking0Context = _context.HoaDonKhachHangs.Include(h => h.IdKhNavigation).Include(h => h.IdNvNavigation);
            return View(await homeCooking0Context.ToListAsync());
        }

        // GET: InvoiceManage/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDonKhachHang = await _context.HoaDonKhachHangs
                .Include(h => h.IdKhNavigation)
                .Include(h => h.IdNvNavigation)
                .FirstOrDefaultAsync(m => m.IdInvoice == id);
            if (hoaDonKhachHang == null)
            {
                return NotFound();
            }

            return View(hoaDonKhachHang);
        }

        // GET: InvoiceManage/Create
        public IActionResult Create()
        {
            ViewData["IdKh"] = new SelectList(_context.KhachHangs, "IdKh", "Name");
            ViewData["IdNv"] = new SelectList(_context.NhanViens, "IdNv", "Ten");
            return View();
        }

        // POST: InvoiceManage/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdInvoice,IdKh,CreatedDate,DeliveryDate,TongTien,PhuongThucThanhToan,Status,IdNv")] HoaDonKhachHang hoaDonKhachHang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hoaDonKhachHang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdKh"] = new SelectList(_context.KhachHangs, "IdKh", "Name", hoaDonKhachHang.IdKh);
            ViewData["IdNv"] = new SelectList(_context.NhanViens, "IdNv", "Ten", hoaDonKhachHang.IdNv);
            return View(hoaDonKhachHang);
        }

        // GET: InvoiceManage/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDonKhachHang = await _context.HoaDonKhachHangs.FindAsync(id);
            if (hoaDonKhachHang == null)
            {
                return NotFound();
            }
            ViewData["IdKh"] = new SelectList(_context.KhachHangs, "IdKh", "Name", hoaDonKhachHang.IdKh);
            ViewData["IdNv"] = new SelectList(_context.NhanViens, "IdNv", "Ten", hoaDonKhachHang.IdNv);
            return View(hoaDonKhachHang);
        }

        // POST: InvoiceManage/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdInvoice,IdKh,CreatedDate,DeliveryDate,TongTien,PhuongThucThanhToan,Status,IdNv")] HoaDonKhachHang hoaDonKhachHang)
        {
            if (id != hoaDonKhachHang.IdInvoice)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hoaDonKhachHang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HoaDonKhachHangExists(hoaDonKhachHang.IdInvoice))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdKh"] = new SelectList(_context.KhachHangs, "IdKh", "Name", hoaDonKhachHang.IdKh);
            ViewData["IdNv"] = new SelectList(_context.NhanViens, "IdNv", "Ten", hoaDonKhachHang.IdNv);
            return View(hoaDonKhachHang);
        }

        // GET: InvoiceManage/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDonKhachHang = await _context.HoaDonKhachHangs
                .Include(h => h.IdKhNavigation)
                .Include(h => h.IdNvNavigation)
                .FirstOrDefaultAsync(m => m.IdInvoice == id);
            if (hoaDonKhachHang == null)
            {
                return NotFound();
            }

            return View(hoaDonKhachHang);
        }

        // POST: InvoiceManage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var hoaDonKhachHang = await _context.HoaDonKhachHangs.FindAsync(id);
            _context.HoaDonKhachHangs.Remove(hoaDonKhachHang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HoaDonKhachHangExists(string id)
        {
            return _context.HoaDonKhachHangs.Any(e => e.IdInvoice == id);
        }
    }
}
