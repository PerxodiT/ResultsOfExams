namespace StudSigns
{
    partial class AdminForm
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
            if (disposing && (components != null))
            {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.AddResultTab = new System.Windows.Forms.TabPage();
            this.SaveDisciplines = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.AddDisciplineBtn = new System.Windows.Forms.Button();
            this.TeacherTextBox = new System.Windows.Forms.TextBox();
            this.DisciplineTextBox = new System.Windows.Forms.TextBox();
            this.DisciplineDGV = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.AddSessionResultBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.AddResultMark = new System.Windows.Forms.NumericUpDown();
            this.AddResultDateTime = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.AddResultStudentID = new System.Windows.Forms.TextBox();
            this.AdminAddtab = new System.Windows.Forms.TabPage();
            this.AddAdminBtn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AddAdmPasstb = new System.Windows.Forms.TextBox();
            this.AddAdmtb = new System.Windows.Forms.TextBox();
            this.SaveAdminChanges = new System.Windows.Forms.Button();
            this.AdminsDGV = new System.Windows.Forms.DataGridView();
            this.UpdateStudentTab = new System.Windows.Forms.TabPage();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.RefreshDB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CreateStudentTab = new System.Windows.Forms.TabPage();
            this.StudentAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.isFemale = new System.Windows.Forms.RadioButton();
            this.isMale = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.Faculty = new System.Windows.Forms.TextBox();
            this.Specialty = new System.Windows.Forms.TextBox();
            this.GroupTextbox = new System.Windows.Forms.TextBox();
            this.FIO = new System.Windows.Forms.TextBox();
            this.StudentID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.AddResultTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisciplineDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddResultMark)).BeginInit();
            this.AdminAddtab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminsDGV)).BeginInit();
            this.UpdateStudentTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.CreateStudentTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ExitButton.Location = new System.Drawing.Point(843, 10);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(27, 28);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(8, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Результаты экзаменационных сессий - Администратор";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 25);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Gray;
            this.MinimizeButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimizeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.MinimizeButton.Location = new System.Drawing.Point(814, 10);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(27, 28);
            this.MinimizeButton.TabIndex = 6;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // AddResultTab
            // 
            this.AddResultTab.BackColor = System.Drawing.Color.LightGray;
            this.AddResultTab.Controls.Add(this.SaveDisciplines);
            this.AddResultTab.Controls.Add(this.label14);
            this.AddResultTab.Controls.Add(this.label13);
            this.AddResultTab.Controls.Add(this.AddDisciplineBtn);
            this.AddResultTab.Controls.Add(this.TeacherTextBox);
            this.AddResultTab.Controls.Add(this.DisciplineTextBox);
            this.AddResultTab.Controls.Add(this.DisciplineDGV);
            this.AddResultTab.Controls.Add(this.label12);
            this.AddResultTab.Controls.Add(this.AddSessionResultBtn);
            this.AddResultTab.Controls.Add(this.label11);
            this.AddResultTab.Controls.Add(this.AddResultMark);
            this.AddResultTab.Controls.Add(this.AddResultDateTime);
            this.AddResultTab.Controls.Add(this.label10);
            this.AddResultTab.Controls.Add(this.AddResultStudentID);
            this.AddResultTab.Location = new System.Drawing.Point(4, 22);
            this.AddResultTab.Name = "AddResultTab";
            this.AddResultTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddResultTab.Size = new System.Drawing.Size(850, 368);
            this.AddResultTab.TabIndex = 4;
            this.AddResultTab.Text = "Добавить результат сессии";
            // 
            // SaveDisciplines
            // 
            this.SaveDisciplines.BackColor = System.Drawing.Color.YellowGreen;
            this.SaveDisciplines.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaveDisciplines.Location = new System.Drawing.Point(380, 328);
            this.SaveDisciplines.Name = "SaveDisciplines";
            this.SaveDisciplines.Size = new System.Drawing.Size(464, 27);
            this.SaveDisciplines.TabIndex = 25;
            this.SaveDisciplines.Text = "Сохранить изменения";
            this.SaveDisciplines.UseVisualStyleBackColor = false;
            this.SaveDisciplines.Click += new System.EventHandler(this.SaveDisciplines_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(380, 250);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Преподаватель";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(380, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Название дисциплины";
            // 
            // AddDisciplineBtn
            // 
            this.AddDisciplineBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.AddDisciplineBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddDisciplineBtn.Location = new System.Drawing.Point(380, 295);
            this.AddDisciplineBtn.Name = "AddDisciplineBtn";
            this.AddDisciplineBtn.Size = new System.Drawing.Size(464, 27);
            this.AddDisciplineBtn.TabIndex = 22;
            this.AddDisciplineBtn.Text = "Добавить дисциплину";
            this.AddDisciplineBtn.UseVisualStyleBackColor = false;
            this.AddDisciplineBtn.Click += new System.EventHandler(this.AddDisciplineBtn_Click);
            // 
            // TeacherTextBox
            // 
            this.TeacherTextBox.Location = new System.Drawing.Point(380, 269);
            this.TeacherTextBox.Name = "TeacherTextBox";
            this.TeacherTextBox.Size = new System.Drawing.Size(464, 20);
            this.TeacherTextBox.TabIndex = 21;
            // 
            // DisciplineTextBox
            // 
            this.DisciplineTextBox.Location = new System.Drawing.Point(380, 220);
            this.DisciplineTextBox.Name = "DisciplineTextBox";
            this.DisciplineTextBox.Size = new System.Drawing.Size(464, 20);
            this.DisciplineTextBox.TabIndex = 20;
            // 
            // DisciplineDGV
            // 
            this.DisciplineDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisciplineDGV.Location = new System.Drawing.Point(380, 28);
            this.DisciplineDGV.MultiSelect = false;
            this.DisciplineDGV.Name = "DisciplineDGV";
            this.DisciplineDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DisciplineDGV.Size = new System.Drawing.Size(464, 170);
            this.DisciplineDGV.TabIndex = 19;
            this.DisciplineDGV.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DisciplineDGV_KeyUp);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(377, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Дисциплина";
            // 
            // AddSessionResultBtn
            // 
            this.AddSessionResultBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.AddSessionResultBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddSessionResultBtn.Location = new System.Drawing.Point(8, 130);
            this.AddSessionResultBtn.Name = "AddSessionResultBtn";
            this.AddSessionResultBtn.Size = new System.Drawing.Size(200, 27);
            this.AddSessionResultBtn.TabIndex = 16;
            this.AddSessionResultBtn.Text = "Добавить результат сессии";
            this.AddSessionResultBtn.UseVisualStyleBackColor = false;
            this.AddSessionResultBtn.Click += new System.EventHandler(this.AddSessionResultBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Отметка за экзамен";
            // 
            // AddResultMark
            // 
            this.AddResultMark.Location = new System.Drawing.Point(8, 104);
            this.AddResultMark.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.AddResultMark.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AddResultMark.Name = "AddResultMark";
            this.AddResultMark.Size = new System.Drawing.Size(200, 20);
            this.AddResultMark.TabIndex = 3;
            this.AddResultMark.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddResultDateTime
            // 
            this.AddResultDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AddResultDateTime.Location = new System.Drawing.Point(8, 58);
            this.AddResultDateTime.Name = "AddResultDateTime";
            this.AddResultDateTime.Size = new System.Drawing.Size(200, 20);
            this.AddResultDateTime.TabIndex = 2;
            this.AddResultDateTime.Value = new System.DateTime(2020, 10, 8, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Номер зачетной книги студента";
            // 
            // AddResultStudentID
            // 
            this.AddResultStudentID.Location = new System.Drawing.Point(8, 31);
            this.AddResultStudentID.Name = "AddResultStudentID";
            this.AddResultStudentID.Size = new System.Drawing.Size(200, 20);
            this.AddResultStudentID.TabIndex = 0;
            this.AddResultStudentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddResultStudentID_KeyPress);
            // 
            // AdminAddtab
            // 
            this.AdminAddtab.BackColor = System.Drawing.Color.Silver;
            this.AdminAddtab.Controls.Add(this.AddAdminBtn);
            this.AdminAddtab.Controls.Add(this.label15);
            this.AdminAddtab.Controls.Add(this.label9);
            this.AdminAddtab.Controls.Add(this.AddAdmPasstb);
            this.AdminAddtab.Controls.Add(this.AddAdmtb);
            this.AdminAddtab.Controls.Add(this.SaveAdminChanges);
            this.AdminAddtab.Controls.Add(this.AdminsDGV);
            this.AdminAddtab.Location = new System.Drawing.Point(4, 22);
            this.AdminAddtab.Name = "AdminAddtab";
            this.AdminAddtab.Padding = new System.Windows.Forms.Padding(3);
            this.AdminAddtab.Size = new System.Drawing.Size(850, 368);
            this.AdminAddtab.TabIndex = 3;
            this.AdminAddtab.Text = "Добавить администратора";
            // 
            // AddAdminBtn
            // 
            this.AddAdminBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddAdminBtn.Location = new System.Drawing.Point(8, 124);
            this.AddAdminBtn.Name = "AddAdminBtn";
            this.AddAdminBtn.Size = new System.Drawing.Size(248, 23);
            this.AddAdminBtn.TabIndex = 8;
            this.AddAdminBtn.Text = "Добавить администратора";
            this.AddAdminBtn.UseVisualStyleBackColor = false;
            this.AddAdminBtn.Click += new System.EventHandler(this.AddAdminBtn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 67);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Пароль";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Логин";
            // 
            // AddAdmPasstb
            // 
            this.AddAdmPasstb.Location = new System.Drawing.Point(8, 83);
            this.AddAdmPasstb.Name = "AddAdmPasstb";
            this.AddAdmPasstb.Size = new System.Drawing.Size(248, 20);
            this.AddAdmPasstb.TabIndex = 5;
            // 
            // AddAdmtb
            // 
            this.AddAdmtb.Location = new System.Drawing.Point(8, 38);
            this.AddAdmtb.Name = "AddAdmtb";
            this.AddAdmtb.Size = new System.Drawing.Size(248, 20);
            this.AddAdmtb.TabIndex = 4;
            // 
            // SaveAdminChanges
            // 
            this.SaveAdminChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SaveAdminChanges.Location = new System.Drawing.Point(568, 339);
            this.SaveAdminChanges.Name = "SaveAdminChanges";
            this.SaveAdminChanges.Size = new System.Drawing.Size(276, 23);
            this.SaveAdminChanges.TabIndex = 3;
            this.SaveAdminChanges.Text = "Сохранить изменения";
            this.SaveAdminChanges.UseVisualStyleBackColor = false;
            // 
            // AdminsDGV
            // 
            this.AdminsDGV.AllowUserToAddRows = false;
            this.AdminsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminsDGV.Location = new System.Drawing.Point(568, 6);
            this.AdminsDGV.Name = "AdminsDGV";
            this.AdminsDGV.Size = new System.Drawing.Size(276, 327);
            this.AdminsDGV.TabIndex = 1;
            // 
            // UpdateStudentTab
            // 
            this.UpdateStudentTab.Controls.Add(this.HelpBtn);
            this.UpdateStudentTab.Controls.Add(this.SaveButton);
            this.UpdateStudentTab.Controls.Add(this.RefreshDB);
            this.UpdateStudentTab.Controls.Add(this.dataGridView1);
            this.UpdateStudentTab.Location = new System.Drawing.Point(4, 22);
            this.UpdateStudentTab.Name = "UpdateStudentTab";
            this.UpdateStudentTab.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateStudentTab.Size = new System.Drawing.Size(850, 368);
            this.UpdateStudentTab.TabIndex = 1;
            this.UpdateStudentTab.Text = "Редактировать студента";
            this.UpdateStudentTab.UseVisualStyleBackColor = true;
            // 
            // HelpBtn
            // 
            this.HelpBtn.Location = new System.Drawing.Point(827, 7);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(17, 23);
            this.HelpBtn.TabIndex = 3;
            this.HelpBtn.Text = "?";
            this.HelpBtn.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SaveButton.Location = new System.Drawing.Point(428, 336);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(416, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Сохранить изменения";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // RefreshDB
            // 
            this.RefreshDB.Location = new System.Drawing.Point(8, 336);
            this.RefreshDB.Name = "RefreshDB";
            this.RefreshDB.Size = new System.Drawing.Size(414, 23);
            this.RefreshDB.TabIndex = 1;
            this.RefreshDB.Text = "Обновить список";
            this.RefreshDB.UseVisualStyleBackColor = true;
            this.RefreshDB.Click += new System.EventHandler(this.RefreshDB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 7);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(817, 323);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // CreateStudentTab
            // 
            this.CreateStudentTab.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CreateStudentTab.Controls.Add(this.StudentAdd);
            this.CreateStudentTab.Controls.Add(this.label8);
            this.CreateStudentTab.Controls.Add(this.DateOfBirth);
            this.CreateStudentTab.Controls.Add(this.label7);
            this.CreateStudentTab.Controls.Add(this.isFemale);
            this.CreateStudentTab.Controls.Add(this.isMale);
            this.CreateStudentTab.Controls.Add(this.label6);
            this.CreateStudentTab.Controls.Add(this.Faculty);
            this.CreateStudentTab.Controls.Add(this.Specialty);
            this.CreateStudentTab.Controls.Add(this.GroupTextbox);
            this.CreateStudentTab.Controls.Add(this.FIO);
            this.CreateStudentTab.Controls.Add(this.StudentID);
            this.CreateStudentTab.Controls.Add(this.label5);
            this.CreateStudentTab.Controls.Add(this.label4);
            this.CreateStudentTab.Controls.Add(this.label3);
            this.CreateStudentTab.Controls.Add(this.label1);
            this.CreateStudentTab.ForeColor = System.Drawing.SystemColors.Control;
            this.CreateStudentTab.Location = new System.Drawing.Point(4, 22);
            this.CreateStudentTab.Name = "CreateStudentTab";
            this.CreateStudentTab.Padding = new System.Windows.Forms.Padding(3);
            this.CreateStudentTab.Size = new System.Drawing.Size(850, 368);
            this.CreateStudentTab.TabIndex = 0;
            this.CreateStudentTab.Text = "Добавить студента";
            // 
            // StudentAdd
            // 
            this.StudentAdd.BackColor = System.Drawing.Color.YellowGreen;
            this.StudentAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.StudentAdd.Location = new System.Drawing.Point(179, 295);
            this.StudentAdd.Name = "StudentAdd";
            this.StudentAdd.Size = new System.Drawing.Size(200, 27);
            this.StudentAdd.TabIndex = 15;
            this.StudentAdd.Text = "Добавить";
            this.StudentAdd.UseVisualStyleBackColor = false;
            this.StudentAdd.Click += new System.EventHandler(this.StudentAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Дата рождения";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateOfBirth.Location = new System.Drawing.Point(179, 235);
            this.DateOfBirth.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.DateOfBirth.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.DateOfBirth.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Пол";
            // 
            // isFemale
            // 
            this.isFemale.AutoSize = true;
            this.isFemale.Location = new System.Drawing.Point(266, 35);
            this.isFemale.Name = "isFemale";
            this.isFemale.Size = new System.Drawing.Size(72, 17);
            this.isFemale.TabIndex = 11;
            this.isFemale.Text = "Женский";
            this.isFemale.UseVisualStyleBackColor = true;
            // 
            // isMale
            // 
            this.isMale.AutoSize = true;
            this.isMale.Checked = true;
            this.isMale.Location = new System.Drawing.Point(179, 35);
            this.isMale.Name = "isMale";
            this.isMale.Size = new System.Drawing.Size(71, 17);
            this.isMale.TabIndex = 10;
            this.isMale.TabStop = true;
            this.isMale.Text = "Мужской";
            this.isMale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Факультет";
            // 
            // Faculty
            // 
            this.Faculty.Location = new System.Drawing.Point(22, 299);
            this.Faculty.Name = "Faculty";
            this.Faculty.Size = new System.Drawing.Size(121, 20);
            this.Faculty.TabIndex = 8;
            this.Faculty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Specialty_KeyPress);
            // 
            // Specialty
            // 
            this.Specialty.Location = new System.Drawing.Point(22, 235);
            this.Specialty.Name = "Specialty";
            this.Specialty.Size = new System.Drawing.Size(121, 20);
            this.Specialty.TabIndex = 6;
            this.Specialty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Specialty_KeyPress);
            // 
            // GroupTextbox
            // 
            this.GroupTextbox.Location = new System.Drawing.Point(22, 172);
            this.GroupTextbox.Name = "GroupTextbox";
            this.GroupTextbox.Size = new System.Drawing.Size(121, 20);
            this.GroupTextbox.TabIndex = 4;
            this.GroupTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GroupTextbox_KeyPress);
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(22, 109);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(121, 20);
            this.FIO.TabIndex = 2;
            this.FIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FIO_KeyPress);
            // 
            // StudentID
            // 
            this.StudentID.Location = new System.Drawing.Point(22, 42);
            this.StudentID.Name = "StudentID";
            this.StudentID.Size = new System.Drawing.Size(121, 20);
            this.StudentID.TabIndex = 0;
            this.StudentID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StudentID_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Специальность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Группа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ФИО";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер зачетной книги";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CreateStudentTab);
            this.tabControl1.Controls.Add(this.UpdateStudentTab);
            this.tabControl1.Controls.Add(this.AdminAddtab);
            this.tabControl1.Controls.Add(this.AddResultTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(858, 394);
            this.tabControl1.TabIndex = 5;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "Администратор";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AddResultTab.ResumeLayout(false);
            this.AddResultTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DisciplineDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddResultMark)).EndInit();
            this.AdminAddtab.ResumeLayout(false);
            this.AdminAddtab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminsDGV)).EndInit();
            this.UpdateStudentTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.CreateStudentTab.ResumeLayout(false);
            this.CreateStudentTab.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.TabPage AddResultTab;
        private System.Windows.Forms.DataGridView DisciplineDGV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button AddSessionResultBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown AddResultMark;
        private System.Windows.Forms.DateTimePicker AddResultDateTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AddResultStudentID;
        private System.Windows.Forms.TabPage AdminAddtab;
        private System.Windows.Forms.TabPage UpdateStudentTab;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button RefreshDB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage CreateStudentTab;
        private System.Windows.Forms.Button StudentAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker DateOfBirth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton isFemale;
        private System.Windows.Forms.RadioButton isMale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Faculty;
        private System.Windows.Forms.TextBox Specialty;
        private System.Windows.Forms.TextBox GroupTextbox;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.TextBox StudentID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button SaveDisciplines;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button AddDisciplineBtn;
        private System.Windows.Forms.TextBox TeacherTextBox;
        private System.Windows.Forms.TextBox DisciplineTextBox;
        private System.Windows.Forms.DataGridView AdminsDGV;
        private System.Windows.Forms.Button AddAdminBtn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AddAdmPasstb;
        private System.Windows.Forms.TextBox AddAdmtb;
        private System.Windows.Forms.Button SaveAdminChanges;
        private System.Windows.Forms.Button HelpBtn;
    }
}