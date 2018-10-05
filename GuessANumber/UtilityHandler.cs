using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessANumber
{
    class UtilityHandler
    {
        public static int ErrorHandler(int numOptions)
        {
            Boolean answer = false;
            int option = 0;

            do
            {
                do
                {

                    try
                    {
                        option = int.Parse(Console.ReadLine());
                        answer = true;
                    }
                    catch (Exception)
                    {
                        Console.Write("Please enter a valid option:  ");
                        answer = false;
                    }
                } while (answer == false);

                if (option < 0 || option > numOptions)
                {
                    Console.Write("Please enter a valid option:  ");
                }
                else { }
            } while (option < 0 || option > numOptions);

            return option;
        }

    }
}
