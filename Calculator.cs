using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleCalculator
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN;  // Default value is "Not-a-number" if an operation, such as division, could result in an error.

            // Use a switch statement to do math.
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisior.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
            }
            return result;
        }
    }
}
