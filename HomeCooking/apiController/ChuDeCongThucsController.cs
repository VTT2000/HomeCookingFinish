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
    public class ChuDeCongThucsController : ControllerBase
    {
        private readonly HomeCooking0Context _context;

        public ChuDeCongThucsController(HomeCooking0Context context)
        {
            _context = context;
        }

        // GET: api/ChuDeCongThucs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChuDeCongThuc>>> GetChuDeCongThucs()
        {
            return await _context.ChuDeCongThucs.ToListAsync();
        }

        // GET: api/ChuDeCongThucs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChuDeCongThuc>> GetChuDeCongThuc(string id)
        {
            var chuDeCongThuc = await _context.ChuDeCongThucs.FindAsync(id);

            if (chuDeCongThuc == null)
            {
                return NotFound();
            }

            return chuDeCongThuc;
        }

        // PUT: api/ChuDeCongThucs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChuDeCongThuc(string id, ChuDeCongThuc chuDeCongThuc)
        {
            if (id != chuDeCongThuc.IdChuDe)
            {
                return BadRequest();
            }

            _context.Entry(chuDeCongThuc).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChuDeCongThucExists(id))
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

        // POST: api/ChuDeCongThucs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ChuDeCongThuc>> PostChuDeCongThuc(ChuDeCongThuc chuDeCongThuc)
        {
            _context.ChuDeCongThucs.Add(chuDeCongThuc);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChuDeCongThuc", new { id = chuDeCongThuc.IdChuDe }, chuDeCongThuc);
        }

        // DELETE: api/ChuDeCongThucs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ChuDeCongThuc>> DeleteChuDeCongThuc(string id)
        {
            var chuDeCongThuc = await _context.ChuDeCongThucs.FindAsync(id);
            if (chuDeCongThuc == null)
            {
                return NotFound();
            }

            _context.ChuDeCongThucs.Remove(chuDeCongThuc);
            await _context.SaveChangesAsync();

            return chuDeCongThuc;
        }

        private bool ChuDeCongThucExists(string id)
        {
            return _context.ChuDeCongThucs.Any(e => e.IdChuDe == id);
        }
    }
}
