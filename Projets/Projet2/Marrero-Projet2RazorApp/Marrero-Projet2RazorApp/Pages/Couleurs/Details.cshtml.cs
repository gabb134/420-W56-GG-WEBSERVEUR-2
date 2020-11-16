using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Marrero_Projet2RazorApp.Models;

namespace Marrero_Projet2RazorApp.Pages.Couleurs
{
    public class DetailsModel : PageModel
    {
        private readonly Marrero_Projet2RazorApp.Models.AutoDbContext _context;

        public DetailsModel(Marrero_Projet2RazorApp.Models.AutoDbContext context)
        {
            _context = context;
        }

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
    }
}
