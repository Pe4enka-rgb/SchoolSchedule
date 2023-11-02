using SchoolSchedule.Teachers;

namespace SchoolSchedule {
    partial class FormTeachers {
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
            buttronFromXml = new Button();
            labelName = new Label();
            labelSurname = new Label();
            labelPatronymic = new Label();
            textBoxName = new TextBox();
            textBoxSurname = new TextBox();
            textBoxPatronymic = new TextBox();
            buttonAdd = new Button();
            buttonToXml = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            dataGridViewTeacher = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) dataGridViewTeacher  ).BeginInit();
            this.SuspendLayout();
            // 
            // buttronFromXml
            // 
            buttronFromXml.BackColor = Color.FromArgb(  64  ,   64  ,   64  );
            buttronFromXml.Dock = DockStyle.Top;
            buttronFromXml.FlatAppearance.BorderSize = 0;
            buttronFromXml.FlatStyle = FlatStyle.Flat;
            buttronFromXml.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttronFromXml.ForeColor = Color.GhostWhite;
            buttronFromXml.Location = new Point(0, 50);
            buttronFromXml.Margin = new Padding(0);
            buttronFromXml.Name = "buttronFromXml";
            buttronFromXml.Size = new Size(250, 50);
            buttronFromXml.TabIndex = 3;
            buttronFromXml.Text = "Загрузить";
            buttronFromXml.UseVisualStyleBackColor = false;
            buttronFromXml.Visible = false;
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.None;
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.ForeColor = SystemColors.Control;
            labelName.Location = new Point(96, 105);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 25);
            labelName.TabIndex = 5;
            labelName.Text = "Имя";
            // 
            // labelSurname
            // 
            labelSurname.Anchor = AnchorStyles.None;
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelSurname.ForeColor = SystemColors.Control;
            labelSurname.Location = new Point(80, 168);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(91, 25);
            labelSurname.TabIndex = 6;
            labelSurname.Text = "Фамилия";
            // 
            // labelPatronymic
            // 
            labelPatronymic.Anchor = AnchorStyles.None;
            labelPatronymic.AutoSize = true;
            labelPatronymic.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelPatronymic.ForeColor = SystemColors.Control;
            labelPatronymic.Location = new Point(80, 232);
            labelPatronymic.Name = "labelPatronymic";
            labelPatronymic.Size = new Size(93, 25);
            labelPatronymic.TabIndex = 7;
            labelPatronymic.Text = "Отчество";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.None;
            textBoxName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxName.Location = new Point(3, 133);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(250, 32);
            textBoxName.TabIndex = 8;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Anchor = AnchorStyles.None;
            textBoxSurname.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSurname.Location = new Point(3, 197);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(250, 32);
            textBoxSurname.TabIndex = 9;
            // 
            // textBoxPatronymic
            // 
            textBoxPatronymic.Anchor = AnchorStyles.None;
            textBoxPatronymic.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPatronymic.Location = new Point(3, 262);
            textBoxPatronymic.Name = "textBoxPatronymic";
            textBoxPatronymic.Size = new Size(250, 32);
            textBoxPatronymic.TabIndex = 10;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(  64  ,   64  ,   64  );
            buttonAdd.FlatAppearance.BorderColor = Color.White;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.GhostWhite;
            buttonAdd.Location = new Point(0, 0);
            buttonAdd.Margin = new Padding(0);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(250, 50);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += this.buttonAdd_Click;
            // 
            // buttonToXml
            // 
            buttonToXml.BackColor = Color.FromArgb(  64  ,   64  ,   64  );
            buttonToXml.Dock = DockStyle.Top;
            buttonToXml.FlatAppearance.BorderSize = 0;
            buttonToXml.FlatStyle = FlatStyle.Flat;
            buttonToXml.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonToXml.ForeColor = Color.GhostWhite;
            buttonToXml.Location = new Point(0, 0);
            buttonToXml.Margin = new Padding(0);
            buttonToXml.Name = "buttonToXml";
            buttonToXml.Size = new Size(250, 50);
            buttonToXml.TabIndex = 2;
            buttonToXml.Text = "Сохранить";
            buttonToXml.UseVisualStyleBackColor = false;
            buttonToXml.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(  64  ,   64  ,   64  );
            panel1.Controls.Add(buttronFromXml);
            panel1.Controls.Add(buttonToXml);
            panel1.Location = new Point(508, 373);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 184);
            panel1.TabIndex = 3;
            panel1.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(  64  ,   64  ,   64  );
            panel2.Controls.Add(textBoxName);
            panel2.Controls.Add(labelName);
            panel2.Controls.Add(buttonAdd);
            panel2.Controls.Add(labelPatronymic);
            panel2.Controls.Add(labelSurname);
            panel2.Controls.Add(textBoxSurname);
            panel2.Controls.Add(textBoxPatronymic);
            panel2.Location = new Point(508, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 373);
            panel2.TabIndex = 12;
            // 
            // dataGridViewTeacher
            // 
            dataGridViewTeacher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTeacher.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeacher.Dock = DockStyle.Left;
            dataGridViewTeacher.Location = new Point(0, 0);
            dataGridViewTeacher.Margin = new Padding(0);
            dataGridViewTeacher.Name = "dataGridViewTeacher";
            dataGridViewTeacher.RowHeadersVisible = false;
            dataGridViewTeacher.RowTemplate.Height = 25;
            dataGridViewTeacher.Size = new Size(508, 557);
            dataGridViewTeacher.TabIndex = 13;
            // 
            // FormTeachers
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(  64  ,   64  ,   64  );
            this.ClientSize = new Size(885, 557);
            this.Controls.Add(dataGridViewTeacher);
            this.Controls.Add(panel2);
            this.Controls.Add(panel1);
            this.FormBorderStyle = FormBorderStyle.None;
            this.MinimizeBox = false;
            this.MinimumSize = new Size(800, 450);
            this.Name = "FormTeachers";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.Manual;
            this.Text = "FormEdit";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize) dataGridViewTeacher  ).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private Label labelName;
        private Label labelSurname;
        private Label labelPatronymic;
        private TextBox textBoxName;
        private TextBox textBoxSurname;
        private TextBox textBoxPatronymic;
        private Button buttronFromXml;
        private Button buttonAdd;
        private Button buttonToXml;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridViewTeacher;
    }
}