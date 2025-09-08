using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Book and Magazine, which are subclasses of Publication
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825, 39.95m);
            Magazine m1 = new Magazine("Time", "Time USA, LLC", 75, 4.95m);

            // Output basic information of the Book and Magazine
            Console.WriteLine($"{b1.Name}, {b1.Author}"); // Output Book name and author
            Console.WriteLine($"{m1.Name}, {m1.Publisher}"); // Output Magazine name and publisher

            // Uncommenting the next line would throw an exception due to name validation
            // b1.Name = ""; // This line would throw an exception if uncommented

            // Call the overridden GetDescription method for both Book and Magazine
            Console.WriteLine(b1.GetDescription()); // Calls the Book version of GetDescription
            Console.WriteLine(b1.Price);            // Accesses the Price property from the base class
            Console.WriteLine(m1.GetDescription()); // Calls the Publication version for Magazine
            Console.WriteLine(m1.Price);            // Accesses the Price property from the base class
        }
    }
}
