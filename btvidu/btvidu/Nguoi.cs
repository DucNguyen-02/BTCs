using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btvidu
{
    class Nguoi
    {
        public string Fullname210 { get ; set ; }
        public int Age210 { get; set; }
        public string Job210 { get; set; }
        public string ID210 { get; set; }

        public Nguoi()
        {
        }

        public Nguoi(string fullname, int age, string job, string iD)
        {
            Fullname210 = fullname;
            Age210 = age;
            Job210 = job;
            ID210 = iD;
        }

        public void Input()
        {
            Console.WriteLine("Nhap ho ten: ");
            Fullname210 = Console.ReadLine();
            Console.WriteLine("Nhap tuoi: ");
            Age210 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap nghe nghiep: ");
            Job210 = Console.ReadLine();
            Console.WriteLine("Nhap ID: ");
            ID210 = Console.ReadLine();
        }

        public void Display()
        {
            Console.WriteLine("ho ten: "+ Fullname210);
            Console.WriteLine("tuoi: " + Age210);
            Console.WriteLine("nghe nghiep: " + Job210);
            Console.WriteLine("ID: " + ID210);
        }
    }
}
