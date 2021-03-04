using System;

namespace DemoOOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Input();
            
            Person p2 = new Person();
            p2.Input();

            p1.Display();
            p2.Display();
        }
    }
}
