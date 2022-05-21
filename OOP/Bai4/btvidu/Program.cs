using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btvidu
{
    class Program
    {
        static void Main(string[] args)
        {
            KhuPho khuPho = new KhuPho();
            khuPho.Input();

            khuPho.Display();

            Console.ReadKey();
        }
    }
}
