using System;
using System.Collections.Generic;
using System.Linq;

namespace p04_Average_Grades
{

    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double Average => Grades.Average();
    }

    class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            while (studentCount-- > 0)
            {
                Student student = new Student();

                string[] studentsInfo = Console.ReadLine().Split(' ').ToArray();
                string studentName = studentsInfo[0];

                student.Name = studentName;
                student.Grades = studentsInfo.Skip(1).Select(double.Parse).ToList();

                students.Add(student);
            }
            students.Where(s => s.Average >= 5.00)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.Average)
                .ToList()
                .ForEach(s =>
                {
                    Console.WriteLine($"{s.Name} -> {s.Average:F2}");
                });
        }
    }
}
