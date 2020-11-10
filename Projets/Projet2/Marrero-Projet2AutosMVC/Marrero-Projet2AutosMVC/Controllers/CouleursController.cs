using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Marrero_Projet2AutosMVC.Models;

namespace Marrero_Projet2AutosMVC.Controllers
{
    public class CouleursController : Controller
    {
        private readonly AutoDbContext _context;

        public CouleursController(AutoDbContext context)
        {
            _context = context;
        }

        // GET: Couleurs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Couleurs.ToListAsync());
        }

        // GET: Couleurs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var couleur = await _context.Couleurs
                .FirstOrDefaultAsync(m => m.CouleurId == id);
            if (couleur == null)
            {
                return NotFound();
            }

            return View(couleur);
        }

        // GET: Couleurs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Couleurs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CouleurId,Nom")] Couleur couleur)
        {
            if (ModelState.IsValid)
            {
                _context.Add(couleur);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(couleur);
        }

        // GET: Couleurs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var couleur = await _context.Couleurs.FindAsync(id);
            if (couleur == null)
            {
                return NotFound();
            }
            return View(couleur);
        }

        // POST: Couleurs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CouleurId,Nom")] Couleur couleur)
        {
            if (id != couleur.CouleurId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(couleur);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CouleurExists(couleur.CouleurId))
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
            return View(couleur);
        }

        // GET: Couleurs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var couleur = await _context.Couleurs
                .FirstOrDefaultAsync(m => m.CouleurId == id);
            if (couleur == null)
            {
                return NotFound();
            }

            return View(couleur);
        }

        // POST: Couleurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var couleur = await _context.Couleurs.FindAsync(id);

            foreach(Auto auto in _context.Autos)
            {
                if(auto.CouleurId == id)
                    return View("~/Views/Shared/Error.cshtml");
            }

            _context.Couleurs.Remove(couleur);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CouleurExists(int id)
        {
            return _context.Couleurs.Any(e => e.CouleurId == id);
        }
    }
}
