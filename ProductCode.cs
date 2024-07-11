// See https://aka.ms/new-console-template for more information
using System;
namespace Product
{
    class ProductCode
    {
static void Main(string[] args)

        {
            Console.WriteLine("Enter Product Id");
            int productId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Name");
            string productName = Console.ReadLine();
            Console.WriteLine("Enter Unit Price");
            double unitPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Quantity");
            int quantity = int.Parse(Console.ReadLine());

          double totalAmount = unitPrice * quantity;
            if(totalAmount>1000 && totalAmount<=3000){
                totalAmount *= 0.9;
            }
            else if (totalAmount > 3000 && totalAmount <= 5000)
            {
                totalAmount *= 0.85;
            }
           else if (totalAmount > 5000)
            {
                totalAmount *= 0.8;
            }


            Console.WriteLine("\n Product Details");
            Console.WriteLine("Product Id"+productId);
            Console.WriteLine("Product Name"+productName);
            Console.WriteLine("Unit Price"+unitPrice);
            Console.WriteLine("Quantity"+quantity);
            Console.WriteLine("Total Amount After Discount"+totalAmount);
           
        }


        }
    }
   

