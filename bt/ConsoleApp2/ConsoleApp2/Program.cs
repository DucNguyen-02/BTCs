using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //bai1();
            //bai2();
            bai3();
            Console.ReadKey();
        }

        static void bai1()
        {
            Console.WriteLine("Nhap n: ");
            int n = Int32.Parse(Console.ReadLine());
            int s = 0;
            for(int i=1; i<= n; i++)
            {
                s += i;
            }

            Console.WriteLine("Tong la: " + s);
        }

        static void bai2()
        {
            Console.WriteLine("Nhap so tien: ");
            double money = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so tien lai: (%)");
            double per = Double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nam: ");
            int year = Int32.Parse(Console.ReadLine());

            double total = money * Math.Pow(1 + per/100, year * 12);
            Console.WriteLine("Tong tien nhan duoc la: " + total);
        }

        static void bai3()
        {
            Console.WriteLine("Nhap n: ");
            int n = Int32.Parse(Console.ReadLine());
            int a = n, b = n;
            for(int i=1; i<=n; i++)
            {
                for(int j=1; j<=2*n-1;j++)
                {
                    if(j==a || j==b || i == n)
                    {
                        Console.Write("*");
                    } else
                    {
                        Console.Write(" ");
                    }
                    
                }
                a--;
                b++;
                Console.Write("\n");
            }
        }
    }
}
