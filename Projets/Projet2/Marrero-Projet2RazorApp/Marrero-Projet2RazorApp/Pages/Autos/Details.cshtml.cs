﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Marrero_Projet2RazorApp.Models;

namespace Marrero_Projet2RazorApp.Pages.Autos
{
    public class DetailsModel : PageModel
    {
        private readonly Marrero_Projet2RazorApp.Models.AutoDbContext _context;

        public DetailsModel(Marrero_Projet2RazorApp.Models.AutoDbContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
