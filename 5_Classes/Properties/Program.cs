using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Book instance and initialize it with values
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);

            // Access the 'Name' property to get the name of the book
            Console.WriteLine(b1.Name);  // Output: War and Peace

            // Access the 'Description' property, which is a computed property
            Console.WriteLine(b1.Description);  // Output: War and Peace by Leo Tolstoy, 825 pages

            // Set values for the 'ISBN' and 'Price' properties
            b1.ISBN = "100140447938";  // Set ISBN
            b1.Price = 24.95m;  // Set Price

            // Access and print the 'ISBN' and 'Price' properties
            Console.WriteLine(b1.ISBN);  // Output: 100140447938
            Console.WriteLine(b1.Price);  // Output: 24.95

            // Modify the 'Name' and 'Pagecount' properties
            b1.Name = "Crime and Punishment";  // Change the book's name
            b1.Pagecount = 652;  // Change the page count

            // Access the updated 'Description' and other properties
            Console.WriteLine(b1.Description);  // Output: Crime and Punishment by John Steinbeck, 652 pages
            Console.WriteLine(b1.Name);  // Output: Crime and Punishment
            Console.WriteLine(b1.Pagecount);  // Output: 652
        }
    }
}

/* Key Concepts and Explanations:

1.Properties:
Getter: The get accessor retrieves the value of the field.
Setter: The set accessor assigns a new value to the field. The value keyword represents the value being assigned.
Read-only properties: If you only need a computed value or don't want the property to be set externally, you can omit the set accessor. For example, Description is a read-only computed property.

2.Auto-Implemented Properties:
You can simplify property declarations when no additional logic is needed. C# will automatically create a backing field for the property, allowing you to define it with just get and set.
Example: public string ISBN { get; set; } is an auto-implemented property where the compiler handles the backing field automatically.

3.Expression-bodied Members:
C# allows shorthand syntax for properties (and methods) using the => operator. This is especially useful for simple properties where no complex logic is needed.
Example: public string Author { get => _author; set => _author = value; } is an expression-bodied property.

4.Computed Properties:
A computed property derives its value from other fields or properties, and it does not have a backing field. You define the logic for the computed value in the get accessor.
Example: Description is a computed property that combines Name, Author, and Pagecount into a single string.

5.Encapsulation:
Properties provide a clean way to expose and control access to class data. You can make a property read-only, write-only, or both, depending on your needs, offering better control than just exposing fields directly.

6.Best Practices:
Use properties instead of fields to control access to your class's data.
For simple fields, use auto-implemented properties to reduce boilerplate code.
Use computed properties to provide derived or formatted data without directly storing it.
Expression-bodied properties can simplify your code when the property logic is short and concise.
Avoid making fields public. Instead, expose them via properties, which allow you to implement validation or transformation if necessary.
*/