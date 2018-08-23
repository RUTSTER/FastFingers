using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;


namespace FastFingers
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }



        // ButtonLogIn
        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
             bool IsLogPassCorrect = false; // F-неверный логин, T-верный логин;

            string FileName = "Users.xml";
            XDocument UsersDoc = XDocument.Load(FileName);


            foreach (XElement User in UsersDoc.Root.Elements())
            {
                if (TextBoxLog.Text == User.Attribute("Login").Value && TextBoxPass.Text == User.Attribute("Password").Value)
                {
                    // Верный лог-пас
                    IsLogPassCorrect = true;
                    TextBoxLog.Text = "Логин";
                    TextBoxLog.ForeColor = Color.Silver;
                    TextBoxPass.Text = "Пароль";
                    TextBoxPass.ForeColor = Color.Silver;
                    TextBoxPass.PasswordChar = '\0';

                    FormMainMenu formMainMenu = new FormMainMenu();
                    Hide();
                    formMainMenu.ShowDialog();                    
                }
            }
            if (!IsLogPassCorrect)
            {
                // НЕ верный лог-пас
                TextBoxLog.Text = "Логин";
                TextBoxLog.ForeColor = Color.Silver;
                TextBoxPass.Text = "Пароль";
                TextBoxPass.ForeColor = Color.Silver;
                TextBoxPass.PasswordChar = '\0';

                MessageBox.Show("Неверный логин или пароль!", "Ошибка!");   //сообщение об ошибке
            }
        }

        private void ButtonLogIn_MouseEnter(object sender, EventArgs e)
        {
            ButtonLogIn.BackgroundImage = Properties.Resources.ButtonPut_Вход_;
            ButtonLogIn.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void ButtonLogIn_MouseLeave(object sender, EventArgs e)
        {
            ButtonLogIn.BackgroundImage = Properties.Resources.Button_Вход_;
        }

        private void ButtonLogIn_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonLogIn.BackgroundImage = Properties.Resources.ButtonPress_Вход_;
            ButtonLogIn.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        private void ButtonLogIn_MouseUp(object sender, MouseEventArgs e)
        {
            ButtonLogIn.BackgroundImage = Properties.Resources.ButtonPut_Вход_;
        }


        // ButtonCheckIn
        private void ButtonCheckIn_Click(object sender, EventArgs e)
        {
            FormCheckIn frm = new FormCheckIn();
            Hide();            
            frm.ShowDialog();
            Show();
        }

        private void ButtonCheckIn_MouseEnter(object sender, EventArgs e)
        {
            ButtonCheckIn.BackgroundImage = Properties.Resources.CheckInRed;
            ButtonCheckIn.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void ButtonCheckIn_MouseLeave(object sender, EventArgs e)
        {
            ButtonCheckIn.BackgroundImage = Properties.Resources.CheckInBlack;
        }

        private void ButtonCheckIn_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonCheckIn.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }


        // ButtonExit
        private void ButtonExit_MouseEnter(object sender, EventArgs e)
        {
            ButtonExit.BackgroundImage = Properties.Resources.ButtonExitPut;
            ButtonExit.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void ButtonExit_MouseLeave(object sender, EventArgs e)
        {
            ButtonExit.BackgroundImage = Properties.Resources.ButtonExit;
        }

        private void ButtonExit_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonExit.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }


        // TextBoxLog
        private void TextBoxLog_Enter(object sender, EventArgs e)
        {
            if (TextBoxLog.Text == "Логин")
            {
                TextBoxLog.Text = "";
                TextBoxLog.ForeColor = Color.Black;
            }
        }

        private void TextBoxLog_Leave(object sender, EventArgs e)
        {
            if (TextBoxLog.Text == "")
            {
                TextBoxLog.Text = "Логин";
                TextBoxLog.ForeColor = Color.Silver;
            }
        }


        // TextBoxPass
        private void TextBoxPass_Enter(object sender, EventArgs e)
        {
            if (TextBoxPass.Text == "Пароль")
            {
                TextBoxPass.Text = "";
                TextBoxPass.ForeColor = Color.Black;
                TextBoxPass.PasswordChar = '*';
            }
        }

        private void TextBoxPass_Leave(object sender, EventArgs e)
        {
            if (TextBoxPass.Text == "")
            {
                TextBoxPass.Text = "Пароль";
                TextBoxPass.ForeColor = Color.Silver;
                TextBoxPass.PasswordChar = '\0';
            }
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
