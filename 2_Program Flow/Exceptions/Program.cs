using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Let's say we want to divide x by y
            int x = 999; // numerator
            int y = 0;  // denominator
            int result;

            // The try block contains the code that *might* throw an exception (error)
            try
            {
                // We check if x is greater than 1000 — if so, we throw a custom error
                if (x > 1000)
                {
                    // Throw a specific error if x is too large
                    throw new ArgumentOutOfRangeException("x", "x has to be 1000 or less");
                }

                // Attempt the division
                result = x / y;

                // If successful, show the result
                Console.WriteLine("The result is: {0}", result);
            }
            // This catch block handles errors where division by zero is attempted
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Whoops! You tried to divide by zero.");
                Console.WriteLine("Error message: " + e.Message);
            }
            // This catch block handles the custom error we threw above
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Sorry, the number is too large.");
                Console.WriteLine("Error message: " + e.Message);
            }
            // The finally block always runs — even if an error occurs
            finally
            {
                Console.WriteLine("This code always runs — cleanup, logging, etc.");
            }
        }
    }
}
