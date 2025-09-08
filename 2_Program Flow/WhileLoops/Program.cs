using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // This will store whatever the user types
            string userInput = "";

            // --- 1. Basic while loop ---
            Console.WriteLine("=== Basic while() loop ===");
            Console.WriteLine("Type something (type 'exit' to quit):");

            // This loop keeps running *as long as* the user hasn't typed "exit"
            while (userInput != "exit")
            {
                // Read user input from the console
                userInput = Console.ReadLine();

                // Echo back the input
                Console.WriteLine("You entered: {0}", userInput);
            }

            Console.WriteLine(); // Blank line for spacing


            // --- 2. do-while loop ---
            Console.WriteLine("=== do-while() loop ===");
            Console.WriteLine("Type something (type 'exit' to quit):");

            // In a do-while loop, the code inside the loop runs *at least once*
            // even if the condition is false from the beginning
            do
            {
                userInput = Console.ReadLine();
                Console.WriteLine("You entered: {0}", userInput);
            }
            while (userInput != "exit");

            Console.WriteLine(); // End of program
        }
    }
}
