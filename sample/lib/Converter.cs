using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample
    .lib
{
    static public class Converter
    {
        static public string IntegerToWordedString(int number)
        {
            if (number == 1)
            {
                return "one";
            }
            else if (number == 2)
            {
                return "two";
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}