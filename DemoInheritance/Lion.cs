using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInheritance
{
    public class Lion : Animal, IPredator
    {
        public static int age;
        public Lion()
        {
            age = 10;
        }
        public override void Drink()
        {
            Console.WriteLine("Lion drinking");
            Console.WriteLine(age);
        }

        public override void Eat()
        {
            Console.WriteLine("Lion eating");
        }

        public void Hunt()
        {
            Console.WriteLine("Lion hunting");
        }

        public static void Catch()
        {
            Console.WriteLine("Lion catch");
            age -= 1;
        }
    }
}
