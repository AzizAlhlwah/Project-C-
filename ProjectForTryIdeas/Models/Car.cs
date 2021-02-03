using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForTryIdeas.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brean { get; set; }
        public string Name { get; set; }
        public int Model { get; set; }

        public Person person { get; set; }
    }
}
