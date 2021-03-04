using System;

namespace DemoOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee p1 = new Employee();
            p1.Eat();
            p1.Eat(1);
            p1.Eat("milk");
            p1.Display();

            Console.WriteLine();

            Doctor doctor = new Doctor();
            doctor.Eat();
            doctor.Eat(2);
            doctor.Eat("water");
            doctor.Display();
        }
    }
}
