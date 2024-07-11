// See https://aka.ms/new-console-template for more information
using System;
namespace PaySlip
{
    class paySlipGenerated
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee ID");
            int empId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            string empName = Console.ReadLine();

            Console.WriteLine("Enter Basic Salary");
           double basicSalary = double.Parse(Console.ReadLine());

            Console.WriteLine("Are You contract employee?(true/false):");
            bool isContract= bool.Parse(Console.ReadLine());
            Console.WriteLine("Enter Department Number");
            int depNo= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Email ID");
            string emailId = Console.ReadLine();

            double hra = 0.15 * basicSalary;
            double ma = 0.10 * basicSalary;
            double ta = 0.15 * basicSalary;

            double netSalary = basicSalary + hra + ma + ta;
            Console.WriteLine("\n Enter Employee Details");
            Console.WriteLine("Enter Employee ID"+empId);
            Console.WriteLine("Enter Employee Name"+empName);
            Console.WriteLine("Enter Basic Salary"+basicSalary);
            Console.WriteLine("HRA" + hra);
            Console.WriteLine("Ma" + ma);
            Console.WriteLine("Ta" + ta);
            Console.WriteLine("Total Salary" + netSalary);

            Console.WriteLine("Are You contract employee?(true/false):"+isContract);
            Console.WriteLine("Enter Department Number"+depNo);
            Console.WriteLine("Enter Email ID"+emailId);
        }
    }
}

