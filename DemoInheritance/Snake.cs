using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInheritance
{
    public class Snake : Animal, IPredator
    {
        public override void Drink()
        {
            Console.WriteLine("Snake drinking");
        }

        public override void Eat()
        {
            Console.WriteLine("Snake eating");
        }

        public void Hunt()
        {
            Console.WriteLine("Snake hunting");
        }
    }
}
