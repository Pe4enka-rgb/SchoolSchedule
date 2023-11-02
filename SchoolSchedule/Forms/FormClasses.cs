using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolSchedule.src;

namespace SchoolSchedule {
    public partial class FormClasses : Form {
        SchoolDataBase database;
        public FormClasses() {
            InitializeComponent();
            database = new SchoolDataBase();
            UpdateData();
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            int check = database.AddClass(Convert.ToByte(textBoxYear.Text), textBoxLetter.Text[0]);
            if (check > 0)
                MessageBox.Show("Запись успешно добавлена.");
            else
                MessageBox.Show("Ошибка при добавлении записи.");

            textBoxLetter.Clear();
            textBoxYear.Clear();
            UpdateData();
        }
        private void UpdateData() {
            dataGridViewClasses.DataSource = database.Request("select * from schoolclass");
        }

    }
}
