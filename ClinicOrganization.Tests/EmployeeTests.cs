using System;
using Xunit;

namespace ClinicOrganization.Tests
{
    public class EmployeeTests
    {
      [Fact]
        public void Pay_Employee()
        {
            var employee = new Employee("Doctor", "Bob", 222, 90000);
            employee.PayEmployee();
            Assert.True(employee.Paid);
        }

        



    }
}