using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public class Student : PersonLibrary.Person
    {
        public int StudentId { get; set; }
        public int Course { get; set; }

        public Student(string name, int age, int studentId)
        {
            Name = name;
            Age = age;
            StudentId = studentId;
        }

        public override void Print()
        {
            Console.WriteLine($"Student ID: {StudentId}, Name: {Name}, Age: {Age}");
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Student other)
            {
                return Name == other.Name && Age == other.Age;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Age);
        }
    }
}
