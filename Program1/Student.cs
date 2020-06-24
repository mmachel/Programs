using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Program1
{
    public class Student: Person
    {
        public string ID{get; set;}
        public Student(string Name, DateTime BirthDate, string ID)
        :base(Name, BirthDate)
        {
            this.ID = ID;
        }
         public override string ToString()
        {
            return string.Format($"Name: {Name} \nAge: {DateTime.Now.Year-BirthDate.Year}"+
            $"\nStudent ID: {ID}\n");
        }
    }
}
