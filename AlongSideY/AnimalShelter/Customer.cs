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
            get { return DateTime.Now.Year - _Birthday.Year; }
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
                return FirstName + "" + LastName;
            }
        }
    }
}
