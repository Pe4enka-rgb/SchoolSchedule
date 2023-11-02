namespace SchoolSchedule
{
    partial class FormClasses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            textBoxLetter = new TextBox();
            textBoxYear = new TextBox();
            labelYear = new Label();
            labelLetter = new Label();
            buttonAdd = new Button();
            dataGridViewClasses = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) dataGridViewClasses  ).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(textBoxLetter, 1, 1);
            tableLayoutPanel1.Controls.Add(textBoxYear, 0, 1);
            tableLayoutPanel1.Controls.Add(labelYear, 0, 0);
            tableLayoutPanel1.Controls.Add(labelLetter, 1, 0);
            tableLayoutPanel1.Location = new Point(277, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(200, 60);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxLetter
            // 
            textBoxLetter.Location = new Point(103, 33);
            textBoxLetter.Name = "textBoxLetter";
            textBoxLetter.Size = new Size(94, 23);
            textBoxLetter.TabIndex = 2;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(3, 33);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(94, 23);
            textBoxYear.TabIndex = 1;
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Dock = DockStyle.Fill;
            labelYear.Location = new Point(3, 0);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(94, 30);
            labelYear.TabIndex = 0;
            labelYear.Text = "Год";
            labelYear.TextAlign = ContentAlignment.BottomCenter;
            // 
            // labelLetter
            // 
            labelLetter.AutoSize = true;
            labelLetter.Dock = DockStyle.Fill;
            labelLetter.Location = new Point(103, 0);
            labelLetter.Name = "labelLetter";
            labelLetter.Size = new Size(94, 30);
            labelLetter.TabIndex = 1;
            labelLetter.Text = "Буква";
            labelLetter.TextAlign = ContentAlignment.BottomCenter;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(277, 78);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(200, 23);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += this.buttonAdd_Click;
            // 
            // dataGridViewClasses
            // 
            dataGridViewClasses.AllowUserToAddRows = false;
            dataGridViewClasses.AllowUserToDeleteRows = false;
            dataGridViewClasses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClasses.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewClasses.BorderStyle = BorderStyle.None;
            dataGridViewClasses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewClasses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClasses.Dock = DockStyle.Left;
            dataGridViewClasses.Location = new Point(0, 0);
            dataGridViewClasses.Name = "dataGridViewClasses";
            dataGridViewClasses.RowHeadersVisible = false;
            dataGridViewClasses.RowTemplate.Height = 25;
            dataGridViewClasses.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewClasses.Size = new Size(271, 450);
            dataGridViewClasses.TabIndex = 4;
            // 
            // FormClasses
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(dataGridViewClasses);
            this.Controls.Add(buttonAdd);
            this.Controls.Add(tableLayoutPanel1);
            this.Name = "FormClasses";
            this.Text = "FormView";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize) dataGridViewClasses  ).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoxLetter;
        private TextBox textBoxYear;
        private Label labelYear;
        private Label labelLetter;
        private Button buttonAdd;
        private DataGridView dataGridViewClasses;
    }
}