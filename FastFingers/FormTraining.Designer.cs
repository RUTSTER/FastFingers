namespace FastFingers
{
    partial class FormTraining
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTraining));
            this.TrainingTimer = new System.Windows.Forms.Timer(this.components);
            this.LabelTimer = new System.Windows.Forms.Label();
            this.LabelMistakes = new System.Windows.Forms.Label();
            this.LabelOllChars = new System.Windows.Forms.Label();
            this.LabelSpeed = new System.Windows.Forms.Label();
            this.LabelPercentOfMistakes = new System.Windows.Forms.Label();
            this.LabelHelper = new System.Windows.Forms.Label();
            this.LabelTimerText = new System.Windows.Forms.Label();
            this.LabelSpeedText = new System.Windows.Forms.Label();
            this.LabelOllCharsText = new System.Windows.Forms.Label();
            this.LabelMistakesText = new System.Windows.Forms.Label();
            this.LabelPercentOfMistakesText = new System.Windows.Forms.Label();
            this.RichTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.RichTextBoxSample = new System.Windows.Forms.RichTextBox();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TrainingTimer
            // 
            this.TrainingTimer.Enabled = true;
            this.TrainingTimer.Tick += new System.EventHandler(this.TrainingTimer_Tick);
            // 
            // LabelTimer
            // 
            this.LabelTimer.AutoSize = true;
            this.LabelTimer.BackColor = System.Drawing.Color.Transparent;
            this.LabelTimer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTimer.Location = new System.Drawing.Point(222, 50);
            this.LabelTimer.Name = "LabelTimer";
            this.LabelTimer.Size = new System.Drawing.Size(20, 22);
            this.LabelTimer.TabIndex = 2;
            this.LabelTimer.Text = "0";
            // 
            // LabelMistakes
            // 
            this.LabelMistakes.AutoSize = true;
            this.LabelMistakes.BackColor = System.Drawing.Color.Transparent;
            this.LabelMistakes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMistakes.Location = new System.Drawing.Point(640, 100);
            this.LabelMistakes.Name = "LabelMistakes";
            this.LabelMistakes.Size = new System.Drawing.Size(20, 22);
            this.LabelMistakes.TabIndex = 10;
            this.LabelMistakes.Text = "0";
            // 
            // LabelOllChars
            // 
            this.LabelOllChars.AutoSize = true;
            this.LabelOllChars.BackColor = System.Drawing.Color.Transparent;
            this.LabelOllChars.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelOllChars.Location = new System.Drawing.Point(640, 50);
            this.LabelOllChars.Name = "LabelOllChars";
            this.LabelOllChars.Size = new System.Drawing.Size(20, 22);
            this.LabelOllChars.TabIndex = 11;
            this.LabelOllChars.Text = "0";
            // 
            // LabelSpeed
            // 
            this.LabelSpeed.AutoSize = true;
            this.LabelSpeed.BackColor = System.Drawing.Color.Transparent;
            this.LabelSpeed.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSpeed.Location = new System.Drawing.Point(316, 100);
            this.LabelSpeed.Name = "LabelSpeed";
            this.LabelSpeed.Size = new System.Drawing.Size(20, 22);
            this.LabelSpeed.TabIndex = 12;
            this.LabelSpeed.Text = "0";
            // 
            // LabelPercentOfMistakes
            // 
            this.LabelPercentOfMistakes.AutoSize = true;
            this.LabelPercentOfMistakes.BackColor = System.Drawing.Color.Transparent;
            this.LabelPercentOfMistakes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPercentOfMistakes.Location = new System.Drawing.Point(647, 150);
            this.LabelPercentOfMistakes.Name = "LabelPercentOfMistakes";
            this.LabelPercentOfMistakes.Size = new System.Drawing.Size(20, 22);
            this.LabelPercentOfMistakes.TabIndex = 13;
            this.LabelPercentOfMistakes.Text = "0";
            // 
            // LabelHelper
            // 
            this.LabelHelper.AutoSize = true;
            this.LabelHelper.BackColor = System.Drawing.Color.Transparent;
            this.LabelHelper.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelHelper.Location = new System.Drawing.Point(162, 120);
            this.LabelHelper.Name = "LabelHelper";
            this.LabelHelper.Size = new System.Drawing.Size(140, 14);
            this.LabelHelper.TabIndex = 14;
            this.LabelHelper.Text = "(кол-во символов в минуту)";
            // 
            // LabelTimerText
            // 
            this.LabelTimerText.AutoSize = true;
            this.LabelTimerText.BackColor = System.Drawing.Color.Transparent;
            this.LabelTimerText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTimerText.Location = new System.Drawing.Point(150, 50);
            this.LabelTimerText.Name = "LabelTimerText";
            this.LabelTimerText.Size = new System.Drawing.Size(70, 22);
            this.LabelTimerText.TabIndex = 15;
            this.LabelTimerText.Text = "Время:";
            // 
            // LabelSpeedText
            // 
            this.LabelSpeedText.AutoSize = true;
            this.LabelSpeedText.BackColor = System.Drawing.Color.Transparent;
            this.LabelSpeedText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSpeedText.Location = new System.Drawing.Point(150, 100);
            this.LabelSpeedText.Name = "LabelSpeedText";
            this.LabelSpeedText.Size = new System.Drawing.Size(164, 22);
            this.LabelSpeedText.TabIndex = 16;
            this.LabelSpeedText.Text = "Скорость набора:";
            // 
            // LabelOllCharsText
            // 
            this.LabelOllCharsText.AutoSize = true;
            this.LabelOllCharsText.BackColor = System.Drawing.Color.Transparent;
            this.LabelOllCharsText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelOllCharsText.Location = new System.Drawing.Point(480, 50);
            this.LabelOllCharsText.Name = "LabelOllCharsText";
            this.LabelOllCharsText.Size = new System.Drawing.Size(154, 22);
            this.LabelOllCharsText.TabIndex = 17;
            this.LabelOllCharsText.Text = "Всего символов:";
            // 
            // LabelMistakesText
            // 
            this.LabelMistakesText.AutoSize = true;
            this.LabelMistakesText.BackColor = System.Drawing.Color.Transparent;
            this.LabelMistakesText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelMistakesText.Location = new System.Drawing.Point(480, 100);
            this.LabelMistakesText.Name = "LabelMistakesText";
            this.LabelMistakesText.Size = new System.Drawing.Size(147, 22);
            this.LabelMistakesText.TabIndex = 18;
            this.LabelMistakesText.Text = "Кол-во ошибок:";
            // 
            // LabelPercentOfMistakesText
            // 
            this.LabelPercentOfMistakesText.AutoSize = true;
            this.LabelPercentOfMistakesText.BackColor = System.Drawing.Color.Transparent;
            this.LabelPercentOfMistakesText.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPercentOfMistakesText.Location = new System.Drawing.Point(480, 150);
            this.LabelPercentOfMistakesText.Name = "LabelPercentOfMistakesText";
            this.LabelPercentOfMistakesText.Size = new System.Drawing.Size(161, 22);
            this.LabelPercentOfMistakesText.TabIndex = 19;
            this.LabelPercentOfMistakesText.Text = "Процент ошибок:";
            // 
            // RichTextBoxInput
            // 
            this.RichTextBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichTextBoxInput.Location = new System.Drawing.Point(150, 438);
            this.RichTextBoxInput.Margin = new System.Windows.Forms.Padding(0);
            this.RichTextBoxInput.Name = "RichTextBoxInput";
            this.RichTextBoxInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RichTextBoxInput.Size = new System.Drawing.Size(660, 90);
            this.RichTextBoxInput.TabIndex = 20;
            this.RichTextBoxInput.Text = "";
            this.RichTextBoxInput.TextChanged += new System.EventHandler(this.RichTextBoxInput_TextChanged);
            // 
            // RichTextBoxSample
            // 
            this.RichTextBoxSample.BackColor = System.Drawing.SystemColors.Window;
            this.RichTextBoxSample.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxSample.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RichTextBoxSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichTextBoxSample.Location = new System.Drawing.Point(150, 180);
            this.RichTextBoxSample.Margin = new System.Windows.Forms.Padding(0);
            this.RichTextBoxSample.Name = "RichTextBoxSample";
            this.RichTextBoxSample.ReadOnly = true;
            this.RichTextBoxSample.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RichTextBoxSample.Size = new System.Drawing.Size(660, 255);
            this.RichTextBoxSample.TabIndex = 24;
            this.RichTextBoxSample.TabStop = false;
            this.RichTextBoxSample.Text = "";
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.Transparent;
            this.ButtonBack.BackgroundImage = global::FastFingers.Properties.Resources.ButtonBack;
            this.ButtonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBack.FlatAppearance.BorderSize = 0;
            this.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(880, 5);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(70, 30);
            this.ButtonBack.TabIndex = 25;
            this.ButtonBack.UseVisualStyleBackColor = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            this.ButtonBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonBack_MouseDown);
            this.ButtonBack.MouseEnter += new System.EventHandler(this.ButtonBack_MouseEnter);
            this.ButtonBack.MouseLeave += new System.EventHandler(this.ButtonBack_MouseLeave);
            // 
            // FormTraining
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::FastFingers.Properties.Resources.BackgroundImageSecond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.RichTextBoxSample);
            this.Controls.Add(this.RichTextBoxInput);
            this.Controls.Add(this.LabelPercentOfMistakesText);
            this.Controls.Add(this.LabelMistakesText);
            this.Controls.Add(this.LabelOllCharsText);
            this.Controls.Add(this.LabelSpeedText);
            this.Controls.Add(this.LabelTimerText);
            this.Controls.Add(this.LabelHelper);
            this.Controls.Add(this.LabelPercentOfMistakes);
            this.Controls.Add(this.LabelSpeed);
            this.Controls.Add(this.LabelOllChars);
            this.Controls.Add(this.LabelMistakes);
            this.Controls.Add(this.LabelTimer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTraining";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormTraining_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TrainingTimer;
        private System.Windows.Forms.Label LabelTimer;
        private System.Windows.Forms.Label LabelMistakes;
        private System.Windows.Forms.Label LabelOllChars;
        private System.Windows.Forms.Label LabelSpeed;
        private System.Windows.Forms.Label LabelPercentOfMistakes;
        private System.Windows.Forms.Label LabelHelper;
        private System.Windows.Forms.Label LabelTimerText;
        private System.Windows.Forms.Label LabelSpeedText;
        private System.Windows.Forms.Label LabelOllCharsText;
        private System.Windows.Forms.Label LabelMistakesText;
        private System.Windows.Forms.Label LabelPercentOfMistakesText;
        private System.Windows.Forms.RichTextBox RichTextBoxInput;
        private System.Windows.Forms.RichTextBox RichTextBoxSample;
        private System.Windows.Forms.Button ButtonBack;
    }
}