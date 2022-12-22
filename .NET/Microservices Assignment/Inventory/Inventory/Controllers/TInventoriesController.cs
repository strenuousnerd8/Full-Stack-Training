using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Inventory;

namespace Inventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TInventoriesController : ControllerBase
    {
        private readonly InventoryDbContext _context;

        public TInventoriesController(InventoryDbContext context)
        {
            _context = context;
        }

        // GET: api/TInventories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TInventory>>> GetTInventory()
        {
            return await _context.TInventory.ToListAsync();
        }

        // GET: api/TInventories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TInventory>> GetTInventory(string id)
        {
            var tInventory = await _context.TInventory.FindAsync(id);

            if (tInventory == null)
            {
                return NotFound();
            }

            return tInventory;
        }

        // PUT: api/TInventories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTInventory(string id, TInventory tInventory)
        {
            if (id != tInventory.airline)
            {
                return BadRequest();
            }

            _context.Entry(tInventory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TInventoryExists(id))
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

        // POST: api/TInventories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TInventory>> PostTInventory(TInventory tInventory)
        {
            _context.TInventory.Add(tInventory);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TInventoryExists(tInventory.airline))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTInventory", new { id = tInventory.airline }, tInventory);
        }

        // DELETE: api/TInventories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTInventory(string id)
        {
            var tInventory = await _context.TInventory.FindAsync(id);
            if (tInventory == null)
            {
                return NotFound();
            }

            _context.TInventory.Remove(tInventory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TInventoryExists(string id)
        {
            return _context.TInventory.Any(e => e.airline == id);
        }
    }
}
