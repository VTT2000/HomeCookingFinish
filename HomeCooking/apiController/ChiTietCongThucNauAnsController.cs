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
    public class ChiTietCongThucNauAnsController : ControllerBase
    {
        private readonly HomeCooking0Context _context;

        public ChiTietCongThucNauAnsController(HomeCooking0Context context)
        {
            _context = context;
        }

        // GET: api/ChiTietCongThucNauAns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChiTietCongThucNauAn>>> GetChiTietCongThucNauAns()
        {
            return await _context.ChiTietCongThucNauAns.ToListAsync();
        }

        // GET: api/ChiTietCongThucNauAns/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChiTietCongThucNauAn>> GetChiTietCongThucNauAn(string id)
        {
            var chiTietCongThucNauAn = await _context.ChiTietCongThucNauAns.FindAsync(id);

            if (chiTietCongThucNauAn == null)
            {
                return NotFound();
            }

            return chiTietCongThucNauAn;
        }

        // PUT: api/ChiTietCongThucNauAns/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChiTietCongThucNauAn(string id, ChiTietCongThucNauAn chiTietCongThucNauAn)
        {
            if (id != chiTietCongThucNauAn.IdCongThuc)
            {
                return BadRequest();
            }

            _context.Entry(chiTietCongThucNauAn).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChiTietCongThucNauAnExists(id))
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

        // POST: api/ChiTietCongThucNauAns
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ChiTietCongThucNauAn>> PostChiTietCongThucNauAn(ChiTietCongThucNauAn chiTietCongThucNauAn)
        {
            _context.ChiTietCongThucNauAns.Add(chiTietCongThucNauAn);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChiTietCongThucNauAnExists(chiTietCongThucNauAn.IdCongThuc))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetChiTietCongThucNauAn", new { id = chiTietCongThucNauAn.IdCongThuc }, chiTietCongThucNauAn);
        }

        // DELETE: api/ChiTietCongThucNauAns/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ChiTietCongThucNauAn>> DeleteChiTietCongThucNauAn(string id)
        {
            var chiTietCongThucNauAn = await _context.ChiTietCongThucNauAns.FindAsync(id);
            if (chiTietCongThucNauAn == null)
            {
                return NotFound();
            }

            _context.ChiTietCongThucNauAns.Remove(chiTietCongThucNauAn);
            await _context.SaveChangesAsync();

            return chiTietCongThucNauAn;
        }

        private bool ChiTietCongThucNauAnExists(string id)
        {
            return _context.ChiTietCongThucNauAns.Any(e => e.IdCongThuc == id);
        }
    }
}
