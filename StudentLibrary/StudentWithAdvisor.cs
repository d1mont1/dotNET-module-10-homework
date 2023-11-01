using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public class StudentWithAdvisor : Student
    {
        public Student Advisor { get; set; }

        public StudentWithAdvisor(string name, int age, int studentId, Student advisor)
            : base(name, age, studentId)
        {
            Advisor = advisor;
        }
    }
}
