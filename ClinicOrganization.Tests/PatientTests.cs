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
            var patient = new Patient(1);
                      
            Assert.Equal(20, Convert.ToInt32(patient.bloodLevel));
            Assert.Equal(10, Convert.ToInt32(patient.healthLevel));
        }

       
        



    }
}