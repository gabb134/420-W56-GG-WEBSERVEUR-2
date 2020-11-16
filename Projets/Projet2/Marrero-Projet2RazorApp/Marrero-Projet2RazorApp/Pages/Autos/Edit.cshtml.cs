using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Marrero_Projet2RazorApp.Models;

namespace Marrero_Projet2RazorApp.Pages.Autos
{
    public class EditModel : PageModel
    {
        private readonly Marrero_Projet2RazorApp.Models.AutoDbContext _context;

        public EditModel(Marrero_Projet2RazorApp.Models.AutoDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Auto Auto { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Auto = await _context.Autos
                .Include(a => a.Couleur)
                .Include(a => a.Marque).FirstOrDefaultAsync(m => m.AutoId == id);

            if (Auto == null)
            {
                return NotFound();
            }
           ViewData["CouleurId"] = new SelectList(_context.Couleurs, "CouleurId", "Nom");
           ViewData["MarqueId"] = new SelectList(_context.Marques, "MarqueId", "Nom");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Auto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutoExists(Auto.AutoId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AutoExists(int id)
        {
            return _context.Autos.Any(e => e.AutoId == id);
        }
    }
}
