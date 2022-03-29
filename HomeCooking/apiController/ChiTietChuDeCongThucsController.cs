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
    public class ChiTietChuDeCongThucsController : ControllerBase
    {
        private readonly HomeCooking0Context _context;

        public ChiTietChuDeCongThucsController(HomeCooking0Context context)
        {
            _context = context;
        }

        // GET: api/ChiTietChuDeCongThucs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChiTietChuDeCongThuc>>> GetChiTietChuDeCongThucs()
        {
            return await _context.ChiTietChuDeCongThucs.ToListAsync();
        }

        // GET: api/ChiTietChuDeCongThucs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChiTietChuDeCongThuc>> GetChiTietChuDeCongThuc(string id)
        {
            var chiTietChuDeCongThuc = await _context.ChiTietChuDeCongThucs.FindAsync(id);

            if (chiTietChuDeCongThuc == null)
            {
                return NotFound();
            }

            return chiTietChuDeCongThuc;
        }

        // PUT: api/ChiTietChuDeCongThucs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChiTietChuDeCongThuc(string id, ChiTietChuDeCongThuc chiTietChuDeCongThuc)
        {
            if (id != chiTietChuDeCongThuc.IdChuDe)
            {
                return BadRequest();
            }

            _context.Entry(chiTietChuDeCongThuc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChiTietChuDeCongThucExists(id))
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

        // POST: api/ChiTietChuDeCongThucs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ChiTietChuDeCongThuc>> PostChiTietChuDeCongThuc(ChiTietChuDeCongThuc chiTietChuDeCongThuc)
        {
            _context.ChiTietChuDeCongThucs.Add(chiTietChuDeCongThuc);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChiTietChuDeCongThucExists(chiTietChuDeCongThuc.IdChuDe))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetChiTietChuDeCongThuc", new { id = chiTietChuDeCongThuc.IdChuDe }, chiTietChuDeCongThuc);
        }

        // DELETE: api/ChiTietChuDeCongThucs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ChiTietChuDeCongThuc>> DeleteChiTietChuDeCongThuc(string id)
        {
            var chiTietChuDeCongThuc = await _context.ChiTietChuDeCongThucs.FindAsync(id);
            if (chiTietChuDeCongThuc == null)
            {
                return NotFound();
            }

            _context.ChiTietChuDeCongThucs.Remove(chiTietChuDeCongThuc);
            await _context.SaveChangesAsync();

            return chiTietChuDeCongThuc;
        }

        private bool ChiTietChuDeCongThucExists(string id)
        {
            return _context.ChiTietChuDeCongThucs.Any(e => e.IdChuDe == id);
        }
    }
}
