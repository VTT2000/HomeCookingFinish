using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HomeCooking.Models;

namespace HomeCooking.apiController
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoaDonKhachHangsController : ControllerBase
    {
        private readonly HomeCooking0Context _context;

        public HoaDonKhachHangsController(HomeCooking0Context context)
        {
            _context = context;
        }

        // GET: api/HoaDonKhachHangs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HoaDonKhachHang>>> GetHoaDonKhachHangs()
        {
            return await _context.HoaDonKhachHangs.ToListAsync();
        }

        // GET: api/HoaDonKhachHangs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HoaDonKhachHang>> GetHoaDonKhachHang(string id)
        {
            var hoaDonKhachHang = await _context.HoaDonKhachHangs.FindAsync(id);

            if (hoaDonKhachHang == null)
            {
                return NotFound();
            }

            return hoaDonKhachHang;
        }

        // PUT: api/HoaDonKhachHangs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHoaDonKhachHang(string id, HoaDonKhachHang hoaDonKhachHang)
        {
            if (id != hoaDonKhachHang.IdInvoice)
            {
                return BadRequest();
            }

            _context.Entry(hoaDonKhachHang).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HoaDonKhachHangExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/HoaDonKhachHangs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<HoaDonKhachHang>> PostHoaDonKhachHang(HoaDonKhachHang hoaDonKhachHang)
        {
            _context.HoaDonKhachHangs.Add(hoaDonKhachHang);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHoaDonKhachHang", new { id = hoaDonKhachHang.IdInvoice }, hoaDonKhachHang);
        }

        // DELETE: api/HoaDonKhachHangs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<HoaDonKhachHang>> DeleteHoaDonKhachHang(string id)
        {
            var hoaDonKhachHang = await _context.HoaDonKhachHangs.FindAsync(id);
            if (hoaDonKhachHang == null)
            {
                return NotFound();
            }

            _context.HoaDonKhachHangs.Remove(hoaDonKhachHang);
            await _context.SaveChangesAsync();

            return hoaDonKhachHang;
        }

        private bool HoaDonKhachHangExists(string id)
        {
            return _context.HoaDonKhachHangs.Any(e => e.IdInvoice == id);
        }
    }
}
