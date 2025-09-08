using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is the number we'll use as the upper limit in our first loop
            int maxCount = 15;

            // This is an array (list) of some favorite numbers
            int[] favoriteNumbers = new int[] { 3, 14, 15, 92, 6 };

            // This is a sample sentence where we'll count how many times 'o' appears
            string sentence = "The quick brown fox jumps over the lazy dog";

            // --- 1. Basic for loop ---
            Console.WriteLine("Using a 'for' loop to count up to a number:");

            // This loop starts at 0, and goes up to (but not including) maxCount (15)
            for (int i = 0; i < maxCount; i++)
            {
                Console.WriteLine("Number: {0}", i);
            }

            Console.WriteLine(); // Just adds a blank line for readability


            // --- 2. Foreach loop to go through an array ---
            Console.WriteLine("Using a 'foreach' loop to go through favorite numbers:");

            // This loop goes through each number in the array one by one
            foreach (int number in favoriteNumbers)
            {
                Console.WriteLine("Favorite number: {0}", number);
            }

            Console.WriteLine(); // Another blank line


            // --- 3. Count how many times 'o' appears in a sentence ---
            Console.WriteLine("Counting how many times 'o' appears in the sentence:");

            // We'll use a counter variable to keep track
            int oCount = 0;

            // Loop through each character in the sentence
            foreach (char letter in sentence)
            {
                // Check if the current letter is the lowercase letter 'o'
                if (letter == 'o')
                {
                    oCount++; // Increase the counter by 1
                }
            }

            // After the loop, print the total count
            Console.WriteLine("The letter 'o' appears {0} times.", oCount);
        }
    }
}
