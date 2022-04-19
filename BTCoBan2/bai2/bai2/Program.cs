using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap toa do diem A(x,y): ");
            double xA210 = Double.Parse(Console.ReadLine());
            double yA210 = Double.Parse(Console.ReadLine());
            Console.Write("Nhap toa do diem B(x,y): ");
            double xB210 = Double.Parse(Console.ReadLine());
            double yB210 = Double.Parse(Console.ReadLine());
            double distance210 = Math.Sqrt(Math.Pow(xB210 - xA210, 2) + Math.Pow(yB210 - yA210, 2));
            Console.WriteLine("Khoang cach la: " + distance210);
            Console.ReadKey();
        }
    }
}
