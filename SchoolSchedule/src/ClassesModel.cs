using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolSchedule.Subjects;
using SchoolSchedule.Teachers;

namespace SchoolSchedule.src {
    class ClassesModel {
        public int Id { get; set; }
        private int year;
        private char letter;
        private List<Subject>? subjects;
        private Teacher? teacher;
        public char ClassLetter {
            get { return letter; }
            set { letter = value; }
        }
        public int ClassYear {
            get { return year; }
            set { year = value; }
        }
        public ClassesModel() { }

        public ClassesModel(int year, char letter) {
            this.year = year;
            this.letter = letter;

        }
    }
}
