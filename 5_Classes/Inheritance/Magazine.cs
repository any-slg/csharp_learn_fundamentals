using System;

namespace Inheritance
{
    // Declare "Magazine" as a subclass of Publication (inheritance)
    class Magazine : Publication
    {
        private string _publisher; // Private field to store the publisher's name

        // Constructor to initialize a Magazine object, calling the base class constructor
        // to initialize common properties like name, page count, and price
        public Magazine(string name, string publisher, int pagecount, decimal price)
             : base(name, pagecount, price) // Calls the constructor of the base class (Publication)
        {
            _publisher = publisher; // Sets the publisher's name
        }

        // Property to get and set the publisher's name
        public string Publisher
        {
            get => _publisher; // Gets the publisher's name
            set => _publisher = value; // Sets the publisher's name
        }
    }
}
