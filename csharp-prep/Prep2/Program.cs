using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();

        int gradePercentage = int.Parse(userInput);
        int lastDigit = gradePercentage % 10;
      
        string letter;
        string sign = null;
        string message = null;
        
        if (gradePercentage >= 90)
        {
            letter = "A";

        }
        else if (gradePercentage >= 80 && gradePercentage < 90)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70 && gradePercentage < 80)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60 && gradePercentage < 70)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        
        if (gradePercentage >= 70)
        {
            message = "congratulations, you did it!";
        }
        else
        {
            message = "better Luck next time";
        }

        if (letter == "A" && sign == "+" || letter == "F" && sign == "+" || letter == "F" && sign == "-")
        {
            sign = "";
        }

        Console.Write($"Your grade is ({letter}{sign}) {message}.");
    
    }
}