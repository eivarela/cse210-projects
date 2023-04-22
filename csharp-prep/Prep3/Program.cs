using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        //Console.Write("What is the magic number? ");
        //string userMagicNumber = Console.ReadLine();
        //int magicNumber = int.Parse(userMagicNumber);

        int guess = -1;
        
        while (guess != number)
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);

            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
        } 
        guess = number;
        Console.Write("You guessed it!");

    }
}
