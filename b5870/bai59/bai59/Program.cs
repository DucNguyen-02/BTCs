using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai59
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap nam: ");
            int n210 = Int32.Parse(Console.ReadLine());

            string[] can210 = new string[] { "Canh", "Tan","Nham", "Quy", "Giap","At", "Binh", "Dinh", "Mau", "Ky" };
            string[] chi210 = new string[] {"Than", "Dau", "Tuat", "Hoi", "Ti", "Suu", "Dan", "Meo", "Thin", "Ty", "Ngo", "Mui"};

            Console.WriteLine("{0} - {1} {2}", n210, can210[n210 % 10], chi210[n210 % 12]);
            Console.WriteLine("{0} - {1} {2}", n210 + 60, can210[n210 % 10], chi210[n210 % 12]);

            Console.ReadKey();
        }
    }
}
