using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppData;

namespace AppView.Controllers
{
    public class PhongsController : Controller
    {
        private readonly HotelDbContext _context;
        public PhongsController(HotelDbContext context)
        {
            _context = context;
        }

        // GET: Phong
        public async Task<IActionResult> Index()
        {
            var phongs = await _context.Phongs.Include(p => p.PhongChiTiets).ToListAsync();
            return View(phongs);
        }

        // GET: Phong/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var phong = await _context.Phongs
            .Include(p => p.PhongChiTiets)
            .FirstOrDefaultAsync(p => p.MaPhong == id);
            if (phong == null)
            {
                return NotFound();
            }
            return View(phong);
        }

        // GET: Phong/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Phong/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaPhong,TenPhong,MoTa,Hinh,TrangThai")] Phong phong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(phong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(phong);
        }

        // GET: Phong/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var phong = await _context.Phongs.FindAsync(id);
            if (phong == null)
            {
                return NotFound();
            }
            return View(phong);
        }

        // POST: Phong/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaPhong,TenPhong,MoTa,Hinh,TrangThai")] Phong phong)
        {
            if (id != phong.MaPhong)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(phong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PhongExists(phong.MaPhong))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(phong);
        }

        // GET: Phong/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var phong = await _context.Phongs
            .FirstOrDefaultAsync(p => p.MaPhong == id);
            if (phong == null)
            {
                return NotFound();
            }
            return View(phong);
        }

        // POST: Phong/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var phong = await _context.Phongs.FindAsync(id);
            _context.Phongs.Remove(phong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PhongExists(int id)
        {
            return _context.Phongs.Any(e => e.MaPhong == id);
        }
    }
}
