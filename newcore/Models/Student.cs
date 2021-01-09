using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace newcore.Models
{
    public class Student
    {
        public int StudId { get; set; }

        public string studentname { get; set; }

        public string studentage { get; set; }

       public Country country { get; set; }

        public List<Country> countries { get; set; }

    }
}
