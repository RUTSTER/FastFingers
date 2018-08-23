using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace FastFingers
{
    public partial class FormCheckIn : Form
    {
        public FormCheckIn()
        {
            InitializeComponent();            
        }


        // ButtonContinue
        private void ButtonContinue_Click(object sender, EventArgs e)
        {

            if (TextBoxPass.Text == TextBoxRepeatPass.Text)
            {
                string FileName = "Users.xml";
                XDocument UsersDoc = XDocument.Load(FileName);

                

                bool IsNewLog = true;

                foreach (XElement User in UsersDoc.Root.Elements())
                {                    
                    if (TextBoxLog.Text == User.Attribute("Login").Value)
                    {
                        IsNewLog = false;

                        TextBoxLog.Text = "Логин";     //обновление полей логина и паролей
                        TextBoxLog.ForeColor = Color.Silver;

                        TextBoxPass.Text = "Пароль";
                        TextBoxPass.ForeColor = Color.Silver;
                        TextBoxPass.PasswordChar = '\0';

                        TextBoxRepeatPass.Text = "Повторите пароль";
                        TextBoxRepeatPass.ForeColor = Color.Silver;
                        TextBoxRepeatPass.PasswordChar = '\0';

                        MessageBox.Show("Такой пользователь уже существует!", "Ошибка!",   //сообщение об ошибке
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1);
                        break;
                    }
                }                

                if (IsNewLog)
                {
                    XElement NewUser = new XElement("User",
                        new XAttribute("Login", TextBoxLog.Text),
                        new XAttribute("Password", TextBoxPass.Text));
                    UsersDoc.Root.Add(NewUser);
                    UsersDoc.Save(FileName);

                    MessageBox.Show("Регистрация выполнена успешно.", "Готово!",      //сообщение о завершении регистрации
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Information,
                         MessageBoxDefaultButton.Button1);
                    
                    Close();
                }
            }

            else
            {
                TextBoxPass.Text = "Пароль";                    //обновление полей
                TextBoxPass.ForeColor = Color.Silver;
                TextBoxPass.PasswordChar = '\0';

                TextBoxRepeatPass.Text = "Повторите пароль";
                TextBoxRepeatPass.ForeColor = Color.Silver;
                TextBoxRepeatPass.PasswordChar = '\0';

                MessageBox.Show("Пароли не совпадают!", "Ошибка!",      //сообщение об ошибке
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);

            }
        }
        private void ButtonContinue_MouseEnter(object sender, EventArgs e)
        {
            ButtonContinue.BackgroundImage = Properties.Resources.CheckInInFormPut;
            ButtonContinue.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void ButtonContinue_MouseLeave(object sender, EventArgs e)
        {
            ButtonContinue.BackgroundImage = Properties.Resources.CheckInInFormBasic;
        }

        private void ButtonContinue_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonContinue.BackgroundImage = Properties.Resources.CheckInInFormPress;
            ButtonContinue.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        private void ButtonContinue_MouseUp(object sender, MouseEventArgs e)
        {
            ButtonContinue.BackgroundImage = Properties.Resources.CheckInInFormPut;
        }


        // ButtonCancel
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonCancel_MouseEnter(object sender, EventArgs e)
        {
            ButtonCancel.BackgroundImage = Properties.Resources.ButtonCancelPut;
            ButtonCancel.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void ButtonCancel_MouseLeave(object sender, EventArgs e)
        {
            ButtonCancel.BackgroundImage = Properties.Resources.ButtonCancel;
        }

        private void ButtonCancel_MouseDown(object sender, MouseEventArgs e)
        {            
            ButtonCancel.FlatAppearance.MouseDownBackColor = Color.Transparent;
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


        // TextBoxRepeatPass
        private void TextBoxRepeatPass_Enter(object sender, EventArgs e)
        {
            if (TextBoxRepeatPass.Text == "Повторите пароль")
            {
                TextBoxRepeatPass.Text = "";
                TextBoxRepeatPass.ForeColor = Color.Black;
                TextBoxRepeatPass.PasswordChar = '*';
            }
        }

        private void TextBoxRepeatPass_Leave(object sender, EventArgs e)
        {
            if (TextBoxRepeatPass.Text == "")
            {
                TextBoxRepeatPass.Text = "Повторите пароль";
                TextBoxRepeatPass.ForeColor = Color.Silver;
                TextBoxRepeatPass.PasswordChar = '\0';
            }
        }

        private void FormCheckIn_Load(object sender, EventArgs e)
        {

        }
    }
}
