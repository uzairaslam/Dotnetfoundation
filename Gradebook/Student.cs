using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    public class Student
    {
        public Student()
        {
            RollNumber = Guid.NewGuid();
            Tests = new List<Test>();
        }
        public Guid RollNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Test> Tests { get; set; }
        public double GradeAverage
        {
            get
            {
                return (Tests.Sum(t => t.NumGrade) / Tests.Count);
            }
        }

        public char LetterGradeAverage
        {
            get
            {
                return GradeAverage.CalculateLetterGrade();
            }

        }

        public void Display()
        {
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Grade Average: {GradeAverage}");
            Console.WriteLine($"Letter Grade Average: {LetterGradeAverage}");

            Console.WriteLine();
            Console.WriteLine("Numeric Grade      LetterGrade");

            foreach (Test test in Tests)
            {
                Console.WriteLine($"{test.NumGrade}        {test.LetterGrade}");
            }
        }
    }
}
