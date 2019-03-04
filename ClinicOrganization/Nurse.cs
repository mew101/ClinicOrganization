using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicOrganization
{
    public class Nurse : Employee
    {
       
        public int Patients { get; set; }

        public Nurse(int patients) : base("Nurse", "Betsy" , 301, 50000, false)
        {
            Patients = 3;       
        }

       
        public void DisplayNurseInfo()
        {          
            Console.WriteLine(Type + ", " + Name + ", employee number " + Num.ToString() + ",\nhas a salary of " + Salary.ToString() + " and payment is " + Paid);  
        }


    }
}
