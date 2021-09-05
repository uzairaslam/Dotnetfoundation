using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    public static class HelperExtensions
    {
        public static char CalculateLetterGrade(this double NumGrade)
        {

            char letter;
            switch (NumGrade)
            {
                case double n when n >= 90 && n <= 100:
                    letter = 'A';
                    break;
                case double n when n >= 80 && n < 90:
                    letter = 'B';
                    break;
                case double n when n >= 70 && n < 80:
                    letter = 'C';
                    break;
                case double n when n >= 60 && n < 70:
                    letter = 'D';
                    break;
                default:
                    letter = 'F';
                    break;
            }
            return letter;
        }
    }
}
