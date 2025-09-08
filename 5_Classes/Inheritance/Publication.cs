using System;

namespace Inheritance
{
    // Base class representing a general Publication (e.g., Book, Magazine, etc.)
    class Publication
    {
        // Private field to store the name of the publication
        private string _name;

        // Constructor to initialize a Publication object with its name, page count, and price
        public Publication(string name, int pagecount, decimal price)
        {
            _name = name;
            PageCount = pagecount;
            Price = price;
        }

        // Auto-implemented property for the number of pages
        public int PageCount { get; set; }

        // Auto-implemented property for the price of the publication
        public decimal Price { get; set; }

        // Property for the name of the publication with validation
        public string Name
        {
            get { return _name; } // Returns the publication name

            // Sets the name with validation to ensure it is not an empty string
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Name cannot be blank"); // Throws exception if name is blank
                }
                _name = value; // Sets the publication name
            }
        }

        // Virtual method that can be overridden by derived classes
        // By default, it returns a simple description including name and page count
        public virtual string GetDescription()
        {
            return $"{Name}, {PageCount} pages"; // Default description
        }
    }
}
