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
    public class KhoBepManageController : Controller
    {
        private readonly HomeCooking0Context _context;

        public KhoBepManageController(HomeCooking0Context context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            // bo dau cham thang de tra ve dang nhap
            if (String.IsNullOrEmpty(httpContextAccessor.HttpContext.Session.GetString("IdQuanLy")))
            {
                httpContextAccessor.HttpContext.Response.Redirect("../Admin/Login");
            }
        }
        

        // GET: KhoBepManage
        public async Task<IActionResult> Index()
        {
            var homeCooking0Context = _context.KhoBepOnlines.Include(k => k.IdKhNavigation);
            return View(await homeCooking0Context.ToListAsync());
        }

        // GET: KhoBepManage/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khoBepOnline = await _context.KhoBepOnlines
                .Include(k => k.IdKhNavigation)
                .FirstOrDefaultAsync(m => m.IdKhobep == id);
            if (khoBepOnline == null)
            {
                return NotFound();
            }

            return View(khoBepOnline);
        }

        // GET: KhoBepManage/Create
        public IActionResult Create()
        {
            ViewData["IdKh"] = new SelectList(_context.KhachHangs, "IdKh", "IdKh");
            return View();
        }

        // POST: KhoBepManage/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdKhobep,IdKh")] KhoBepOnline khoBepOnline)
        {
            if (ModelState.IsValid)
            {
                _context.Add(khoBepOnline);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdKh"] = new SelectList(_context.KhachHangs, "IdKh", "IdKh", khoBepOnline.IdKh);
            return View(khoBepOnline);
        }

        // GET: KhoBepManage/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khoBepOnline = await _context.KhoBepOnlines.FindAsync(id);
            if (khoBepOnline == null)
            {
                return NotFound();
            }
            ViewData["IdKh"] = new SelectList(_context.KhachHangs, "IdKh", "IdKh", khoBepOnline.IdKh);
            return View(khoBepOnline);
        }

        // POST: KhoBepManage/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdKhobep,IdKh")] KhoBepOnline khoBepOnline)
        {
            if (id != khoBepOnline.IdKhobep)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(khoBepOnline);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KhoBepOnlineExists(khoBepOnline.IdKhobep))
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
            ViewData["IdKh"] = new SelectList(_context.KhachHangs, "IdKh", "IdKh", khoBepOnline.IdKh);
            return View(khoBepOnline);
        }

        // GET: KhoBepManage/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khoBepOnline = await _context.KhoBepOnlines
                .Include(k => k.IdKhNavigation)
                .FirstOrDefaultAsync(m => m.IdKhobep == id);
            if (khoBepOnline == null)
            {
                return NotFound();
            }

            return View(khoBepOnline);
        }

        // POST: KhoBepManage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var khoBepOnline = await _context.KhoBepOnlines.FindAsync(id);
            _context.KhoBepOnlines.Remove(khoBepOnline);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KhoBepOnlineExists(string id)
        {
            return _context.KhoBepOnlines.Any(e => e.IdKhobep == id);
        }
    }
}
