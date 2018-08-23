namespace FastFingers
{
    partial class FormCheckIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckIn));
            this.TextBoxPass = new System.Windows.Forms.TextBox();
            this.TextBoxLog = new System.Windows.Forms.TextBox();
            this.TextBoxRepeatPass = new System.Windows.Forms.TextBox();
            this.ButtonContinue = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxPass
            // 
            this.TextBoxPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPass.BackColor = System.Drawing.Color.White;
            this.TextBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPass.ForeColor = System.Drawing.Color.Silver;
            this.TextBoxPass.Location = new System.Drawing.Point(125, 140);
            this.TextBoxPass.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxPass.Name = "TextBoxPass";
            this.TextBoxPass.Size = new System.Drawing.Size(350, 19);
            this.TextBoxPass.TabIndex = 5;
            this.TextBoxPass.Text = "Пароль";
            this.TextBoxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxPass.Enter += new System.EventHandler(this.TextBoxPass_Enter);
            this.TextBoxPass.Leave += new System.EventHandler(this.TextBoxPass_Leave);
            // 
            // TextBoxLog
            // 
            this.TextBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxLog.BackColor = System.Drawing.Color.White;
            this.TextBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxLog.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxLog.ForeColor = System.Drawing.Color.Silver;
            this.TextBoxLog.Location = new System.Drawing.Point(125, 100);
            this.TextBoxLog.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxLog.Name = "TextBoxLog";
            this.TextBoxLog.Size = new System.Drawing.Size(350, 19);
            this.TextBoxLog.TabIndex = 4;
            this.TextBoxLog.Text = "Логин";
            this.TextBoxLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxLog.Enter += new System.EventHandler(this.TextBoxLog_Enter);
            this.TextBoxLog.Leave += new System.EventHandler(this.TextBoxLog_Leave);
            // 
            // TextBoxRepeatPass
            // 
            this.TextBoxRepeatPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxRepeatPass.BackColor = System.Drawing.Color.White;
            this.TextBoxRepeatPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxRepeatPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxRepeatPass.ForeColor = System.Drawing.Color.Silver;
            this.TextBoxRepeatPass.Location = new System.Drawing.Point(125, 180);
            this.TextBoxRepeatPass.Margin = new System.Windows.Forms.Padding(0);
            this.TextBoxRepeatPass.Name = "TextBoxRepeatPass";
            this.TextBoxRepeatPass.Size = new System.Drawing.Size(350, 19);
            this.TextBoxRepeatPass.TabIndex = 6;
            this.TextBoxRepeatPass.Text = "Повторите пароль";
            this.TextBoxRepeatPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxRepeatPass.Enter += new System.EventHandler(this.TextBoxRepeatPass_Enter);
            this.TextBoxRepeatPass.Leave += new System.EventHandler(this.TextBoxRepeatPass_Leave);
            // 
            // ButtonContinue
            // 
            this.ButtonContinue.BackColor = System.Drawing.Color.Transparent;
            this.ButtonContinue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonContinue.BackgroundImage")));
            this.ButtonContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonContinue.FlatAppearance.BorderSize = 0;
            this.ButtonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonContinue.Location = new System.Drawing.Point(170, 220);
            this.ButtonContinue.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonContinue.Name = "ButtonContinue";
            this.ButtonContinue.Size = new System.Drawing.Size(260, 40);
            this.ButtonContinue.TabIndex = 7;
            this.ButtonContinue.UseVisualStyleBackColor = false;
            this.ButtonContinue.Click += new System.EventHandler(this.ButtonContinue_Click);
            this.ButtonContinue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonContinue_MouseDown);
            this.ButtonContinue.MouseEnter += new System.EventHandler(this.ButtonContinue_MouseEnter);
            this.ButtonContinue.MouseLeave += new System.EventHandler(this.ButtonContinue_MouseLeave);
            this.ButtonContinue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonContinue_MouseUp);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonCancel.BackgroundImage")));
            this.ButtonCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.FlatAppearance.BorderSize = 0;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Location = new System.Drawing.Point(270, 263);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(60, 20);
            this.ButtonCancel.TabIndex = 8;
            this.ButtonCancel.UseVisualStyleBackColor = false;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            this.ButtonCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonCancel_MouseDown);
            this.ButtonCancel.MouseEnter += new System.EventHandler(this.ButtonCancel_MouseEnter);
            this.ButtonCancel.MouseLeave += new System.EventHandler(this.ButtonCancel_MouseLeave);
            // 
            // FormCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FastFingers.Properties.Resources.BackgroundImageSecond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonContinue);
            this.Controls.Add(this.TextBoxRepeatPass);
            this.Controls.Add(this.TextBoxPass);
            this.Controls.Add(this.TextBoxLog);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCheckIn";
            this.Load += new System.EventHandler(this.FormCheckIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxPass;
        private System.Windows.Forms.TextBox TextBoxLog;
        private System.Windows.Forms.TextBox TextBoxRepeatPass;
        private System.Windows.Forms.Button ButtonContinue;
        private System.Windows.Forms.Button ButtonCancel;
    }
}