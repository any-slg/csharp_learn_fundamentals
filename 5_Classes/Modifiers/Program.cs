using System;

namespace Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the 'Book' class using the constructor
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);

            // Directly accessing the public field '_name' is allowed (but not recommended).
            b1._name = "Aldous Huxley";
            Console.WriteLine(b1.GetDescription());  // Output: Aldous Huxley by Leo Tolstoy, 825 pages

            // Accessing and modifying protected/private fields directly is **not allowed**.
            // Trying to directly access '_author' or '_pagecount' will cause a compiler error.

            // Use setter methods to modify fields with private or protected access modifiers.
            b1.SetName("Grapes of Wrath");
            b1.SetAuthor("John Steinbeck");
            b1.SetPagecount(464);
            Console.WriteLine(b1.GetDescription());  // Output: Grapes of Wrath by John Steinbeck, 464 pages
        }
    }
}

/*

🔍 Key Concepts and Explanations:

1.Access Modifiers:

Public: Members declared as public can be accessed from anywhere, both inside and outside the class. In this example, _name is public, so it can be directly accessed.

Protected: Members declared as protected can be accessed within the class and by any class that inherits from it (i.e., derived classes). In this example, _author is protected, meaning it is accessible inside the class and any subclass of Book.

Private: Members declared as private can only be accessed inside the class. _pagecount is private, and any attempt to access it directly from outside the class will cause a compiler error.

2.Encapsulation:

Encapsulation is a fundamental OOP concept where the internal state of an object is hidden from the outside world. You can control access to it using methods or properties. This helps in preventing the direct modification of an object’s internal state.

3.Why not make everything public?:

Making fields public exposes the internal structure of a class to external code, which can lead to data being modified in unpredictable or unintended ways. Using private or protected fields and providing methods to access or modify the data is a safer approach.

4.Using Methods to Access Data:

Instead of accessing fields directly, the recommended approach is to use getter and setter methods or properties. This ensures that data access and modification are controlled, allowing for validation, logging, or other logic when necessary.

5.Best Practices:

Public fields should generally be avoided unless absolutely necessary. Use properties (getters/setters) or methods to control access to fields.

Use private fields to ensure encapsulation and protect the data from unintended changes.

Protected fields are useful when creating base classes for inheritance and want derived classes to access certain data but not expose it publicly.

💡 Further Improvements:

Using Properties Instead of Fields:
Instead of using methods like GetName and SetName, you can use properties for cleaner and more idiomatic C# code.
public string Name { get; set; }


Readonly and Const:
If some fields should never change once they are set, you can use the readonly modifier for fields that should be set only during initialization, and const for constant values that are known at compile-time.

*/