namespace SchoolSchedule
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button3 = new Button();
            buttonTeachers = new Button();
            buttonSubjects = new Button();
            buttonClasses = new Button();
            button2 = new Button();
            panelButtons = new Panel();
            panelForms = new Panel();
            button1 = new Button();
            panelButtons.SuspendLayout();
            panelForms.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(  0  ,   128  ,   131  );
            button3.Dock = DockStyle.Left;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(  247  ,   129  ,   4  );
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(  250  ,   171  ,   54  );
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Gainsboro;
            button3.Location = new Point(572, 0);
            button3.Name = "button3";
            button3.Size = new Size(210, 50);
            button3.TabIndex = 2;
            button3.Text = "Архив расписаний";
            button3.UseVisualStyleBackColor = false;
            button3.Visible = false;
            button3.Click += this.button3_Click;
            // 
            // buttonTeachers
            // 
            buttonTeachers.BackColor = Color.FromArgb(  0  ,   128  ,   131  );
            buttonTeachers.Dock = DockStyle.Left;
            buttonTeachers.FlatAppearance.BorderSize = 0;
            buttonTeachers.FlatAppearance.MouseDownBackColor = Color.FromArgb(  247  ,   129  ,   4  );
            buttonTeachers.FlatAppearance.MouseOverBackColor = Color.FromArgb(  250  ,   171  ,   54  );
            buttonTeachers.FlatStyle = FlatStyle.Flat;
            buttonTeachers.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTeachers.ForeColor = Color.Gainsboro;
            buttonTeachers.Location = new Point(429, 0);
            buttonTeachers.Name = "buttonTeachers";
            buttonTeachers.Size = new Size(143, 50);
            buttonTeachers.TabIndex = 5;
            buttonTeachers.Text = "Учителя";
            buttonTeachers.UseVisualStyleBackColor = false;
            buttonTeachers.Click += this.buttonTeachers_Click;
            // 
            // buttonSubjects
            // 
            buttonSubjects.BackColor = Color.FromArgb(  0  ,   128  ,   131  );
            buttonSubjects.Dock = DockStyle.Left;
            buttonSubjects.FlatAppearance.BorderSize = 0;
            buttonSubjects.FlatAppearance.MouseDownBackColor = Color.FromArgb(  247  ,   129  ,   4  );
            buttonSubjects.FlatAppearance.MouseOverBackColor = Color.FromArgb(  250  ,   171  ,   54  );
            buttonSubjects.FlatStyle = FlatStyle.Flat;
            buttonSubjects.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSubjects.ForeColor = Color.Gainsboro;
            buttonSubjects.Location = new Point(143, 0);
            buttonSubjects.Name = "buttonSubjects";
            buttonSubjects.Size = new Size(143, 50);
            buttonSubjects.TabIndex = 3;
            buttonSubjects.Text = "Предметы";
            buttonSubjects.UseVisualStyleBackColor = false;
            buttonSubjects.Click += this.buttonSubjects_Click;
            // 
            // buttonClasses
            // 
            buttonClasses.BackColor = Color.FromArgb(  0  ,   128  ,   131  );
            buttonClasses.Dock = DockStyle.Left;
            buttonClasses.FlatAppearance.BorderSize = 0;
            buttonClasses.FlatAppearance.MouseDownBackColor = Color.FromArgb(  247  ,   129  ,   4  );
            buttonClasses.FlatAppearance.MouseOverBackColor = Color.FromArgb(  250  ,   171  ,   54  );
            buttonClasses.FlatStyle = FlatStyle.Flat;
            buttonClasses.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClasses.ForeColor = Color.Gainsboro;
            buttonClasses.Location = new Point(286, 0);
            buttonClasses.Name = "buttonClasses";
            buttonClasses.Size = new Size(143, 50);
            buttonClasses.TabIndex = 4;
            buttonClasses.Text = "Классы";
            buttonClasses.UseVisualStyleBackColor = false;
            buttonClasses.Click += this.buttonClasses_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(  0  ,   128  ,   131  );
            button2.Dock = DockStyle.Left;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(  247  ,   129  ,   4  );
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(  250  ,   171  ,   54  );
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Gainsboro;
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(143, 50);
            button2.TabIndex = 1;
            button2.Text = "Расписание";
            button2.UseVisualStyleBackColor = false;
            button2.Click += this.buttonSchedule_Click;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(  36  ,   158  ,   160  );
            panelButtons.Controls.Add(button3);
            panelButtons.Controls.Add(buttonTeachers);
            panelButtons.Controls.Add(buttonClasses);
            panelButtons.Controls.Add(buttonSubjects);
            panelButtons.Controls.Add(button2);
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Location = new Point(0, 0);
            panelButtons.Margin = new Padding(0);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(1000, 50);
            panelButtons.TabIndex = 1;
            // 
            // panelForms
            // 
            panelForms.BackColor = Color.Silver;
            panelForms.Controls.Add(button1);
            panelForms.Dock = DockStyle.Fill;
            panelForms.Location = new Point(0, 50);
            panelForms.Name = "panelForms";
            panelForms.Size = new Size(1000, 450);
            panelForms.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(483, 313);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.MouseDown += this.Control_MouseDown;
            button1.MouseMove += this.Control_MouseMove;
            button1.MouseUp += this.Control_MouseUp;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1000, 500);
            this.Controls.Add(panelForms);
            this.Controls.Add(panelButtons);
            this.MinimumSize = new Size(1016, 539);
            this.Name = "FormMain";
            panelButtons.ResumeLayout(false);
            panelForms.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons;
        private Panel panel2;
        private Button button2;
        private Panel panelForms;
        private Button buttonTeachers;
        private Button buttonClasses;
        private Button buttonSubjects;
        private Button button3;
        private Panel panel1;
        private Button button1;
    }
}