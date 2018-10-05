using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessANumber
{
    class UserFindsTheNumber
    {
        public void LookForNumber(int[] arrList, int target)
        {
            int userGuess;
            bool guessRight = false;
            int counter = 0;

            Console.WriteLine($"I have chosen a number between 1 and {arrList.Length}.  Let's see how quickly you can find it");
            Console.WriteLine("I'll tell you if your number is higher or lower than my number.");

            do
            {
                Console.WriteLine($"Enter a number between 1 and {arrList.Length}");
                userGuess = UtilityHandler.ErrorHandler(arrList.Length);

                guessRight = FindNumber(target, userGuess);
                counter++;

            } while (!guessRight);

            Console.WriteLine($"Congratulations! You found the correct number in {counter} guesses!");
        }



        private bool FindNumber(int target, int userGuess)
        {
            bool guessRight;

            if(userGuess < target)
            {
                Console.WriteLine("Your guess is too low.");
                guessRight = false;
            }
            else if(userGuess > target)
            {
                Console.WriteLine("Your guess is too high.");
                guessRight = false;
            }
            else
            {
                guessRight = true;
            }

            return guessRight;
        }
    }
}
