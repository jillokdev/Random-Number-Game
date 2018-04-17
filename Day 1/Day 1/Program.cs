using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber;
            string secondNumber;
            string guessedNumber;
            

            Console.Write("First Number: ");

            firstNumber = Console.ReadLine();

            Console.Write("Second Number: ");

            secondNumber = Console.ReadLine();

            Console.WriteLine("Guess a number between " + firstNumber + " and " + secondNumber);

            guessedNumber = Console.ReadLine();

            // Converting Strings to Int. 
            int intFirstNumber = int.Parse(firstNumber);
            int intSecondNumber = int.Parse(secondNumber);
            int intGuessedNumber = int.Parse(guessedNumber);

            // Creating a random number between FirstNumber and SecondNumber.
            Random rnd = new Random();
            int random = rnd.Next(intFirstNumber, intSecondNumber);

            // Looping if GuessedNumber is inequal to random. 
            while (intGuessedNumber != random)
            {
                if(intGuessedNumber < intFirstNumber || intGuessedNumber > intSecondNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\nThe Number can not be less than " + intFirstNumber + " or greater than " + intSecondNumber);
                }

                random = rnd.Next(intFirstNumber, intSecondNumber);

                if (intGuessedNumber != random)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\nWrong, try again.");
                }

                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine("Guess a number between " + firstNumber + " and " + secondNumber);

                guessedNumber = Console.ReadLine();

                intGuessedNumber = int.Parse(guessedNumber);

                
            }

            if (intGuessedNumber == random)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\nCongratulation, the number was " + intGuessedNumber);
            }

            Console.ReadKey();

        }
    }
}
