using System;
using System.Linq;
using System.Windows.Forms;


namespace Kurs_RPK
{
    public partial class AddAndModForm : Form
    {
        Query controller;
        
        
        public AddAndModForm()
        {
            InitializeComponent();
            controller = new Query(ConnectionStr.ConnStr);
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string sFio = "";
            string tFio = "";
            
            if (NotEMPT())
            {
                sFio = sf.Text[0].ToString().ToUpper() + sf.Text.Substring(1) + " " + sn.Text.ToUpper()[0] + ". " + so.Text.ToUpper()[0] + ".";
                int count = controller.newUser(Group.Text + "-" + ID.Text.Replace(" ", ""), sFio, Group.Text);
                tFio = tf.Text[0].ToString().ToUpper() + tf.Text.Substring(1) + " " + tn.Text.ToUpper()[0] + ". " + to.Text.ToUpper()[0] + ".";
                if (count == 1)
                {
                    controller.addStud(ID.Text.Replace(" ", ""), sFio, Group.Text);
                    controller.Add(ID.Text.Replace(" ", ""), sFio, Group.Text, Type.Text, Semester.Text, Class.Text, tFio);
                    Program.f2.dataGridView1.DataSource = controller.UpdateEmployee();
                    Program.f2.SubFill();
                    return;
                }
                else if (count == 2)
                {
                    if (controller.exists(Group.Text + "-" + ID.Text.Replace(" ", ""), sFio, Group.Text, Type.Text, Semester.Text, Class.Text, tFio))
                    {
                        controller.Add(ID.Text.Replace(" ", ""), sFio, Group.Text, Type.Text, Semester.Text, Class.Text, tFio);
                        Program.f2.dataGridView1.DataSource = controller.UpdateEmployee();
                        Program.f2.SubFill();
                    }
                    else MessageBox.Show("Данная задолженность уже существует");
                    return;
                }
                else
                {
                    MessageBox.Show("Номер зачетной книжки не совпадает со студентом");
                    return;
                }
            }
            else MessageBox.Show("Не все ячейки заполнены","Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        //Проверка на заполненность полей
        private bool NotEMPT()
        {
            foreach(var TB in this.Controls.OfType<TextBox>())
            {
                if (TB.Text.Length == 0)
                {
                    return false;
                }
            }
            foreach (var CB in this.Controls.OfType<ComboBox>())
            {
                if (CB.SelectedIndex == -1)
                {
                    return false;
                }
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.f2.Enabled = true;
            this.Hide();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.f2.Enabled = true;
            this.Hide();
        }

        private void Group_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Group.SelectedIndex >= 0 && Group.SelectedIndex <= 1)
            {
                Semester.Items.Clear();
                Semester.Items.AddRange(new object[] {"1","2" });
            }
            else if (Group.SelectedIndex >= 2 && Group.SelectedIndex <= 3)
            {
                Semester.Items.Clear();
                Semester.Items.AddRange(new object[] { "1", "2","3","4" });
            }
            else if (Group.SelectedIndex >= 4 && Group.SelectedIndex <= 5)
            {
                Semester.Items.Clear();
                Semester.Items.AddRange(new object[] { "3", "4", "5", "6" });
            }
            else if (Group.SelectedIndex >= 6 && Group.SelectedIndex <= 7)
            {
                Semester.Items.Clear();
                Semester.Items.AddRange(new object[] { "5", "6", "7", "8" });
            }
        }
        
        private void Semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Semester.SelectedItem.ToString())
            {
                case "1":
                    {
                        Class.Items.Clear();
                        Class.Items.AddRange(new object[] {"Программирование","Социология","История" });
                        break;
                    }
                case "2":
                    {
                        Class.Items.Clear();
                        Class.Items.AddRange(new object[] { "Программирование", "Мат. анализ", "История региона" });
                        break;
                    }
                case "3":
                    {
                        Class.Items.Clear();
                        Class.Items.AddRange(new object[] { "Дискретная математика", "Философия", "Физика" });
                        break;
                    }
                case "4":
                    {
                        Class.Items.Clear();
                        Class.Items.AddRange(new object[] { "МНИ", "ОС", "Проф. этика" });
                        break;
                    }
                case "5":
                    {
                        Class.Items.Clear();
                        Class.Items.AddRange(new object[] { "РПК", "Экономика", "Экология" });
                        break;
                    }
                case "6":
                    {
                        Class.Items.Clear();
                        Class.Items.AddRange(new object[] { "Схемотехника", "Экономика на предприятии", "Правоведение" });
                        break;
                    }
                case "7":
                    {
                        Class.Items.Clear();
                        Class.Items.AddRange(new object[] { "СИТиП", "Социология", "Трудовое право" });
                        break;
                    }
                case "8":
                    {
                        Class.Items.Clear();
                        Class.Items.AddRange(new object[] { "ИСОУ", "ТО АСОИУ", "ПО АСОИУ" });
                        break;
                    }
            }
            

        }

        private void sf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || e.KeyChar == ' '|| char.IsDigit(e.KeyChar)||char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }
    }
}
