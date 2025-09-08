using System;

namespace Modifiers
{
    // Access modifiers control how properties and methods can be accessed from other classes.
    // They are an important part of Object-Oriented Programming (OOP) because they provide encapsulation,
    // protecting the internal data of a class from direct manipulation.

    class Book
    {
        // Public members and methods can be accessed from anywhere, including outside the class.
        // In this case, '_name' can be modified directly by any code that has access to a 'Book' instance.
        // However, exposing fields directly like this is generally considered bad practice.
        // Instead, it's better to use **properties** or methods to control access to fields.
        public string _name;

        // Protected members can only be accessed within the class itself and by derived classes.
        // This allows a class to control access while allowing child classes to inherit and access this data.
        protected string _author;

        // Private members can only be accessed within the class itself.
        // This is the most restrictive modifier and is the default for fields in C#.
        private int _pagecount;

        // Constructor: Initializes the fields of the 'Book' class with the provided values.
        public Book(string name, string author, int pages) {
            _name = name;
            _author = author;
            _pagecount = pages;
        }

        // Method: Returns a description of the book in a formatted string.
        public string GetDescription() {
            return $"{_name} by {_author}, {_pagecount} pages";
        }

        // Getter method for '_name'. Public methods provide controlled access to private fields.
        public string GetName() {
            return _name;
        }

        // Setter method for '_name'. This allows controlled modification of the field.
        public void SetName(string s) {
            _name = s;
        }

        // Setter method for '_author'. Even though '_author' is protected, it's a good practice to allow
        // controlled changes via a setter.
        public void SetAuthor(string s) {
            _author = s;
        }

        // Setter method for '_pagecount'. Even though this field is private, we allow modifying it
        // via a setter method.
        public void SetPagecount(int c) {
            _pagecount = c;
        }
    }
}
