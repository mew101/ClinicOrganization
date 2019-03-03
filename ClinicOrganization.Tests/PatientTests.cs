using System;
using Xunit;
using System.Collections.Generic;


namespace ClinicOrganization.Tests
{
    public class PatientTests
    {
        [Fact]
        public void Default_Levels()
        {
            var patient = new Patient();
                      
            Assert.Equal(20, Convert.ToInt32(patient.BloodLevel));
            Assert.Equal(10, Convert.ToInt32(patient.HealthLevel));
        }

        [Fact]
        public void Doc_Incrceases_BloodLevel()
        {
            var patient = new Patient();
            patient.DoctorVisit();
            Assert.Equal(40, Convert.ToInt32(patient.BloodLevel));
        }
        [Fact]
        public void Doc_Incrceases_HealthLevel()
        {
            var patient = new Patient();
            patient.DoctorVisit();
            Assert.Equal(20, Convert.ToInt32(patient.HealthLevel));
        }

        [Fact]
        public void Nurse_Incrceases_HealthLevel()
        {
            var patient = new Patient();
            patient.NurseVisit();
            Assert.Equal(15, Convert.ToInt32(patient.HealthLevel));
        }
        [Fact]
        public void Nurse_Incrceases_BloodLevel()
        {
            var patient = new Patient();
            patient.NurseVisit();
            Assert.Equal(30, Convert.ToInt32(patient.BloodLevel));
        }




    }
}