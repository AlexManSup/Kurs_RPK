namespace Kurs_RPK
{
    partial class LogInForm
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
            this.AdminB = new System.Windows.Forms.Button();
            this.UserB = new System.Windows.Forms.Button();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.EnterPassLab = new System.Windows.Forms.Label();
            this.PassEnter = new System.Windows.Forms.Button();
            this.BackB = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // AdminB
            // 
            this.AdminB.Location = new System.Drawing.Point(58, 56);
            this.AdminB.Name = "AdminB";
            this.AdminB.Size = new System.Drawing.Size(139, 23);
            this.AdminB.TabIndex = 0;
            this.AdminB.Text = "Администратор";
            this.AdminB.UseVisualStyleBackColor = true;
            this.AdminB.Click += new System.EventHandler(this.AdminB_Click);
            this.AdminB.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.About_HelpRequested);
            // 
            // UserB
            // 
            this.UserB.Location = new System.Drawing.Point(58, 98);
            this.UserB.Name = "UserB";
            this.UserB.Size = new System.Drawing.Size(139, 23);
            this.UserB.TabIndex = 1;
            this.UserB.Text = "Пользователь";
            this.UserB.UseVisualStyleBackColor = true;
            this.UserB.Click += new System.EventHandler(this.UserB_Click);
            this.UserB.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.About_HelpRequested);
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(58, 72);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '*';
            this.PasswordTB.Size = new System.Drawing.Size(139, 20);
            this.PasswordTB.TabIndex = 2;
            this.PasswordTB.UseSystemPasswordChar = true;
            this.PasswordTB.Visible = false;
            this.PasswordTB.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.About_HelpRequested);
            // 
            // EnterPassLab
            // 
            this.EnterPassLab.AutoSize = true;
            this.EnterPassLab.Location = new System.Drawing.Point(82, 54);
            this.EnterPassLab.Name = "EnterPassLab";
            this.EnterPassLab.Size = new System.Drawing.Size(91, 13);
            this.EnterPassLab.TabIndex = 3;
            this.EnterPassLab.Text = "Введите пароль:";
            this.EnterPassLab.Visible = false;
            this.EnterPassLab.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.About_HelpRequested);
            // 
            // PassEnter
            // 
            this.PassEnter.Location = new System.Drawing.Point(85, 98);
            this.PassEnter.Name = "PassEnter";
            this.PassEnter.Size = new System.Drawing.Size(88, 23);
            this.PassEnter.TabIndex = 4;
            this.PassEnter.Text = "Ввод";
            this.PassEnter.UseVisualStyleBackColor = true;
            this.PassEnter.Visible = false;
            this.PassEnter.Click += new System.EventHandler(this.PassEnter_Click);
            this.PassEnter.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.About_HelpRequested);
            // 
            // BackB
            // 
            this.BackB.Location = new System.Drawing.Point(85, 127);
            this.BackB.Name = "BackB";
            this.BackB.Size = new System.Drawing.Size(88, 23);
            this.BackB.TabIndex = 13;
            this.BackB.Text = "Назад";
            this.BackB.UseVisualStyleBackColor = true;
            this.BackB.Visible = false;
            this.BackB.Click += new System.EventHandler(this.BackB_Click);
            this.BackB.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.About_HelpRequested);
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(176, 3);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(75, 23);
            this.About.TabIndex = 14;
            this.About.Text = "Автор";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            this.About.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.About_HelpRequested);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Help.chm";
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 155);
            this.Controls.Add(this.About);
            this.Controls.Add(this.BackB);
            this.Controls.Add(this.PassEnter);
            this.Controls.Add(this.EnterPassLab);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.UserB);
            this.Controls.Add(this.AdminB);
            this.HelpButton = true;
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogInForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminB;
        private System.Windows.Forms.Button UserB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label EnterPassLab;
        private System.Windows.Forms.Button PassEnter;
        private System.Windows.Forms.Button BackB;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

