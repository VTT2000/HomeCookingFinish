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
    public class KhoBepOnlinesController : ControllerBase
    {
        private readonly HomeCooking0Context _context;

        public KhoBepOnlinesController(HomeCooking0Context context)
        {
            _context = context;
        }

        // GET: api/KhoBepOnlines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<KhoBepOnline>>> GetKhoBepOnlines()
        {
            return await _context.KhoBepOnlines.ToListAsync();
        }

        // GET: api/KhoBepOnlines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<KhoBepOnline>> GetKhoBepOnline(string id)
        {
            var khoBepOnline = await _context.KhoBepOnlines.FindAsync(id);

            if (khoBepOnline == null)
            {
                return NotFound();
            }

            return khoBepOnline;
        }

        // PUT: api/KhoBepOnlines/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKhoBepOnline(string id, KhoBepOnline khoBepOnline)
        {
            if (id != khoBepOnline.IdKhobep)
            {
                return BadRequest();
            }

            _context.Entry(khoBepOnline).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KhoBepOnlineExists(id))
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

        // POST: api/KhoBepOnlines
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<KhoBepOnline>> PostKhoBepOnline(KhoBepOnline khoBepOnline)
        {
            _context.KhoBepOnlines.Add(khoBepOnline);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKhoBepOnline", new { id = khoBepOnline.IdKhobep }, khoBepOnline);
        }

        // DELETE: api/KhoBepOnlines/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<KhoBepOnline>> DeleteKhoBepOnline(string id)
        {
            var khoBepOnline = await _context.KhoBepOnlines.FindAsync(id);
            if (khoBepOnline == null)
            {
                return NotFound();
            }

            _context.KhoBepOnlines.Remove(khoBepOnline);
            await _context.SaveChangesAsync();

            return khoBepOnline;
        }

        private bool KhoBepOnlineExists(string id)
        {
            return _context.KhoBepOnlines.Any(e => e.IdKhobep == id);
        }
    }
}
