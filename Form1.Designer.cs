namespace CSCDashboard
{
    partial class Form1
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
            this.userNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.passTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            // 
            // 
            // 
            this.userNameTextBox.CustomButton.Image = null;
            this.userNameTextBox.CustomButton.Location = new System.Drawing.Point(290, 1);
            this.userNameTextBox.CustomButton.Name = "";
            this.userNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.userNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userNameTextBox.CustomButton.TabIndex = 1;
            this.userNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userNameTextBox.CustomButton.UseSelectable = true;
            this.userNameTextBox.CustomButton.Visible = false;
            this.userNameTextBox.Lines = new string[0];
            this.userNameTextBox.Location = new System.Drawing.Point(218, 157);
            this.userNameTextBox.MaxLength = 32767;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.PasswordChar = '\0';
            this.userNameTextBox.PromptText = "Enter your User Name";
            this.userNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userNameTextBox.SelectedText = "";
            this.userNameTextBox.SelectionLength = 0;
            this.userNameTextBox.SelectionStart = 0;
            this.userNameTextBox.ShortcutsEnabled = true;
            this.userNameTextBox.Size = new System.Drawing.Size(312, 23);
            this.userNameTextBox.TabIndex = 0;
            this.userNameTextBox.UseSelectable = true;
            this.userNameTextBox.WaterMark = "Enter your User Name";
            this.userNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passTextBox
            // 
            // 
            // 
            // 
            this.passTextBox.CustomButton.Image = null;
            this.passTextBox.CustomButton.Location = new System.Drawing.Point(290, 1);
            this.passTextBox.CustomButton.Name = "";
            this.passTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passTextBox.CustomButton.TabIndex = 1;
            this.passTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passTextBox.CustomButton.UseSelectable = true;
            this.passTextBox.CustomButton.Visible = false;
            this.passTextBox.Lines = new string[0];
            this.passTextBox.Location = new System.Drawing.Point(218, 231);
            this.passTextBox.MaxLength = 32767;
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '●';
            this.passTextBox.PromptText = "Enter your Password";
            this.passTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passTextBox.SelectedText = "";
            this.passTextBox.SelectionLength = 0;
            this.passTextBox.SelectionStart = 0;
            this.passTextBox.ShortcutsEnabled = true;
            this.passTextBox.Size = new System.Drawing.Size(312, 23);
            this.passTextBox.TabIndex = 1;
            this.passTextBox.UseSelectable = true;
            this.passTextBox.UseSystemPasswordChar = true;
            this.passTextBox.WaterMark = "Enter your Password";
            this.passTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(536, 157);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(123, 97);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Click For Loign";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Name = "Form1";
            this.Text = "Welcome To Cyber Security Center";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox userNameTextBox;
        private MetroFramework.Controls.MetroTextBox passTextBox;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}

