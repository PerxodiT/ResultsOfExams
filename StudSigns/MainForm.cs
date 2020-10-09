using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace StudSigns
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AdminPass.ContextMenu = new ContextMenu();
            AdminPass.ShortcutsEnabled = false;
        }
        
        int iFormX, iFormY, iMouseX, iMouseY;

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

        private void StudID_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = this.StudentInput;
        }

        private void AdminLogin_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = this.AdminInput;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminInput_Click(object sender, EventArgs e)
        {
            using (AdministratorContext AdminDb = new AdministratorContext())
            {
                string login = AdminLogin.Text;
                string pass = AdminPass.Text;
                var admin = AdminDb.Admins.Where(a => a.Login == login && a.Pass == pass);
                if (admin != null) {
                        Form adminform = new AdminForm();
                        adminform.Show();
                    }
                else
                {
                    MessageBox.Show(
                        "Неверный логин или пароль!",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void StudentInput_Click(object sender, EventArgs e)
        {
            using (StudentContext StudentsDb = new StudentContext())
            {
                string id = StudID.Text;
                var studs = StudentsDb.Students;
                var stud = studs.Find(id);
                {
                    if (stud != null)
                    {
                        Form form = new StudentForm(stud.StudentNumber);
                        form.Show();
                    }
                    else
                        MessageBox.Show(
                            $"Cтудента с номером зачетной книги \"{id}\" не существует!",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                }
            }
        }


    }
}
