using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    public class CanBo
    {
        //Họ tên, tuổi, giới tính(name, nữ, khác), địa chỉ.
        protected string name;
        protected int age;
        protected string gender;
        protected string address;

        public CanBo(string name, int age, string gender, string address)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Address = address;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
    }
}