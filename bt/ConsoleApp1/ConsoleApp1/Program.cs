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
            nhap();
            Console.ReadKey();
        }

        static void nhap()
        {
            person p = new person();
            Console.WriteLine("Nhap ten: ");
            p.Name = Console.ReadLine();
            Console.WriteLine("Nhap tuoi: ");
            p.Age = Int32.Parse(Console.ReadLine());

            if(p.Age >= 60)
            {
                Console.WriteLine("Nguoi gia");
            } else if (p.Age <18 )
            {
                Console.WriteLine("Em be");
            } else
            {
                Console.WriteLine("Nguoi lon");
            }
        }
    }

    class person
    {
        string name;
        int age;

        public person()
        {
         
        }

        public person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                this.age = value;
            }
        }
    }
}
