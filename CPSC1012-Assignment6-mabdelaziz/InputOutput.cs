// File:    InputOutput.cs
// Purpose: Display boxes and ask for length

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC1012_Assignment6_mabdelaziz
{
    class InputOutput
    {
        public static void DisplayBox(int length)
        {
            // code the outer loop
            for (int outerCounter = 1; outerCounter <= length; outerCounter++)
            {
                // code the inner loop
                for (int innerCounter = 1; innerCounter < length; innerCounter++)
                {
                    // specify edges and inner
                    if (innerCounter == 1 && outerCounter != 1 && outerCounter != length)
                    {
                        Console.Write("|");
                    }
                    else if (outerCounter == 1 || outerCounter == length)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                } // end of inner loop
                // specify top/bottom or side
                if (outerCounter == 1 || outerCounter == length)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("|");
                }
            } //  end of outer loop
        }

        public static void DisplayBox(int length, char fillChar)
        {
            // code the outer loop
            for (int outerCounter = 1; outerCounter <= length; outerCounter++)
            {
                // code the inner loop
                for (int innerCounter = 1; innerCounter < length; innerCounter++)
                {
                    // specify edges and inner
                    if (innerCounter == 1 && outerCounter != 1 && outerCounter != length)
                    {
                        Console.Write("|");
                    }
                    else if (outerCounter == 1 || outerCounter == length)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write("{0}", fillChar);
                    }
                } // end of inner loop
                // specify top/bottom or side
                if (outerCounter == 1 || outerCounter == length)
                {
                    Console.WriteLine("-");
                }
                else
                {
                    Console.WriteLine("|");
                }
            } //  end of outer loop
        }

        public static int GetLength(string prompt)
        {
            // declare variables
            int intValue;
            bool inputIsValid = false;
            string errorMessage = "*** Invalid length {0}.";

            // loop to determine whether length is valid
            do
            {
                // ask for and capture an char value
                Console.Write(prompt);

                // loop to determine whether the input is a number
                while (!int.TryParse(Console.ReadLine().Trim(), out intValue))
                {
                    Console.WriteLine(errorMessage, intValue);
                    Console.Write(prompt);
                }
                if (intValue <= 0)
                {
                    Console.WriteLine(errorMessage, intValue);
                }
                else
                {
                    inputIsValid = true;
                }
            } while (inputIsValid == false);

            return intValue;
        }
    }
}
