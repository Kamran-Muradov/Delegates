using Delegates_Homework.Helpers.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Homework.Helpers.Extensions
{
    internal static  class MathExtension
    {
        public static int FactorialOfNumber(this int number)
        {
            int result = 1;
            if (number < 0 )
            {
                throw new CustomMathExceptopions("Number cannot be negative");
            }
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
