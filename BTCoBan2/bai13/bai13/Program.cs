using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai13
{
    class Program
    {
        static void Main(string[] args)
        {
            int day210, month210, year210, maxOfDay210, dayOfWeek210;
            Console.Write("Nhap ngay, thang, nam: ");
            day210 = Int32.Parse(Console.ReadLine());
            month210 = Int32.Parse(Console.ReadLine());
            year210 = Int32.Parse(Console.ReadLine());

            if (month210 < 1 || month210 > 12)
            {
                Console.WriteLine("Khong hop le");
                Console.ReadKey();
                return;
            }

            switch (month210)
            {
                case 4: case 6: case 9: case 11:
                    maxOfDay210 = 30;
                    break;
                case 2:
                    if ((year210 % 4 == 0 && year210 % 100 != 0) || year210 % 400 == 0)
                        maxOfDay210 = 29;
                    else
                        maxOfDay210 = 28;
                    break;
                default:
                    maxOfDay210 = 31;
                    break;
            }

            if (day210 < 1 || day210 > maxOfDay210)
            {
                Console.WriteLine("Khong hop le");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Hop le");
            int a = (14 - month210) / 12;
            int y = year210 - a;
            int m = month210 + 12 * a - 2;
            dayOfWeek210 = (day210 + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12) % 7;

            Console.WriteLine("Thu " + (dayOfWeek210 + 1));

            Console.ReadKey();
        }
    }
}
