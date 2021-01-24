namespace Kurs_RPK
{
    partial class MForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeachersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Head = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.DeleteEmployee = new System.Windows.Forms.Button();
            this.QueryList = new System.Windows.Forms.ListBox();
            this.QueryTB = new System.Windows.Forms.TextBox();
            this.ExecuteQuery = new System.Windows.Forms.Button();
            this.QueryCB = new System.Windows.Forms.ComboBox();
            this.QueryMTB = new System.Windows.Forms.MaskedTextBox();
            this.QueryTBL = new System.Windows.Forms.Label();
            this.QueryCBL = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SName,
            this.Group,
            this.Type,
            this.Semester,
            this.Class,
            this.TeachersName,
            this.SubFaculty,
            this.Head,
            this.Number});
            this.dataGridView1.Location = new System.Drawing.Point(11, 27);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1068, 333);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Зачетная книжка";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 60;
            // 
            // SName
            // 
            this.SName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SName.DataPropertyName = "StudName";
            this.SName.HeaderText = "ФИО";
            this.SName.Name = "SName";
            this.SName.ReadOnly = true;
            this.SName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SName.Width = 110;
            // 
            // Group
            // 
            this.Group.DataPropertyName = "Group";
            this.Group.HeaderText = "Группа";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            this.Group.Width = 67;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Вид задолженности";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 122;
            // 
            // Semester
            // 
            this.Semester.DataPropertyName = "Semester";
            this.Semester.HeaderText = "Семестр";
            this.Semester.Name = "Semester";
            this.Semester.ReadOnly = true;
            this.Semester.Width = 76;
            // 
            // Class
            // 
            this.Class.DataPropertyName = "Class";
            this.Class.HeaderText = "Дисциплина";
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            this.Class.Width = 95;
            // 
            // TeachersName
            // 
            this.TeachersName.DataPropertyName = "TeachersName";
            this.TeachersName.HeaderText = "Фио преподавателя";
            this.TeachersName.Name = "TeachersName";
            this.TeachersName.ReadOnly = true;
            this.TeachersName.Width = 123;
            // 
            // SubFaculty
            // 
            this.SubFaculty.DataPropertyName = "SubFaculty";
            this.SubFaculty.HeaderText = "Кафедра преподавателя";
            this.SubFaculty.Name = "SubFaculty";
            this.SubFaculty.ReadOnly = true;
            this.SubFaculty.Width = 143;
            // 
            // Head
            // 
            this.Head.DataPropertyName = "Head";
            this.Head.HeaderText = "Зав. кафедрой";
            this.Head.Name = "Head";
            this.Head.ReadOnly = true;
            this.Head.Width = 98;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Номер зав. кафедрой";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 131;
            // 
            // AddEmployee
            // 
            this.AddEmployee.Location = new System.Drawing.Point(12, 421);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(106, 23);
            this.AddEmployee.TabIndex = 2;
            this.AddEmployee.Text = "Добавить запись";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Visible = false;
            this.AddEmployee.Click += new System.EventHandler(this.AddDebt_Click);
            this.AddEmployee.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.AddEmployee_HelpRequested);
            // 
            // DeleteEmployee
            // 
            this.DeleteEmployee.Location = new System.Drawing.Point(12, 448);
            this.DeleteEmployee.Name = "DeleteEmployee";
            this.DeleteEmployee.Size = new System.Drawing.Size(106, 23);
            this.DeleteEmployee.TabIndex = 3;
            this.DeleteEmployee.Text = "Удалить запись";
            this.DeleteEmployee.UseVisualStyleBackColor = true;
            this.DeleteEmployee.Visible = false;
            this.DeleteEmployee.Click += new System.EventHandler(this.DeleteEmployee_Click);
            this.DeleteEmployee.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.DeleteEmployee_HelpRequested);
            // 
            // QueryList
            // 
            this.QueryList.FormattingEnabled = true;
            this.QueryList.Items.AddRange(new object[] {
            "По студенту",
            "По группе",
            "По дисциплине"});
            this.QueryList.Location = new System.Drawing.Point(12, 366);
            this.QueryList.Name = "QueryList";
            this.QueryList.Size = new System.Drawing.Size(132, 43);
            this.QueryList.TabIndex = 4;
            this.QueryList.SelectedIndexChanged += new System.EventHandler(this.QueryList_SelectedIndexChanged);
            this.QueryList.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.QueryList_HelpRequested);
            // 
            // QueryTB
            // 
            this.QueryTB.Location = new System.Drawing.Point(150, 384);
            this.QueryTB.Name = "QueryTB";
            this.QueryTB.Size = new System.Drawing.Size(120, 20);
            this.QueryTB.TabIndex = 5;
            this.QueryTB.Visible = false;
            this.QueryTB.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.QueryList_HelpRequested);
            // 
            // ExecuteQuery
            // 
            this.ExecuteQuery.Location = new System.Drawing.Point(149, 415);
            this.ExecuteQuery.Name = "ExecuteQuery";
            this.ExecuteQuery.Size = new System.Drawing.Size(120, 23);
            this.ExecuteQuery.TabIndex = 6;
            this.ExecuteQuery.Text = "Исполнить запрос";
            this.ExecuteQuery.UseVisualStyleBackColor = true;
            this.ExecuteQuery.Click += new System.EventHandler(this.ExecuteQuery_Click);
            this.ExecuteQuery.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.QueryList_HelpRequested);
            // 
            // QueryCB
            // 
            this.QueryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QueryCB.Location = new System.Drawing.Point(150, 383);
            this.QueryCB.Name = "QueryCB";
            this.QueryCB.Size = new System.Drawing.Size(158, 21);
            this.QueryCB.TabIndex = 7;
            this.QueryCB.Visible = false;
            this.QueryCB.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.QueryList_HelpRequested);
            // 
            // QueryMTB
            // 
            this.QueryMTB.Location = new System.Drawing.Point(150, 384);
            this.QueryMTB.Mask = "00";
            this.QueryMTB.Name = "QueryMTB";
            this.QueryMTB.Size = new System.Drawing.Size(120, 20);
            this.QueryMTB.TabIndex = 8;
            this.QueryMTB.ValidatingType = typeof(int);
            this.QueryMTB.Visible = false;
            this.QueryMTB.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.QueryList_HelpRequested);
            // 
            // QueryTBL
            // 
            this.QueryTBL.AutoSize = true;
            this.QueryTBL.Location = new System.Drawing.Point(150, 368);
            this.QueryTBL.Name = "QueryTBL";
            this.QueryTBL.Size = new System.Drawing.Size(0, 13);
            this.QueryTBL.TabIndex = 10;
            this.QueryTBL.Visible = false;
            // 
            // QueryCBL
            // 
            this.QueryCBL.AutoSize = true;
            this.QueryCBL.Location = new System.Drawing.Point(149, 367);
            this.QueryCBL.Name = "QueryCBL";
            this.QueryCBL.Size = new System.Drawing.Size(89, 13);
            this.QueryCBL.TabIndex = 11;
            this.QueryCBL.Text = "Выберите отдел";
            this.QueryCBL.Visible = false;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Help.chm";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1091, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // MForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 515);
            this.Controls.Add(this.QueryCBL);
            this.Controls.Add(this.QueryTBL);
            this.Controls.Add(this.QueryMTB);
            this.Controls.Add(this.QueryCB);
            this.Controls.Add(this.ExecuteQuery);
            this.Controls.Add(this.QueryTB);
            this.Controls.Add(this.QueryList);
            this.Controls.Add(this.DeleteEmployee);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Картотека работников";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.MForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public  System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Button DeleteEmployee;
        private System.Windows.Forms.Button ExecuteQuery;
        public System.Windows.Forms.ListBox QueryList;
        public System.Windows.Forms.TextBox QueryTB;
        public System.Windows.Forms.ComboBox QueryCB;
        public System.Windows.Forms.MaskedTextBox QueryMTB;
        private System.Windows.Forms.Label QueryTBL;
        private System.Windows.Forms.Label QueryCBL;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeachersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Head;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}

