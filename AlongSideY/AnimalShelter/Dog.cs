using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public enum DogBreed { Mixed, Bulldog, Jindo, Yorkshire }

    public class Dog
    {
        public int PetId;
        public string Name;
        public string Color;
        public string Gender;
        public string Description;
        public DogBreed Breed;

        public Dog(int petId, string name, string color, string gender, DogBreed breed)
        {
            PetId = petId;
            Name = name;
            Color = color;
            Gender = gender;
            Breed = breed;
        }

        public string MakeSound()
        {
            return "멍멍";
        }

        public string Bite()
        {
            return "물어뜯기";
        }
    }
}
