using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Marrero_Projet2RazorApp.Models
{
    public class Couleur
    {
        [Key]
        public int CouleurId { get; set; }
        [Required]
        [Display(Name = "Couleur")]
        public string Nom { get; set; }
        public virtual ICollection<Auto> Autos { get; set; }
    }
}
