using System;

class Program
{
    static void Main(string[] args)
    {
        var input = new[] { 5, 2, 4, 6, 1, 3 };

        for (int i = 1; i < input.Length; i++)
        {
            var key = input[i];
            var j = i - 1;

            while (j >= 0 && input[j] > key)
            {
                input[j + 1] = input[j];
                j--;
            }

            input[j + 1] = key;
        }

        Console.WriteLine("Result:");
        Console.Write(string.Join(" ", input));
        Console.ReadLine();
    }
}