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
    public class CTInvoiceManageController : Controller
    {
        private readonly HomeCooking0Context _context;

        public CTInvoiceManageController(HomeCooking0Context context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            // bo dau cham thang de tra ve dang nhap
            if (String.IsNullOrEmpty(httpContextAccessor.HttpContext.Session.GetString("IdQuanLy")))
            {
                httpContextAccessor.HttpContext.Response.Redirect("../Admin/Login");
            }
        }

        // GET: CTInvoiceManage
        public async Task<IActionResult> Index()
        {
            var homeCooking0Context = _context.ChiTietHoaDonKhachHangs.Include(c => c.IdInvoiceNavigation).Include(c => c.IdLoHangNavigation.IdFoodNavigation);
            return View(await homeCooking0Context.ToListAsync());
        }

        // GET: CTInvoiceManage/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            string[] a = id.Split("@");

            var chiTietHoaDonKhachHang = await _context.ChiTietHoaDonKhachHangs
                .Include(c => c.IdInvoiceNavigation)
                .Include(c => c.IdLoHangNavigation.IdFoodNavigation)
                .FirstOrDefaultAsync(m => m.IdInvoice == a[0] && m.IdLoHang == a[1]);
            if (chiTietHoaDonKhachHang == null)
            {
                return NotFound();
            }

            return View(chiTietHoaDonKhachHang);
        }

        // GET: CTInvoiceManage/Create
        public IActionResult Create()
        {
            ViewData["IdInvoice"] = new SelectList(_context.HoaDonKhachHangs, "IdInvoice", "IdInvoice");
            ViewData["IdFood"] = new SelectList(_context.ThucPhams, "IdFood", "NameFood");
            ViewData["IdLoHang"] = _context.LoHangs.ToList();
            return View();
        }

        // POST: CTInvoiceManage/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdInvoice,IdLoHang,SoLuong,GiaTien")] ChiTietHoaDonKhachHang chiTietHoaDonKhachHang)
        {
            if(chiTietHoaDonKhachHang.IdLoHang == null || chiTietHoaDonKhachHang.IdLoHang.Length == 0)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _context.Add(chiTietHoaDonKhachHang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdInvoice"] = new SelectList(_context.HoaDonKhachHangs, "IdInvoice", "IdInvoice", chiTietHoaDonKhachHang.IdInvoice);
            ViewData["IdFood"] = new SelectList(_context.ThucPhams, "IdFood", "NameFood");
            ViewData["IdLoHang"] = _context.LoHangs.ToList();
            return View(chiTietHoaDonKhachHang);
        }

        // GET: CTInvoiceManage/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            string[] a = id.Split("@");
            var chiTietHoaDonKhachHang = await _context.ChiTietHoaDonKhachHangs.FirstOrDefaultAsync(p=>p.IdInvoice == a[0] && p.IdLoHang == a[1]);
            if (chiTietHoaDonKhachHang == null)
            {
                return NotFound();
            }
            ViewData["IdInvoice"] = new SelectList(_context.HoaDonKhachHangs, "IdInvoice", "IdInvoice", chiTietHoaDonKhachHang.IdInvoice);
            ViewData["IdLoHang"] = new SelectList(_context.LoHangs, "IdLoHang", "IdLoHang", chiTietHoaDonKhachHang.IdLoHang);
            return View(chiTietHoaDonKhachHang);
        }

        // POST: CTInvoiceManage/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdInvoice,IdLoHang,SoLuong,GiaTien")] ChiTietHoaDonKhachHang chiTietHoaDonKhachHang)
        {
            string[] a = id.Split("@");
            if (a[0] != chiTietHoaDonKhachHang.IdInvoice || a[1] != chiTietHoaDonKhachHang.IdLoHang)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chiTietHoaDonKhachHang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChiTietHoaDonKhachHangExists(chiTietHoaDonKhachHang.IdInvoice+"@"+chiTietHoaDonKhachHang.IdLoHang))
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
            ViewData["IdInvoice"] = new SelectList(_context.HoaDonKhachHangs, "IdInvoice", "IdInvoice", chiTietHoaDonKhachHang.IdInvoice);
            ViewData["IdLoHang"] = new SelectList(_context.LoHangs, "IdLoHang", "IdLoHang", chiTietHoaDonKhachHang.IdLoHang);
            return View(chiTietHoaDonKhachHang);
        }

        // GET: CTInvoiceManage/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            
            if (id == null)
            {
                return NotFound();
            }
            string[] a = id.Split("@");
            var chiTietHoaDonKhachHang = await _context.ChiTietHoaDonKhachHangs
                .Include(c => c.IdInvoiceNavigation)
                .Include(c => c.IdLoHangNavigation)
                .FirstOrDefaultAsync(m => m.IdInvoice == a[0] && m.IdLoHang == a[1]);
            if (chiTietHoaDonKhachHang == null)
            {
                return NotFound();
            }

            return View(chiTietHoaDonKhachHang);
        }

        // POST: CTInvoiceManage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            string[] a = id.Split("@");
            var chiTietHoaDonKhachHang = await _context.ChiTietHoaDonKhachHangs.FirstOrDefaultAsync(p=>p.IdInvoice == a[0] && p.IdLoHang == a[1]);
            _context.ChiTietHoaDonKhachHangs.Remove(chiTietHoaDonKhachHang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChiTietHoaDonKhachHangExists(string id)
        {
            string[] a = id.Split("@");
            return _context.ChiTietHoaDonKhachHangs.Any(e => e.IdInvoice == a[0]&&e.IdLoHang == a[1]);
        }
    }
}
