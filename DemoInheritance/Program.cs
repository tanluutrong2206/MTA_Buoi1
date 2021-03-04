using System;

namespace DemoInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion l1 = new Lion();
            Lion l2 = new Lion();
            Lion l3 = new Lion();

            l1.Hunt();
            l2.Hunt();
            l3.Drink();
        }
    }
}
