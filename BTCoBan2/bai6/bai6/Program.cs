using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap 3 so a,b,c: ");
            int a210 = Int32.Parse(Console.ReadLine());
            int b210 = Int32.Parse(Console.ReadLine());
            int c210 = Int32.Parse(Console.ReadLine());
            int d210;
            if(a210 > b210)
            {
                d210 = a210;
                a210 = b210;
                b210 = d210;
            }
            if (a210 > c210)
            {
                d210 = a210;
                a210 = c210;
                c210 = d210;
            }
            if (b210 > c210)
            {
                d210 = b210;
                b210 = c210;
                c210 = d210;
            }
            Console.WriteLine("Thu tu tang dan: " + a210 + b210 + c210);
            Console.ReadKey();
        }
    }
}
