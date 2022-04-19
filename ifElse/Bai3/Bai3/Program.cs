using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a210, b210, c210;
            Console.WriteLine("Nhap ba canh: ");
            a210 = Double.Parse(Console.ReadLine());
            b210 = Double.Parse(Console.ReadLine());
            c210 = Double.Parse(Console.ReadLine());

            if(a210 + b210 > c210 && b210 + c210 > a210 && a210 + c210 > b210)
            {
                Console.WriteLine("La ba canh cua tam giac");
            } else
            {
                Console.WriteLine("Khong phai ba canh cua tam giac");
            }

            Console.ReadKey();
        }
    }
}
