using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuteCat
{
    public class Cat
    {
        public string Name;
        public int Age;

        private int Happiness = 50;

        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void GetBored()
        {
            Happiness -= 10;
            if (Happiness < 0)
                Happiness = 0;
        }
        public void Play()
        {
            Happiness += 10;
            if (Happiness > 100)
                Happiness = 100;
        }

        public void Eat()
        {
            Happiness += 20;
            if (Happiness > 100)
                Happiness = 100;
        }

        public string Express()
        {
            string message = "";
            if (Happiness >= 80)
                message = "very happy";
            else if (Happiness >= 60)
                message = "happy";
            else if (Happiness >= 40)
                message = "so so";
            else if (Happiness >= 20)
                message = "gloomy";
            else
                message = "sad";

            return this.Name + ": " + message;
        }
    }
}
