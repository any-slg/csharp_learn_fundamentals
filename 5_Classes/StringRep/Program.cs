using System;

namespace StringRep
{
    class Program
    {
        static void Main(string[] args)
        {
            // Every class in C# inherits from Object, which means every class has the ToString() method
            // ToString() is a default method in the base Object class that can be overridden

            int x = 1000;
            Console.WriteLine(x.ToString()); // Calls the integer's ToString() method (outputs "1000")

            // If you don't override the ToString() method in your class, it defaults to the base Object class behavior
            object a = new object();
            Console.WriteLine(a.ToString()); // Default behavior: Prints the fully qualified name of the object class, e.g., "System.Object"

            // Create a new Book object
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);

            // Call ToString() on the Book object
            Console.WriteLine(b1.ToString()); // Calls the overridden ToString method - outputs "Book: War and Peace by Leo Tolstoy"

            // The following line also implicitly calls the ToString() method without explicitly typing it out
            Console.WriteLine(b1); // Outputs the result of ToString() implicitly

            // Call the overloaded ToString method with different format specifiers
            Console.WriteLine(b1.ToString('B')); // Outputs "Book: War and Peace:Leo Tolstoy" (short format with Name and Author)
            Console.WriteLine(b1.ToString('F')); // Outputs "Book: War and Peace by Leo Tolstoy is 825 pages" (full format with PageCount)
        }
    }
}
