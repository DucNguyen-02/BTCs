using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai63
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r210 = new Random();
            Console.WriteLine("Nhap so phan tu: ");
            int n210 = Int32.Parse(Console.ReadLine());
            int[] arr210 = new int[n210];
            for(int i210 = 0; i210 < arr210.Length; i210++)
            {
                arr210[i210] = r210.Next(-100, 100);
            }
            display(arr210);
            Console.WriteLine("\nCo {0} phan tu chia het cho 4, tan cung la 6", count(arr210));
            inc(ref arr210);
            display(arr210);
            Console.ReadKey();
        }   

        static void display(int[] arr210)
        {
            for (int i210 = 0; i210 < arr210.Length; i210++)
            {
                Console.Write(arr210[i210] + " ");
            }
        }

        static void inc(ref int[] arr210)
        {
            for (int i210 = 0; i210 < arr210.Length; i210++)
            {
                if(i210 % 2 != 0)
                {
                    arr210[i210] *= 2;
                }
            }
        }

        static int count(int[] arr210)
        {
            int c210 = 0;
            for(int i210 = 0; i210 < arr210.Length; i210++)
            {
                if(arr210[i210] % 10 == 6 && arr210[i210] % 4 ==0)
                {
                    c210++;
                }
            }
            return c210;
        }
    }
}
