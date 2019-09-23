using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vysvedceni.Data
{
    public class Grade
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public string Subject { get; set; }
        public int Weight { get; set; }
        public Grade(int id, int value, string subject, int weight)
        {
            id = Id;
            value = Value;
            subject = Subject;
            weight = Weight;
        }
    }
}
