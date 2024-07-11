using System;
namespace AssignmentSeriesDayfour
{ 

    public class AssignmentSeriesDayfour
	{
		static void Main(string[] args)
		{
			const int numberOfProducts = 5;
			double totalAmount = 0.0;
			double prices = new double[numberOfProducts];
			int quantities = new int[numberOfProducts];
			Console.WriteLine("Enter the prices and quantities for number of product is" + numberOfProducts);
			for (int i = 0; i < numberOfProducts; i++)
			{
				Console.Write($"Enter the price of product {i + 1}:");
				prices[i] = double.Parse(Console.ReadLine());
				Console.Write($"Enter the quantity of product {i + 1}:");
				quantities[i] = int.Parse(Console.ReadLine());
			}
			for (int i = 0; i < numberOfProducts; i++)
			{
				totalAmount += prices[i] * quantities[i];

			}
            Console.WriteLine(" The Total Amount is" + totalAmount);

        }
    }
}
