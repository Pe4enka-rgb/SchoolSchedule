using SchoolSchedule.Subjects;
using SchoolSchedule.Teachers;
namespace SchoolSchedule.Forms {
    partial class FormSubjects {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            labelSubjectName = new Label();
            textBoxName = new TextBox();
            buttonAddSubject = new Button();
            dataGridViewSubjects = new DataGridView();
            ( (System.ComponentModel.ISupportInitialize) dataGridViewSubjects  ).BeginInit();
            this.SuspendLayout();
            // 
            // labelSubjectName
            // 
            labelSubjectName.Location = new Point(381, 9);
            labelSubjectName.Name = "labelSubjectName";
            labelSubjectName.Size = new Size(199, 22);
            labelSubjectName.TabIndex = 0;
            labelSubjectName.Text = "Название";
            labelSubjectName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(381, 34);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(199, 23);
            textBoxName.TabIndex = 1;
            // 
            // buttonAddSubject
            // 
            buttonAddSubject.Location = new Point(381, 63);
            buttonAddSubject.Name = "buttonAddSubject";
            buttonAddSubject.Size = new Size(199, 23);
            buttonAddSubject.TabIndex = 2;
            buttonAddSubject.Text = "Добавить";
            buttonAddSubject.UseVisualStyleBackColor = true;
            buttonAddSubject.Click += this.buttonAddSubject_Click;
            // 
            // dataGridViewSubjects
            // 
            dataGridViewSubjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSubjects.Dock = DockStyle.Left;
            dataGridViewSubjects.Location = new Point(0, 0);
            dataGridViewSubjects.Name = "dataGridViewSubjects";
            dataGridViewSubjects.RowHeadersVisible = false;
            dataGridViewSubjects.RowTemplate.Height = 25;
            dataGridViewSubjects.Size = new Size(299, 487);
            dataGridViewSubjects.TabIndex = 3;
            // 
            // FormSubjects
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(788, 487);
            this.Controls.Add(dataGridViewSubjects);
            this.Controls.Add(buttonAddSubject);
            this.Controls.Add(textBoxName);
            this.Controls.Add(labelSubjectName);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "FormSubjects";
            this.StartPosition = FormStartPosition.Manual;
            ( (System.ComponentModel.ISupportInitialize) dataGridViewSubjects  ).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label labelSubjectName;
        private TextBox textBoxName;
        private Button buttonAddSubject;
        private DataGridView dataGridViewSubjects;
    }
}