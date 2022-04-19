using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11
{
    class Program
    {
        static void Main(string[] args)
        {
            int computerScore210 = 0 , humanScore210 = 0;
            int choose210;
            do
            {
                Console.WriteLine("1. Keo");
                Console.WriteLine("2. Bua");
                Console.WriteLine("3. Bao");
                Console.WriteLine("4. Thoat");
                choose210 = Int32.Parse(Console.ReadLine());
                Random r210 = new Random();
                int bot210 = r210.Next(1, 4);
                switch(choose210)
                {
                    case 1:
                        if(bot210 == choose210)
                        {
                            Console.WriteLine("Computer: 1");
                        } else if(bot210 == 2)
                        {
                            Console.WriteLine("Computer: 2");
                            computerScore210++;
                        }
                        else 
                        {
                            Console.WriteLine("Computer: 3");
                            humanScore210++;
                        }
                        break;
                    case 2:
                        if (bot210 == choose210)
                        {
                            Console.WriteLine("Computer: 2");
                        }
                        else if (bot210 == 1)
                        {
                            Console.WriteLine("Computer: 1");
                            computerScore210++;
                        }
                        else
                        {
                            Console.WriteLine("Computer: 3");
                            humanScore210++;
                        }
                        break;
                    case 3:
                        if (bot210 == choose210)
                        {
                            Console.WriteLine("Computer: 3");
                        }
                        else if (bot210 == 2)
                        {
                            Console.WriteLine("Computer: 2");
                            humanScore210++;
                        }
                        else
                        {
                            Console.WriteLine("Computer: 3");
                            computerScore210++;
                        }
                        break;
                }
                Console.WriteLine("Computer: " + computerScore210 + "-" + "Human: " + humanScore210);
            } while (choose210 != 4);
        }
    }
}
