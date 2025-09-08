using System;

namespace Properties
{
    // A class that represents a Book, containing fields, properties, and methods
    class Book
    {
        // Backing fields for properties - private fields to store internal data
        private string _name;
        private string _author;
        private int _pagecount;

        // Constructor initializes a Book object with name, author, and page count
        public Book(string name, string author, int pages) {
            _name = name;
            _author = author;
            _pagecount = pages;
        }

        // Property: 'Name' gives external access to the private _name field
        // Using getter and setter methods
        public string Name {
            get {
                return _name;  // Retrieve the value of '_name'
            }
            set {
                _name = value;  // Set the value of '_name'
            }
        }

        // Property: 'Author' provides access to the private '_author' field
        // The shorthand syntax (expression-bodied) is used for simplicity
        public string Author {
            get => _author;  // Returns '_author'
            set => _author = value;  // Sets '_author' to the given value
        }

        // Property: 'Pagecount' provides access to the private '_pagecount' field
        public int Pagecount {
            get => _pagecount;  // Returns '_pagecount'
            set => _pagecount = value;  // Sets '_pagecount'
        }

        // A read-only computed property: 'Description' combines other properties
        // The 'Description' is derived from the Name, Author, and Pagecount properties.
        // It doesn't have a setter because it doesn't need to store any value.
        public string Description {
            get => $"{Name} by {Author}, {Pagecount} pages";  // Concatenate book details
        }

        // Auto-implemented property: No backing field, compiler generates it automatically
        // Allows direct get/set access to ISBN and Price without a backing field.
        public string ISBN { get; set; }  // Auto-implemented property for ISBN
        public decimal Price { get; set; }  // Auto-implemented property for Price
    }
}
