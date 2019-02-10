using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicOrganization
{
    public class Patient
    {
        public int patientNum { get; set; }
        public int bloodLevel { get; private set; } 
        public int healthLevel { get; private set; }
        int docBloodIncrease = 20;
        int docHealthIncrease = 10;
        int nursBloodIncrease = 10;
        int nursHealthIncrease = 5;
        public const int maxBloodLevel = 160;
        public const int maxHealthLevel = 100;


        public Patient(int patientNum)
        {
            patientNum = 1; 
            bloodLevel = 20; 
            healthLevel = 10;           
        }

        public void DoctorVisit()
        {
            bloodLevel += docBloodIncrease;
            if (bloodLevel > maxBloodLevel) bloodLevel = maxBloodLevel;
            healthLevel += docHealthIncrease;
            if (healthLevel > maxHealthLevel) healthLevel = maxHealthLevel;

        }
        public void NurseVisit()
        {
            bloodLevel += nursBloodIncrease;
            if (bloodLevel > maxBloodLevel) bloodLevel = maxBloodLevel;
            healthLevel += nursHealthIncrease;
            if (healthLevel > maxHealthLevel) healthLevel = maxHealthLevel;
        }
        
    }

}
