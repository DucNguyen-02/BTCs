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
            int choose10;
            while(true)
            {
                Console.WriteLine("1. Tinh tong hieu tich thuong");
                Console.WriteLine("2. Ve la co");
                Console.WriteLine("3. Chuyen doi so thap phan thanh nhi phan");
                Console.WriteLine("4. In ra thong tin cua ban than");
                Console.WriteLine("Nhap so khac de thoat");

                Console.Write("Chon bai: ");
                choose10 = Int32.Parse(Console.ReadLine());
                switch(choose10)
                {
                    case 1:
                        Console.WriteLine("Nhap 2 so a,b: ");
                        double x10 = Double.Parse(Console.ReadLine());
                        double y10 = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Tong 2 so la: " + tong(x10, y10));
                        Console.WriteLine("Hieu 2 so la: " + hieu(x10, y10));
                        Console.WriteLine("Tich 2 so la: " + tich(x10, y10));
                        Console.WriteLine("Thuong 2 so la: " + thuong(x10, y10));
                        break;
                    case 2:
                        theFlag();
                        break;
                    case 3:
                        Console.WriteLine("Nhap so can chuyen doi: ");
                        int change10 = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("So sau khi chuyen doi: " + chuyenDoi(change10));
                        break;
                    case 4:
                        showInfo();
                        break;
                    default:
                        return;
                }
            } 
            
            Console.ReadKey();
        }

        static double tong(double a10, double b10)
        {
            return a10 + b10;
        }

        static double hieu(double a10, double b10)
        {
            return a10 - b10;
        }

        static double tich(double a10, double b10)
        {
            return a10 * b10;
        }

        static double thuong(double a10, double b10)
        {
            return a10 / b10;
        }

        static string chuyenDoi(int a10)
        {
            string rs10 = "";
            while(a10 > 0)
            {
                rs10 = a10 % 2 + rs10;
                a10 = a10 / 2;
            }
            return rs10;
        }

        static void showInfo()
        {
            Console.WriteLine("Ho va ten: Nguyen Xuan Duc");
            Console.WriteLine("Lop: 19T2");
            Console.WriteLine("Ma SV: 1911505310210");
        }

        static void theFlag()
        {
            //Viết phương thức In ra lá cờ Việt Nam bằng các dấu = và *
            for (int i10 = 1; i10 <= 8; i10++)
            {
                for(int j10 = 1; j10 <= 10; j10++)
                {
                    
                    if (i10 == 1 || j10 == 1 || i10 == 8 || j10 == 10)
                    {
                        Console.Write(" = ");
                    } else
                    {
                        if (i10 / 2 == 4 && j10 / 2 == 5)
                        {
                            Console.Write(" * ");
                        } else
                        {
                            Console.Write("   ");

                        }
                    }

                }
                Console.Write("\n");
            }
        }
    }
}
