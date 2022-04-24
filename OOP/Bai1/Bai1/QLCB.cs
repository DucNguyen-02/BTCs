using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace Bai1
{
    class QLCB
    {
       
        private ArrayList canBo;

        public QLCB()
        {
            this.canBo = new ArrayList();
        }

        public void addOfficer(CanBo cb)
        {
            this.canBo.Add(cb);
        }

        public ArrayList searchOfficerByName(String name)
        {
            ArrayList a = new ArrayList();
            foreach(CanBo i in this.canBo) {
                if(i.Name.Contains(name))
                {
                    a.Add(i);
                }
            }
            return a;
        }

        public void showListInforOfficer()
        {
            foreach(CanBo i in this.canBo)
            {
                Console.WriteLine(i.Name);
            }
        }
    }
}
