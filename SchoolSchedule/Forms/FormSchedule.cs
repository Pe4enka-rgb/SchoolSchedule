using SchoolSchedule.src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSchedule.Forms
{

    public partial class FormSchedule : Form
    {
        /* время уроков              
        8.00 - 8.45
        8.55 - 9.40
        10.00 - 10.45
        11.05 - 11.50
        12.10 - 12.55
        13.10 - 13.55
        14.05 - 14.50
        15.10 - 15.55
        16.05 - 16.50
        17.00 - 17.45
        17.55 - 18.40
        */
        private string GetLessonNumber(byte lessonNumber)
        {
            string lessonTime;
            switch (lessonNumber) {

                case 1:
                    lessonTime = "8.00 - 8.45";
                    break;
                case 2:
                    lessonTime = "8.55 - 9.40";
                    break;
                case 3:
                    lessonTime = "10.00 - 10.45";
                    break;
                case 4:
                    lessonTime = "11.05 - 11.50";
                    break;
                case 5:
                    lessonTime = "12.10 - 12.55";
                    break;
                case 6:
                    lessonTime = "13.10 - 13.55";
                    break;
                case 7:
                    lessonTime = "14.05 - 14.50";
                    break;
                case 8:
                    lessonTime = "15.10 - 15.55";
                    break;
                case 9:
                    lessonTime = "16.05 - 16.50";
                    break;
                case 10:
                    lessonTime = "17.00 - 17.45";
                    break;
                case 11:
                    lessonTime = "17.55 - 18.40";
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }
            return lessonTime;
        }
        private void ShowClasses()
        {
            var dataBase = new SchoolDataBase();
            DataTable dataTable = dataBase.Request("select * from schoolclass");
            var classList = dataTable.AsEnumerable().Select(row =>
                new ClassesModel {
                    Id = row.Field<int>("Id"),
                    ClassYear = row.Field<int>("year"), // set the properties accordingly 
                    ClassLetter = row.Field<string>("letter")[0]
                }).ToList();
            var classes = from schoolClass in classList
                          orderby schoolClass.ClassYear,
                          schoolClass.ClassLetter
                          select schoolClass;

            foreach (var item in classes) {
                dataGridViewSchedule.ColumnCount += 1;
                dataGridViewSchedule.Columns[dataGridViewSchedule.ColumnCount - 1].Name =
                            item.ClassYear.ToString() +
                            item.ClassLetter.ToString();
            }
        }
        private void SetTime()
        {
            //dataGridViewSchedule.Columns["Time"];
        }
        public FormSchedule()
        {
            InitializeComponent();
            ShowClasses();
        }
        /*
                private void button1_Click(object sender, EventArgs e)
                {
                    try {
                        OpenFileDialog openFileDialog1 = new OpenFileDialog();  //create openfileDialog Object
                        openFileDialog1.Filter = "XML Files (*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb) |*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb";//open file format define Excel Files(.xls)|*.xls| Excel Files(.xlsx)|*.xlsx| 
                        openFileDialog1.FilterIndex = 3;

                        openFileDialog1.Multiselect = false;        //not allow multiline selection at the file selection level
                        openFileDialog1.Title = "Open Text File-R13";   //define the name of openfileDialog
                        openFileDialog1.InitialDirectory = @"Desktop"; //define the initial directory

                        if (openFileDialog1.ShowDialog() == DialogResult.OK)        //executing when file open
                        {
                            string pathName = openFileDialog1.FileName;
                            string fileName = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                            DataTable tbContainer = new DataTable();
                            string strConn = string.Empty;
                            string sheetName = fileName;

                            FileInfo file = new FileInfo(pathName);
                            if (!file.Exists) { throw new Exception("Error, file doesn't exists!"); }
                            string extension = file.Extension;
                            switch (extension) {
                                case ".xls":
                                    strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                                    break;
                                case ".xlsx":
                                    strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathName + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";
                                    break;
                                default:
                                    strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                                    break;
                            }
                            OleDbConnection cnnxls = new OleDbConnection(strConn);
                            OleDbDataAdapter oda = new OleDbDataAdapter(string.Format("select * from [{0}$]", sheetName), cnnxls);
                            oda.Fill(tbContainer);

                            dataGridViewSchedule.DataSource = tbContainer;
                        }

                    } catch (Exception ex) {
                        MessageBox.Show(ex.ToString());
                    }
                }

        */

        private void addColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridViewSchedule.ColumnCount++;
        }

        private void delColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewSchedule.Columns.Count > 0) {
                dataGridViewSchedule.ColumnCount--;
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e){
            try {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();  //create openfileDialog Object
                openFileDialog1.Filter = "XML Files (*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb) |*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb";//open file format define Excel Files(.xls)|*.xls| Excel Files(.xlsx)|*.xlsx| 
                openFileDialog1.FilterIndex = 3;

                openFileDialog1.Multiselect = false;        //not allow multiline selection at the file selection level
                openFileDialog1.Title = "Open Text File-R13";   //define the name of openfileDialog
                openFileDialog1.InitialDirectory = @"Desktop"; //define the initial directory

                if (openFileDialog1.ShowDialog() == DialogResult.OK)        //executing when file open
                {
                    string pathName = openFileDialog1.FileName;
                    string fileName = System.IO.Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                    DataTable tbContainer = new DataTable();
                    string strConn = string.Empty;
                    string sheetName = fileName;

                    FileInfo file = new FileInfo(pathName);
                    if (!file.Exists) { throw new Exception("Error, file doesn't exists!"); }
                    string extension = file.Extension;
                    switch (extension) {
                        case ".xls":
                            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                            break;
                        case ".xlsx":
                            strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + pathName + ";Extended Properties='Excel 12.0;HDR=Yes;IMEX=1;'";
                            break;
                        default:
                            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathName + ";Extended Properties='Excel 8.0;HDR=Yes;IMEX=1;'";
                            break;
                    }
                    OleDbConnection cnnxls = new OleDbConnection(strConn);
                    OleDbDataAdapter oda = new OleDbDataAdapter(string.Format("select * from [{0}$]", sheetName), cnnxls);
                    oda.Fill(tbContainer);

                    dataGridViewSchedule.DataSource = tbContainer;
                }

            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
