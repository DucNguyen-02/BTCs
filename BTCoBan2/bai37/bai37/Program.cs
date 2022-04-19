using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap n: ");
            int n210 = Int32.Parse(Console.ReadLine());
            int i210 = 0;
            int sum210 = 0;
            while(sum210 < n210)
            {
                i210++;
                sum210 += i210;
            }
            Console.Write(i210 - 1);
            Console.ReadKey();
        }
    }
}
