using SchoolSchedule.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSchedule.Forms {
    public partial class FormSubjects : Form {
        SchoolDataBase database;
        public FormSubjects() {
            InitializeComponent();
            database = new SchoolDataBase();
            UpdateData();
        }

        private void buttonAddSubject_Click(object sender, EventArgs e) {
            if (textBoxName.Text == "") {
                MessageBox.Show("Заполните поле");
                return;
            }
            int check = database.AddSubject(textBoxName.Text);
            if (check > 0)
                MessageBox.Show("Запись успешно добавлена.");
            else
                MessageBox.Show("Ошибка при добавлении записи.");

            textBoxName.Clear();
            UpdateData();
        }
        private void UpdateData() {
            dataGridViewSubjects.DataSource = database.Request("select * from subject");
        }
    }
}
