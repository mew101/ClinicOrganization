using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicOrganization
{
    public class Receptionist : Employee
    {
        public bool OnPhone { get; set; } = true;

        public Receptionist(bool OnPhone) : base("Receptionist", "Jane", 401, 45000, false)
        {
            OnPhone = true;
           
        }

        public void DisplayReceptionistInfo()
        {
            Console.WriteLine(Type + "," + Name + ", employee number " + Num.ToString() + ",\nhas a salary of " + Salary.ToString() + " and payment is " + Paid);
           
           // Console.WriteLine(Convert.ToString(OnPhone));
        }
    }
}
