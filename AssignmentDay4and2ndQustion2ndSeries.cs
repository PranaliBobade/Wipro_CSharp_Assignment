using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();

        int count = CountWordsWithEqualLength(input);

        Console.WriteLine($"Number of words with equal lengths: {count}");
    }

    static int CountWordsWithEqualLength(string input)
    {
        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int equalLengthCount = 0;

        foreach (string word in words)
        {
            int length = word.Length;

            if (CountWordsOfLength(words, length) > 1)
            {
                equalLengthCount++;
            }
        }

        return equalLengthCount;
    }

    static int CountWordsOfLength(string[] words, int length)
    {
        int count = 0;
        foreach (string word in words)
        {
            if (word.Length == length)
            {
                count++;
            }
        }
        return count;
    }
}
