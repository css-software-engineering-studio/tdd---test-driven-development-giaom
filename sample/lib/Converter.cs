// cd to correct file, then run: dotnet run, cd .., git add . && git commit -m "message" && git push. 
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
        "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
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

            // made 0 an edge case to avoid "thosand zero" like errors. 
            if (number == 0)
            {
                return "zero";
            }

            return ConvertNumberToWords(number);
        }

        // Helper function to handle 0-19
        private static string ConvertNumberToWords(int number)
        {
            string words = "";

            // Handle thousands
            if ((number / 1000) > 0)
            {
                words += Ones[number / 1000] + " thousand";
                number %= 1000; // Remove thousands from number
                if ((number > 0) && (number < 100)) words += " and "; // Add 'and' if there are more digits
            }

            // Handle hundreds
            if ((number / 100) > 0)
            {
                words += Ones[number / 100] + " hundred";
                number %= 100; // Remove hundreds from number
                if (number > 0) words += " and "; // Add 'and' if there are more digits
            }

            if (number < 20)
            {
                words += Ones[number - 1]; // Handle numbers from 1 to 19
            }
            else
            {
                words += Tens[number / 10]; // Handle multiples of ten (20, 30, ..., 90)
                if ((number % 10) > 0)
                {
                    words += "-" + Ones[(number % 10) - 1]; // Handle ones after tens
                }
            }

            return words;
        }
    }
}