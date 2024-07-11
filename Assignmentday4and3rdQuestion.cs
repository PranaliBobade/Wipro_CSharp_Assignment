using System;

namespace AssignmentLoop {
	public class AssignmentLoop
	{
		static void Main(string[] args)

		{
			Console.WriteLine("Enter the Number");
			int newNumber = int.Parse(Console.ReadLine());
			int number = new int[newNumber];
			Console.WriteLine($"Enter {newNumber} Number is");
			for (int i = 0; i < newNumber; i++)
			{
				Console.Write($"Enter  Number {i + 1} :");
				number[i] = int.Parse(Console.Readline());
			}
			int SumEven = 0;
			int SumOdd = 0;
			for (int i = 0; i < newNumber; i++)
			{
				if (number[i] % 2 == 0)
				{
					SumEven += number[i];

				}
				else
				{
					SumOdd += number[i];


				}
			}
			Console.WriteLine("Sum Of All Even Numbers" + SumEven);
            Console.WriteLine("Sum Of All Odd Numbers" + SumOdd);
        }
	}
}