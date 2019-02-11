using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ClinicOrganization.Tests
{
    public class ReceptionistTests
    {
        [Fact]
        public void ReceptionistInfo()
        {
            Receptionist receptionist = new Receptionist("Receptionist", "Jones", 101, false, 0, false);
           // Assert.Equal(101, receptionist.Num);
            Assert.Equal(45000, receptionist.Salary);
        }
    }
}
