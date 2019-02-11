using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ClinicOrganization.Tests
{
    public class NurseTests
    {
        [Fact]
        public void NurseInfo()
        {
            Nurse nurse = new Nurse("Nurse", "James", 101, 0, 4, false);
            Assert.Equal(101, nurse.Num);
            //Assert.Equal(50000, nurse.Salary);


        }
    }
}
