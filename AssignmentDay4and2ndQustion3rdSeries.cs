using System;
namespace ThirdSeries {
	public class ThirdSeries
	{
		static void Main(string[] args)
		{

			Console.Writeline("This is the Series");
			int n = 3;
			for (int i = 0; i < 14; i++)
			{
				Console.Writeline(n + " ");
				if (i % 3 == 0)
				{
					n += 2;
				}
				else
				{
					n += 3;
				}
			}
		}
	}

} 
