using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP2
{
    public class Person
    {
        public int Age { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }

        public void Input()
        {
            Console.WriteLine("--------- Nhap thong tin ---------");
            Console.WriteLine("Nhap ten: ");
            this.Name = Console.ReadLine();

            Console.WriteLine("Nhap dia chi: ");
            this.Address = Console.ReadLine();

            Console.WriteLine("Nhap tuoi: ");
            this.Age = int.Parse(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine($"Thong tin: {{Name: {Name}, Age: {Age}, Address: {Address}}}");
        }
    }
}
