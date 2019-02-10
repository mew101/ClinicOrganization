using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicOrganization
{
    public class Patient
    {
     int bloodLevel { get; set; }
     int healthLevel { get; set; }

        public Patient(int bloodLevel, int healthLevel)
        {
            bloodLevel += 20;
            healthLevel += 10;
        }
        public void BloodRange()
        {
            if (bloodLevel <= 0) { bloodLevel = 0; Console.WriteLine("Patient died!"); }
            if (bloodLevel > 200) { bloodLevel = 200; Console.WriteLine("Heart attack!"); }

        }
    }

}
