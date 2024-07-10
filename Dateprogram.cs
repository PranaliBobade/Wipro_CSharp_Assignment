// See https://aka.ms/new-console-temp
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace DateCode
{
    public class Datecode
    {
        public static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            DateTime date = today.AddDays(10);
            Console.WriteLine(date);

            DateTime d = new DateTime(2024, 7, 9, 8, 11, 28, 0);
            string newFormatdate = d.ToString("dddd,d MMMM yyyy 'at' hh:mm:tt");
            Console.WriteLine("Formatted Date" + newFormatdate);

            DateTime startDate = new DateTime(2024, 7, 1);
            DateTime endDate = new DateTime(2024, 7, 15);
            TimeSpan gap = endDate - startDate;
            int differanceOfDays = gap.Days;
            Console.WriteLine("Number of days Gap between" + differanceOfDays);


        }
    }
}