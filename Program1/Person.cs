using System;
using System.Collections.Generic;
using System.Text;

namespace Program1
{
    public abstract class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate{get; set;}
        public Person(string Name, DateTime BirthDate)
        {
            this.Name = Name;
            this.BirthDate = BirthDate;
        }
    }
}
