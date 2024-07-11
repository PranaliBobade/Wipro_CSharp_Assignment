// See https://aka.ms/new-console-template for more information
using System;
namespace PatientBill
{
    class PatientBilling {
        static void Main(string[]args) {
            Console.WriteLine("Enter The detatils");
            Console.WriteLine("Enter The Patient Id");
            int patientId =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Name");
            string name = Console.ReadLine();
            
            Console.WriteLine("Enter The BloodGroup");
            string bloodGroup = Console.ReadLine();
            Console.WriteLine("Enter The Height (in cm)");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Weight (in kg)");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter The DateOfBirth(yyyy-MM-dd):");
            DateTime dateOfBirth =DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            string phoneNumber = Console.ReadLine();



            Console.WriteLine("Enter The Patient Id"+patientId);
            Console.WriteLine("Enter The Name"+name);

            Console.WriteLine("Enter The BloodGroup"+bloodGroup);
            Console.WriteLine("Enter The Height (in cm)"+height);
            Console.WriteLine("Enter The Weight (in kg)"+weight);
            Console.WriteLine("Enter The DateOfBirth(yyyy-MM-dd):"+dateOfBirth);
            Console.WriteLine("Enter Address"+address);
            Console.WriteLine("Enter Phone Number"+phoneNumber);

        } }}

