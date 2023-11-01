using StudentLibrary;
using System;
using System.Collections.Generic;
using PersonLibrary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherLibrary
{
    public class Teacher : PersonLibrary.Person
    {
        public List<StudentWithAdvisor> Students { get; set; }

        public Teacher(string name, int age)
        {
            Name = name;
            Age = age;
            Students = new List<StudentWithAdvisor>();
        }

        public override void Print()
        {
            Console.WriteLine($"Teacher: {Name}, Age: {Age}");
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Person other)
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
