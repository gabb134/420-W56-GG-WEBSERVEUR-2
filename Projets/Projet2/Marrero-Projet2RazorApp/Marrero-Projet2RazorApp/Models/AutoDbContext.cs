using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marrero_Projet2RazorApp.Models
{
    public class AutoDbContext: DbContext
    {
        public AutoDbContext(DbContextOptions<AutoDbContext> options) : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:424sql.cgodin.qc.ca,5433;Database=BDW56Projet2Gabriel;MultipleActiveResultSets=true;User ID=W56Gabriel; Password=Linuxmaster134;Integrated Security=false");
        }

        public DbSet<Marque> Marques { get; set; }
        public DbSet<Auto> Autos { get; set; }
        public DbSet<Couleur> Couleurs { get; set; }
    }
}
