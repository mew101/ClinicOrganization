using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicOrganization
{
    public class Patient
    {
       
        public int BloodLevel { get; set; } 
        public int HealthLevel { get; set; }
        
        
       

        public Patient()
        {
          
            BloodLevel = 20; 
            HealthLevel = 10;           
        }

        public void DoctorVisit()
        {
            BloodLevel += 20;
            HealthLevel += 10;
        }
        public void NurseVisit()
        {
            BloodLevel += 10;
            HealthLevel += 5;
        }
        public void PatientInfo()
        {
            Console.WriteLine("Patient Bloodlevel is " + BloodLevel);
            Console.WriteLine("Patient healthlevel is " + HealthLevel);

        }
    }

}
