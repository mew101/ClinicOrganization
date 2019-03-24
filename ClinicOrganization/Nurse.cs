using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicOrganization
{
    public class Nurse : Employee
    {       
        public int Patients { get; set; }

        public Nurse(int patients) : base("Nurse", "Betsy" , 301, 50000)
        {
            Patients = 3;       
        }
      
        public void DisplayNurseInfo()
        {          
            Console.WriteLine(Type + ", " + Name + ", employee number " + Num.ToString() + ", has a salary of " + Salary.ToString());  
        }

        public override void DrawBlood(Patient patient)
        {
            patient.BloodLevel += 10;
            patient.HealthLevel += 5;
            Console.WriteLine("Patient's health and bloodlevel went up!");
        }
    }
}
