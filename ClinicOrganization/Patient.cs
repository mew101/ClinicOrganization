using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicOrganization
{
    public class Patient
    {
        public int bloodLevel { get; set; } 
        public int healthLevel { get; set; }
        int bloodIncrease = 10;
        int healthIncrease = 10;
        public const int maxBloodLevel = 160;
        public const int maxHealthLevel = 100;


        public Patient()
        {
            bloodLevel = 20; 
            healthLevel = 10;           
        }
        
        public void DoctorVisit()
        {
            bloodLevel += bloodIncrease;
            if (bloodLevel > maxBloodLevel) bloodLevel = maxBloodLevel;
            healthLevel += healthIncrease;
            if (healthLevel > maxHealthLevel) healthLevel = maxHealthLevel;

        }
       
    }

}
