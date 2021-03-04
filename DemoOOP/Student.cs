using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP
{
    public class Student
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public ushort Age { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return $"Student {{Id: {Id}, Name: {Name}, Age: {Age}, Address: {Address}}}";
        }
    }
}
