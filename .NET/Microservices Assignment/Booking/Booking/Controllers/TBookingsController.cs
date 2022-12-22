using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Booking;

namespace Booking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TBookingsController : ControllerBase
    {
        private readonly BookingDbContext _context;

        public TBookingsController(BookingDbContext context)
        {
            _context = context;
        }

        // GET: api/TBookings
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TBooking>>> GetTBooking()
        {
            return await _context.TBooking.ToListAsync();
        }

        // GET: api/TBookings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TBooking>> GetTBooking(string id)
        {
            var tBooking = await _context.TBooking.FindAsync(id);

            if (tBooking == null)
            {
                return NotFound();
            }

            return tBooking;
        }

        // PUT: api/TBookings/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTBooking(string id, TBooking tBooking)
        {
            if (id != tBooking.BookingId)
            {
                return BadRequest();
            }

            _context.Entry(tBooking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TBookingExists(id))
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

        // POST: api/TBookings
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TBooking>> PostTBooking(TBooking tBooking)
        {
            _context.TBooking.Add(tBooking);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TBookingExists(tBooking.BookingId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTBooking", new { id = tBooking.BookingId }, tBooking);
        }

        // DELETE: api/TBookings/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTBooking(string id)
        {
            var tBooking = await _context.TBooking.FindAsync(id);
            if (tBooking == null)
            {
                return NotFound();
            }

            _context.TBooking.Remove(tBooking);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TBookingExists(string id)
        {
            return _context.TBooking.Any(e => e.BookingId == id);
        }
    }
}
