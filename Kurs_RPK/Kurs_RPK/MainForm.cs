using System;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Kurs_RPK { 
    public partial class MForm : Form
    {
        Query controller;
        string[] FAPU = new string[10] { "Программирование", "Дискретная математика", "МНИ", "ОС", "РПК", "Схемотехника", "СИТиП", "ИСОУ", "ТО АСОИУ", "ПО АСОИУ" };
        string[] SOC = new string[] { "Социология", "Трудовое право", "Правоведение" };
        string[] his = new string[2] { "История", "История региона" };
        string[] econ = new string[2] { "Экономика на предприятии", "Экономика" };
        string phis = "Физика";
        string math = "Мат. анализ";
        string[] phil = new string[2] { "Философия", "Проф. этика" };
        string eco = "Экология";
        DataTable d = new DataTable();
        public MForm()
        {
            InitializeComponent();
            if (Program.f1.isAdm)
            {
                this.AddEmployee.Visible = true;
                this.DeleteEmployee.Visible = true;
            }
            else
            {
                this.AddEmployee.Visible = false;
                this.DeleteEmployee.Visible = false;
            }
            controller = new Query(ConnectionStr.ConnStr);
            dataGridView1.DataSource = controller.UpdateEmployee();

        }

        public void subFac(string Class)
        {
            foreach (string s in FAPU)
            {
                if (Class == s)
                {
                    d = controller.UpdateSubF("СУиВТ");
                }
            }
            foreach (string s in SOC)
            {
                if (Class == s)
                {
                    d = controller.UpdateSubF("Социальных наук");
                }
            }
            foreach (string s in his)
            {
                if (Class == s)
                {
                    d = controller.UpdateSubF("Истории");
                }
            }
            foreach (string s in econ)
            {
                if (Class == s)
                {
                    d = controller.UpdateSubF("Экономики");
                }
            }
            foreach (string s in phil)
            {
                if (Class == s)
                {
                    d = controller.UpdateSubF("Философии");
                }
            }
            if (Class == phis)
            {
                d = controller.UpdateSubF("Физики");
            }
            if (Class == math)
            {
                d = controller.UpdateSubF("Высшей математики");
            }
            if (Class == eco)
            {
                d = controller.UpdateSubF("Экономики");
            }
        }
        private void AddDebt_Click(object sender, EventArgs e)
        {
            AddAndModForm add =new AddAndModForm();
            add.Text = "Добавление задолженности";
            add.Show();
            this.Enabled=false;
        }
        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            controller.Delete(dataGridView1.CurrentRow.Cells[3].Value.ToString(),
                dataGridView1.CurrentRow.Cells[4].Value.ToString(),
                dataGridView1.CurrentRow.Cells[5].Value.ToString(),
                dataGridView1.CurrentRow.Cells[6].Value.ToString(),
                dataGridView1.CurrentRow.Cells[7].Value.ToString(),
                dataGridView1.CurrentRow.Cells[8].Value.ToString(),
                dataGridView1.CurrentRow.Cells[9].Value.ToString());
            MessageBox.Show("Задолженность была успешно удалена из базы данных","Удаление задолженности",MessageBoxButtons.OK,MessageBoxIcon.Information);
            dataGridView1.DataSource = controller.UpdateEmployee();
            SubFill();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void QueryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (QueryList.SelectedIndex)
            {
                case 0:
                    {
                        QueryTBL.Visible = true;
                        QueryTBL.Text = "Введите ФИО студента или выберите запись из таблицы";
                        QueryMTB.Visible = false;
                        QueryCB.Visible = false;
                        QueryCBL.Visible = false;
                        QueryTB.Visible = true;
                        break;
                    }
                case 1:
                    {
                        QueryCBL.Visible = true;
                        QueryCBL.Text = "Выберите номер группы";
                        QueryMTB.Visible = false;
                        QueryTB.Visible = false;
                        QueryTBL.Visible = false;
                        QueryCB.Visible = true;
                        QueryCB.Items.Clear();
                        QueryCB.Items.AddRange(new object[] {
                        "20-ВТ",
                        "20-ИЭ",
                        "19-ВТ",
                        "19-ИЭ",
                        "18-ВТ",
                        "18-ИЭ",
                        "17-ВТ",
                        "17-ИЭ" });
                        break;
                    }
                case 2:
                    {
                        List<string> Classes = new List<string> {"Программирование",
                            "Дискретная математика",
                            "МНИ",
                            "ОС",
                            "РПК",
                            "Схемотехника",
                            "СИТиП",
                            "ИСОУ",
                            "ТО АСОИУ",
                            "ПО АСОИУ",
                            "Социология",
                            "Трудовое право",
                            "Правоведение",
                            "История",
                            "История региона",
                            "Экономика на предприятии",
                            "Экономика",
                            "Физика",
                            "Мат. анализ",
                            "Философия",
                            "Проф. этика",
                            "Экология" };
                        Classes.Sort();
                        QueryCBL.Visible = true;
                        QueryCBL.Text = "Выберите дисциплину";
                        QueryMTB.Visible = false;
                        QueryTB.Visible = false;
                        QueryTBL.Visible = false;
                        QueryCB.Visible = true;
                        QueryCB.Items.Clear();
                        foreach (var item in Classes)
                        {
                            QueryCB.Items.Add(item);
                        }
                        break;
                        
                    }
            }
        }
        private void ExecuteQuery_Click(object sender, EventArgs e)
        {
            switch (QueryList.SelectedIndex)
            {
                case 0:
                    {
                        dataGridView1.DataSource = controller.byStudName(QueryTB.Text);
                        SubFill();
                        break;
                    }
                case 1:
                    {
                        dataGridView1.DataSource = controller.byGroup();
                        SubFill();
                        break;
                    }
                case 2:
                    {
                        dataGridView1.DataSource = controller.byClass();
                        SubFill();
                        break;
                    }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count>0) QueryTB.Text = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value.ToString();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "newtopic.htm");
        }

        private void QueryList_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "newtopic4.htm");
        }

        private void AddEmployee_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "newtopic2.htm");
        }

        private void DeleteEmployee_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "newtopic3.htm");
        }

        private void MForm_Load(object sender, EventArgs e)
        {
            SubFill();
        }
        public void SubFill()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                d.Clear();
                subFac(row.Cells[8].Value.ToString());
                row.Cells[0].Value = d.Rows[0][0].ToString();
                row.Cells[1].Value = d.Rows[0][1].ToString();
                row.Cells[2].Value = d.Rows[0][2].ToString();
            }
        }
    }
}
