using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicOrganization
{
    public class Receptionist : Employee
    {
        public bool OnPhone { get; set; }

        public Receptionist(string type, string nam, int num, bool onPhone, int sal, bool paid) : base(type, nam, num, sal, paid)
        {
            OnPhone = false;
        }

        public void DisplayReceptionistInfo()
        {
            
            Console.WriteLine(Name);
            Console.WriteLine(Num.ToString());
            Console.WriteLine(Convert.ToString(OnPhone));
            Console.WriteLine(Salary.ToString());
            Console.WriteLine(Convert.ToString(Paid));
        }
    }
}
