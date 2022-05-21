using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btvidu
{
    class HoGiaDinh : Nguoi
    {
        private int soNguoi;
        private int soNha;
        private Nguoi[] listNguoi = new Nguoi[10];

        public HoGiaDinh()
        {

        }

        public HoGiaDinh(string fullname, int age, string job, string iD,int soNguoi, int soNha, Nguoi[] listNguoi):base(fullname,age,job,iD)
        { 
            this.soNguoi = soNguoi;
            this.soNha = soNha;
            this.listNguoi = listNguoi;
        }

        public void Input2()
        {
            Console.WriteLine("Nhap so nguoi: ");
           soNguoi = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so nha: ");
            soNha = Int32.Parse(Console.ReadLine());
            for(int i=0; i<this.soNguoi; i++)
            {
                Console.WriteLine("Nhap thong tin nguoi thu {0}",i+1);
                listNguoi[i] = new Nguoi();
                listNguoi[i].Input();
            }
        }

        public void Display2()
        {
            Console.WriteLine("So nguoi: "+soNguoi);
            Console.WriteLine("So nha: "+soNha);
            for (int i = 0; i < this.soNguoi; i++)
            {
                Console.WriteLine("Thong tin nguoi thu {0}", i + 1);
                listNguoi[i].Display();
            }
        }
    }
}
