namespace StudSigns
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExitButton = new System.Windows.Forms.Button();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.StudentInput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StudID = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.AdminPass = new System.Windows.Forms.TextBox();
            this.AdminInput = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AdminLogin = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.Tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ExitButton.Location = new System.Drawing.Point(256, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(27, 28);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Controls.Add(this.tabPage2);
            this.Tabs.Location = new System.Drawing.Point(4, 35);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(282, 150);
            this.Tabs.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.Controls.Add(this.StudentInput);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.StudID);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(274, 124);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Студент";
            // 
            // StudentInput
            // 
            this.StudentInput.BackColor = System.Drawing.Color.DimGray;
            this.StudentInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StudentInput.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.StudentInput.FlatAppearance.BorderSize = 0;
            this.StudentInput.Location = new System.Drawing.Point(12, 59);
            this.StudentInput.Name = "StudentInput";
            this.StudentInput.Size = new System.Drawing.Size(251, 23);
            this.StudentInput.TabIndex = 2;
            this.StudentInput.Text = "Войти";
            this.StudentInput.UseVisualStyleBackColor = false;
            this.StudentInput.Click += new System.EventHandler(this.StudentInput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Номер зачетной книги";
            // 
            // StudID
            // 
            this.StudID.AcceptsReturn = true;
            this.StudID.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.StudID.Location = new System.Drawing.Point(11, 32);
            this.StudID.MaxLength = 10;
            this.StudID.Name = "StudID";
            this.StudID.Size = new System.Drawing.Size(252, 20);
            this.StudID.TabIndex = 0;
            this.StudID.WordWrap = false;
            this.StudID.Enter += new System.EventHandler(this.StudID_Enter);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.AdminPass);
            this.tabPage2.Controls.Add(this.AdminInput);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.AdminLogin);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(274, 124);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Администратор";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пароль";
            // 
            // AdminPass
            // 
            this.AdminPass.AcceptsReturn = true;
            this.AdminPass.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.AdminPass.Location = new System.Drawing.Point(11, 66);
            this.AdminPass.Name = "AdminPass";
            this.AdminPass.PasswordChar = '#';
            this.AdminPass.Size = new System.Drawing.Size(252, 20);
            this.AdminPass.TabIndex = 6;
            this.AdminPass.Text = "admin";
            this.AdminPass.Enter += new System.EventHandler(this.AdminLogin_Enter);
            // 
            // AdminInput
            // 
            this.AdminInput.BackColor = System.Drawing.Color.DimGray;
            this.AdminInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AdminInput.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.AdminInput.FlatAppearance.BorderSize = 0;
            this.AdminInput.Location = new System.Drawing.Point(7, 92);
            this.AdminInput.Name = "AdminInput";
            this.AdminInput.Size = new System.Drawing.Size(261, 22);
            this.AdminInput.TabIndex = 5;
            this.AdminInput.Text = "Войти";
            this.AdminInput.UseVisualStyleBackColor = false;
            this.AdminInput.Click += new System.EventHandler(this.AdminInput_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Логин";
            // 
            // AdminLogin
            // 
            this.AdminLogin.AcceptsReturn = true;
            this.AdminLogin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.AdminLogin.Location = new System.Drawing.Point(11, 24);
            this.AdminLogin.Name = "AdminLogin";
            this.AdminLogin.Size = new System.Drawing.Size(252, 20);
            this.AdminLogin.TabIndex = 3;
            this.AdminLogin.Text = "admin";
            this.AdminLogin.WordWrap = false;
            this.AdminLogin.Enter += new System.EventHandler(this.AdminLogin_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 25);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(8, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Результаты экзаменационных сессий";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Gray;
            this.MinimizeButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimizeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.MinimizeButton.Location = new System.Drawing.Point(227, 2);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(27, 28);
            this.MinimizeButton.TabIndex = 7;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.StudentInput;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(290, 190);
            this.ControlBox = false;
            this.Controls.Add(this.MinimizeButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.Tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button StudentInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StudID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AdminPass;
        private System.Windows.Forms.Button AdminInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AdminLogin;
        private System.Windows.Forms.Button MinimizeButton;
    }
}

