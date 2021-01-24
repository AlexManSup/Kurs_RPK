using JThomas.Controls;
namespace Kurs_RPK
{
    partial class AddAndModForm
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
            this.AddB = new System.Windows.Forms.Button();
            this.CloseB = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.sf = new System.Windows.Forms.TextBox();
            this.sn = new System.Windows.Forms.TextBox();
            this.so = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.ComboBox();
            this.Group = new System.Windows.Forms.ComboBox();
            this.Class = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.to = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Semester = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddB
            // 
            this.AddB.Location = new System.Drawing.Point(43, 353);
            this.AddB.Name = "AddB";
            this.AddB.Size = new System.Drawing.Size(75, 23);
            this.AddB.TabIndex = 1;
            this.AddB.Text = "Добавить";
            this.AddB.UseVisualStyleBackColor = true;
            this.AddB.Click += new System.EventHandler(this.button1_Click);
            // 
            // CloseB
            // 
            this.CloseB.Location = new System.Drawing.Point(176, 353);
            this.CloseB.Name = "CloseB";
            this.CloseB.Size = new System.Drawing.Size(75, 23);
            this.CloseB.TabIndex = 2;
            this.CloseB.Text = "Закрыть";
            this.CloseB.UseVisualStyleBackColor = true;
            this.CloseB.Click += new System.EventHandler(this.button2_Click);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Help.chm";
            // 
            // sf
            // 
            this.sf.Location = new System.Drawing.Point(6, 36);
            this.sf.Name = "sf";
            this.sf.Size = new System.Drawing.Size(100, 20);
            this.sf.TabIndex = 4;
            this.sf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sf_KeyPress);
            // 
            // sn
            // 
            this.sn.Location = new System.Drawing.Point(113, 36);
            this.sn.Name = "sn";
            this.sn.Size = new System.Drawing.Size(100, 20);
            this.sn.TabIndex = 5;
            this.sn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sf_KeyPress);
            // 
            // so
            // 
            this.so.Location = new System.Drawing.Point(220, 36);
            this.so.Name = "so";
            this.so.Size = new System.Drawing.Size(100, 20);
            this.so.TabIndex = 6;
            this.so.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sf_KeyPress);
            // 
            // Type
            // 
            this.Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "Экзамен",
            "Зачет",
            "Дифф. зачет",
            "Курсовая работа"});
            this.Type.Location = new System.Drawing.Point(148, 222);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(121, 21);
            this.Type.TabIndex = 7;
            // 
            // Group
            // 
            this.Group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Group.FormattingEnabled = true;
            this.Group.Items.AddRange(new object[] {
            "20-ВТ",
            "20-ИЭ",
            "19-ВТ",
            "19-ИЭ",
            "18-ВТ",
            "18-ИЭ",
            "17-ВТ",
            "17-ИЭ"});
            this.Group.Location = new System.Drawing.Point(18, 222);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(121, 21);
            this.Group.TabIndex = 8;
            this.Group.SelectedIndexChanged += new System.EventHandler(this.Group_SelectedIndexChanged);
            // 
            // Class
            // 
            this.Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Class.FormattingEnabled = true;
            this.Class.Location = new System.Drawing.Point(148, 272);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(121, 21);
            this.Class.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Номер зачетной книжки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Отчество";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sf);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.sn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.so);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 62);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Студент";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tf);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tn);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.to);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 62);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Преподаватель";
            // 
            // tf
            // 
            this.tf.Location = new System.Drawing.Point(6, 36);
            this.tf.Name = "tf";
            this.tf.Size = new System.Drawing.Size(100, 20);
            this.tf.TabIndex = 4;
            this.tf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sf_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Отчество";
            // 
            // tn
            // 
            this.tn.Location = new System.Drawing.Point(113, 36);
            this.tn.Name = "tn";
            this.tn.Size = new System.Drawing.Size(100, 20);
            this.tn.TabIndex = 5;
            this.tn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sf_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Имя";
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(220, 36);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(100, 20);
            this.to.TabIndex = 6;
            this.to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sf_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Фамилия";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Вид задолженности";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Дисциплина";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Группа";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Семестр";
            // 
            // Semester
            // 
            this.Semester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Semester.FormattingEnabled = true;
            this.Semester.Location = new System.Drawing.Point(18, 272);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(121, 21);
            this.Semester.TabIndex = 25;
            this.Semester.SelectedIndexChanged += new System.EventHandler(this.Semester_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(18, 29);
            this.ID.Mask = "000";
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 3;
            // 
            // AddAndModForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 405);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Semester);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.CloseB);
            this.Controls.Add(this.AddB);
            this.HelpButton = true;
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TableOfContents);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAndModForm";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddB;
        private System.Windows.Forms.Button CloseB;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TextBox sf;
        private System.Windows.Forms.TextBox sn;
        private System.Windows.Forms.TextBox so;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.ComboBox Group;
        private System.Windows.Forms.ComboBox Class;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox Semester;
        private System.Windows.Forms.MaskedTextBox ID;
    }
}