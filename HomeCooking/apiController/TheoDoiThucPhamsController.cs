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
    public class TheoDoiThucPhamsController : ControllerBase
    {
        private readonly HomeCooking0Context _context;

        public TheoDoiThucPhamsController(HomeCooking0Context context)
        {
            _context = context;
        }

        // GET: api/TheoDoiThucPhams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TheoDoiThucPham>>> GetTheoDoiThucPhams()
        {
            return await _context.TheoDoiThucPhams.ToListAsync();
        }

        // GET: api/TheoDoiThucPhams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TheoDoiThucPham>> GetTheoDoiThucPham(string id)
        {
            var theoDoiThucPham = await _context.TheoDoiThucPhams.FindAsync(id);

            if (theoDoiThucPham == null)
            {
                return NotFound();
            }

            return theoDoiThucPham;
        }

        // PUT: api/TheoDoiThucPhams/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTheoDoiThucPham(string id, TheoDoiThucPham theoDoiThucPham)
        {
            if (id != theoDoiThucPham.IdTheoDoi)
            {
                return BadRequest();
            }

            _context.Entry(theoDoiThucPham).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TheoDoiThucPhamExists(id))
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

        // POST: api/TheoDoiThucPhams
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TheoDoiThucPham>> PostTheoDoiThucPham(TheoDoiThucPham theoDoiThucPham)
        {
            _context.TheoDoiThucPhams.Add(theoDoiThucPham);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTheoDoiThucPham", new { id = theoDoiThucPham.IdTheoDoi }, theoDoiThucPham);
        }

        // DELETE: api/TheoDoiThucPhams/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TheoDoiThucPham>> DeleteTheoDoiThucPham(string id)
        {
            var theoDoiThucPham = await _context.TheoDoiThucPhams.FindAsync(id);
            if (theoDoiThucPham == null)
            {
                return NotFound();
            }

            _context.TheoDoiThucPhams.Remove(theoDoiThucPham);
            await _context.SaveChangesAsync();

            return theoDoiThucPham;
        }

        private bool TheoDoiThucPhamExists(string id)
        {
            return _context.TheoDoiThucPhams.Any(e => e.IdTheoDoi == id);
        }
    }
}
