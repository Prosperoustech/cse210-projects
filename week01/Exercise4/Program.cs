using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                if (num == 0)
                    break;
                numbers.Add(num);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }
        Console.WriteLine();
        if (numbers.Count > 0)
        {
            int total = numbers.Sum();
            double average = numbers.Average();
            int maximum = numbers.Max();
            
            var positiveNumbers = numbers.Where(n => n > 0).ToList();
            int? smallestPositive = positiveNumbers.Any() ? positiveNumbers.Min() : (int?)null;
            
            numbers.Sort();
            
            Console.WriteLine($"The sum is: {total}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {maximum}");
            if (smallestPositive.HasValue)
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            
            Console.WriteLine("The sorted list is:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}