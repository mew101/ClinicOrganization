using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicOrganization
{
    public class Employee
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Num { get; set; }
        public int Salary { get; set; }
        public bool Paid { get; set; } = false;
        

        public Employee(string type, string nam, int num, int sal) //bool paid)
        {
            Type = type;
            Name = nam;
            Num = num;
            Salary = sal;
            //Paid = paid;

        }

        public void PayEmployee()
        {
            Paid = true;
        }

        public List<Employee> Employees = new List<Employee>
        {
            new Doctor("Internist"),
            new Nurse(3),
            new Receptionist(true),
            new Janitor(true)
        };

       
    }

}
