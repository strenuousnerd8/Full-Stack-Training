using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using User;

namespace User.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TUsersController : ControllerBase
    {
        private readonly UserDbContext _context;

        public TUsersController(UserDbContext context)
        {
            _context = context;
        }

        // GET: api/TUsers
        [HttpGet, AllowAnonymous]
        public async Task<ActionResult<IEnumerable<TUser>>> GetTUser()
        {
            return await _context.TUser.ToListAsync();
        }

        // GET: api/TUsers/5
        [HttpGet("{id}"), AllowAnonymous]
        public async Task<ActionResult<TUser>> GetTUser(string id)
        {
            var tUser = await _context.TUser.FindAsync(id);

            if (tUser == null)
            {
                return NotFound();
            }

            return tUser;
        }

        // PUT: api/TUsers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTUser(string id, TUser tUser)
        {
            if (id != tUser.username)
            {
                return BadRequest();
            }

            _context.Entry(tUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TUserExists(id))
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

        // POST: api/TUsers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TUser>> PostTUser(TUser tUser)
        {
            _context.TUser.Add(tUser);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TUserExists(tUser.username))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTUser", new { id = tUser.username }, tUser);
        }

        // DELETE: api/TUsers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTUser(string id)
        {
            var tUser = await _context.TUser.FindAsync(id);
            if (tUser == null)
            {
                return NotFound();
            }

            _context.TUser.Remove(tUser);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TUserExists(string id)
        {
            return _context.TUser.Any(e => e.username == id);
        }
    }
}
