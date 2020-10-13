using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudSigns
{
    public partial class StudentForm : Form
    {

        int iFormX, iFormY, iMouseX, iMouseY;
        Nullable<int> DisciplineID;

        private void Form_MouseDown(object sender, MouseEventArgs e) // Events for move form
        {
            iFormX = this.Location.X;
            iFormY = this.Location.Y;
            iMouseX = MousePosition.X;
            iMouseY = MousePosition.Y;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            int iMouseX2 = MousePosition.X;
            int iMouseY2 = MousePosition.Y;
            if (e.Button == MouseButtons.Left)
                this.Location = new Point(iFormX + (iMouseX2 - iMouseX), iFormY + (iMouseY2 - iMouseY));
        }

        private void MinimizeButton_Click(object sender, EventArgs e) // Form control buttons
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Student Stud; //Authentificated student
        public StudentForm(string studnumber)
        {
            InitializeComponent();
            StudentContext context = new StudentContext();
            Stud = context.Students.Find(studnumber);
            DisciplineID = null;
            LoadData();

            StudentID.Text = Stud.StudentNumber; // Set info about student
            FIO.Text = Stud.Name;
            Group.Text = Stud.Group;
            Specialty.Text = Stud.Specialty;
            Faculty.Text = Stud.Faculty;
            Gender.Text = Stud.Gender;
            DateOfBirth.Text = Stud.DateOfBirth.ToString("d");


            ResultDGV.Columns["ExamDate"].HeaderText = "Дата экзамена";
            ResultDGV.Columns["ExamMark"].HeaderText = "Отметка за экзамен";
        }

        private void DisciplineDataShowBtn_Click(object sender, EventArgs e) // Show info about discipline
        {
            try
            {
                DisciplineID = (Nullable<int>)ResultDGV.CurrentRow.Cells["DisciplineID"].Value;
                if (DisciplineID == null)
                {
                    DisciplineDGV.Rows.Clear();
                    return;
                }

                var db = new DisciplineContext();
                var DisciplineDataSource = db.Disciplines.Where(d => d.ID == DisciplineID).ToList();
                DisciplineDGV.DataSource = DisciplineDataSource;
                DisciplineDGV.Columns["ID"].Visible = false;

                DisciplineDGV.Columns["Name"].HeaderText = "Название дисциплины"; // Localisation of tables
                DisciplineDGV.Columns["Teacher"].HeaderText = "Преподаватель";
            } catch (Exception ex)
            {
                MessageBox.Show(
                        ex.Message,
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
            }
        }

        private void LoadData() // Show session results
        {
            var db = new SessionContext();
            var results = db.Sessions.Where(s => s.Student.StudentNumber == Stud.StudentNumber).ToList();
            ResultDGV.DataSource = results;


            ResultDGV.Columns["Student"].Visible = false;
            ResultDGV.Columns["ID"].Visible = false;
            ResultDGV.Columns["DisciplineID"].Visible = false;
            ResultDGV.Columns["Discipline"].Visible = false;
        }
    }
}
