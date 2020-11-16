using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Marrero_Projet2AutosMVC.Models
{
    public class Auto
    {
        [Key]
        public int AutoId { get; set; }
        [Required]
        [Display(Name = "Nom")]
        public string nom { get; set; }
        [Required]
        [Display(Name = "Marque ")]
        public int MarqueId { get; set; }
        [Required]
        [Display(Name = "Modèle")]
        public string Modele { get; set; }
        [Required]
        [Display(Name = "Couleur")]
        public int CouleurId { get; set; }

        public virtual Marque Marque { get; set; }
        public virtual Couleur Couleur { get; set; }
    }
}
