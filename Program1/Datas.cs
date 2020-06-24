using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Program1
{
    public class Datas
    {
        public Student[] Students;
        public Datas(int size)
        {
            Students = new Student[size];
        }
        public Student this[int index]
        {
            get{return Students[index];}
            set{Students[index] = value;}
        }
    }
}
