using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_SELECT
{
    class select
    {
        static void Main()
        {
            List<Student> students = new List<Student>
            {
                new Student{Name = "Alice",Age = 28},
                new Student{Name = "Bob", Age = 20}
            };

            var result = from student in students
                         where student.Age == 20
                         select student.Name;

            Console.WriteLine("20歲的學生");

            foreach (var name in result)
            {
                Console.WriteLine(name);
            }

        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
