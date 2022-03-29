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
    public class CongThucNauAnsController : ControllerBase
    {
        private readonly HomeCooking0Context _context;

        public CongThucNauAnsController(HomeCooking0Context context)
        {
            _context = context;
        }

        // GET: api/CongThucNauAns
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CongThucNauAn>>> GetCongThucNauAns()
        {
            return await _context.CongThucNauAns.ToListAsync();
        }

        // GET: api/CongThucNauAns/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CongThucNauAn>> GetCongThucNauAn(string id)
        {
            var congThucNauAn = await _context.CongThucNauAns.FindAsync(id);

            if (congThucNauAn == null)
            {
                return NotFound();
            }

            return congThucNauAn;
        }

        // PUT: api/CongThucNauAns/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCongThucNauAn(string id, CongThucNauAn congThucNauAn)
        {
            if (id != congThucNauAn.IdCongThuc)
            {
                return BadRequest();
            }

            _context.Entry(congThucNauAn).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CongThucNauAnExists(id))
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

        // POST: api/CongThucNauAns
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CongThucNauAn>> PostCongThucNauAn(CongThucNauAn congThucNauAn)
        {
            _context.CongThucNauAns.Add(congThucNauAn);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCongThucNauAn", new { id = congThucNauAn.IdCongThuc }, congThucNauAn);
        }

        // DELETE: api/CongThucNauAns/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CongThucNauAn>> DeleteCongThucNauAn(string id)
        {
            var congThucNauAn = await _context.CongThucNauAns.FindAsync(id);
            if (congThucNauAn == null)
            {
                return NotFound();
            }

            _context.CongThucNauAns.Remove(congThucNauAn);
            await _context.SaveChangesAsync();

            return congThucNauAn;
        }

        private bool CongThucNauAnExists(string id)
        {
            return _context.CongThucNauAns.Any(e => e.IdCongThuc == id);
        }
    }
}
