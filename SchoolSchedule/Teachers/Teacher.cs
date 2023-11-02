using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolSchedule.Subjects;

namespace SchoolSchedule.Teachers {
    public class Teacher {
        private string name;
        private string surname;
        private string? patronymic;

        public string Name {
            get { return name; }
            set { name = value; }
        }
        public string Surname {
            get { return surname; }
            set { surname = value; }
        }
        public string? Patronymic {
            get { return patronymic; }
            set { patronymic = value; }
        }

        public Teacher() { }
        public Teacher(string name, string surname, string patronymic = "") {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic;
        }
    }





}
