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

        private void Form_MouseDown(object sender, MouseEventArgs e)
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

        private Student Stud;
        public StudentForm(string studnumber)
        {
            InitializeComponent();
            StudentContext context = new StudentContext();
            Stud = context.Students.Find(studnumber);
            LoadData();
            DisciplineID = null;

            StudentID.Text = Stud.StudentNumber;
            FIO.Text = Stud.Name;
            Group.Text = Stud.Group;
            Specialty.Text = Stud.Specialty;
            Faculty.Text = Stud.Faculty;
            Gender.Text = Stud.Gender;
            DateOfBirth.Text = Stud.DateOfBirth.ToString("d");
        }

        private void DisciplineDataShowBtn_Click(object sender, EventArgs e)
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
        }

        private void LoadData()
        {
            var db = new SessionContext();
            var results = db.Sessions.Where(s => s.Student.StudentNumber == Stud.StudentNumber).ToList();
            ResultDGV.DataSource = results;


            ResultDGV.Columns["Student"].Visible = false;
            ResultDGV.Columns["ID"].Visible = false;
            ResultDGV.Columns["DisciplineID"].Visible = false;
            ResultDGV.Columns["Discipline"].Visible = false;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

    class SRes
    {
        public DateTime ExamDate { get; set; }
        public ushort ExamMark { get; set; }
    }
}
