using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisectingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool play = true;
                do
                {
                    Console.WriteLine("Welcome to the number guessing game!\n" +
                        "What would you like to do?\n" +
                        "1. Bisecting algorithm example\n" +
                        "2. Guess the computer's number.\n" +
                        "3. Have the computer guess your number.");
                    string input = Console.ReadLine();
                    if (input == "1")
                    {
                        BisectExample();
                    }
                    if (input == "2")
                    {
                        UserPlays();
                    }
                    if (input == "3")
                    {
                        ComputerPlays();
                    }
                    Console.WriteLine("Would you like to play again?\n" +
                        "Type 'y' for Yes.\n" +
                        "Type 'n' for No.");
                    string newInput = Console.ReadLine();
                    newInput.ToLower();
                    if (newInput == "y")
                    {
                        play = true;
                    }
                    else if (newInput == "n")
                    {
                        play = false;
                    }
                } while (play);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an appropriate value!");
            }
        }

        private static void BisectExample()
        {
            Random random = new Random();
            int[] range = new int[10];
            int randomNumber = random.Next(range.Length);
            for (int i = 0; i < range.Length; i++)
            {
                range[i] = i + 1;
            }
            int guess;
            int numberOfGuesses = 3;
            int length = range.Length;
            bool gameOver = false;
            try
            {
                while (gameOver == false)
                {
                    Console.WriteLine($"Guess a number between 1-{length}");
                    guess = Convert.ToInt32(Console.ReadLine());
                    numberOfGuesses--;

                    if (guess != randomNumber && numberOfGuesses == 0)
                    {
                        Console.WriteLine("You ran out of guesses! You lose!");
                        Console.WriteLine($"You have {numberOfGuesses} guess left!");
                        Console.WriteLine($"The correct answer was {randomNumber}.");
                        gameOver = true;
                    }
                    else if (guess == randomNumber)
                    {
                        Console.WriteLine("That is the correct number!");
                        Console.WriteLine($"You have {numberOfGuesses} guess left!");
                        gameOver = true;
                    }
                    else if (guess > randomNumber)
                    {
                        Console.WriteLine("Your guess is too big!");
                        Console.WriteLine($"You have {numberOfGuesses} guess left!");
                        gameOver = false;
                    }
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine("Your guess is too small!");
                        Console.WriteLine($"You have {numberOfGuesses} guess left!");
                        gameOver = false;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please type an appropriate value!");
            }
            Console.ReadLine();
        }
        private static void UserPlays()
        {
            Random random = new Random();
            int[] range = new int[1000];
            int randomNumber = random.Next(range.Length);
            for (int i = 0; i < range.Length; i++)
            {
                range[i] = i + 1;
            }
            int guess;
            int numberOfGuesses = 10;
            int length = range.Length;
            bool gameOver = false;
            try
            {
                while (gameOver == false)
                {
                    Console.WriteLine($"Guess a number between 1-{length}");
                    guess = Convert.ToInt32(Console.ReadLine());
                    numberOfGuesses--;

                    if (guess != randomNumber && numberOfGuesses == 0)
                    {
                        Console.WriteLine("You ran out of guesses! You lose!");
                        Console.WriteLine($"You have {numberOfGuesses} guess left!");
                        Console.WriteLine($"The correct answer was {randomNumber}.");
                        gameOver = true;
                    }
                    else if (guess == randomNumber)
                    {
                        Console.WriteLine("That is the correct number!");
                        Console.WriteLine($"You have {numberOfGuesses} guess left!");
                        gameOver = true;
                    }
                    else if (guess > randomNumber)
                    {
                        Console.WriteLine("Your guess is too big!");
                        Console.WriteLine($"You have {numberOfGuesses} guess left!");
                        gameOver = false;
                    }
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine("Your guess is too small!");
                        Console.WriteLine($"You have {numberOfGuesses} guess left!");
                        gameOver = false;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please type an appropriate value!");
            }
            Console.ReadLine();
        }
        private static void ComputerPlays()
        {
            int[] numlist = new int[1000];
            for (int i = 0; i < numlist.Length; i++)
            {
                numlist[i] = i + 1;
            }
            int length = numlist.Length;
            int numberOfGuesses = 10;
            Console.WriteLine($"Enter a number between 1 and {length}. The computer will now use the bisecting algorithm to guess your number correctly!");
            Console.WriteLine($"The computer has {numberOfGuesses} guesses left!");
            int guess = int.Parse(Console.ReadLine());
            bool gameOver = false;
            int split;
            int min = 1;
            try
            {
                while (gameOver == false)
                {
                    split = (min + length) / 2;
                    numberOfGuesses--;

                    if (guess < split )
                    {
                        length = split - 1;
                        Console.WriteLine($"{split} is too high");
                        Console.WriteLine($"The computer has {numberOfGuesses} guesses left!");
                    }
                    else if (guess > split)
                    {
                        min = split + 1;
                        Console.WriteLine($"{split} is too low");
                        Console.WriteLine($"The computer has {numberOfGuesses} guesses left!");
                    }
                    else
                    {
                        gameOver = true;
                        Console.WriteLine($"{guess} is your number");
                        Console.WriteLine($"The computer had {numberOfGuesses} guesses left!");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please type an appropriate value!");
            }

        }
    }
}

