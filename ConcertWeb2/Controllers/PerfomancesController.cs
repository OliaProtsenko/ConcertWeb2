using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ConcertWeb2.Models;

namespace ConcertWeb2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfomancesController : ControllerBase
    {
        private readonly ConcertContext _context;

        public PerfomancesController(ConcertContext context)
        {
            _context = context;
        }

        // GET: api/Perfomances
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Perfomance>>> GetPerfomances()
        {
            return await _context.Perfomances.ToListAsync();
        }

        // GET: api/Perfomances/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Perfomance>> GetPerfomance(int id)
        {
            var perfomance = await _context.Perfomances.FindAsync(id);

            if (perfomance == null)
            {
                return NotFound();
            }

            return perfomance;
        }

        // PUT: api/Perfomances/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPerfomance(int id, Perfomance perfomance)
        {
            if (id != perfomance.Id)
            {
                return BadRequest();
            }

            _context.Entry(perfomance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PerfomanceExists(id))
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

        // POST: api/Perfomances
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Perfomance>> PostPerfomance(Perfomance perfomance)
        {
            _context.Perfomances.Add(perfomance);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPerfomance", new { id = perfomance.Id }, perfomance);
        }

        // DELETE: api/Perfomances/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePerfomance(int id)
        {
            var perfomance = await _context.Perfomances.FindAsync(id);
            if (perfomance == null)
            {
                return NotFound();
            }

            _context.Perfomances.Remove(perfomance);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PerfomanceExists(int id)
        {
            return _context.Perfomances.Any(e => e.Id == id);
        }
    }
}
