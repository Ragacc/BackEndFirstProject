using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentControl
{
    class Student
    {
        public string Name { get; set; }
        public int RollNumber { get; set; }
        public char Grade { get; set; }

        public Student(string name, int rollNumber, char grade)
        {
            Name = name;
            RollNumber = rollNumber;
            Grade = grade;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Roll Number: {RollNumber}, Grade: {Grade}");
        }
    }

    class Program
    {
        static List<Student> students = new List<Student>();

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("Student Management System");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Search Student by Roll Number");
                Console.WriteLine("4. Update Student Grade");
                Console.WriteLine("5. Remove Student");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        ViewAllStudents();
                        break;
                    case "3":
                        SearchStudent();
                        break;
                    case "4":
                        UpdateStudentGrade();
                        break;
                    case "5":
                        RemoveStudent();
                        break;
                    case "6":
                        running = false;
                        Console.WriteLine("Exiting the program...");
                        break;
                    default:
                        Console.WriteLine("Invalid option! Please choose again.");
                        break;
                }
            }
        }

        static void AddStudent()
        {
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            int rollNumber;
            while (true)
            {
                Console.Write("Enter Roll Number: ");
                if (int.TryParse(Console.ReadLine(), out rollNumber) && rollNumber > 0)
                    break;
                Console.WriteLine("Invalid roll number! Enter a positive integer.");
            }

            char grade;
            while (true)
            {
                Console.Write("Enter Grade (A-F): ");
                char.TryParse(Console.ReadLine().ToUpper(), out grade);
                if ("ABCDEF".Contains(grade))
                    break;
                Console.WriteLine("Invalid grade! Enter a letter between A and F.");
            }

            students.Add(new Student(name, rollNumber, grade));
            Console.WriteLine("Student added successfully!");
        }

        static void ViewAllStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students in the system.");
                return;
            }

            Console.WriteLine("List of Students:");
            foreach (var student in students)
            {
                student.DisplayInfo();
            }
        }

        static void SearchStudent()
        {
            Console.Write("Enter Roll Number to search: ");
            if (int.TryParse(Console.ReadLine(), out int rollNumber))
            {
                var student = students.FirstOrDefault(s => s.RollNumber == rollNumber);
                if (student != null)
                {
                    Console.WriteLine("Student found:");
                    student.DisplayInfo();
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid roll number.");
            }
        }

        static void UpdateStudentGrade()
        {
            Console.WriteLine("Enter the Rollnumber of the student to update their grade");
            int updaterrollnumbere = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the new grade");
            char updatedgrade = char.Parse(Console.ReadLine());
            foreach (var item in students)
            {
                if (updaterrollnumbere == item.RollNumber)
                {
                    item.Grade = updatedgrade;
                }

            }
            Console.WriteLine("Updated");
        }

        static void RemoveStudent()
        {
            Console.Write("Enter Roll Number to remove: ");
            if (int.TryParse(Console.ReadLine(), out int rollNumber))
            {
                var studentToRemove = students.FirstOrDefault(s => s.RollNumber == rollNumber);
                if (studentToRemove != null)
                {
                    students.Remove(studentToRemove);
                    Console.WriteLine("Student removed successfully!");
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid roll number.");
            }
        }
    }
}
