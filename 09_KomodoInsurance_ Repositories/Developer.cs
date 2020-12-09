using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_KomodoInsurance__Repositories
{



    //POCO
    public class Developer

    {

        public string Name { get; set; }
        public int IdNumber { get; set; }
        public bool HaveAccess { get; set; }

        public Developer() { }

        public Developer(string name, int idnumber, bool haveaccess)
        {
            Name = name;
            IdNumber = idnumber;
            HaveAccess = haveaccess;
        }



    }


}

