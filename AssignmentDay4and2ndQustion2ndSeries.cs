using System;

public class SecondSeries
{
	static void Main(string[]args)

	{
		Console.WriteLine("This is the Series");
		int a = 0;
		int b = 1;
		Console.Write(a + " " + b + " ");
		for(int i = 2; i < 13; i++)
		{
			int c = a + b;
			Console.Write(c + " ");
			a = b;
			b = c;
		}

	}
}
