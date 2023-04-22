using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        List<int> numbers = new List<int>();
        
        int value = -1;

        while (value != 0)
        {
            string userValue = Console.ReadLine();
            value = int.Parse(userValue);

            if (value != 0)
            {
                numbers.Add(value);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}


//print("Enter a list of numbers, type 0 when finished.")

//numbers = []
//value = None

//while value != 0:
//    value = int(input("Enter number: "))

//    if value != 0:
//        numbers.append = value

//print()
//print("the numbers are: ")

//for number in numbers:
//    print(number)
