using System;
using System.Collections.Generic;
using System.Text;
using ClinicOrganization;

namespace ClinicOrganization
{
    public class Janitor : Employee
    {
        public bool Sweeping { get; set; } = true;

        public Janitor() : base("Janitor", "Bob", 501, 40000)
        {
            
        }

        public void DisplayJanitorInfo()
        {
            Console.WriteLine(Type + "," + Name + ", employee number " + Num.ToString() + ", has a salary of " + Salary.ToString());
        }
        public void Sweep()
        {
            if (Sweeping == false)
            {
                Sweeping = true; Console.WriteLine("Janitor is now sweeping");

            }
            else
            {
                Sweeping = false; Console.WriteLine("Janitor is done sweeping");

            }
        }
    }
}
