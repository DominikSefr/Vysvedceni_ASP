using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vysvedceni.Data
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Název")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Zkratka")]
        public string Shortcut { get; set; }
        public Subject(int id, string name, string shortcut)
        {
            Id = id;
            Name = name;
            Shortcut = shortcut;
        }
    }
}
