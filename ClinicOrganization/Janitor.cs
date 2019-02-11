using System;
using System.Collections.Generic;
using System.Text;
using ClinicOrganization;

namespace ClinicOrganization
{
    public class Janitor : Employee
    {
        public bool IsSweeping { get; set; }

        public Janitor(string type, string nam, int num, bool isSweeping, int sal, bool paid) : base(type, nam, num, sal, paid)
        {
            IsSweeping = false;
            Salary = 40000;
        }

        public void DisplayJanitorInfo()
        {        
            Console.WriteLine(Type);
            Console.WriteLine(Name);
            Console.WriteLine(Num.ToString());
            Console.WriteLine(Convert.ToString(IsSweeping));
            Console.WriteLine(Salary.ToString());
            Console.WriteLine(Convert.ToString(Paid));
        }

    }
}
