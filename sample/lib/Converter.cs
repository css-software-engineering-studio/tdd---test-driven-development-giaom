using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample
    .lib
{
    static public class Converter
    {
        private static readonly string[] Ones = {
        "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
        "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
        };
        private static readonly string[] Tens = {
        "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"
        };


        static public string IntegerToWordedString(int number)
        {
            if (number < 0 || number > 9999)
            {
                throw new NotImplementedException("Number must be between 0 and 9999");
                //throw new ArgumentOutOfRangeException("Number must be between 0 and 9999");
            }
            /* // zero no longer edge case, but part of the "Ones" array
            if (number == 0)
            {
                return "zero";
            } */

            return ConvertNumberToWords(number);
        }

        // returns string
        private static string ConvertNumberToWords(int number)
        {
            string words = "";

            // Handle tens

            if (number < 20)
            {
                words += Ones[number]; // Handle numbers from 1 to 19
            }
            else
            {
                words += Tens[number / 10]; // Handle multiples of ten (20, 30, ..., 90)
                if ((number % 10) > 0)
                {
                    words += "-" + Ones[number % 10]; // Handle ones after tens
                }
            }

            return words;
        }
    }
}