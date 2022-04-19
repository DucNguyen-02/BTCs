using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a,b: ");
            int a210 = Int32.Parse(Console.ReadLine());
            int b210 = Int32.Parse(Console.ReadLine());
            if(a210 == 0)
            {
                Console.WriteLine(b210 == 0 ? "Vo so nghiem": "Vo nghiem" );
            } else
            {
                Console.WriteLine("Nghiem x = " + (-b210 * 1.0 / a210));
            }
            Console.ReadKey();
        }
    }
}
