﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClinicOrganization
{
    public class Doctor : Employee
    {
        public string Specialty { get; set; }
        public List<Doctor> DocList { get; set; }


        public Doctor(string specialty, string nam, int num): base("Doctor", nam, num, 90000, false)
        {
            Type = "doctor";
            Specialty = specialty;
           
        }

        public void ListOfDocs()
        {
            DocList = new List<Doctor>
            {
               // new Doctor("Cardiologist", "Doctor", "Smith", 101, 90000, false),
               // new Doctor("Neurologist", "Doctor", "Jones", 102, 90000, false)
            };
        }
        public void DisplayDoctorInfo()
        {
            Console.WriteLine(Specialty);
            Console.WriteLine(Type);
            Console.WriteLine(Name);
            Console.WriteLine(Num.ToString());
            Console.WriteLine(Salary.ToString()); 
            Console.WriteLine(Convert.ToString(Paid));
        }



    }
}
