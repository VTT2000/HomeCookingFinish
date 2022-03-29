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
    public class TittleRecipesManageController : Controller
    {
        private readonly HomeCooking0Context _context;

        public TittleRecipesManageController(HomeCooking0Context context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            // bo dau cham thang de tra ve dang nhap
            if (String.IsNullOrEmpty(httpContextAccessor.HttpContext.Session.GetString("IdQuanLy")))
            {
                httpContextAccessor.HttpContext.Response.Redirect("../Admin/Login");
            }
        }
        

        // GET: TittleRecipesManage
        public async Task<IActionResult> Index()
        {
            return View(await _context.ChuDeCongThucs.ToListAsync());
        }

        // GET: TittleRecipesManage/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chuDeCongThuc = await _context.ChuDeCongThucs
                .FirstOrDefaultAsync(m => m.IdChuDe == id);
            if (chuDeCongThuc == null)
            {
                return NotFound();
            }

            return View(chuDeCongThuc);
        }

        // GET: TittleRecipesManage/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TittleRecipesManage/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdChuDe,TenChuDe,MoTaChuDe,LinkHinhAnh")] ChuDeCongThuc chuDeCongThuc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chuDeCongThuc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(chuDeCongThuc);
        }

        // GET: TittleRecipesManage/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chuDeCongThuc = await _context.ChuDeCongThucs.FindAsync(id);
            if (chuDeCongThuc == null)
            {
                return NotFound();
            }
            return View(chuDeCongThuc);
        }

        // POST: TittleRecipesManage/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdChuDe,TenChuDe,MoTaChuDe,LinkHinhAnh")] ChuDeCongThuc chuDeCongThuc)
        {
            if (id != chuDeCongThuc.IdChuDe)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(chuDeCongThuc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChuDeCongThucExists(chuDeCongThuc.IdChuDe))
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
            return View(chuDeCongThuc);
        }

        // GET: TittleRecipesManage/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var chuDeCongThuc = await _context.ChuDeCongThucs
                .FirstOrDefaultAsync(m => m.IdChuDe == id);
            if (chuDeCongThuc == null)
            {
                return NotFound();
            }

            return View(chuDeCongThuc);
        }

        // POST: TittleRecipesManage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {

            HomeCooking0Context context = new HomeCooking0Context();
            var listRemove = context.ChiTietChuDeCongThucs.Where(p=>p.IdChuDe == id);
            if(listRemove.Count() != 0)
            {
                context.ChiTietChuDeCongThucs.RemoveRange(listRemove);
                context.SaveChanges();
            }
            

            var chuDeCongThuc = await _context.ChuDeCongThucs.FindAsync(id);
            _context.ChuDeCongThucs.Remove(chuDeCongThuc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChuDeCongThucExists(string id)
        {
            return _context.ChuDeCongThucs.Any(e => e.IdChuDe == id);
        }
    }
}
