using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btvidu
{
    class HoGiaDinh : Nguoi
    {
        private int soNguoi210;
        private int soNha210;
        private Nguoi[] listNguoi210 = new Nguoi[10];

        public HoGiaDinh()
        {

        }

        public HoGiaDinh(string fullname, int age, string job, string iD,int soNguoi, int soNha, Nguoi[] listNguoi):base(fullname,age,job,iD)
        { 
            this.soNguoi210 = soNguoi;
            this.soNha210 = soNha;
            this.listNguoi210 = listNguoi;
        }

        public void Input2()
        {
            Console.WriteLine("Nhap so nguoi: ");
            soNguoi210 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nha: ");
            soNha210 = Int32.Parse(Console.ReadLine());
            for(int i=0; i<this.soNguoi210; i++)
            {
                Console.WriteLine("Nhap thong tin nguoi thu {0}",i+1);
                listNguoi210[i] = new Nguoi();
                listNguoi210[i].Input();
            }
        }

        public void Display2()
        {
            Console.WriteLine("So nguoi: "+ soNguoi210);
            Console.WriteLine("So nha: "+ soNha210);
            for (int i = 0; i < this.soNguoi210; i++)
            {
                Console.WriteLine("Thong tin nguoi thu {0}", i + 1);
                listNguoi210[i].Display();
            }
        }
    }
}
