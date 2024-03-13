using Delegates_Homework.Helpers.Exceptions;
using Delegates_Homework.Helpers.Extensions;

namespace Delegates_Homework.Controllers
{
    internal class CalculationController
    {
        public void GetFactorial()
        {
            try
            {
                int number = -5;
                Console.WriteLine(number.FactorialOfNumber());
            }
            catch (CustomMathExceptopions ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
