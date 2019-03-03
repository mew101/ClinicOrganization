using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicOrganization
{
    public class Doctor : Employee
    {
        public string Specialty { get; set; }
       
       public Doctor(string specialty): base("Doctor", "Roberts", 201, 90000, false)
        {
            Specialty = "Internist";            
        }

      
        public void DisplayDoctorInfo()
        {
            Console.WriteLine(Specialty);
            Console.WriteLine(Type);
            Console.WriteLine(Name);
            Console.WriteLine(Num.ToString());
            Console.WriteLine(Salary.ToString()); 
            Console.WriteLine(Convert.ToString(Paid));
        }



    }
}
