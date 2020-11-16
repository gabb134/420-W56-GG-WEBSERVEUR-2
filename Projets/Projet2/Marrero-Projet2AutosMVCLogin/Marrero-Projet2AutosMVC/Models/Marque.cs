using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Marrero_Projet2AutosMVC.Models
{
    public class Marque
    {

        [Key]
        public int MarqueId { get; set; }
        [Required]
        [Display(Name = "Marque")]
        public string Nom { get; set; }
        public virtual ICollection<Auto> Autos { get; set; }
    }
}
