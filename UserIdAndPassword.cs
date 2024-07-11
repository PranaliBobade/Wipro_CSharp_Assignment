using System;
namespace UserId
{
    internal class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("enter the user Id:");
            string userId = Console.ReadLine();
            Console.WriteLine("enter the password Id:");
            string password = Console.ReadLine();
          
            if (userId.ToLower() == "admin" && password == "admin123")
            {
                Console.WriteLine("Welcome to Admin");
            }
            else{

                Console.WriteLine("Invalid userId or Password");
            }
            Console.ReadLine();
        }
    }
}
