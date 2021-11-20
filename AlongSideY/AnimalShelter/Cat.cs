using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Cat : Pet
    {
        public Cat(int petId, string name, string color, string gender) 
            : base(petId, name, color, gender)
        {          
        }

        public override string MakeSound()
        {
            return "야옹";
        }

        public string Scratch()
        {
            return "할퀴기";
        }
    }
}
