using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btvidu
{
    class KhuPho
    {
        private int soHoGiaDinh210 { get; set; }
        List<HoGiaDinh> listHoGiaDinh210 = new List<HoGiaDinh>();

        public KhuPho() { }

        public KhuPho(int soHoGiaDinh, List<HoGiaDinh> listHoGiaDinh)
        {
            this.soHoGiaDinh210 = soHoGiaDinh;
            this.listHoGiaDinh210 = listHoGiaDinh;
        }

        public void addHoGiaDinh(HoGiaDinh hoGiaDinh)
        {
            listHoGiaDinh210.Add(hoGiaDinh);
        }

        public void Input()
        {
            Console.WriteLine("nhap so ho gia dinh: ");
            soHoGiaDinh210 = Int32.Parse(Console.ReadLine());

            for(int i=0; i< soHoGiaDinh210; i++)
            {
                Console.WriteLine("Nhap so ho gia dinh thu {0}", i + 1);
                HoGiaDinh hoGiaDinh210 = new HoGiaDinh();
                hoGiaDinh210.Input2();
                addHoGiaDinh(hoGiaDinh210);
            }
        }

        public void Display()
        {
            Console.WriteLine("Tong so ho: {0} ", soHoGiaDinh210);
            for (int i = 0; i < soHoGiaDinh210; i++)
            {
                Console.WriteLine("Thong tin ho {0}", i + 1);
                listHoGiaDinh210[i].Display2();
            }
        }

        
    }
}
