using System;

namespace Defining
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new instances of the 'Book' class using the 'new' keyword.
            // Each book is initialized with its name, author, and page count.
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);
            Book b2 = new Book("The Grapes of Wrath", "John Steinbeck", 464);

            // Call the 'GetDescription' method on each book object to print the book's description.
            // This will print the name and author of each book to the console.
            Console.WriteLine(b1.GetDescription()); // Output: War and Peace by Leo Tolstoy
            Console.WriteLine(b2.GetDescription()); // Output: The Grapes of Wrath by John Steinbeck

            // ERROR: Uncommenting the following line will result in a compiler error
            // because _name is a private field, and direct access is not allowed outside the class.
            // b1._name = "Aldous Huxley"; // This will cause a compiler error!

            // TIP: You can control access to class fields through **properties** (getters and setters),
            // but direct modification of private fields is not allowed outside the class. 
            // This is a key concept of **encapsulation** in OOP (Object-Oriented Programming).
        }
    }
}

/*
🔍 Key Concepts and Explanations:

1. Classes and Objects:

A class is a blueprint for creating objects. It defines properties and methods that can operate on the data.

An object is an instance of a class. It contains real data and can use the methods defined in the class.

2.Fields:

Fields (or member variables) store data for an object. In the example, _name, _author, and _pagecount are fields of the Book class.

Encapsulation: Fields are usually private (or protected) to protect them from direct access. This enforces the idea of data hiding, ensuring the data is only accessible through methods or properties.

3.Constructor:

A constructor is a special method that is automatically called when an object is created.

It initializes the object's fields. In the example, the constructor accepts parameters for the book's name, author, and page count and assigns these values to the private fields.

4.Methods:

Methods define behaviors or actions that can be performed on an object.

In this case, the GetDescription method returns a formatted string with the book's name and author.

5.Access Modifiers:

Private fields cannot be accessed directly outside the class. This is an important aspect of encapsulation.

To allow controlled access, you could expose public properties or methods that let you interact with the private fields.

6.Best Practices:

Private Fields: Use private fields to encapsulate the data and protect it from direct external modification.

Constructors: Ensure constructors are clear and concise. Only include parameters that are essential for initializing the object.

Method Design: Methods should be designed to operate on object data and return meaningful results, as seen with GetDescription.

Further Enhancements:

7.Properties: Instead of directly accessing private fields, you can expose properties to allow for controlled access to data. Here's an example:

public string Name
{
    get { return _name; }
    set { _name = value; }
}

Method Overloading: You can define multiple constructors with different parameter signatures if needed.

*/