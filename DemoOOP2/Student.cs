using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP2
{
    public class Student : Person
    {
        public void Walk()
        {
            Console.WriteLine("Student walk");
        }

        public void Walk(int speed)
        {
            Console.WriteLine("Student walk with speed " + speed);
        }
    }
}
