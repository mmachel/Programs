using System;
using System.Collections.Generic;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student("Adelaide Mac Mars", new DateTime(2000,05,07),"M-6520");
            var student2 = new Student("Finance Moses",new DateTime(1971,09,23),"F-2323");
            var student3 = new Student("Elizabeth Ziquite",new DateTime(1947,04,07),"E-7540");
            var student4 = new Student("Isaac Lucas",new DateTime(2005,10,07),"I-5738");
            var st = new Datas(4);
            st[0] = student1;
            st[1] = student2;
            st[2] = student3;
            st[3] = student4;
            Console.WriteLine("Array output:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(st[i]);
            }
            var stlist = new List<Student>();
            stlist.Add(student1);
            stlist.Add(student2);
            stlist.Add(student3);
            stlist.Add(student4);
            Console.WriteLine("List output: ");
            foreach (var std in stlist)
            {
                Console.WriteLine(std);
            }
        }
    }
}
