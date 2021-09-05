using System;
using System.Collections.Generic;
using System.Linq;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            #region Enter details of Students
        StudentsCount:
            Console.WriteLine("Please enter certain number of students");
            string input;
            input = Console.ReadLine();

            if (int.TryParse(input, out _))
            {
                int numberOfStudents = Convert.ToInt32(input);
                for (int i = 0; i < numberOfStudents; i++)
                {
                    Student std = new Student();
                    Console.WriteLine();
                    Console.WriteLine($"Enter First Name of student{(i+1)}");
                    std.FirstName = Console.ReadLine();
                    Console.WriteLine($"Enter Last Name of student{(i + 1)}");
                    std.LastName = Console.ReadLine();

                SubjectsCount:
                    Console.WriteLine();
                    Console.WriteLine($"Enter number of tests for {std.FirstName}");
                    input = Console.ReadLine();

                    if (int.TryParse(input, out _))
                    {
                        int countOfTests = Convert.ToInt32(input);
                        for (int j = 0; j < countOfTests; j++)
                        {
                            Test test = new Test();

                        TestMarks:
                            Console.WriteLine($"Enter Numeric test marks for Test{(j+1)} between 0 and 100");
                            input = Console.ReadLine();
                            if (double.TryParse(input, out _))
                            {
                                double testMarks = Convert.ToDouble(input);
                                if (testMarks >= 0 && testMarks <= 100)
                                { 
                                    test.NumGrade = testMarks;
                                    std.Tests.Add(test);
                                }
                                else
                                {
                                    Console.WriteLine("Test Marks should be between 0 and 100");
                                    goto TestMarks;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Test marks should be numeric");
                                goto TestMarks;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Number of tests should be a digit");
                        goto SubjectsCount;
                    }
                    students.Add(std);
                }
            }
            else
            {
                Console.WriteLine("You have to enter a digit");
                goto StudentsCount;
            }

            #endregion

            #region Display Students Details

            foreach (var student in students.Select((value, i) => new { i, value }))
            {
                Console.WriteLine();
                Console.WriteLine($"Student{student.i+1} details");
                Console.WriteLine("*****************************************");
                student.value.Display();
                Console.WriteLine("*****************************************");
                Console.WriteLine();
            }
            #endregion
            
            Console.ReadLine();
        }
    }
}
