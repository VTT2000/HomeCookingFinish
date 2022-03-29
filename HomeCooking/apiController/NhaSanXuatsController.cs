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
    public class NhaSanXuatsController : ControllerBase
    {
        private readonly HomeCooking0Context _context;

        public NhaSanXuatsController(HomeCooking0Context context)
        {
            _context = context;
        }

        // GET: api/NhaSanXuats
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NhaSanXuat>>> GetNhaSanXuats()
        {
            return await _context.NhaSanXuats.ToListAsync();
        }

        // GET: api/NhaSanXuats/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NhaSanXuat>> GetNhaSanXuat(string id)
        {
            var nhaSanXuat = await _context.NhaSanXuats.FindAsync(id);

            if (nhaSanXuat == null)
            {
                return NotFound();
            }

            return nhaSanXuat;
        }

        // PUT: api/NhaSanXuats/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNhaSanXuat(string id, NhaSanXuat nhaSanXuat)
        {
            if (id != nhaSanXuat.IdNsx)
            {
                return BadRequest();
            }

            _context.Entry(nhaSanXuat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NhaSanXuatExists(id))
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

        // POST: api/NhaSanXuats
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<NhaSanXuat>> PostNhaSanXuat(NhaSanXuat nhaSanXuat)
        {
            _context.NhaSanXuats.Add(nhaSanXuat);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNhaSanXuat", new { id = nhaSanXuat.IdNsx }, nhaSanXuat);
        }

        // DELETE: api/NhaSanXuats/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<NhaSanXuat>> DeleteNhaSanXuat(string id)
        {
            var nhaSanXuat = await _context.NhaSanXuats.FindAsync(id);
            if (nhaSanXuat == null)
            {
                return NotFound();
            }

            _context.NhaSanXuats.Remove(nhaSanXuat);
            await _context.SaveChangesAsync();

            return nhaSanXuat;
        }

        private bool NhaSanXuatExists(string id)
        {
            return _context.NhaSanXuats.Any(e => e.IdNsx == id);
        }
    }
}
