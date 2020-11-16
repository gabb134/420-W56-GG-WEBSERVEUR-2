using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Marrero_Projet2RazorApp.Models;

namespace Marrero_Projet2RazorApp.Pages.Couleurs
{
    public class EditModel : PageModel
    {
        private readonly Marrero_Projet2RazorApp.Models.AutoDbContext _context;

        public EditModel(Marrero_Projet2RazorApp.Models.AutoDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Couleur Couleur { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Couleur = await _context.Couleurs.FirstOrDefaultAsync(m => m.CouleurId == id);

            if (Couleur == null)
            {
                return NotFound();
            }
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

            _context.Attach(Couleur).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CouleurExists(Couleur.CouleurId))
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

        private bool CouleurExists(int id)
        {
            return _context.Couleurs.Any(e => e.CouleurId == id);
        }
    }
}
