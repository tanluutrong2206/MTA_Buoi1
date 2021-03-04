using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAbstract
{
    public class Snake : Animal
    {
        public override void Go()
        {
            Console.WriteLine("Snake go");
        }

        public override void Run()
        {
            Console.WriteLine("Snake run");
        }
    }
}
