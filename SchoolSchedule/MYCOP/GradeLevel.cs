using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolSchedule.Subjects;

namespace SchoolSchedule.Мусор
{
    public class GradeLevel
    {
        public int Number { get; set; }
        public Dictionary<Subject, int> SubjectDifficulties { get; set; }

        public GradeLevel(int number, Dictionary<Subject, int> subjectDifficulties)
        {
            Number = number;
            SubjectDifficulties = subjectDifficulties;
        }
    }
}
