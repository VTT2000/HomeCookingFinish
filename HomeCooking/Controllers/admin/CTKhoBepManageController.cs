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
    public class CTKhoBepManageController : Controller
    {
        private readonly HomeCooking0Context _context;

        public CTKhoBepManageController(HomeCooking0Context context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            // bo dau cham thang de tra ve dang nhap
            if (String.IsNullOrEmpty(httpContextAccessor.HttpContext.Session.GetString("IdQuanLy")))
            {
                httpContextAccessor.HttpContext.Response.Redirect("../Admin/Login");
            }
        }

        // GET: CTKhoBepManage
        public async Task<IActionResult> Index()
        {
            var homeCooking0Context = _context.ChiTietKhoBeps.Include(c => c.IdInvoiceNavigation).Include(c => c.IdKhoBepNavigation);
            return View(await homeCooking0Context.ToListAsync());
        }

        // GET: CTKhoBepManage/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            string[] a = id.Split("@");
            var chiTietKhoBep = await _context.ChiTietKhoBeps
                .Include(c => c.IdInvoiceNavigation)
                .Include(c => c.IdKhoBepNavigation)
                .FirstOrDefaultAsync(m => m.IdKhoBep == a[0] && m.IdInvoice == a[1] && m.IdLoHang == a[2]);
            if (chiTietKhoBep == null)
            {
                return NotFound();
            }

            return View(chiTietKhoBep);
        }

        // GET: CTKhoBepManage/Create
        public IActionResult Create()
        {
            ViewData["Invoice"] = _context.HoaDonKhachHangs.ToList();
            ViewData["CTInvoice"] = _context.ChiTietHoaDonKhachHangs.ToList();
            ViewData["KhoBep"] = _context.KhoBepOnlines.ToList();
            return View();
        }

        // POST: CTKhoBepManage/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdKhoBep,IdInvoice,IdLoHang,SoLuongTrongChiTietHoDonKhachHang,Status")] ChiTietKhoBep chiTietKhoBep)
        {
            if (chiTietKhoBep.IdInvoice == null|| chiTietKhoBep.IdInvoice.Length == 0 || chiTietKhoBep.IdLoHang == null || chiTietKhoBep.IdLoHang.Length == 0)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _context.Add(chiTietKhoBep);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdInvoice"] = new SelectList(_context.HoaDonKhachHangs, "IdInvoice", "IdInvoice", chiTietKhoBep.IdInvoice);
            ViewData["IdKhoBep"] = new SelectList(_context.KhoBepOnlines, "IdKhobep", "IdKhobep", chiTietKhoBep.IdKhoBep);
            return View(chiTietKhoBep);
        }

        // GET: CTKhoBepManage/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            string[] a = id.Split("@");
            var chiTietKhoBep = await _context.ChiTietKhoBeps.FirstOrDefaultAsync(p=>p.IdKhoBep == a[0] && p.IdInvoice == a[1] && p.IdLoHang == a[2]);
            if (chiTietKhoBep == null)
            {
                return NotFound();
            }
            ViewData["IdInvoice"] = new SelectList(_context.HoaDonKhachHangs, "IdInvoice", "IdInvoice", chiTietKhoBep.IdInvoice);
            ViewData["IdKhoBep"] = new SelectList(_context.KhoBepOnlines, "IdKhobep", "IdKhobep", chiTietKhoBep.IdKhoBep);
            return View(chiTietKhoBep);
        }

        // POST: CTKhoBepManage/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdKhoBep,IdInvoice,IdLoHang,SoLuongTrongChiTietHoDonKhachHang,Status")] ChiTietKhoBep chiTietKhoBep)
        {
            string[] a = id.Split("@");
            if (a[0] != chiTietKhoBep.IdKhoBep || a[1] != chiTietKhoBep.IdInvoice || a[2] != chiTietKhoBep.IdLoHang)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chiTietKhoBep);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChiTietKhoBepExists(chiTietKhoBep.IdKhoBep+"@"+chiTietKhoBep.IdInvoice+"@"+chiTietKhoBep.IdLoHang))
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
            ViewData["IdInvoice"] = new SelectList(_context.HoaDonKhachHangs, "IdInvoice", "IdInvoice", chiTietKhoBep.IdInvoice);
            ViewData["IdKhoBep"] = new SelectList(_context.KhoBepOnlines, "IdKhobep", "IdKhobep", chiTietKhoBep.IdKhoBep);
            return View(chiTietKhoBep);
        }

        // GET: CTKhoBepManage/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            string[] a = id.Split("@");
            var chiTietKhoBep = await _context.ChiTietKhoBeps
                .Include(c => c.IdInvoiceNavigation)
                .Include(c => c.IdKhoBepNavigation)
                .FirstOrDefaultAsync(m => m.IdKhoBep == a[0] && m.IdInvoice == a[1] && m.IdLoHang == a[2]);
            if (chiTietKhoBep == null)
            {
                return NotFound();
            }

            return View(chiTietKhoBep);
        }

        // POST: CTKhoBepManage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            string[] a = id.Split("@");
            var chiTietKhoBep = await _context.ChiTietKhoBeps.FirstOrDefaultAsync(p=>p.IdKhoBep == a[0] && p.IdInvoice == a[1] && p.IdLoHang == a[2]);
            
            _context.ChiTietKhoBeps.Remove(chiTietKhoBep);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChiTietKhoBepExists(string id)
        {
            string[] a = id.Split("@");
            return _context.ChiTietKhoBeps.Any(e => e.IdKhoBep == a[0] && e.IdInvoice == a[1] && e.IdLoHang == a[2]);
        }
    }
}
