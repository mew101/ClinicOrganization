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
        public bool Paid { get; set;}
       

        public Employee(string type, string nam, int num, int sal)
        {
            Type = type;
            Name = nam;
            Num = num;
            Salary = sal;
           
        }
       

        public virtual void PayEmployee()
        {
            Paid = true;
        }
       
       

    }

}
