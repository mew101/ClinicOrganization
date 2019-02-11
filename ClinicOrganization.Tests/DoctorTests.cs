using Xunit;


namespace ClinicOrganization.Tests
{
   
    public class DoctorTests
   
    {
        [Fact]
        public void DocInfo()
        {
            Doctor doctor = new Doctor("Cardiologist", "Doctor", "Smith", 101, 60000, false);
            //Assert.Equal("Cardiologist", doctor.Specialty);
            //Assert.Equal(101, doctor.Num);
            Assert.Equal(90000, doctor.Salary);
            
        }
    }
}
