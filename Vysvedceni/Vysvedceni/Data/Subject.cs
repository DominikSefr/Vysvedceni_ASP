using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vysvedceni.Data
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Shortcut { get; set; }
        public Subject(int id, string name, string shortcut)
        {
            id = Id;
            name = Name;
            shortcut = Shortcut;
        }
    }
}
