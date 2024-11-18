using AppData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhongController : ControllerBase
    {
        private readonly HotelDbContext _context;

        public PhongController(HotelDbContext context)
        {
            _context = context;
        }

        // GET: api/Phong
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Phong>>> GetPhongs()
        {
            var phongs = await _context.Phongs.Include(p => p.PhongChiTiets).ToListAsync();
            return Ok(phongs);
        }

        // GET: api/Phong/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Phong>> GetPhong(int id)
        {
            var phong = await _context.Phongs.Include(p => p.PhongChiTiets)
                                              .FirstOrDefaultAsync(p => p.MaPhong == id);

            if (phong == null)
            {
                return NotFound();
            }

            return Ok(phong);
        }

        // POST: api/Phong
        [HttpPost]
        public async Task<ActionResult<Phong>> PostPhong(Phong phong)
        {
            _context.Phongs.Add(phong);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPhong), new { id = phong.MaPhong }, phong);
        }

        // PUT: api/Phong/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPhong(int id, Phong phong)
        {
            if (id != phong.MaPhong)
            {
                return BadRequest();
            }

            _context.Entry(phong).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Phong/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePhong(int id)
        {
            var phong = await _context.Phongs.FindAsync(id);
            if (phong == null)
            {
                return NotFound();
            }

            _context.Phongs.Remove(phong);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
