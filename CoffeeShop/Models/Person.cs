using System;
using System.Collections.Generic;

namespace CoffeeShop.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Person Parent { get; set; }
    }
}
