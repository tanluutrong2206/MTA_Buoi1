using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP
{
    public class Employee : Person
    {
        public uint BasicSalary { get; set; }

        public double CalculateSalary() => BasicSalary;

        public double CalculateSalary(int bonus, int punishment) => BasicSalary + bonus - punishment;

        public double CalculateSalary(int bonus, int punishment, int extra) => BasicSalary + bonus - punishment - extra;
    }
}
