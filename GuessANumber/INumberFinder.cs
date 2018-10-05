using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessANumber
{
    interface INumberFinder
    {

        void FindNumber(int[] arr, int target);
        void UserHelpFindNumber(int[] arr, int target);

    }
}
