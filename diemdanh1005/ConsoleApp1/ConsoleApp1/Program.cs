using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap gia tri nguyen: ");
            int[] n210 = new int[10];
            for(int i=0; i<10; i++)
            {
                n210[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("so lon nhat la: ", findMax(n210));
            Console.WriteLine("so nho nhat la: ", findMin(n210));

            Console.WriteLine("Sap xep tang dan: ");
            sortAsc(n210);

            Console.WriteLine("sap xep giam dan: ");
            sortDesc(n210);
        }

        static int findMax(int []a210)
        {
            int maxOfArr = 0;
            for(int i=0; i<a210.Length; i++)
            {
                if(maxOfArr < a210[i])
                {
                    maxOfArr = a210[i];
                }
            }
            return maxOfArr;
        }

        static int findMin(int[] a210)
        {
            int minOfArr = 0;
            for (int i = 0; i < a210.Length; i++)
            {
                if (minOfArr > a210[i])
                {
                    minOfArr = a210[i];
                }
            }
            return minOfArr;
        }

        static void sortAsc(int[] a210)
        {
            for (int i = 0; i < a210.Length; i++)
            {
                for (int j = i + 1; j < a210.Length; j++)
                {
                    if (a210[i] > a210[j])
                    {
                        int temp = a210[i];
                        a210[i] = a210[j];
                        a210[j] = temp;
                    }
                }
            }
        }

        static void sortDesc(int[] a210)
        {
            for (int i = 0; i < a210.Length; i++)
            {
                for (int j = i + 1; j < a210.Length; j++)
                {
                    if (a210[i] < a210[j])
                    {
                        int temp = a210[i];
                        a210[i] = a210[j];
                        a210[j] = temp;
                    }
                }
            }
        }
    }
}
