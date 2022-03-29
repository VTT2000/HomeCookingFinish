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
    public class KhuyenMaisController : ControllerBase
    {
        private readonly HomeCooking0Context _context;

        public KhuyenMaisController(HomeCooking0Context context)
        {
            _context = context;
        }

        // GET: api/KhuyenMais
        [HttpGet]
        public async Task<ActionResult<IEnumerable<KhuyenMai>>> GetKhuyenMais()
        {
            return await _context.KhuyenMais.ToListAsync();
        }

        // GET: api/KhuyenMais/5
        [HttpGet("{id}")]
        public async Task<ActionResult<KhuyenMai>> GetKhuyenMai(string id)
        {
            var khuyenMai = await _context.KhuyenMais.FindAsync(id);

            if (khuyenMai == null)
            {
                return NotFound();
            }

            return khuyenMai;
        }

        // PUT: api/KhuyenMais/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKhuyenMai(string id, KhuyenMai khuyenMai)
        {
            if (id != khuyenMai.IdKhuyenMai)
            {
                return BadRequest();
            }

            _context.Entry(khuyenMai).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KhuyenMaiExists(id))
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

        // POST: api/KhuyenMais
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<KhuyenMai>> PostKhuyenMai(KhuyenMai khuyenMai)
        {
            _context.KhuyenMais.Add(khuyenMai);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKhuyenMai", new { id = khuyenMai.IdKhuyenMai }, khuyenMai);
        }

        // DELETE: api/KhuyenMais/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<KhuyenMai>> DeleteKhuyenMai(string id)
        {
            var khuyenMai = await _context.KhuyenMais.FindAsync(id);
            if (khuyenMai == null)
            {
                return NotFound();
            }

            _context.KhuyenMais.Remove(khuyenMai);
            await _context.SaveChangesAsync();

            return khuyenMai;
        }

        private bool KhuyenMaiExists(string id)
        {
            return _context.KhuyenMais.Any(e => e.IdKhuyenMai == id);
        }
    }
}
