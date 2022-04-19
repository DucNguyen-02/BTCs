using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so gio: ");
            int hour210 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} tuan, {1} ngay, {2} gio ", hour210 / (24*7), hour210 % (24 * 7) /24 , hour210 % (24 * 7) % 24);
            Console.ReadKey();
        }
    }
}
