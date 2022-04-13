using System;
using System.Collections.Generic;
using System.Text;

namespace JsonObject.Models
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Adress Adress { get; set; }
    }
}
