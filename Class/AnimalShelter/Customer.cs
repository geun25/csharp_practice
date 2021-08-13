using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Customer
    {
        public string FirstName;
        public string LastName;
        private DateTime _Birthday;
        private bool _IsQualified;
        public string Address;
        public string Description;

        private List<Pet> _MyPets = new List<Pet>();
        public List<Pet> MyPets
        {
            get
            {
                return _MyPets;
            }
        }
        public bool Adopt(Pet pet)
        {
            if (_IsQualified)
            {
                _MyPets.Add(pet);
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
        private List<Cat> _MyCats = new List<Cat>();
        public List<Cat> MyCats
        {
            get
            {
                return _MyCats;
            }
        }

        public bool Adopt(Cat cat)
        {
            if (_IsQualified)
            {
                _MyCats.Add(cat);
                return true;
            }
            else
            {
                return false;
            }
        }

        private List<Dog> _MyDogs = new List<Dog>();
        public List<Dog> MyDogs
        {
            get
            {
                return _MyDogs;
            }
        }

        public bool Adopt(Dog dog)
        {
            if (_IsQualified)
            {
                _MyDogs.Add(dog);
                return true;
            }
            else
            {
                return false;
            }
        }
        */

        public Customer(string firstName, string lastName, DateTime birthday)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this._Birthday = birthday;

            this._IsQualified = Age >= 18;
        }

        public DateTime Birthday
        {
            get
            {
                return _Birthday;
            }

            set
            {
                _Birthday = value;
                _IsQualified = Age >= 18;
            }
        }

        public int Age
        {
            get 
            {
                return DateTime.Now.Year - _Birthday.Year; 
            }
        }

        public bool IsQualified
        {
            get
            {
                return _IsQualified;
            }
        }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
