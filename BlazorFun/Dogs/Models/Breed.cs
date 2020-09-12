using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dogs.Models
{
    public class Breed
    {
        public string Name { get; set; }
        public Breed[] SubBreeds { get; set; }
    }
}
