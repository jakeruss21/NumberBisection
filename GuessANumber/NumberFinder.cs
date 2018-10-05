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
                    Console.WriteLine("You found the number!");
                    Console.WriteLine($"It is the number {target}");
                }

            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}
