using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicOrganization
{
    public class Doctor : Employee
    {
        public Doctor(string v1, string v2, string v3, int v4, int v5, bool v6)
        {
        }

        public string Specialty { get; set; }
       


       /*public Doctor(string specialty, string nam, int num): base("Doctor", nam, num, 90000, false)
        {
            Type = "doctor";
            Specialty = specialty;
            
        }*/

      
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
