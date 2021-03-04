using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOverloading
{
    public class Employee : Person
    {
        public Employee()
        {

        }

        public Employee(int speed)
        {

        }

        public void Display()
        {
            Console.WriteLine("Employee display information");
        }
    }
}
