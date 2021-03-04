using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAbstract
{
    public class Bird : Animal
    {
        public override void Go()
        {
            Console.WriteLine("Bird go");
        }

        public override void Run()
        {
            Console.WriteLine("Bird run");
        }
    }
}
