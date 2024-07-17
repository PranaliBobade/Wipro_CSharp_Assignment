using System;
using System.Collections.Generic;

public class TimeInWords
{
    private static Dictionary<int, string> numberWords = new Dictionary<int, string>
    {
        {0, "o' clock"},
        {1, "one"},
        {2, "two"},
        {3, "three"},
        {4, "four"},
        {5, "five"},
        {6, "six"},
        {7, "seven"},
        {8, "eight"},
        {9, "nine"},
        {10, "ten"},
        {11, "eleven"},
        {12, "twelve"},
        {13, "thirteen"},
        {14, "fourteen"},
        {15, "quarter"},
        {16, "sixteen"},
        {17, "seventeen"},
        {18, "eighteen"},
        {19, "nineteen"},
        {20, "twenty"},
        {21, "twenty one"},
        {22, "twenty two"},
        {23, "twenty three"},
        {24, "twenty four"},
        {25, "twenty five"},
        {26, "twenty six"},
        {27, "twenty seven"},
        {28, "twenty eight"},
        {29, "twenty nine"},
        {30, "half"}
    };

    public static string ConvertTimeToWords(int hours, int minutes)
    {
        if (minutes == 0)
        {
            return $"{numberWords[hours]} {numberWords[minutes]}";
        }
        else if (minutes == 15 || minutes == 30)
        {
            return $"{numberWords[minutes]} past {numberWords[hours]}";
        }
        else if (minutes == 45)
        {
            return $"{numberWords[15]} to {numberWords[(hours % 12) + 1]}";
        }
        else if (minutes < 30)
        {
            return $"{numberWords[minutes]} minute{(minutes == 1 ? "" : "s")} past {numberWords[hours]}";
        }
        else
        {
            int minutesTo = 60 - minutes;
            return $"{numberWords[minutesTo]} minute{(minutesTo == 1 ? "" : "s")} to {numberWords[(hours % 12) + 1]}";
        }
    }

    public static void Main()
    {
        Console.Write("Enter hours: ");
        int hours = int.Parse(Console.ReadLine());

        Console.Write("Enter minutes: ");
        int minutes = int.Parse(Console.ReadLine());

        string timeInWords = ConvertTimeToWords(hours, minutes);
        Console.WriteLine(timeInWords);
    }
}
