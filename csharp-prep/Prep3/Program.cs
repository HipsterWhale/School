using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the number guessing game.\nGuess a number between 0 and 100. ");

        string response = "yes";
        while (response.ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0, 101);
            int guess = number + 1;
            int guess_counter = 0;

            while (number != guess)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guess_counter += 1;

                if (guess > number)
                {Console.WriteLine("Lower");}

                if (guess < number)
                {Console.WriteLine("Higher");}
            }

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {guess_counter} guesses.");
            Console.Write("Would you like to play again? ");
            response = Console.ReadLine();
        }
        Console.Write("Ok. Goodbye.");
    }
    }