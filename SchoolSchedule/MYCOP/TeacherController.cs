using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SchoolSchedule.Teachers;

namespace SchoolSchedule.Мусор
{
    public class TeacherController
    {

        private string filePath = string.Empty;
        public readonly List<Teacher> teachers = new();

        public void AddTeacher(string name, string surname, string patronymic)
        {
            Teacher teacher = new Teacher(name, surname, patronymic);
            AddTeacher(teacher);
        }

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            teachers.Remove(teacher);
        }

        public void ToXml()
        {
            ToXml(filePath);
        }
        private void ToXml(string path)
        {
            if (teachers.Count == 0)
            {
                MessageBox.Show("Не добавлено ни одного учителя", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                XmlSerializer xmlSerializer = new(typeof(List<Teacher>));
                using (var fileStream = new FileStream(path + "Teacher.xml", FileMode.Create, FileAccess.Write))
                    xmlSerializer.Serialize(fileStream, teachers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void FromXml()
        {
            FromXml(filePath);
        }
        public void FromXml(string path)
        {
            try
            {
                XmlSerializer xmlSerializer = new(typeof(List<Teacher>));
                using (var fileStream = new FileStream(path + @"Teacher.xml", FileMode.Open, FileAccess.Read))
                    teachers.AddRange(xmlSerializer.Deserialize(fileStream) as List<Teacher>);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}


