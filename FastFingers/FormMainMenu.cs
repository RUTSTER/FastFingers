using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFingers
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {

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


        // ButtonStart
        private void ButtonStart_MouseEnter(object sender, EventArgs e)
        {
            ButtonStart.BackgroundImage = Properties.Resources.MainMenuStartPut;
            ButtonStart.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void ButtonStart_MouseLeave(object sender, EventArgs e)
        {
            ButtonStart.BackgroundImage = Properties.Resources.MainMenuStartBasic;
        }

        private void ButtonStart_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonStart.BackgroundImage = Properties.Resources.MainMenuStartPress;
            ButtonStart.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        private void ButtonStart_MouseUp(object sender, MouseEventArgs e)
        {
            ButtonStart.BackgroundImage = Properties.Resources.MainMenuStartPut;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            FormTraining formTraining = new FormTraining();
            Hide();
            formTraining.ShowDialog();
            Show();
        }


        //ButtonStatistics
        private void ButtonStatistics_MouseEnter(object sender, EventArgs e)
        {
            ButtonStatistics.BackgroundImage = Properties.Resources.MainMenuStatisticsPut;
            ButtonStatistics.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void ButtonStatistics_MouseLeave(object sender, EventArgs e)
        {
            ButtonStatistics.BackgroundImage = Properties.Resources.MainMenuStatisticsBasic;
        }

        private void ButtonStatistics_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonStatistics.BackgroundImage = Properties.Resources.MainMenuStatisticsPress;
            ButtonStatistics.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        private void ButtonStatistics_MouseUp(object sender, MouseEventArgs e)
        {
            ButtonStatistics.BackgroundImage = Properties.Resources.MainMenuStatisticsPut;
        }


        //ButtonHelp
        private void ButtonHelp_MouseEnter(object sender, EventArgs e)
        {
            ButtonHelp.BackgroundImage = Properties.Resources.MainMenuHelpPut;
            ButtonHelp.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void ButtonHelp_MouseLeave(object sender, EventArgs e)
        {
            ButtonHelp.BackgroundImage = Properties.Resources.MainMenuHelpBasic;
        }

        private void ButtonHelp_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonHelp.BackgroundImage = Properties.Resources.MainMenuHelpPress;
            ButtonHelp.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        private void ButtonHelp_MouseUp(object sender, MouseEventArgs e)
        {
            ButtonHelp.BackgroundImage = Properties.Resources.MainMenuHelpPut;
        }


        //ButtonAbout
        private void ButtonAbout_MouseEnter(object sender, EventArgs e)
        {
            ButtonAbout.BackgroundImage = Properties.Resources.MainMenuAboutPut;
            ButtonAbout.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void ButtonAbout_MouseLeave(object sender, EventArgs e)
        {
            ButtonAbout.BackgroundImage = Properties.Resources.MainMenuAboutBasic;
        }

        private void ButtonAbout_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonAbout.BackgroundImage = Properties.Resources.MainMenuAboutPress;
            ButtonAbout.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        private void ButtonAbout_MouseUp(object sender, MouseEventArgs e)
        {
            ButtonAbout.BackgroundImage = Properties.Resources.MainMenuAboutPut;
        }


        //ButtinAccount
        private void ButtinAccount_MouseEnter(object sender, EventArgs e)
        {
            ButtonAccount.BackgroundImage = Properties.Resources.MainMenuAccountPut;
            ButtonAccount.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void ButtinAccount_MouseLeave(object sender, EventArgs e)
        {
            ButtonAccount.BackgroundImage = Properties.Resources.MainMenuAccountBasic;
        }

        private void ButtinAccount_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonAccount.BackgroundImage = Properties.Resources.MainMenuAccountPress;
            ButtonAccount.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        private void ButtinAccount_MouseUp(object sender, MouseEventArgs e)
        {
            ButtonAccount.BackgroundImage = Properties.Resources.MainMenuAccountPut;
        }
    }
}
