

using Npgsql;
using SchoolSchedule.Forms;
using System.Windows;

namespace SchoolSchedule
{
    public partial class FormMain : Form
    {
        private Form activeForm;
        private Button activeButton;
        private bool isDragging = false;
        private System.Drawing.Point lastLocation;

        public FormMain()
        {
            InitializeComponent();
        }


        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                isDragging = true;
                lastLocation = e.Location;
            }
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging) {
                Control control = sender as Control;
                control.Left += e.X - lastLocation.X;
                control.Top += e.Y - lastLocation.Y;
            }
        }

        private void Control_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                isDragging = false;
            }
        }




        private void OpenChildForm(Form childForm, object buttonSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            activeForm.TopLevel = false;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            activeForm.Dock = DockStyle.Fill;
            this.panelForms.Controls.Add(activeForm);
            this.panelForms.Tag = activeForm;
            activeForm.BringToFront();
            activeForm.Show();

        }
        private void EnableButton(object buttonSender)
        {
            if (buttonSender == null)
                return;
            if (activeButton == (Button)buttonSender)
                return;
            DisableButton();
            activeButton = (Button)buttonSender;
            activeButton.BackColor = Color.FromArgb(250, 171, 54);
            activeButton.ForeColor = Color.FromArgb(10, 10, 10);

        }
        private void DisableButton()
        {
            foreach (var previousButton in this.panelButtons.Controls) {
                if (previousButton.GetType() != typeof(Button))
                    continue;
                ( (Button)previousButton ).BackColor = Color.FromArgb(0, 128, 131);
                ( (Button)previousButton ).ForeColor = Color.FromArgb(220, 220, 220);
            }
        }

        private void buttonSchedule_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSchedule(), sender);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            EnableButton(sender);
        }
        private void buttonSubjects_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSubjects(), sender);
        }
        private void buttonClasses_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormClasses(), sender);
        }
        private void buttonTeachers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTeachers(), sender);
        }

    }
}