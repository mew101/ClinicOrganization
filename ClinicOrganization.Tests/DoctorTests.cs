using Xunit;


namespace ClinicOrganization.Tests
{
   
    public class DoctorTests
   
    {
        [Fact]
        public void DocInfo()
        {
            Visit doctor = new Visit("Internist");
            Assert.Equal("Internist", doctor.Specialty);
            Assert.Equal(201, doctor.Num);
            Assert.Equal(90000, doctor.Salary);
            
        }
    }
}
