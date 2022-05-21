using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btvidu
{
    class KhuPho
    {
        private int soHoGiaDinh { get; set; }
        List<HoGiaDinh> listHoGiaDinh = new List<HoGiaDinh>();

        public KhuPho() { }

        public KhuPho(int soHoGiaDinh, List<HoGiaDinh> listHoGiaDinh)
        {
            this.soHoGiaDinh = soHoGiaDinh;
            this.listHoGiaDinh = listHoGiaDinh;
        }

        public void addHoGiaDinh(HoGiaDinh hoGiaDinh)
        {
            listHoGiaDinh.Add(hoGiaDinh);
        }

        public void Input()
        {
            Console.WriteLine("nhap so ho gia dinh: ");
            soHoGiaDinh = Int32.Parse(Console.ReadLine());

            for(int i=0; i<soHoGiaDinh; i++)
            {
                Console.WriteLine("Nhap so ho gia dinh thu {0}", i + 1);
                HoGiaDinh hoGiaDinh = new HoGiaDinh();
                hoGiaDinh.Input2();
                addHoGiaDinh(hoGiaDinh);
            }
        }

        public void Display()
        {
            Console.WriteLine("Tong so ho: {0} ", soHoGiaDinh);
            for (int i = 0; i < soHoGiaDinh; i++)
            {
                Console.WriteLine("Thong tin ho {0}", i + 1);
                listHoGiaDinh[i].Display2();
            }
        }

        
    }
}
