// See https://aka.ms/new-console-template for more information
using System;
namespace Product
{
    class ProductCode
    {
        static void Main(string[] args)

        {
            int MaxInt1 = int.MaxValue;
            int MaxInt2 = int.MaxValue;
            try
            { int sum = checked(MaxInt1 + MaxInt2);
                Console.WriteLine("Sum Of MaxInt1 and  MaxInt1 is" + sum);

            }
            catch (OverflowException)
            {
                long sum = (long))MaxInt1 + (long)MaxInt2;
                Console.WriteLine("Overflow detected using long to store the sum" + sum);
            }

        }


    }
}   
   

