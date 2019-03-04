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

                bool gameContinues = true;
                string userInput;
                string userResponse;
                userInput = Console.ReadLine();
            do
            {
               
                    Console.WriteLine("---Main Menu---");
                    Console.WriteLine("Press 1 for list of employees and status");
                    Console.WriteLine("Press 2 for patient status");
                    Console.WriteLine("Press 3 to pay all employess");
                    Console.WriteLine("4 to Exit\n"); 
                   
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
                        Console.WriteLine("Press 1 to see the Doctor, 2 to see the nurse, and 3 to go back to Main Menu\n");
                        userResponse = Console.ReadLine();

                        if (1 == Convert.ToInt32(userResponse) )
                        {
                            Console.WriteLine("Patient's health and bloodlevel went up!");
                           
                        }
                         else if (2 == Convert.ToInt32(userResponse))
                        {
                            Console.WriteLine("Patient's health and bloodlevel went up!");
                        }
                          else if (userResponse = 3)
                        {
                            
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
