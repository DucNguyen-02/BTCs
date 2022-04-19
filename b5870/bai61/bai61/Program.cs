using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai61
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so phan tu: ");
            int n210 = Int32.Parse(Console.ReadLine());
            int[] arr210 = new int[n210];
            Random r210 = new Random();
            for(int i210 = 0; i210 < arr210.Length; i210++)
            {
                arr210[i210] = r210.Next(-100, 100);
            }

            display(arr210, arr210.Length);
            Console.WriteLine("\nTong so nguyen duong la: " +sum(arr210));
            Console.WriteLine("Nhap chi so muon xoa: ");
            int index210 = Int32.Parse(Console.ReadLine());
            remove(arr210, index210);
            Console.WriteLine("Mang sau khi xoa la: ");
            display(arr210, arr210.Length-1);
            Console.ReadKey();
        }

        static void display(int [] arr210, int len210)
        {
            for(int i210 = 0; i210 < len210; i210++)
            {
                Console.Write(arr210[i210] + " ");
            }
        }

        static int sum(int[] arr210)
        {
            int count210 = 0;
            for(int i210 = 0; i210 < arr210.Length; i210++)
            {
                if(arr210[i210] > 0)
                {
                    count210 += arr210[i210];
                }
            }
            return count210;
        }

        static void remove( int[] arr210, int index210)
        {
            for(int i210 = index210; i210 < arr210.Length-1 ; i210++)
            {
                arr210[i210] = arr210[i210 + 1];
            }
        }
    }
}
