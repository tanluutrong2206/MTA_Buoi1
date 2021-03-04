using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOverloading
{
    public class Person
    {
        public void Eat()
        {
            Console.WriteLine("Just eatting");
        }

        public void Eat(int speed)
        {
            Console.WriteLine("Eatting with speed " + speed);
        }

        public void Eat(string meal)
        {
            Console.WriteLine("Eatting with meal " + meal);
        }
    }
}
