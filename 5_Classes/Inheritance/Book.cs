using System;

namespace Inheritance
{
    // Declare "Book" as a subclass of Publication (inheritance)
    class Book : Publication
    {
        private string _author; // Private field to store the author's name

        // Constructor to initialize a Book object, calling the base class constructor
        // to initialize common properties like name, page count, and price
        public Book(string name, string author, int pagecount, decimal price)
            : base(name, pagecount, price) // Calls the constructor of the base class (Publication)
        {
            _author = author; // Sets the author's name
        }

        // Property to get and set the author's name
        public string Author
        {
            get => _author; // Gets the author's name
            set => _author = value; // Sets the author's name
        }

        // Override the GetDescription method from the base class to customize it for Book
        // This version includes the author's name as well
        public override string GetDescription()
        {
            return $"{Name} by {Author}, {PageCount} pages"; // Returns a description specific to Books
        }
    }
}
