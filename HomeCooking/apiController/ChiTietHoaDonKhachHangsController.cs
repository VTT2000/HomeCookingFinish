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
    public class ChiTietHoaDonKhachHangsController : ControllerBase
    {
        private readonly HomeCooking0Context _context;

        public ChiTietHoaDonKhachHangsController(HomeCooking0Context context)
        {
            _context = context;
        }

        // GET: api/ChiTietHoaDonKhachHangs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChiTietHoaDonKhachHang>>> GetChiTietHoaDonKhachHangs()
        {
            return await _context.ChiTietHoaDonKhachHangs.ToListAsync();
        }

        // GET: api/ChiTietHoaDonKhachHangs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChiTietHoaDonKhachHang>> GetChiTietHoaDonKhachHang(string id)
        {
            var chiTietHoaDonKhachHang = await _context.ChiTietHoaDonKhachHangs.FindAsync(id);

            if (chiTietHoaDonKhachHang == null)
            {
                return NotFound();
            }

            return chiTietHoaDonKhachHang;
        }

        // PUT: api/ChiTietHoaDonKhachHangs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChiTietHoaDonKhachHang(string id, ChiTietHoaDonKhachHang chiTietHoaDonKhachHang)
        {
            if (id != chiTietHoaDonKhachHang.IdInvoice)
            {
                return BadRequest();
            }

            _context.Entry(chiTietHoaDonKhachHang).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChiTietHoaDonKhachHangExists(id))
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

        // POST: api/ChiTietHoaDonKhachHangs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ChiTietHoaDonKhachHang>> PostChiTietHoaDonKhachHang(ChiTietHoaDonKhachHang chiTietHoaDonKhachHang)
        {
            _context.ChiTietHoaDonKhachHangs.Add(chiTietHoaDonKhachHang);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChiTietHoaDonKhachHangExists(chiTietHoaDonKhachHang.IdInvoice))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetChiTietHoaDonKhachHang", new { id = chiTietHoaDonKhachHang.IdInvoice }, chiTietHoaDonKhachHang);
        }

        // DELETE: api/ChiTietHoaDonKhachHangs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ChiTietHoaDonKhachHang>> DeleteChiTietHoaDonKhachHang(string id)
        {
            var chiTietHoaDonKhachHang = await _context.ChiTietHoaDonKhachHangs.FindAsync(id);
            if (chiTietHoaDonKhachHang == null)
            {
                return NotFound();
            }

            _context.ChiTietHoaDonKhachHangs.Remove(chiTietHoaDonKhachHang);
            await _context.SaveChangesAsync();

            return chiTietHoaDonKhachHang;
        }

        private bool ChiTietHoaDonKhachHangExists(string id)
        {
            return _context.ChiTietHoaDonKhachHangs.Any(e => e.IdInvoice == id);
        }
    }
}
