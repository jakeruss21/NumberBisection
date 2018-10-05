using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int target;
            Random rand = new Random();
            UserTargetInput userInput = new UserTargetInput();

            int[] arrlist1 = new int[10];

            for(int i = 0; i < arrlist1.Length; i++)
            {
                arrlist1[i] = i + 1;
            }

            target = userInput.InputTarget(arrlist1.Length);

            INumberFinder cpuFinder = new CompNumberFinder();
            cpuFinder.FindNumber(arrlist1, target);

            int[] arrList2 = new int[100];
            for(int i = 0; i < arrList2.Length; i++)
            {
                arrList2[i] = i + 1;
            }

            target = rand.Next(1, arrList2.Length);

            UserFindsTheNumber userFinder = new UserFindsTheNumber();
            userFinder.LookForNumber(arrList2, target);

        }
    }
}
