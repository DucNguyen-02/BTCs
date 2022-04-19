using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a210, b210, c210;
            Console.WriteLine("Nhap vao 3 canh: ");
            a210 = Double.Parse(Console.ReadLine());
            b210 = Double.Parse(Console.ReadLine());
            c210 = Double.Parse(Console.ReadLine());

            if (a210 * a210 + b210 * b210 == c210 * c210 || a210 * a210 + c210 * c210 == b210 * b210 || b210 * b210 + c210 * c210 == a210 * a210)
            {
                Console.WriteLine("La 3 canh cua tam giac vuong");
            } else
            {
                Console.WriteLine("Khong phai la 3 canh cua tam giac vuong");
            }

            Console.ReadKey();
        }
    }
}
