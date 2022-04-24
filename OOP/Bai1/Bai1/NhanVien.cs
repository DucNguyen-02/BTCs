using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class NhanVien:CanBo
    {
        private string task;

        public NhanVien(string name, int age, string gender, string address,string task):base(name,age,gender,address)
        {
            this.Task = task;
        }

        public string Task { get; set; }
    }
}
