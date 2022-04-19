using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap n: ");
            int n210 = Int32.Parse(Console.ReadLine());

            for(int i210 = 1; i210 < n210; i210++)
            {
                int sum210 = 0;
                for(int j210 = 1; j210 < i210; j210++)
                {
                    if(i210 % j210 == 0)
                    {
                        sum210 += j210;
                    }
                }
                if(sum210 == i210)
                {
                    Console.WriteLine(i210 + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
