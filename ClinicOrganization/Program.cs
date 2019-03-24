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
                var receptionist = new Receptionist();
                var janitor = new Janitor();
                var patient = new Patient();
               

                string userInput;
                string userResponse;
                //userInput = Console.ReadLine();
                bool gameContinues = true;
                bool paid = false; 
            do
            {              
                    Console.WriteLine("\n---Main Menu---");
                    Console.WriteLine("Press 1 for list of employees and information");
                    Console.WriteLine("Press 2 for patient status and visit");
                    Console.WriteLine("Press 3 to see if employees are working");
                    Console.WriteLine("Press 4 to pay all employess");
                    Console.WriteLine("Press 5 to Exit\n"); 
                   
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
                            doctor.DrawBlood(patient);                        
                            patient.PatientInfo();                          
                        }
                        else if (2 == Convert.ToInt32(userResponse))
                        {
                            nurse.DrawBlood(patient);
                            patient.PatientInfo();                           
                        }
                        else
                        {
                            Console.WriteLine("Choose a valid option:");
                        }
                         break;

                    case "3":
                        janitor.Sweep();
                        receptionist.Phone();   
                        Console.WriteLine("Press 1 for janitor. 2 for receptionist.");
                        userResponse = Console.ReadLine();
                        if (1 == Convert.ToInt32(userResponse))
                        {
                            janitor.Sweep();             
                        }
                        else if (2 == Convert.ToInt32(userResponse))
                        {
                            receptionist.Phone();                         
                        }
                        else
                        {
                            Console.WriteLine("That was not a valid input. Main Menu:");
                        }
                        break;

                    case "4":
                        if (paid == false)
                        {
                            paid = true;
                            Console.WriteLine("Everyone just got paid");

                        }
                        else
                        {
                            Console.WriteLine("We dont more than once!");
                        }

                        break;

                    case "5":
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
