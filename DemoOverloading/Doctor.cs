using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOverloading
{
    public class Doctor : Person
    {
        public Doctor()
        {

        }

        public Doctor(int speed)
        {

        }

        public void Display()
        {
            Console.WriteLine("Doctor display information");
        }
    }
}
