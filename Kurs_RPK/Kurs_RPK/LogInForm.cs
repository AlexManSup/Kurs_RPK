using System;
using System.Windows.Forms;
namespace Kurs_RPK
{
    public partial class LogInForm : Form
    {
        readonly string AdmPass = "12345678";
        public bool isAdm = false;

        public LogInForm()
        {
            InitializeComponent();
            Program.f1 = this;
        }

        private void AdminB_Click(object sender, EventArgs e)
        {
            AdminB.Visible = false;
            UserB.Visible = false;
            PasswordTB.Visible = true;
            EnterPassLab.Visible = true;
            PassEnter.Visible = true;
            isAdm = true;
            BackB.Visible = true;
        }

        private void UserB_Click(object sender, EventArgs e)
        {
            Program.f2 = new MForm();
            Program.f2.Show();
            this.Hide();
        }

        private void PassEnter_Click(object sender, EventArgs e)
        {
            if (isAdm == true)
            {
                if (PasswordTB.Text == AdmPass)
                {
                    Program.f2 = new MForm();
                    Program.f2.Show();
                    this.Hide();
                }
                else MessageBox.Show("Введен неправильный пароль","Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BackB_Click(object sender, EventArgs e)
        {
            if (PasswordTB.Visible == true)
            {
                AdminB.Visible = true;
                UserB.Visible = true;
                PasswordTB.Visible = false;
                EnterPassLab.Visible = false;
                PassEnter.Visible = false;
                isAdm = false;
                BackB.Visible = false;
            }

            }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Система разработана студентом 18-ВТ\nАлтуховым Владиславом", "Об авторе", MessageBoxButtons.OK);
        }

        private void About_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "newtopic1.htm");
        }
    }
}
