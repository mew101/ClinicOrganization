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
        public bool IsPaid = true;
        public int Balance { get; set; }

        public Employee(string type, string name, int num, int salary)
        {
            Type = type;
            Name = name;
            Num = num;
            Salary = salary;
        }
        public Employee()
        {

        }
        public virtual void PayEmployee()
        {
           
        }
        public virtual void DisplayEmployeeInfo()
        {
            Console.WriteLine(Type + " " + Name + " is employee " + Num + " and gets paid " + Salary );
        }

    }

}
