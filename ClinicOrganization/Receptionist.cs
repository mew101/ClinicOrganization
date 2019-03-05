using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicOrganization
{
    public class Receptionist : Employee
    {
        public bool OnPhone { get; set; } = true;

        public Receptionist() : base("Receptionist", "Jane", 401, 45000)
        {
     
        }

        public void DisplayReceptionistInfo()
        {
            Console.WriteLine(Type + ", " + Name + ", employee number " + Num.ToString() + ", has a salary of " + Salary.ToString());
        }

        public void Phone()
        {
            if (OnPhone == false)
            {
                OnPhone = true;
                Console.WriteLine("Receptionist is now on the phone");
               
            }
            else
            {
                OnPhone = false;
                Console.WriteLine("Receptionist is now off the phone");
            }
        }
    }
}
