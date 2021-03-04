using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLesson1
{
    public class DemoException
    {
        private DemoException() { }

        public static void ReadFile()
        {
            Console.WriteLine("Nhap duong dan file: ");
            var filePath = Console.ReadLine();

            StreamReader fileStream = null;
            try
            {
                fileStream = File.OpenText(filePath);
                Console.WriteLine("Noi dung file: ");
                Console.WriteLine(fileStream.ReadToEnd());
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine("Khong the tim thay file");
            } 
            catch (UnauthorizedAccessException uae)
            {
                Console.WriteLine("Khong co quyen truy cap file");
            } finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
        }

        public static void WriteFile()
        {
            Console.WriteLine("Nhap duong dan file: ");
            var filePath = Console.ReadLine();
            Console.WriteLine("Nhap noi dung muon ghi vao file");
            var content = Console.ReadLine();
            StreamWriter fileStream = null;
            try
            {
                fileStream = File.AppendText(filePath);
                fileStream.WriteLine(content);
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine("Khong the tim thay file");
            }
            catch (UnauthorizedAccessException uae)
            {
                Console.WriteLine("Khong co quyen truy cap file");
            } catch (Exception ioe)
            {
                Console.WriteLine("Co loi khi xu ly file");
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
        }
    }
}
