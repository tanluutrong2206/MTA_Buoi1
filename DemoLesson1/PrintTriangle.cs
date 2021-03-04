using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLesson1
{
    public sealed class PrintTriangle
    {
        public static void Print1()
        {
            for (int i = 5; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{i}   ");
                }
                Console.WriteLine();
            }
        }

        public static void Print2()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{i * j}   ");
                }
                Console.WriteLine();
            }
        }
    }
}
