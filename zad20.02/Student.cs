using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad20._02
{
    internal class Student
    {
        public string Name { get; set; }
        public double AvgGrade { get; set; }

        public Student(string name, double avgGrade)
        {
            Name = name;
            AvgGrade = avgGrade;
        }

        public override string ToString()
        {
            return ($"Student {Name} with average grade {AvgGrade}");
        }

    }
}
