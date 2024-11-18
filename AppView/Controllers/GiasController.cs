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
    public class GiasController : Controller
    {
        private readonly HotelDbContext _context;

        public GiasController(HotelDbContext context)
        {
            _context = context;
        }

        // GET: Gias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Gias.ToListAsync());
        }

        // GET: Gias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gia = await _context.Gias
                .FirstOrDefaultAsync(m => m.MaGia == id);
            if (gia == null)
            {
                return NotFound();
            }

            return View(gia);
        }

        // GET: Gias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Gias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaGia,MaPhongChiTiet,GiaNgayThuong,GiaCuoiTuan,GiaBanDem,GiaNgayLe")] Gia gia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gia);
        }

        // GET: Gias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gia = await _context.Gias.FindAsync(id);
            if (gia == null)
            {
                return NotFound();
            }
            return View(gia);
        }

        // POST: Gias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaGia,MaPhongChiTiet,GiaNgayThuong,GiaCuoiTuan,GiaBanDem,GiaNgayLe")] Gia gia)
        {
            if (id != gia.MaGia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GiaExists(gia.MaGia))
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
            return View(gia);
        }

        // GET: Gias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gia = await _context.Gias
                .FirstOrDefaultAsync(m => m.MaGia == id);
            if (gia == null)
            {
                return NotFound();
            }

            return View(gia);
        }

        // POST: Gias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gia = await _context.Gias.FindAsync(id);
            if (gia != null)
            {
                _context.Gias.Remove(gia);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GiaExists(int id)
        {
            return _context.Gias.Any(e => e.MaGia == id);
        }
    }
}
