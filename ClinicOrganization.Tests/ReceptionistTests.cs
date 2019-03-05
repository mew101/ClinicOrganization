using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ClinicOrganization.Tests
{
    public class ReceptionistTests
    {
        [Fact]
        public void Receptionist_Info()
        {
            Receptionist receptionist = new Receptionist();
            Assert.Equal(401, receptionist.Num);
            Assert.Equal(45000, receptionist.Salary);
            Assert.Equal("Jane", receptionist.Name);
            Assert.True(receptionist.OnPhone);
        }
    }
}
