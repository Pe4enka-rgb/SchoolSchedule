namespace SchoolSchedule.Forms
{
    partial class FormSchedule
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSchedule));
            panelInfo = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            dataGridViewSchedule = new DataGridView();
            Time = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            addColumnToolStripMenuItem = new ToolStripMenuItem();
            delColumnToolStripMenuItem = new ToolStripMenuItem();
            importToolStripMenuItem = new ToolStripMenuItem();
            panelInfo.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize) dataGridViewSchedule  ).BeginInit();
            toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            panelInfo.Controls.Add(flowLayoutPanel1);
            panelInfo.Dock = DockStyle.Left;
            panelInfo.Location = new Point(0, 25);
            panelInfo.Margin = new Padding(0);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(140, 539);
            panelInfo.TabIndex = 24;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(140, 305);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(140, 25);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Location = new Point(0, 25);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(140, 25);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlDark;
            panel3.Location = new Point(0, 50);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(140, 25);
            panel3.TabIndex = 2;
            // 
            // dataGridViewSchedule
            // 
            dataGridViewSchedule.AllowUserToResizeColumns = false;
            dataGridViewSchedule.AllowUserToResizeRows = false;
            dataGridViewSchedule.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSchedule.Columns.AddRange(new DataGridViewColumn[] { Time });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Gainsboro;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewSchedule.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewSchedule.Dock = DockStyle.Fill;
            dataGridViewSchedule.Location = new Point(140, 25);
            dataGridViewSchedule.Margin = new Padding(0);
            dataGridViewSchedule.Name = "dataGridViewSchedule";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewSchedule.RowHeadersVisible = false;
            dataGridViewSchedule.RowHeadersWidth = 40;
            dataGridViewCellStyle4.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewSchedule.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewSchedule.RowTemplate.Height = 40;
            dataGridViewSchedule.Size = new Size(949, 539);
            dataGridViewSchedule.TabIndex = 25;
            // 
            // Time
            // 
            Time.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Time.HeaderText = "Время";
            Time.Name = "Time";
            Time.Width = 117;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1089, 25);
            toolStrip1.TabIndex = 26;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { addColumnToolStripMenuItem, delColumnToolStripMenuItem, importToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image) resources.GetObject("toolStripDropDownButton1.Image") ;
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(29, 22);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // addColumnToolStripMenuItem
            // 
            addColumnToolStripMenuItem.Name = "addColumnToolStripMenuItem";
            addColumnToolStripMenuItem.Size = new Size(180, 22);
            addColumnToolStripMenuItem.Text = "addColumn";
            addColumnToolStripMenuItem.Click += this.addColumnToolStripMenuItem_Click;
            // 
            // delColumnToolStripMenuItem
            // 
            delColumnToolStripMenuItem.Name = "delColumnToolStripMenuItem";
            delColumnToolStripMenuItem.Size = new Size(180, 22);
            delColumnToolStripMenuItem.Text = "delColumn";
            delColumnToolStripMenuItem.Click += this.delColumnToolStripMenuItem_Click;
            // 
            // importToolStripMenuItem
            // 
            importToolStripMenuItem.Name = "importToolStripMenuItem";
            importToolStripMenuItem.Size = new Size(180, 22);
            importToolStripMenuItem.Text = "Import";
            importToolStripMenuItem.Click += this.importToolStripMenuItem_Click;
            // 
            // FormSchedule
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1089, 564);
            this.Controls.Add(dataGridViewSchedule);
            this.Controls.Add(panelInfo);
            this.Controls.Add(toolStrip1);
            this.Name = "FormSchedule";
            this.Text = "FormSchedule";
            panelInfo.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ( (System.ComponentModel.ISupportInitialize) dataGridViewSchedule  ).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private Panel panelInfo;
        private DataGridView dataGridViewSchedule;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem addColumnToolStripMenuItem;
        private ToolStripMenuItem delColumnToolStripMenuItem;
        private DataGridViewTextBoxColumn Time;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ToolStripMenuItem importToolStripMenuItem;
    }
}