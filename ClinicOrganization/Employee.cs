using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicOrganization
{
    public class Employee
    {
        public string Name { get; set; }
        public int Num { get; set; }
        public int Salary { get; set; }
        public bool IsPaid { get; set; }
        public int Balance = 0;

        public Employee(string name, int num, int salary)
        {
            Name = name;
            Num = num;
            Salary = salary;
        }   
        public virtual void PayEmployee()
        {
            Balance = 0;
        }


    }

}
