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
using System.Reflection;

namespace FastFingers
{
    public partial class FormTraining : Form
    {       
        string[] OllTextArr;
        const int NumberDisplayedParagraph = 5;
        int IndexOfActualString = NumberDisplayedParagraph;
        int Mistakes = 0;
        int OllCharsCount = 0;


        private void FormTraining_Load(object sender, EventArgs e)
        {
        }

        // Constructor
        public FormTraining()
        {
            InitializeComponent();

            OllTextArr = Properties.Resources.SelfishGene
                .Replace("«", "\"")
                .Replace("»", "\"")
                .Replace("\u00A0", " ")
                .Replace("\u2014", "-")
                .Split(new string[] { "\r\n", "  " }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = NumberDisplayedParagraph; i >= 0; i--)
            {
                RichTextBoxSample.Text += "     " + OllTextArr[IndexOfActualString - i] + "\n";
            }
            RichTextBoxInput.Text = "     ";
            RichTextBoxInput.SelectionStart = 6;
        }
        
        // Timer
        int TimeIntMS = 0;       

        private void TrainingTimer_Tick(object sender, EventArgs e) // говно, переделать
        {
            TimeIntMS++;
            LabelTimer.Text = ((TimeIntMS/10) / 60).ToString() + " мин. " + ((TimeIntMS / 10) % 60).ToString() + " сек."; // "Тик" таймера каждые 100мс, перевод в секунды, разделение на минуты и секунды
        }

        
        // Input any char        
        private void RichTextBoxInput_TextChanged(object sender, EventArgs e)
        {
            /*
            string ClipboardData = Clipboard.GetText();
            if (RichTextBoxInput.Text.Contains(ClipboardData))
            {
                RichTextBoxInput.Text = RichTextBoxInput.Text.Remove((RichTextBoxInput.SelectionStart - ClipboardData.Length), ClipboardData.Length);
                Clipboard.Clear();
            }*/         
            OllCharsCount++;

            if (RichTextBoxSample.Text.Substring(0, RichTextBoxInput.Text.Length) == RichTextBoxInput.Text)
            {
                if (OllTextArr[IndexOfActualString - NumberDisplayedParagraph].Length + 6 == RichTextBoxInput.Text.Length)
                {
                    RichTextBoxSample.Text = "";
                    for (int i = NumberDisplayedParagraph - 1; i >= 0; i--)
                    {
                        RichTextBoxSample.Text += "     " + OllTextArr[IndexOfActualString - i] + "\n";
                    }
                    RichTextBoxInput.Text = "     ";
                    RichTextBoxInput.SelectionStart = 6;
                    IndexOfActualString++;
                }

                BackgroundImage = Properties.Resources.BackgroundImageSecond;
            }

            else
            {
                BackgroundImage = Properties.Resources.BackgroundImageSecondRed;
                Mistakes++;
            }

            LabelMistakes.Text = Mistakes.ToString();
            LabelOllChars.Text = OllCharsCount.ToString();
            LabelPercentOfMistakes.Text = (100 * (double)Mistakes / OllCharsCount).ToString("F2") + "%";
            LabelSpeed.Text = (OllCharsCount / ((double)TimeIntMS / 600)).ToString("F2");            
        }


        // ButtonBack
        private void ButtonBack_MouseEnter(object sender, EventArgs e)
        {
            ButtonBack.BackgroundImage = Properties.Resources.ButtonBackPut;
            ButtonBack.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void ButtonBack_MouseLeave(object sender, EventArgs e)
        {
            ButtonBack.BackgroundImage = Properties.Resources.ButtonBack;
        }

        private void ButtonBack_MouseDown(object sender, MouseEventArgs e)
        {
            ButtonBack.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
