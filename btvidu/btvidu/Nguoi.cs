using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btvidu
{
    class Nguoi
    {
        public string Fullname { get ; set ; }
        public int Age { get; set; }
        public string Job { get; set; }
        public string ID { get; set; }

        public Nguoi()
        {
        }

        public Nguoi(string fullname, int age, string job, string iD)
        {
            Fullname = fullname;
            Age = age;
            Job = job;
            ID = iD;
        }

        public void Input()
        {
            Console.WriteLine("Nhap ho ten: ");
            Fullname = Console.ReadLine();
            Console.WriteLine("Nhap tuoi: ");
            Age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nghe nghiep: ");
            Job = Console.ReadLine();
            Console.WriteLine("Nhap ID: ");
            ID = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("ho ten: "+ Fullname);
            Console.WriteLine("tuoi: " + Age);
            Console.WriteLine("nghe nghiep: " + Job);
            Console.WriteLine("ID: " + ID);
        }
    }
}
