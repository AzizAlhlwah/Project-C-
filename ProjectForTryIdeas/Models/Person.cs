using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForTryIdeas.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int age { get; set; }


        public List<Car> Cars{ get; set; }    

    }
}
