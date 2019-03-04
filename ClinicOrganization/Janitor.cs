﻿using System;
using System.Collections.Generic;
using System.Text;
using ClinicOrganization;

namespace ClinicOrganization
{
    public class Janitor : Employee
    {
        public bool IsSweeping { get; set; } = true;

        public Janitor(bool IsSweeping ) : base("Janitor", "Bob", 501, 40000)
        {
            IsSweeping = true;
           
        }

        public void DisplayJanitorInfo()
        {
            Console.WriteLine(Type + "," + Name + ", employee number " + Num.ToString() + ", has a salary of " + Salary.ToString());         
            //Console.WriteLine(Convert.ToString(IsSweeping));
         
        }

    }
}
