﻿using System;
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
            int target = 10;
            int[] arrlist1 = new int[10];

            for(int i = 0; i < arrlist1.Length; i++)
            {
                arrlist1[i] = i + 1;
            }

            INumberFinder cpuFinder = new CompNumberFinder();
            cpuFinder.FindNumber(arrlist1, target);




        }
    }
}
