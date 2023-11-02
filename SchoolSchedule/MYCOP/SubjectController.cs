using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using SchoolSchedule.Subjects;

namespace SchoolSchedule.Мусор
{
    internal class SubjectController
    {
        public readonly List<Subject> subjects;
        public Dictionary<int, Dictionary<Subject, int>> subjectDifficulties = new();

        public SubjectController()
        {
            subjects = new List<Subject>();
        }
        public void AddSubject(Subject subject)
        {
            if (subjects.Contains(subject))
            {
                throw new ArgumentException($"Subject '{subject.Name}' already exists.");
            }

            subjects.Add(subject);
            //subjectDifficulties.Add(subject.Id, new Dictionary<Subject, int>());
        }

        private void SetValues()
        {

        }

        public static void SaveData()
        {
            // Сохраняем данные в базу данных или файл, используя соответствующий провайдер.
        }

        public static void GetSubejectsList()
        {

        }
    }


}
