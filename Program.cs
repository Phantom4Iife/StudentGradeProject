using System;
using System.Collections.Generic;

namespace StudentGradeOrganizer
{
    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            Console.WriteLine("Creating student instances...\n");

            // Creating Student instances
            Student student1 = new Student { Name = "Goku Son", ID = 101 };
            Student student2 = new Student { Name = "Ichigo Kurosaki", ID = 102 };
            Student student3 = new Student { Name = "Naruto Uzumaki", ID = 103 };
            Student student4 = new Student { Name = "Monkey D. Luffy", ID = 104 };

            // Adding Students to List
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);

            Console.WriteLine("Students have been added to the list.\n");

            // Assigning Grades
            student1.AddGrade(95.3);
            student1.AddGrade(89.0, 92.7, 85.5);

            student2.AddGrade(88.5);
            student2.AddGrade(76.0, 90.2, 81.4);

            student3.AddGrade(91.2);
            student3.AddGrade(85.0, 79.8, 88.6);

            student4.AddGrade(78.9);
            student4.AddGrade(82.3, 74.1, 89.7);

            Console.WriteLine("Grades have been successfully assigned.\n");

            // Displaying Student Information
            Console.WriteLine("Student Performance Report:\n");

            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.ID}, Name: {student.Name}");
                Console.Write("Grades: ");
                foreach (var grade in student.Grades)
                {
                    Console.Write($"{grade} ");
                }

                Console.WriteLine($"\nAverage Grade: {student.CalculateAverageGrade():F2}");
                Console.WriteLine("---------------------------------");
            }

            //  Setting up Course Enrollment
            Console.WriteLine("\nSetting up a new course...\n");

            Subject advancedProgramming = new Subject
            {
                Title = "Advanced Programming",
                Code = "CS301"
            };

            //  Enrolling Students in Course
            Console.WriteLine("\nProcessing course enrollments...\n");

            advancedProgramming.RegisterStudent(student1);
            advancedProgramming.RegisterStudent(student2);
            advancedProgramming.RegisterStudent(student1); 

            //  Display Course and Enrolled Students
            Console.WriteLine("\nCourse Overview:");
            Console.WriteLine($"Course Name: {advancedProgramming.Title}");
            Console.WriteLine($"Course Code: {advancedProgramming.Code}");
            Console.WriteLine("Registered Students:");

            foreach (var student in advancedProgramming.Participants)
            {
                Console.WriteLine($"- {student.Name} (ID: {student.ID})");
            }
        }
    }
}
