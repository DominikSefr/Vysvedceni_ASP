using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vysvedceni.Data;

namespace Vysvedceni.Services
{
    public class DataService
    {
        public List<Subject> Subjects { get; set; } = new List<Subject>
        {
            new Subject(0,"Programování", "PRG"),
            new Subject(1,"Webové aplikace", "WEB"),
            new Subject(2,"Český jazyk a literatura", "ČJL")
        };
        public List<Grade> Grades { get; set; } = new List<Grade>();
    }
}
