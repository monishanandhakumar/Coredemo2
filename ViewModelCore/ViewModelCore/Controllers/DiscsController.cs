using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using ViewModelCore.Models;

namespace ViewModelCore.Controllers
{
  // [RoutePrefix("Disc")]
 // [Route("Disc")]
    public class DiscsController : Controller
    {
        private readonly dbMoviesContext _context;

        public DiscsController(dbMoviesContext context)
        {
            _context = context;
        }

        // GET: Discs

      //  [Route("Discinfo")]
        public async Task<IActionResult> Index()
        {
            var dbMoviesContext = _context.Disc.Include(d => d.M);
            return View(await dbMoviesContext.ToListAsync());
        }

        // GET: Discs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var disc = await _context.Disc
                .Include(d => d.M)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (disc == null)
            {
                return NotFound();
            }

            return View(disc);
        }

        // GET: Discs/Create
        public IActionResult Create()
        {
            ViewData["Mid"] = new SelectList(_context.Movies, "Id", "Id");
            return View();
        }

        // POST: Discs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DiscName,Mid")] Disc disc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(disc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Mid"] = new SelectList(_context.Movies, "Id", "Id", disc.Mid);
            return View(disc);
        }

        // GET: Discs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var disc = await _context.Disc.FindAsync(id);
            if (disc == null)
            {
                return NotFound();
            }
            ViewData["Mid"] = new SelectList(_context.Movies, "Id", "Id", disc.Mid);
            return View(disc);
        }

        // POST: Discs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DiscName,Mid")] Disc disc)
        {
            if (id != disc.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(disc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DiscExists(disc.Id))
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
            ViewData["Mid"] = new SelectList(_context.Movies, "Id", "Id", disc.Mid);
            return View(disc);
        }

        // GET: Discs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var disc = await _context.Disc
                .Include(d => d.M)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (disc == null)
            {
                return NotFound();
            }

            return View(disc);
        }

        // POST: Discs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var disc = await _context.Disc.FindAsync(id);
            _context.Disc.Remove(disc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DiscExists(int id)
        {
            return _context.Disc.Any(e => e.Id == id);
        }
    }
}
