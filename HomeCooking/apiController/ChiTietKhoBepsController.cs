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
    public class ChiTietKhoBepsController : ControllerBase
    {
        private readonly HomeCooking0Context _context;

        public ChiTietKhoBepsController(HomeCooking0Context context)
        {
            _context = context;
        }

        // GET: api/ChiTietKhoBeps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChiTietKhoBep>>> GetChiTietKhoBeps()
        {
            return await _context.ChiTietKhoBeps.ToListAsync();
        }

        // GET: api/ChiTietKhoBeps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChiTietKhoBep>> GetChiTietKhoBep(string id)
        {
            var chiTietKhoBep = await _context.ChiTietKhoBeps.FindAsync(id);

            if (chiTietKhoBep == null)
            {
                return NotFound();
            }

            return chiTietKhoBep;
        }

        // PUT: api/ChiTietKhoBeps/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChiTietKhoBep(string id, ChiTietKhoBep chiTietKhoBep)
        {
            if (id != chiTietKhoBep.IdKhoBep)
            {
                return BadRequest();
            }

            _context.Entry(chiTietKhoBep).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChiTietKhoBepExists(id))
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

        // POST: api/ChiTietKhoBeps
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<ChiTietKhoBep>> PostChiTietKhoBep(ChiTietKhoBep chiTietKhoBep)
        {
            _context.ChiTietKhoBeps.Add(chiTietKhoBep);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ChiTietKhoBepExists(chiTietKhoBep.IdKhoBep))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetChiTietKhoBep", new { id = chiTietKhoBep.IdKhoBep }, chiTietKhoBep);
        }

        // DELETE: api/ChiTietKhoBeps/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<ChiTietKhoBep>> DeleteChiTietKhoBep(string id)
        {
            var chiTietKhoBep = await _context.ChiTietKhoBeps.FindAsync(id);
            if (chiTietKhoBep == null)
            {
                return NotFound();
            }

            _context.ChiTietKhoBeps.Remove(chiTietKhoBep);
            await _context.SaveChangesAsync();

            return chiTietKhoBep;
        }

        private bool ChiTietKhoBepExists(string id)
        {
            return _context.ChiTietKhoBeps.Any(e => e.IdKhoBep == id);
        }
    }
}
