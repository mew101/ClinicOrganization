using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ClinicOrganization.Tests
{
    public class NurseTests
    {
        [Fact]
        public void Nurse_Info()
        {
            Nurse nurse = new Nurse(3);
            Assert.Equal("Betsy", nurse.Name);
            Assert.Equal(301, nurse.Num);
            Assert.Equal(50000, nurse.Salary);

        }
    }
}
