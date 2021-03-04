using System;

namespace DemoLesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //DemoException.WriteFile();
            //Menu.TinhDienTich();
            PrintTriangle.Print2();
        }

        #region If else

        static void IfElse1()
        {
            Console.WriteLine("Ban hay nhap tien luong: ");
            float salary = float.Parse(Console.ReadLine());
            if (salary >= 500)
            {
                var tax = salary * (float)0.1;
                Console.WriteLine($"Ban phai dong {tax} tien thue");
            }
            else
            {
                Console.WriteLine("Ban khong phai dong thue");
            }

        }
        static void IfElse2()
        {
            Console.WriteLine("Ban hay nhap diem: ");
            short score = short.Parse(Console.ReadLine());

            if (score > 100)
            {
                Console.WriteLine("Diem khong hop le");
            }
            else if (score >= 80)
            {
                Console.WriteLine("Hoc sinh gioi");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Hoc sinh kha");
            }
            else if (score >= 60)
            {
                Console.WriteLine("Hoc sinh TBK");
            }
            else if (score >= 50)
            {
                Console.WriteLine("Hoc sinh TB");
            }
            else
            {
                Console.WriteLine("Hoc sinh yeu");
            }
        }

        /// <summary>
        /// Tinh tien dien
        /// </summary>
        static void IfElse3()
        {
            Console.WriteLine("Ban hay nhap so dien da dung: ");
            uint numberElectric = uint.Parse(Console.ReadLine());

            ulong price = 0;
            if (numberElectric <= 100)
            {
                price = numberElectric * 450;
            }
            else if (numberElectric <= 200)
            {
                price = 100 * 450 + (numberElectric - 100) * 600;
            }
            else if (numberElectric <= 300)
            {
                price = 100 * 450 + 100 * 600 + (numberElectric - 100) * 750;
            }
            else if (numberElectric <= 500)
            {
                price = 100 * 450 + 100 * 600 + 100 * 750 + (numberElectric - 200) * 900;
            }
            else if (numberElectric <= 1000)
            {
                price = 100 * 450 + 100 * 600 + 100 * 750 + 200 * 900 + (numberElectric - 500) * 1000;
            }
            else
            {
                price = 100 * 450 + 100 * 600 + 100 * 750 + 200 * 900 + 500 * 1000 + (numberElectric - 1000) * 1200;
            }

            Console.WriteLine($"So tien dien ban phai tra la: {price}");
        }
        #endregion

        #region While
        static void While1()
        {
            int number = 1;
            int total = 0;

            while (number <= 100)
            {
                total += number;

                number += 1;
            }
        }

        static void While2()
        {
            int number = 20;
            Console.WriteLine("Nhung so chia het cho 3 la: ");
            while (number <= 50)
            {
                if (number % 3 == 0)
                {
                    Console.Write(number + ", ");
                }
            }
        }
        #endregion

        #region Do While
        static void DoWhile1()
        {
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Nhap so thu {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int max = numbers[0];

            int index = 0;
            do
            {
                max = numbers[0] > max ? numbers[0] : max;
            } while (index < 5);

            Console.WriteLine($"So lon nhat la: {max}");
        }

        static void DoWhile2()
        {
            int number = 10;
            Console.WriteLine("Nhung so chia het cho 7 la: ");
            do
            {
                if (number % 7 == 0)
                {
                    Console.Write(number + ", ");
                }
            }
            while (number <= 70);
        }
        #endregion

        #region Intermediate 
        /// <summary>
        /// Tinh cuoc dien thoai
        /// </summary>
        static void TinhCuocDienThoai()
        {
            Console.WriteLine("Nhap so phut dien thoai su dung: ");
            int minutes = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap loai khach hang: ");
            bool isStudent = ushort.Parse(Console.ReadLine()) == 0;

            if (isStudent)
            {
                // free first 50 minutes
                minutes -= 50;
            }

            long price = 27000;

            if (minutes > 400)
            {
                price += 200 * 120 + 200 * 80 + (minutes - 400) * 40;
            }
            else if (minutes > 200)
            {
                price += 200 * 120 + (minutes - 200) * 80;
            }
            else if (minutes > 0)
            {
                price += minutes * 120;
            }

            // tax
            price = (uint)(price * 1.1);
            Console.WriteLine($"Tong so tien phai tra la: {price}");
        }
        #endregion
    }
}
