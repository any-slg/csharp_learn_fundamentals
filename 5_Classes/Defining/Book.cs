using System;

namespace Defining
{
    // A class in C# is a blueprint for creating objects (instances).
    // Classes can contain fields (variables), methods (functions), and constructors.
    
    public class Book
    {
        // Member variables (fields) to hold the data for each book.
        // These fields are private by default and should generally be encapsulated
        // by properties or methods for better maintainability.
        private string _name;
        private string _author;
        private int _pagecount;

        // A constructor is used to initialize new objects. 
        // It is called when the 'new' keyword is used to create an instance of the class.
        // The constructor allows us to set values for the fields when creating the object.
        public Book(string name, string author, int pages)
        {
            _name = name;   // Assign 'name' parameter to '_name' field
            _author = author; // Assign 'author' parameter to '_author' field
            _pagecount = pages; // Assign 'pages' parameter to '_pagecount' field
        }

        // A method is used to define behavior on the object.
        // Here, we have a method that returns a description of the book.
        public string GetDescription()
        {
            // This method uses string interpolation to create a string with the book's name and author.
            return $"{_name} by {_author}";
        }

        // TIP: Fields like '_name', '_author', and '_pagecount' are private and can only be accessed 
        // within the class. Public methods (like GetDescription) provide controlled access to them.
    }
}
