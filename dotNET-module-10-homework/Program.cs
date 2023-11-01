using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLibrary;
using StudentLibrary;
using TeacherLibrary;
using InterfaceLibrary;

namespace dotNET_module_10_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            // Создаем массив объектов Person или их наследников
            List<Person> people = new List<Person>();

            for (int i = 0; i < 10; i++)
            {
                if (i % 3 == 0)
                {
                    people.Add(Program.RandomStudent());
                }
                else if (i % 2 == 0)
                {
                    people.Add(Program.RandomTeacher());
                }
                else
                {
                    people.Add(Program.RandomPerson());
                }
            }

            // Вывод информации о каждом объекте
            foreach (var person in people)
            {
                Console.WriteLine(person.ToString());
            }

            // Подсчет количества студентов, преподавателей и остальных
            int studentCount = 0;
            int teacherCount = 0;
            int personCount = 0;

            foreach (var person in people)
            {
                if (person is Student)
                {
                    studentCount++;
                    // Пример: переводим студента на следующий курс
                    ((Student)person).Course++;
                }
                else if (person is Teacher)
                {
                    teacherCount++;
                }
                else
                {
                    personCount++;
                }
            }

            Console.WriteLine($"Students: {studentCount}");
            Console.WriteLine($"Teachers: {teacherCount}");
            Console.WriteLine($"Other: {personCount}");

            Console.WriteLine("ДОПОЛНИТЕЛЬНЫЕ ЗАДАЧИ:");

            SimpleCalculator simpleCalculator = new SimpleCalculator();
            AdvancedCalculator advancedCalculator = new AdvancedCalculator();

            double result1 = simpleCalculator.Add(5, 3);
            double result2 = advancedCalculator.Power(2, 3);
            double result3 = advancedCalculator.SquareRoot(16);

            Console.WriteLine("Simple Calculator:");
            simpleCalculator.DisplayResult(result1);

            Console.WriteLine("\nAdvanced Calculator:");
            advancedCalculator.DisplayResult(result2);
            advancedCalculator.DisplayResult(result3);

            // Сохранение и загрузка состояния
            IStorable storableCalculator = new AdvancedCalculator();
            storableCalculator.SaveState("calculator_state.txt");
            storableCalculator.LoadState("calculator_state.txt");

        }

        static Random random = new Random();

        public static Person RandomPerson()
        {
            string[] names = { "Alice", "Bob", "Charlie", "David", "Eve" };
            string randomName = names[random.Next(names.Length)];
            int randomAge = random.Next(18, 30);
            return new Person { Name = randomName, Age = randomAge };
        }

        public static Student RandomStudent()
        {
            int randomStudentId = random.Next(1000, 9999);
            return new Student("Student", random.Next(18, 30), randomStudentId);
        }

        public static Teacher RandomTeacher()
        {
            return new Teacher("Teacher", random.Next(30, 60));
        }

    }
}
