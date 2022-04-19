using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap S: ");
            double s210 = Double.Parse(Console.ReadLine());
            double r210 = Math.Sqrt(s210 / (4 * Math.PI));
            double v210 = (4 * Math.PI * Math.Pow(r210, 3)) /3 ;
            Console.Write("The tich hinh cau la: " + v210);
            Console.ReadKey();
        }
    }
}
