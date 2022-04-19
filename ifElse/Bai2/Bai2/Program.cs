using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n210;
            Console.WriteLine("Nhap vao mot so nguyen: ");
            n210 = int.Parse(Console.ReadLine());

            if(n210 == 0)
            {
                Console.WriteLine("Không");
            } else if(n210 == 1)
            {
                Console.WriteLine("Một");
            }
            else if (n210 == 2)
            {
                Console.WriteLine("Hai");
            }
            else if (n210 == 3)
            {
                Console.WriteLine("Ba");
            }
            else if (n210 == 4)
            {
                Console.WriteLine("Bốn");
            }
            else if (n210 == 5)
            {
                Console.WriteLine("Năm");
            }
            else if (n210 == 6)
            {
                Console.WriteLine("Sáu");
            }
            else if (n210 == 7)
            {
                Console.WriteLine("Bảy");
            }
            else if (n210 == 8)
            {
                Console.WriteLine("Tám");
            }
            else if (n210 == 9)
            {
                Console.WriteLine("Chín");
            }

            Console.ReadKey();
        }
    }
}
