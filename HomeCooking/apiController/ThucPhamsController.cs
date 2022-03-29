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
    public class ThucPhamsController : ControllerBase
    {        
        private readonly HomeCooking0Context _context;

        public ThucPhamsController(HomeCooking0Context context)
        {
            _context = context;
        }

        // GET: api/ThucPhams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ThucPham>>> GetThucPhams()
        {
            return await _context.ThucPhams.ToListAsync();
        }

        // GET: api/ThucPhams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ThucPham>> GetThucPham(string id)
        {
            var thucPham = await _context.ThucPhams.FindAsync(id);

            if (thucPham == null)
            {
                return NotFound();
            }

            return thucPham;
        }

        // PUT: api/ThucPhams/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutThucPham(string id, ThucPham thucPham)
        {
            if (id != thucPham.IdFood)
            {
                return BadRequest();
            }

            _context.Entry(thucPham).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ThucPhamExists(id))
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

        // POST: api/ThucPhams
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ThucPham>> PostThucPham(ThucPham thucPham)
        {
            _context.ThucPhams.Add(thucPham);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetThucPham", new { id = thucPham.IdFood }, thucPham);
        }

        // DELETE: api/ThucPhams/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ThucPham>> DeleteThucPham(string id)
        {
            var thucPham = await _context.ThucPhams.FindAsync(id);
            if (thucPham == null)
            {
                return NotFound();
            }

            _context.ThucPhams.Remove(thucPham);
            await _context.SaveChangesAsync();

            return thucPham;
        }

        private bool ThucPhamExists(string id)
        {
            return _context.ThucPhams.Any(e => e.IdFood == id);
        }
    }
}
