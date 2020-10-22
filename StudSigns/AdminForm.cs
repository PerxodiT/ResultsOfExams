using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace StudSigns
{
    public partial class AdminForm : Form
    {
        int iFormX, iFormY, iMouseX, iMouseY;
        StudentContext context;
        DisciplineContext dContext;

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


        public AdminForm()
        {
            InitializeComponent();
            context = new StudentContext();
            dContext = new DisciplineContext();
            LoadData();
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.AllowUserToDeleteRows = true;

            dataGridView1.Columns["StudentNumber"].HeaderText = "Номер зачетной книги";
            dataGridView1.Columns["Name"].HeaderText = "ФИО";
            dataGridView1.Columns["Gender"].HeaderText = "Пол";
            dataGridView1.Columns["DateOfBirth"].HeaderText = "Дата рождения";
            dataGridView1.Columns["Group"].HeaderText = "Группа";
            dataGridView1.Columns["Specialty"].HeaderText = "Специальность";
            dataGridView1.Columns["Faculty"].HeaderText = "Факультет";


            //dataGridView1.Columns["DateOfBirth"].DefaultCellStyle.Format = "dd.MM.yyyy";

            AdminsDGV.Columns["Login"].HeaderText = "Логин";
            AdminsDGV.Columns["Pass"].Visible = false;

            DisciplineDGV.Columns["ID"].HeaderText = "Идентификационный номер";
            DisciplineDGV.Columns["Name"].HeaderText = "Название дисциплины";
            DisciplineDGV.Columns["Teacher"].HeaderText = "Преподаватель";

            ToolTip tooltip = new ToolTip
            {
                AutoPopDelay = 5000,
                InitialDelay = 100,
                ReshowDelay = 200
            };
            tooltip.SetToolTip(this.HelpBtn, "Для удаления записи, выделите ее в таблице и нажмите кнопку \"Delete\"");
        }



        private void LoadData()
        {

            var query = context.Students;

            var students = query.ToList();

            dataGridView1.DataSource = students;


            var disciplineDb = new DisciplineContext();
            var disciplines = disciplineDb.Disciplines.ToList();
            DisciplineDGV.DataSource = disciplines;

            var adminDb = new AdministratorContext();
            var admins = adminDb.Admins.ToList();
            AdminsDGV.DataSource = admins;
        }


        private void RefreshDB_Click(object sender, EventArgs e)
        {
                LoadData();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                $"Вы действительно хотите сохранить изменения?",
                "Вы уверены?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if (dialog == DialogResult.Yes)
            {
            context.SaveChanges();
            }
        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
        }
        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //проверка ввода фио
            if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Name"].IsInEditMode == true)
                if (!Char.IsLetter(e.KeyChar) && (e.KeyChar != 8) && !Char.IsWhiteSpace(e.KeyChar))
                    e.Handled = true;
            if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Specialty"].IsInEditMode == true)
                if (!Char.IsLetter(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != 8) && !Char.IsWhiteSpace(e.KeyChar))
                    e.Handled = true;
            if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Faculty"].IsInEditMode == true)
                if (!Char.IsLetter(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != 8) && !Char.IsWhiteSpace(e.KeyChar))
                    e.Handled = true;
            if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["DateOfBirth"].IsInEditMode == true)
                if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 8) && (e.KeyChar != '.'))
                    e.Handled = true;
            if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Group"].IsInEditMode == true)
                if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 8) && !Char.IsLetter(e.KeyChar))
                    e.Handled = true;
            if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Gender"].IsInEditMode == true)
                if (!Char.IsLetter(e.KeyChar) && (e.KeyChar != 8))
                    e.Handled = true;
        }
        private void FIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (e.KeyChar != 8) && !Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
        private void GroupTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != 8) && !Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }



        private void DeleteStudent()
        {
            string studentID;
            try
            {
                studentID = dataGridView1.CurrentRow.Cells["StudentNumber"].Value.ToString();
            } catch (Exception)
            {
                MessageBox.Show(
                "Возможно вы не выбрали строку",
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
                return;
            }
            DialogResult dialog = MessageBox.Show(
                $"Вы действительно хотите удалить студента с номером зачетной книги \"{studentID}\"?",
                "Вы уверены?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if (dialog == DialogResult.Yes)
            {
                var stud = context.Students.Find(studentID);
                if (stud != null)
                {
                    context.Students.Attach(stud);
                    context.Students.Remove(stud);
                    context.SaveChanges();
                    MessageBox.Show(
                $"Удаление успешно!",
                "Успех!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
                LoadData();
                }
                else
                {
                    MessageBox.Show(
                $"Cтудента с номером зачетной книги \"{studentID}\" не существует!",
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
                }
            }
        }
        private void DeleteDiscipline()
        {
            var Context = new DisciplineContext();
            int DisciplineID;
            try
            {
                DisciplineID = (int) DisciplineDGV.CurrentRow.Cells["ID"].Value;
            }
            catch (Exception e)
            {
                MessageBox.Show(
                "Возможно вы не выбрали строку\n" +
                e.Message,
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
                return;
            }
            DialogResult dialog = MessageBox.Show(
                $"Вы действительно хотите удалить дисциплину?",
                "Вы уверены?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if (dialog == DialogResult.Yes)
            {
                var stud = Context.Disciplines.Find(DisciplineID);
                if (stud != null)
                {
                    Context.Disciplines.Attach(stud);
                    Context.Disciplines.Remove(stud);
                    Context.SaveChanges();
                    MessageBox.Show(
                $"Удаление успешно!",
                "Успех!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
                    LoadData();
                }
            }
        }

        
        private void AddSessionResultBtn_Click(object sender, EventArgs e)
        {
            int disciplineID;
            try
            {
                disciplineID = (int)DisciplineDGV.CurrentRow.Cells["ID"].Value;
            }
            catch (Exception)
            {
                MessageBox.Show(
                "Возможно вы не выбрали дисциплину",
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
                return;
            }
            if (AddResultStudentID.Text == "")
            {
                MessageBox.Show(
                $"Все поля должны быть заполнены!",
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
                return;
            }
            var std = context.Students.Find(AddResultStudentID.Text.Trim());
            if (std == null)
            {
                MessageBox.Show(
                $"Cтудента с номером зачетной книги \"{AddResultStudentID.Text.Trim()}\" не существует!",
                "Ошибка!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
                return;
            }

            DialogResult dialog = MessageBox.Show(
                $"Вы действительно хотите добавить результат сессии?",
                "Вы уверены?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if (dialog == DialogResult.Yes)
            {
                SessionResult result = new SessionResult
                {
                    ExamDate = AddResultDateTime.Value,
                    ExamMark = (short)AddResultMark.Value,
                    DisciplineID = disciplineID
                };

                std.sessionResults.Add(result);
                context.SaveChanges();
                LoadData();
                MessageBox.Show(
                        "Успех!",
                        "Успех!",
                        MessageBoxButtons.OK
                    );
            }
        }
        private void AddDisciplineBtn_Click(object sender, EventArgs e)
        {
            if (DisciplineTextBox.Text.Trim() == "" ||
                TeacherTextBox.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Все поля должны быть заполнены!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            var toadd = new Discipline
            {
                Name = DisciplineTextBox.Text.Trim(),
                Teacher = TeacherTextBox.Text.Trim()
            };

            DialogResult dialog = MessageBox.Show(
                $"Вы действительно хотите добавить дисциплину?",
                "Вы уверены?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if (dialog == DialogResult.Yes)
            {
                dContext.Disciplines.Add(toadd);
                dContext.SaveChanges();
                LoadData();
                MessageBox.Show(
                        "Успех!",
                        "Успех!",
                        MessageBoxButtons.OK
                    );
            }

        }
        private void AddAdminBtn_Click(object sender, EventArgs e)
        {
            Regex passwordCheck = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9])\S{6,16}$");
            string login = AddAdmtb.Text.Trim(),
                   pass = AddAdmPasstb.Text;

            if (!passwordCheck.IsMatch(pass))
            {
                MessageBox.Show(
                            "Слишком слабый пароль, в пароле должна быть минимум \n" +
                            "одна цифра, одна буква(английская),\n" +
                            "большая буква и любой знак,\n" +
                            "который не цифра и не буква,\n" +
                            "длина пароля от 6 до 16 символов!\n",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                return;
            }


            DialogResult dialog = MessageBox.Show(
                $"Вы действительно хотите добавить администратора?",
                "Вы уверены?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if (dialog == DialogResult.No) return;
            if (login == "" ||
                pass == "") {
                MessageBox.Show(
                            "Все поля должны быть заполнены!",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
            }
            using (AdministratorContext db = new AdministratorContext())
            {
                var adm = db.Admins.Find(login);
                if (adm == null)
                {
                    Administrator admin  = new Administrator
                    {
                        Login = login,
                        Pass = pass
                    };
                    db.Admins.Add(admin);
                    db.SaveChanges();
                    MessageBox.Show(
                        "Успех!",
                        "Успех!",
                        MessageBoxButtons.OK
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Этот администратор уже сужествует!",
                        "Ошибка!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                }
            }
        }
        private void StudentAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                $"Вы действительно хотите добавить студента?",
                "Вы уверены?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if (dialog == DialogResult.Yes)
            {
                if (StudentID.Text.Trim() != "" &&
                FIO.Text.Trim() != "" &&
                GroupTextbox.Text.Trim() != "" &&
                Specialty.Text.Trim() != "" &&
                Faculty.Text.Trim() != ""
                )
                {
                    string id = StudentID.Text.Trim();
                    string fio = FIO.Text.Trim();
                    string group = GroupTextbox.Text.Trim();
                    string specialty = Specialty.Text.Trim();
                    string faculty = Faculty.Text.Trim();
                    string gender;
                    DateTime birthday = DateOfBirth.Value;
                    if (isMale.Checked) gender = "Мужской";
                    else gender = "Женский";

                    using (StudentContext StudentsDb = new StudentContext())
                    {
                        var std = StudentsDb.Students.Find(id);
                        if (std == null)
                        {
                            Student student = new Student
                            {
                                StudentNumber = id,
                                Name = fio,
                                Group = group,
                                Specialty = specialty,
                                Faculty = faculty,
                                Gender = gender,
                                DateOfBirth = birthday,
                                sessionResults = new List<SessionResult> { }
                            };
                            StudentsDb.Students.Add(student);
                            StudentsDb.SaveChanges();
                            MessageBox.Show(
                                "Успех!",
                                "Успех!",
                                MessageBoxButtons.OK
                            );
                        }
                        else
                        {
                            MessageBox.Show(
                                "Студент с таким номером зачетной книги уже существует!",
                                "Ошибка!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
                        }
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Все поля должны быть заполнены!",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            } 
        }
        private void SaveDisciplines_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                $"Вы действительно хотите сохранить изменения?",
                "Вы уверены?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            if (dialog == DialogResult.Yes)
            {
                dContext.SaveChanges();
            }
            LoadData();
        }


        private void AddResultStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) e.Handled = true;
        }
        private void StudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) e.Handled = true;
        }
        private void Specialty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != 8) && !Char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteStudent();
            } 
        }


        private void DisciplineDGV_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteDiscipline();
            }
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
}
