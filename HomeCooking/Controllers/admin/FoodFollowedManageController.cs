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
    public class FoodFollowedManageController : Controller
    {
        private readonly HomeCooking0Context _context;

        public FoodFollowedManageController(HomeCooking0Context context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            // bo dau cham thang de tra ve dang nhap
            if (String.IsNullOrEmpty(httpContextAccessor.HttpContext.Session.GetString("IdQuanLy")))
            {
                httpContextAccessor.HttpContext.Response.Redirect("../Admin/Login");
            }
        }
        

        // GET: FoodFollowedManage
        public async Task<IActionResult> Index()
        {
            var homeCooking0Context = _context.TheoDoiThucPhams.Include(t => t.IdFoodNavigation).Include(t => t.IdKhNavigation);
            return View(await homeCooking0Context.ToListAsync());
        }

        // GET: FoodFollowedManage/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theoDoiThucPham = await _context.TheoDoiThucPhams
                .Include(t => t.IdFoodNavigation)
                .Include(t => t.IdKhNavigation)
                .FirstOrDefaultAsync(m => m.IdTheoDoi == id);
            if (theoDoiThucPham == null)
            {
                return NotFound();
            }

            return View(theoDoiThucPham);
        }

        // GET: FoodFollowedManage/Create
        public IActionResult Create()
        {
            ViewData["IdFood"] = new SelectList(_context.ThucPhams, "IdFood", "NameFood");
            ViewData["IdKh"] = new SelectList(_context.KhachHangs, "IdKh", "Name");
            return View();
        }

        // POST: FoodFollowedManage/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdTheoDoi,IdKh,IdFood")] TheoDoiThucPham theoDoiThucPham)
        {
            if (ModelState.IsValid)
            {
                _context.Add(theoDoiThucPham);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdFood"] = new SelectList(_context.ThucPhams, "IdFood", "NameFood", theoDoiThucPham.IdFood);
            ViewData["IdKh"] = new SelectList(_context.KhachHangs, "IdKh", "Name", theoDoiThucPham.IdKh);
            return View(theoDoiThucPham);
        }

        // GET: FoodFollowedManage/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theoDoiThucPham = await _context.TheoDoiThucPhams.FindAsync(id);
            if (theoDoiThucPham == null)
            {
                return NotFound();
            }
            ViewData["IdFood"] = new SelectList(_context.ThucPhams, "IdFood", "NameFood", theoDoiThucPham.IdFood);
            ViewData["IdKh"] = new SelectList(_context.KhachHangs, "IdKh", "Name", theoDoiThucPham.IdKh);
            return View(theoDoiThucPham);
        }

        // POST: FoodFollowedManage/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdTheoDoi,IdKh,IdFood")] TheoDoiThucPham theoDoiThucPham)
        {
            if (id != theoDoiThucPham.IdTheoDoi)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(theoDoiThucPham);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TheoDoiThucPhamExists(theoDoiThucPham.IdTheoDoi))
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
            ViewData["IdFood"] = new SelectList(_context.ThucPhams, "IdFood", "NameFood", theoDoiThucPham.IdFood);
            ViewData["IdKh"] = new SelectList(_context.KhachHangs, "IdKh", "Name", theoDoiThucPham.IdKh);
            return View(theoDoiThucPham);
        }

        // GET: FoodFollowedManage/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var theoDoiThucPham = await _context.TheoDoiThucPhams
                .Include(t => t.IdFoodNavigation)
                .Include(t => t.IdKhNavigation)
                .FirstOrDefaultAsync(m => m.IdTheoDoi == id);
            if (theoDoiThucPham == null)
            {
                return NotFound();
            }

            return View(theoDoiThucPham);
        }

        // POST: FoodFollowedManage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var theoDoiThucPham = await _context.TheoDoiThucPhams.FindAsync(id);
            _context.TheoDoiThucPhams.Remove(theoDoiThucPham);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TheoDoiThucPhamExists(string id)
        {
            return _context.TheoDoiThucPhams.Any(e => e.IdTheoDoi == id);
        }
    }
}
