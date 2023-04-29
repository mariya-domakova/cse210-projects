using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int number = -1;

        do
        {
            Console.Write("Enter number: ");
            string userResponse = Console.ReadLine();
            number = int.Parse(userResponse);
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        int sum = 0;
        foreach (int num in numbers)
        {
            sum = sum + num;    
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int largest = 0;
        largest = numbers.Max();
        Console.WriteLine($"The largest number is: {largest}");
    }
}
