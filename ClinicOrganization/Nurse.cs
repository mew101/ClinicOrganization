﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicOrganization
{
    class Nurse : Employee
    {
        public List<Nurse> NursList { get; set; }
        public int Patients { get; set; }

        public Nurse(string type, string nam, int num, int sal, int patients, bool paid) : base(type, nam, num, sal, paid)
        {
             Patients = patients;
        }

        public void ListOfNurses()
        {
            NursList = new List<Nurse>
            {
                new Nurse("Nurse", "Thomson", 201, 50000, 3, false),
                new Nurse("Nurse", "Brown", 202, 50000, 5, false)
            };
        }
        public string DisplayNurseInfo()
        {
            return (Type + " " + Name + " is employee " + Num.ToString() + ", gets paid " + Salary.ToString() + " has" +  Patients.ToString() + " " + Paid);
        }

    }
}
