using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai67
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r210 = new Random();
            Console.WriteLine("Nhap so phan tu cua mang: ");
            int n210 = Int32.Parse(Console.ReadLine());
            int[] arr210 = new int[n210];
            for(int i210 = 0; i210 < n210; i210++)
            {
                arr210[i210] = r210.Next(-100, 100);
            }
            display(arr210);

            Console.WriteLine("\nSau khi chuyen: ");
            for(int i210 = 0; i210 < arr210.Length - 1; i210++)
            {
                for(int j210 = i210 + 1; j210 < arr210.Length; j210++)
                {
                    if((arr210[i210] % 2 == 0 && arr210[j210] % 2 == 0 && arr210[j210] < arr210[i210]) || (arr210[i210] % 2 != 0 && arr210[j210] % 2 != 0 && arr210[i210] < arr210[j210]))
                    {
                        int temp210 = arr210[i210];
                        arr210[i210] = arr210[j210];
                        arr210[j210] = temp210;
                    }
                }
            }

            display(arr210);
            Console.ReadKey();
        }

        static void display(int[] arr210)
        {
            for(int i210 = 0; i210 < arr210.Length; i210++)
            {
                Console.Write(arr210[i210] + " ");
            }
        }
    }
}
