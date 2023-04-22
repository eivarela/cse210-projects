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
        int guess_count = 1;
        
        while (guess != number)
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);

            if (guess < number)
            {
                Console.WriteLine("Higher");
                guess_count += 1;

            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
                guess_count += 1;
            }
        } 
        guess = number;
        Console.WriteLine("You guessed it!");
        Console.Write($"You made {guess_count} guesse(s).");

        Console.Write("Do you want to play again? (YES/NO) ");
        string try_again = Console.ReadLine();
        try_again = try_again.ToLower();

        while (try_again == "yes")
        {
            number = randomGenerator.Next(1, 100);
            guess = -1;
            guess_count = 1;

            while (guess != number)
            {
                Console.Write("What is your guess? ");
                string userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);

                if (guess < number)
                {
                    Console.WriteLine("Higher");
                    guess_count += 1;

                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                    guess_count += 1;
                }
            } 
            guess = number;
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"You made {guess_count} guesse(s).");
            Console.WriteLine("Do you want to play again? (YES/NO) ");
            try_again = Console.ReadLine();
            try_again = try_again.ToLower();

        }
        try_again = "no";
        Console.WriteLine("Thanks for playing");
    }
}
