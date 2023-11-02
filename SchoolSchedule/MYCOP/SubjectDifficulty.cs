using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolSchedule.Subjects;

namespace SchoolSchedule.Мусор
{
    public class SubjectDifficulty
    {
        public Subject Subject { get; set; }
        public Dictionary<GradeLevel, int> DifficultyByGrade { get; set; }

        public SubjectDifficulty(Subject subject)
        {
            Subject = subject;
            DifficultyByGrade = new Dictionary<GradeLevel, int>();
        }

        public void SetDifficulty(GradeLevel gradeLevel, int difficulty)
        {
            DifficultyByGrade[gradeLevel] = difficulty;
        }

        public int GetDifficulty(GradeLevel gradeLevel)
        {
            if (DifficultyByGrade.TryGetValue(gradeLevel, out int difficulty))
            {
                return difficulty;
            }

            // Если сложность не была установлена для указанного класса,
            // возвращаем некое значение по умолчанию
            return 0;
        }
    }

}
