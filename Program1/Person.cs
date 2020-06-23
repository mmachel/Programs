using System;
using System.Collections.Generic;
using System.Text;

namespace Program1
{
    class Person
    {
        public string Name { get; set; }
        public Person(string Name)
        {
            this.Name = Name;
        }
        public override string ToString()
        {
            return string.Format($"Name: {Name}");
        }
    }
}
