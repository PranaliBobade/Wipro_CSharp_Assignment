// See https://aka.ms/new-console-template for more information
using System;
namespace billgenerate
{
    class BillGenerated
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numner Of Pizza");
            int numOfPizza = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number Of Puffs");
            int numOfPuffs = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number Of Pepsis");
            int numOfPepsis= int.Parse(Console.ReadLine());


            double pizzaOfcost = numOfPizza * 300;
            double puffsOfcost = numOfPuffs * 50;
            double pepsisOfcost = numOfPepsis * 130;
            

            double totalOfCost = pizzaOfcost + puffsOfcost + pepsisOfcost;
            double gstAmount = 0.09 * totalOfCost;
                double cessAmount = 0.09 * totalOfCost;
            double grandTotal = totalOfCost + gstAmount + cessAmount;
            Console.WriteLine("\n Bill Details");
            Console.WriteLine("Total cost of pizzas"+pizzaOfcost);
            Console.WriteLine("Total cost of puffs"+puffsOfcost);
            Console.WriteLine("Total cost of pepsis"+pepsisOfcost);
            Console.WriteLine("Gst"+gstAmount);
            Console.WriteLine("Cess"+cessAmount);
            Console.WriteLine("Total Amount" + grandTotal);
        }
    }
}
