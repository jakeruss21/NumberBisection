using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessANumber
{
    class CompNumberFinder : INumberFinder
    {
        public void FindNumber(int[] arr, int target)
        {
            int midpoint;
            int first = 0;
            int last = arr.Length;
            bool found = false;
            

            while(!found)
            {
                midpoint = (first + last) / 2;

                if(target < midpoint)
                {
                    last = midpoint - 1;
                    Console.WriteLine($"{midpoint} is too high");
                }
                else if(target > midpoint)
                {
                    first = midpoint + 1;
                    Console.WriteLine($"{midpoint} is too low");
                }
                else
                {
                    found = true;
                    Console.WriteLine("I found your number!");
                    Console.WriteLine($"Your number is the number {target}");
                }

            }

            Console.ReadLine();
            Console.Clear();
        }

        public void UserHelpFindNumber(int[] arr, int target)
        {
            int first = 0;
            int last = arr.Length;
            int midpoint;
            string answer = "";
            bool found = false;
            int counter = 0;

            Console.WriteLine("I will guess what number you chose, you tell me whether it is 'High', 'Low', or 'Correct'...");

            do
            {
                midpoint = (first + last) / 2;
                Console.WriteLine($"Is your number {midpoint}?\nEnter: High, Low, or Correct");
                answer = Console.ReadLine();

                while (answer != "High" || answer != "Low" || answer != "Correct")
                {
                    Console.WriteLine("The answer is case-sensative.  Please enter 'High', 'Low', or 'Correct'.");
                    answer = Console.ReadLine();
                }

                if (answer == "High")
                {
                    first = midpoint + 1;
                    found = false;
                }
                else if (answer == "Low")
                {
                    last = midpoint - 1;
                    found = false;
                }
                else if (answer == "Correct")
                {
                    found = true;
                }

                counter++;
            } while (!found);

            Console.WriteLine($"Hooray! I found your number after {counter} tries.");
        }
    }
}
