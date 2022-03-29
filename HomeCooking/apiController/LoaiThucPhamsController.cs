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
    public class LoaiThucPhamsController : ControllerBase
    {
        private readonly HomeCooking0Context _context;

        public LoaiThucPhamsController(HomeCooking0Context context)
        {
            _context = context;
        }

        // GET: api/LoaiThucPhams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LoaiThucPham>>> GetLoaiThucPhams()
        {
            return await _context.LoaiThucPhams.ToListAsync();
        }

        // GET: api/LoaiThucPhams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LoaiThucPham>> GetLoaiThucPham(string id)
        {
            var loaiThucPham = await _context.LoaiThucPhams.FindAsync(id);

            if (loaiThucPham == null)
            {
                return NotFound();
            }

            return loaiThucPham;
        }

        // PUT: api/LoaiThucPhams/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLoaiThucPham(string id, LoaiThucPham loaiThucPham)
        {
            if (id != loaiThucPham.IdLoai)
            {
                return BadRequest();
            }

            _context.Entry(loaiThucPham).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LoaiThucPhamExists(id))
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

        // POST: api/LoaiThucPhams
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<LoaiThucPham>> PostLoaiThucPham(LoaiThucPham loaiThucPham)
        {
            _context.LoaiThucPhams.Add(loaiThucPham);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLoaiThucPham", new { id = loaiThucPham.IdLoai }, loaiThucPham);
        }

        // DELETE: api/LoaiThucPhams/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LoaiThucPham>> DeleteLoaiThucPham(string id)
        {
            var loaiThucPham = await _context.LoaiThucPhams.FindAsync(id);
            if (loaiThucPham == null)
            {
                return NotFound();
            }

            _context.LoaiThucPhams.Remove(loaiThucPham);
            await _context.SaveChangesAsync();

            return loaiThucPham;
        }

        private bool LoaiThucPhamExists(string id)
        {
            return _context.LoaiThucPhams.Any(e => e.IdLoai == id);
        }
    }
}
