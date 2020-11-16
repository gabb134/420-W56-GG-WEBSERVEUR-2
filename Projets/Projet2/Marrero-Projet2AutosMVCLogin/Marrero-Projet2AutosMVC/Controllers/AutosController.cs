using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Marrero_Projet2AutosMVC.Models;
using Microsoft.AspNetCore.Authorization;

namespace Marrero_Projet2AutosMVC.Controllers
{
    public class AutosController : Controller
    {
        private readonly AutoDbContext _context;

        public AutosController(AutoDbContext context)
        {
            _context = context;
        }

        // GET: Autos
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var autoDbContext = _context.Autos.Include(a => a.Couleur).Include(a => a.Marque);
            return View(await autoDbContext.ToListAsync());
        }

        // GET: Autos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auto = await _context.Autos
                .Include(a => a.Couleur)
                .Include(a => a.Marque)
                .FirstOrDefaultAsync(m => m.AutoId == id);
            if (auto == null)
            {
                return NotFound();
            }

            return View(auto);
        }

        // GET: Autos/Create
        public IActionResult Create()
        {
            ViewData["CouleurId"] = new SelectList(_context.Couleurs, "CouleurId", "Nom");
            ViewData["MarqueId"] = new SelectList(_context.Marques, "MarqueId", "Nom");
            return View();
        }

        // POST: Autos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AutoId,nom,MarqueId,Modele,CouleurId")] Auto auto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(auto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CouleurId"] = new SelectList(_context.Couleurs, "CouleurId", "Nom", auto.CouleurId);
            ViewData["MarqueId"] = new SelectList(_context.Marques, "MarqueId", "Nom", auto.MarqueId);
            return View(auto);
        }

        // GET: Autos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auto = await _context.Autos.FindAsync(id);
            if (auto == null)
            {
                return NotFound();
            }
            ViewData["CouleurId"] = new SelectList(_context.Couleurs, "CouleurId", "Nom", auto.CouleurId);
            ViewData["MarqueId"] = new SelectList(_context.Marques, "MarqueId", "Nom", auto.MarqueId);
            return View(auto);
        }

        // POST: Autos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AutoId,nom,MarqueId,Modele,CouleurId")] Auto auto)
        {
            if (id != auto.AutoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(auto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutoExists(auto.AutoId))
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
            ViewData["CouleurId"] = new SelectList(_context.Couleurs, "CouleurId", "Nom", auto.CouleurId);
            ViewData["MarqueId"] = new SelectList(_context.Marques, "MarqueId", "Nom", auto.MarqueId);
            return View(auto);
        }

        // GET: Autos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auto = await _context.Autos
                .Include(a => a.Couleur)
                .Include(a => a.Marque)
                .FirstOrDefaultAsync(m => m.AutoId == id);
            if (auto == null)
            {
                return NotFound();
            }

            return View(auto);
        }

        // POST: Autos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var auto = await _context.Autos.FindAsync(id);
            _context.Autos.Remove(auto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AutoExists(int id)
        {
            return _context.Autos.Any(e => e.AutoId == id);
        }
    }
}
