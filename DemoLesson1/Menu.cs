using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLesson1
{
    public sealed class Menu
    {
        public static void TinhDienTich()
        {
            var option = 0;
            do
            {
                DisplayMenu();
                option = int.Parse(Console.ReadLine());
                TinhDienTich(option);
                if (option != 5)
                {
                    Console.WriteLine("Press any key to back to menu.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            while (option != 5) ;
        }

        private static void DisplayMenu()
        {
            Console.WriteLine(@"
1. Tính diện tích hình vuông
2. Tính diện tích hình chữ nhật
3. Tính diện tích hình tam giác
4. Tính diện tích hình tròn
5. Thoát
");
        }

        private static void TinhDienTich(int option)
        {
            double s;
            switch (option)
            {
                case 1:
                    s = TinhDienTichHinhVuong();
                    Console.WriteLine($"Dien tich hinh vuong la: {s}");
                    break;
                case 2:
                    s = TinhDienTichHinhChuNhat();
                    Console.WriteLine($"Dien tich hinh chu nhat la: {s}");
                    break;
                case 3:
                    s = TinhDienTichHinhTamGiac();
                    Console.WriteLine($"Dien tich hinh tam giac la: {s}");
                    break;
                case 4:
                    s = TinhDienTichHinhTron();
                    Console.WriteLine($"Dien tich hinh tron la: {s}");
                    break;
                default:
                    break;
            }
        }

        private static double TinhDienTichHinhVuong()
        {
            Console.WriteLine("Nhap do dai canh cua hinh vuong: ");
            double width = double.Parse(Console.ReadLine());

            return width * width;
        }

        private static double TinhDienTichHinhTamGiac()
        {
            Console.WriteLine("Nhap do dai canh day cua tam giac: ");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap do dai chieu cao tuong ung voi canh day cua tam giac: ");
            double height = double.Parse(Console.ReadLine());
            return width * height / 2;
        }

        private static double TinhDienTichHinhChuNhat()
        {
            Console.WriteLine("Nhap do dai chieu cao cua hinh chu nhat: ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap do dai chieu rong cua hinh chu nhat: ");
            double width = double.Parse(Console.ReadLine());
            return width * height;
        }

        private static double TinhDienTichHinhTron()
        {
            Console.WriteLine("Nhap ban kinh cua hinh tron: ");
            double r = double.Parse(Console.ReadLine());

            return Math.PI * r * r;
        }
    }
}
