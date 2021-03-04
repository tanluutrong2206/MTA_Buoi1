using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInheritance
{
    public class Person : Animal, IPredator
    {
        public override void Drink()
        {
            Console.WriteLine("Human drinking");
        }

        public override void Eat()
        {
            Console.WriteLine("Human eating");
        }

        public void Hunt()
        {
            Console.WriteLine("Human hunting");
        }
    }
}
