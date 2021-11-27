using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemesterProjekt2021
{
    class Person
    {
        public Person()
        {

        }
        public int ID { get; set; }
        public int CPR { get; set; }
        public string City { get; set; }
        public int Zip { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int PhoneNr { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public bool IsEjendomsmælger { get; set; }
        public bool IsKøber { get; set; }
        public bool IsSælger { get; set; }


    }
}
