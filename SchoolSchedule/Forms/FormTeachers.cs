using SchoolSchedule.Forms;
using SchoolSchedule.src;
using SchoolSchedule.Teachers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSchedule {
    public partial class FormTeachers : Form {
        SchoolDataBase database;
        public FormTeachers() {
            InitializeComponent();
            database = new SchoolDataBase();
            UpdateData();
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            if (textBoxName.Text == "") {
                MessageBox.Show("Заполните поле \"Имя\"");
                return;
            }
            if (textBoxSurname.Text == "") {
                MessageBox.Show("Заполните поле \"Фамилия\"");
                return;
            }
            int check = database.AddTeacher(textBoxName.Text, textBoxSurname.Text, textBoxPatronymic.Text);
            if (check > 0)
                MessageBox.Show("Запись успешно добавлена.");
            else
                MessageBox.Show("Ошибка при добавлении записи.");

            textBoxName.Clear();
            textBoxSurname.Clear();
            textBoxPatronymic.Clear();

            UpdateData();
        }

        private void UpdateData() {
            dataGridViewTeacher.DataSource = database.Request("select * from teacher");
        }


    }
}
