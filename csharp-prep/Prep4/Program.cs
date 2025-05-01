using System;

class Program
{
    static void Main(string[] args)
    {
        int input = 1;
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (input != 0)
        {
            Console.Write("Enter a number. ");
            input = int.Parse(Console.ReadLine());
            numbers.Add(input);
        }
        int sum = numbers.Sum();
        Console.WriteLine("The sum is: " + sum);
        double mean = numbers.Average();
        Console.WriteLine("The mean is " + mean);
        int max = numbers.Max();
        Console.WriteLine("The max is " + max);
    }
}