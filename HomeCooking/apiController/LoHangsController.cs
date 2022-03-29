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
    public class LoHangsController : ControllerBase
    {
        private readonly HomeCooking0Context _context;

        public LoHangsController(HomeCooking0Context context)
        {
            _context = context;
        }

        // GET: api/LoHangs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LoHang>>> GetLoHangs()
        {
            return await _context.LoHangs.ToListAsync();
        }

        // GET: api/LoHangs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LoHang>> GetLoHang(string id)
        {
            var loHang = await _context.LoHangs.FindAsync(id);

            if (loHang == null)
            {
                return NotFound();
            }

            return loHang;
        }

        // PUT: api/LoHangs/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoHang(string id, LoHang loHang)
        {
            if (id != loHang.IdLoHang)
            {
                return BadRequest();
            }

            _context.Entry(loHang).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoHangExists(id))
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

        // POST: api/LoHangs
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<LoHang>> PostLoHang(LoHang loHang)
        {
            _context.LoHangs.Add(loHang);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLoHang", new { id = loHang.IdLoHang }, loHang);
        }

        // DELETE: api/LoHangs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LoHang>> DeleteLoHang(string id)
        {
            var loHang = await _context.LoHangs.FindAsync(id);
            if (loHang == null)
            {
                return NotFound();
            }

            _context.LoHangs.Remove(loHang);
            await _context.SaveChangesAsync();

            return loHang;
        }

        private bool LoHangExists(string id)
        {
            return _context.LoHangs.Any(e => e.IdLoHang == id);
        }
    }
}
