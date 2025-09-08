using System;

namespace StringRep {
    class Book {
        // Automatic properties to store book details
        public string Name { get; set; } // Name of the book
        public string Author { get; set; } // Author of the book
        public int PageCount { get; } // Read-only property for page count (set only via constructor)

        // Constructor to initialize a new Book object with name, author, and page count
        public Book(string name, string author, int pages) {
            Name = name;
            Author = author;
            PageCount = pages; // Initialize the page count
        }

        // Override ToString() to provide a custom string representation of the Book object
        // This is the default string format when calling ToString()
        public override string ToString() {
            return $"Book: {Name} by {Author}"; // Simple format showing Name and Author
        }

        // Overloaded ToString method allows different formats for string representation
        // This version takes a 'format' character as input and returns a custom string based on it
        // This is NOT an override; it's a new method with the same name (method overloading)
        public string ToString(char format) {
            if (format == 'B') {
                return $"Book: {Name}:{Author}"; // Short format for Book with Name and Author
            }
            else if (format == 'F') {
                return $"Book: {Name} by {Author} is {PageCount} pages"; // Full format with PageCount
            }
            else {
                return ToString(); // Default format (calls the overridden ToString method if format is not recognized)
            }
        }
    }
}
