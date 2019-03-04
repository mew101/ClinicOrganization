using System;
using System.Collections.Generic;
using System.Text;
using ClinicOrganization;

namespace ClinicOrganization
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            
                var doctor = new Doctor("Internist");
                var nurse = new Nurse(3);
                var receptionist = new Receptionist(true);
                var janitor = new Janitor(true);

                var patient = new Patient();

               
                string userInput;
                string userResponse;
                userInput = Console.ReadLine();
                bool gameContinues = true;
            do
            {              
                    Console.WriteLine("\n---Main Menu---");
                    Console.WriteLine("Press 1 for list of employees and status");
                    Console.WriteLine("Press 2 for patient status");
                    Console.WriteLine("Press 3 to pay all employess");
                    Console.WriteLine("Press 4 to Exit\n"); 
                   
                   userInput = Console.ReadLine();
                  
                switch (userInput)
                {
                    case "1":                       
                            doctor.DisplayDoctorInfo();
                            nurse.DisplayNurseInfo();
                            receptionist.DisplayReceptionistInfo();
                            janitor.DisplayJanitorInfo();                      
                        break;

                    case "2":
                        patient.PatientInfo();
                        Console.WriteLine("Press 1 to see the Doctor, 2 to see the nurse\n");
                        userResponse = Console.ReadLine();
                       

                       if (1 == Convert.ToInt32(userResponse) )
                        {
                            patient.DoctorVisit();
                            Console.WriteLine("Patient's health and bloodlevel went up!");
                            patient.PatientInfo();                          
                        }
                        else if (2 == Convert.ToInt32(userResponse))
                        {
                            patient.NurseVisit();
                            Console.WriteLine("Patient's health and bloodlevel went up!");
                            patient.PatientInfo();                           
                        }
                        else
                        {
                            Console.WriteLine("Choose a valis option:");
                        }
                         break; 

                    case "3":
                        doctor.PayEmployee();
                        nurse.PayEmployee();
                        receptionist.PayEmployee();
                        janitor.PayEmployee();
                        break;

                    case "4":
                        gameContinues = false;
                        Console.WriteLine("GoodBye!");
                        break;
                    default:
                        Console.WriteLine("Enter a number between 1 and 3");
                        break;
                }
               
            } while (gameContinues == true);

        }

    }
}
