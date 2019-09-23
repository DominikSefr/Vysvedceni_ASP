using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vysvedceni.Data
{
    public class Grade
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name="Hodnota")]
        public int Value { get; set; }
        [Required]
        [Display(Name="Váha")]
        public int Weight { get; set; }
        [Required]
        [Display(Name="Předmět")]
        public Subject Subject { get; set; }
    }
}
