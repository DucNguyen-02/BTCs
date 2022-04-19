using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai47
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap n: ");
            int n210 = Int32.Parse(Console.ReadLine());
            int s210 = 0;
            if(n210 % 2 == 0)
            {
                for(int i210 = 2; i210 <= n210; i210 += 2)
                {
                    s210 += i210;
                }
            } else
            {
                for (int i210 = 1; i210 <= n210; i210++)
                {
                    s210 += i210;
                }
            }
            Console.Write("Tong la: " + s210);
            Console.ReadKey();
        }
    }
}
