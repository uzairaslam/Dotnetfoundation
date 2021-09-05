using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    public class Test
    {
        public double NumGrade { get; set; }
        public char LetterGrade 
        { 
            get
            {
                return NumGrade.CalculateLetterGrade();
            }
        }
    }
}
