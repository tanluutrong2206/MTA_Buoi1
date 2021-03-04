using System;
using System.Linq;

namespace DemoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //CountVowel();
            Employee employee1 = new Employee
            {
                Age = 24,
                Name = "Luu Trong Tan",
                BasicSalary = 100000
            };
            Employee employee2 = new Employee
            {
                Age = 20,
                Name = "Vu Dieu Phuong Linh",
                BasicSalary = 1150
            };

            Console.WriteLine(employee1.CalculateSalary());
            Console.WriteLine(employee1.CalculateSalary(3000, 0));
            Console.WriteLine(employee1.CalculateSalary(3000, 0, 50));
        }

        private static void ThongTinSinhVien()
        {
            Console.WriteLine("Nhap so luong sinh vien: ");
            int n = ushort.Parse(Console.ReadLine());

            var students = new Student[n];
            for (int i = 0; i < n; i++)
            {
                students[i] = InputStudent(index: i + 1);
            }

            Console.WriteLine("Thong tin cua cac sinh vien da nhap la: ");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            // in thong tin sinh vien co tuoi lon nhat
            Console.WriteLine("Thong tin sinh vien co tuoi lon nhat la:");
            Console.WriteLine(students.First(x => x.Age == students.Max(x => x.Age)));

            // tong so sinh vien co id la so chan
            Console.WriteLine($"Tong so sinh vien co id la so chan la: " +
                $"{students.Count(x => x.Id % 2 == 0)}");

            // tuoi trung binh cong cua cac sinh vien
            Console.WriteLine("Do tuoi trung binh cua cac sinh vien la: " +
                students.Sum(x => x.Age) / (double)n);

            // nhung sinh vien co dia chi bat dau bang chu N
            Console.WriteLine("Nhung sinh vien co dia chi bat dau bang chu N la:");
            foreach (var student in students.Where(x => x.Address.StartsWith("N")))
            {
                Console.WriteLine(student);
            }
        }

        private static Student InputStudent(int index)
        {
            Console.WriteLine($"Nhap id cua sinh vien thu {index}: ");
            uint id = uint.Parse(Console.ReadLine());

            Console.WriteLine($"Nhap ten cua sinh vien thu {index}: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Nhap tuoi cua sinh vien thu {index}: ");
            ushort age = ushort.Parse(Console.ReadLine());

            Console.WriteLine($"Nhap dia chi cua sinh vien thu {index}: ");
            string address = Console.ReadLine();

            return new Student
            {
                Address = address,
                Age = age,
                Id = id,
                Name = name
            };
        }

        private static void CountVowel()
        {
            Console.WriteLine("Nhap vao 1 chuoi: ");
            var content = Console.ReadLine();

            char[] vowels = { 'u', 'e', 'o', 'a', 'i' };

            foreach (var vowel in vowels)
            {
                Console.WriteLine($"Tong so lan xuat hien chu cai {vowel} la: {CountCharacter(vowel, content)}");
            }
        }

        private static int CountCharacter(char c, string s)
        {
            return s.ToCharArray().Count(x => x == c);
        }
    }
}
