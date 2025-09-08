using System;

namespace MultiValues
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tuples are a lightweight way to group multiple values together.
            // Tuples were introduced in C# 7.0, providing a simple way to store heterogeneous data.

            // Create a tuple using explicit naming of elements
            // 'tup1' has two elements: 'a' and 'b', both of type 'int'
            (int a, int b) tup1 = (5, 10);  // Tuple with named elements
            // Use 'var' for type inference. C# will determine the type based on the values.
            var tup2 = ("Some text", 10.5); // Tuple with implicit naming of Item1, Item2

            // TIP: Tuples are mutable, meaning you can modify their elements after creation
            tup1.b = 20;                  // Changing the second element of 'tup1' from 10 to 20
            tup2.Item1 = "New String";    // Modifying the first element of 'tup2' (the string)

            // Printing tuple values to console
            Console.WriteLine($"{tup1.a}, {tup1.b}");        // Output: 5, 20
            Console.WriteLine($"{tup2.Item1}, {tup2.Item2}"); // Output: New String, 10.5

            // Functions can return tuples to return multiple values from a single function
            // The PlusTimes function returns a tuple of the sum and product of two integers.
            (int, int) result = PlusTimes(6, 12);  // 'result' stores a tuple with sum and product
            Console.WriteLine($"Sum: {result.Item1}, Product: {result.Item2}");  // Output: Sum: 18, Product: 72
        }

        // Function that returns a tuple with two elements: the sum and the product of the inputs
        static (int, int) PlusTimes(int a, int b) {
            // Returning both sum and product as a tuple
            return (a + b, a * b);
            // TIP: You can return a tuple directly from a function without needing to create a separate variable.
        }
    }
}
