using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class CongNhan : CanBo
    {
        private int level;

        public CongNhan(string name, int age, string gender, string address, int level):base(name,age,gender,address)
        {
            Level = level;
        }

        public int Level { get; set; }
    }
}
