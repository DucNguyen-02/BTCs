using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class KySu:CanBo
    {
        private string branch;

        public KySu(string name, int age, string gender, string address,string branch) :base(name,age,gender,address)
        {
            this.Branch = branch;
        }

        public string Branch { get; set ; }
    }
}
