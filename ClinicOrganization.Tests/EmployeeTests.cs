using System;
using Xunit;

namespace ClinicOrganization.Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void Pay_Employee()
        {
            var employee = new Employee();

            employee.IsPaid = true;

            Assert.True(employee.IsPaid);
        }

        [Fact]



    }
}