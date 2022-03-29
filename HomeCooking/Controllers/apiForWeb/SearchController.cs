using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HomeCooking.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HomeCooking.Controllers.apiForWeb
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly HomeCooking0Context _context;

        public SearchController(HomeCooking0Context context)
        {
            _context = context;
        }

        // GET: api/ThucPhams
        [HttpGet("{id}/{input}")]
        public async Task<ActionResult<IEnumerable<ThucPham>>> GetThucPhams(string id, string input)
        {
            if(id == "all")
            {
                return await _context.ThucPhams.Where(p=>p.NameFood.Contains(input)).ToListAsync();
            }
            else
            {
                return await _context.ThucPhams.Where(p => p.IdLoai == id).Where(p => p.NameFood.Contains(input)).ToListAsync();
            }
            
        }



    }
}
