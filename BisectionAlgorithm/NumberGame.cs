using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
namespace BisectionAlgorithm
{
    class NumberGame
    {
        public void GetResponse()
        {
            int arraySize = 0;
            Console.WriteLine("Please enter the size of the Array");
            int userResponse = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Please guess a number between 0 and {userResponse}");
            int userGuess = Convert.ToInt32(Console.ReadLine());

            int[] myarray = null;
            arraySize = userResponse;
            myarray = new int[arraySize];

            Random random = new Random();
            int randomNumber = random.Next(arraySize);

            do
            {
                if (userGuess > randomNumber)
                {
                    Console.WriteLine("You have guessed High, Please guess again.");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                }

                if (userGuess < randomNumber)
                {
                    Console.WriteLine("You have guessed Low, Please guess again.");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                }

                if (userGuess == randomNumber)
                {
                    Console.WriteLine($"Great Job!!! The number was {randomNumber}");
                    for (int i = 0; i <= arraySize; i++)
                    {
                        Console.WriteLine("Value of i: {0}", i);
                    }
                    break;
                }
            }
            while (userGuess != randomNumber);
        }
    }
}*/

namespace BisectionAlgorithm2
{
    class NumberGame2
    {
        public void GetResponse()
        {
            int guessAgain = 0;
            int guessCounter = 1;
            int highLow = 0;

            Console.WriteLine("Starting Number?");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ending Number?");
            int end = Convert.ToInt32(Console.ReadLine());

            List<int> numberList = new List<int>() { };

            Console.WriteLine($"Please enter a number between {start} and {end} and I will attemt to guess it");
            int myNumber = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int computerRandom = random.Next(start, end);

            Console.WriteLine($"Is your number {computerRandom}?");
            guessAgain = Convert.ToInt32(Console.ReadLine());

            guessCounter++;
            Console.Clear();
            while (computerRandom != myNumber)
            {
                Random newRandom = new Random();
                computerRandom = random.Next(start, end);

                if (guessAgain == 1)
                {
                    Console.WriteLine($"I will a guess again. This is guess number {guessCounter}, is your number {computerRandom}?");
                    guessAgain = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter 1 if my number is HIGHER or 2 if my number is LOWER");
                    highLow = Convert.ToInt32(Console.ReadLine());

                    if (highLow == 1)
                    {
                        numberList.RemoveRange(computerRandom, end);
                        foreach (int i in numberList)
                        {
                            Console.WriteLine(i);
                        }
                    }

                    /*if (highLow == 2)
                    {
                        Console.WriteLine($"Awesome!!!, It took me {guessCounter} guesses to figure out your number");
                        break;
                    }*/

                }


            }
        }
    }
}











