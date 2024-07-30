using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM
{
    class MasterClass
    {
        internal bool Login(string user,string pass)
        {
            return true;
        }
        public bool Check_id_invalid(string id)
        {
            if (id.Length < 10)
                return true;
            else
                return false;
        }
        public string name(string id)
        {
            string Name = "amin";
            return Name;
        }
        public string family(string id)
        {
            string Name = "mi";
            return Name;
        }
        public string shahrie(string id)
        {
            return "0";
        }



    }
}
