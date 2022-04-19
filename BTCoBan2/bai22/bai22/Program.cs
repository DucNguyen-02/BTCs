using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai22
{
    class Program
    {
        static void Main(string[] args)
        {
            int count210 = 0, sum210 = 0;
            Console.WriteLine("Nhap n: ");
            int n210 = Int32.Parse(Console.ReadLine());

            for(int i210 = 1; i210 <= n210; i210++)
            {
                if (n210 % i210 == 0)
                {
                    Console.Write(i210 + " ");
                    count210++;
                    sum210 += i210;
                }
            }
            Console.Write("\nCo " + count210 + " uoc so, tong la: "+ sum210);
            Console.ReadKey();
        }
    }
}
