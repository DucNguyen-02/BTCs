using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai62
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
                arr210[i210] = r210.Next(10, 20);
            }
            display(arr210);
            int tongle210 = tongLe(arr210);
            int tongchan210 = tongChan(arr210);
            Console.Write("\nTong chan o vi tri le {0}", tongchan210);
            Console.Write((tongle210 == tongchan210) ? " Bang " : " Khac ");
            Console.Write("Tong le o vi tri chan {0}", tongle210);

            Console.WriteLine("\nCac cap nguyen to cung nhau: ");
            for(int i210 = 0; i210 < arr210.Length; i210++)
            {
                for(int j210 = i210 + 1; j210 < n210; j210++)
                {
                    if(check(arr210[i210], arr210[j210]) == 1)
                    {
                        Console.WriteLine(" {0} {1}", arr210[i210], arr210[j210]);
                    }
                }
            }

            Console.ReadKey();
        }

        static int check(int a210, int b210)
        {
            while (a210 != b210)
            {
                if (a210 > b210)
                {
                    a210 -= b210;
                }
                else
                {
                    b210 -= a210;
                }
            }
            return a210;
        }

        static void display(int[] arr210)
        {
            for(int i210 = 0; i210 < arr210.Length; i210++)
            {
                Console.Write(arr210[i210] + " ");
            }
        }

        static int tongChan(int[] arr210)
        {
            int sum210 = 0;
            for(int i210 = 0; i210 < arr210.Length; i210++)
            {
                if(i210 % 2 != 0 && arr210[i210] % 2 ==0)
                {
                    sum210 += arr210[i210];
                }
            }
            return sum210;
        }
        static int tongLe(int[] arr210)
        {
            int sum210 = 0;
            for (int i210 = 0; i210 < arr210.Length; i210++)
            {
                if (i210 % 2 == 0 && arr210[i210] % 2 != 0)
                {
                    sum210 += arr210[i210];
                }
            }
            return sum210;
        }
    }
}
