﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicOrganization
{
    public class Doctor : Employee
    {
        public string Specialty { get; set; }
       
       public Doctor(string specialty): base("Doctor", "Roberts", 201, 90000)
        {
            Specialty = "Internist";            
        }

      
        public void DisplayDoctorInfo()
        {
            Console.WriteLine(Specialty + "," + Type + "," + Name + ", employee number " + Num.ToString() + ", has a salary of " + Salary.ToString());
           
        }



    }
}
