using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Marrero_Projet2AutosMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Marrero_Projet2AutosMVC.Models
{
    public class AutoDbContext: IdentityDbContext
    {
        public AutoDbContext(DbContextOptions<AutoDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=tcp:424sql.cgodin.qc.ca,5433;Database=BDW56Projet2Gabriel;MultipleActiveResultSets=true;User ID=W56Gabriel; Password=Linuxmaster134;Integrated Security=false");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Marque> Marques { get; set; }
        public DbSet<Auto> Autos { get; set; }
        public DbSet<Couleur> Couleurs { get; set; }

    }
}
