// See https://aka.ms/new-console-template for more information
using System;
namespace udemyRegistration { 
    class Project
    {
static void Main(string[] args) { 
    
    Console.WriteLine("Enter the  Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Course Name");
            string courseName = Console.ReadLine();

            Console.WriteLine("Email Id");
            string email = Console.ReadLine();

            Console.WriteLine("Registration Date");
            DateTime registrationDate = DateTime.Parse(Console.ReadLine());
            decimal totalFee = 25000;

            if (registrationDate < new DateTime(2024, 6, 10))
            {
                totalFee *=0.9m;

            }

           else if (registrationDate < new DateTime(2024,6,15)) 
            {
                totalFee *= 0.85m;
            }
           else if (registrationDate > new DateTime(2024,6,20))
            {
                totalFee *= 1.05m;
            }



            Console.WriteLine("Enter Name"+name);
            Console.WriteLine("Enter Course Name" + courseName);
            Console.WriteLine("Enter Email Id"+email);
            Console.WriteLine("Registration Date"+registrationDate);
            Console.WriteLine("Total Fee"+totalFee);
          

          
        }
}
}