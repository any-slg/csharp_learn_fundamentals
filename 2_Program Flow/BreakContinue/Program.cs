using System;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            // ✅ Scenario:
            // You're organizing a line of people for a game. Each person has a number (like their age or ticket number). You want to:
            // Skip people whose numbers are between 20 and 29 → (using continue)
            // Stop checking completely if someone’s number is 40 or higher → (using break)

            // These are the numbers we’ll check (could represent ages, scores, etc.)
            int[] numbers = { 15, 7, 12, 23, 41, 28, 9, 17, 36 };

            Console.WriteLine("Demonstrating 'break' and 'continue' in a loop:");

            // Loop through each number in the array
            foreach (int number in numbers)
            {
                // If the number is between 20 and 29, we skip it
                if (number >= 20 && number <= 29)
                {
                    // Skip the rest of this loop and go to the next number
                    Console.WriteLine("Found a number between 20 and 29, so skipping and going to next number");
                    continue;
                }

                // Print the number if it wasn't skipped
                Console.WriteLine($"Number is: {number}");

                // If we find a number that's 40 or more, stop the loop completely
                if (number >= 40)
                {
                    Console.WriteLine("Found a number 40 or higher, stopping the loop.");
                    break;
                }
            }
        }
    }
}
