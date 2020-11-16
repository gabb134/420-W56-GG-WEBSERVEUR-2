using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Marrero_Projet2RazorApp.Models;

namespace Marrero_Projet2RazorApp.Pages.Couleurs
{
    public class CreateModel : PageModel
    {
        private readonly Marrero_Projet2RazorApp.Models.AutoDbContext _context;

        public CreateModel(Marrero_Projet2RazorApp.Models.AutoDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Couleur Couleur { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Couleurs.Add(Couleur);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
