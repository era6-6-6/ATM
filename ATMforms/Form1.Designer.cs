
namespace ATMforms
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
            this.MainTab = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.msgLabelLgn = new MetroFramework.Controls.MetroLabel();
            this.LoginBtn = new MetroFramework.Controls.MetroButton();
            this.PasswordBox = new MetroFramework.Controls.MetroTextBox();
            this.UsernameBox = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.MsgLabel = new MetroFramework.Controls.MetroLabel();
            this.RegisterBtn = new MetroFramework.Controls.MetroButton();
            this.RegisterPasswordBox = new MetroFramework.Controls.MetroTextBox();
            this.RegisterPassBox = new MetroFramework.Controls.MetroTextBox();
            this.RegisterNameBox = new MetroFramework.Controls.MetroTextBox();
            this.MainTab.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.metroTabPage1);
            this.MainTab.Controls.Add(this.metroTabPage2);
            this.MainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTab.Location = new System.Drawing.Point(20, 60);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(411, 205);
            this.MainTab.TabIndex = 0;
            this.MainTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.msgLabelLgn);
            this.metroTabPage1.Controls.Add(this.LoginBtn);
            this.metroTabPage1.Controls.Add(this.PasswordBox);
            this.metroTabPage1.Controls.Add(this.UsernameBox);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(403, 166);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Login";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // msgLabelLgn
            // 
            this.msgLabelLgn.AutoSize = true;
            this.msgLabelLgn.Location = new System.Drawing.Point(3, 147);
            this.msgLabelLgn.Name = "msgLabelLgn";
            this.msgLabelLgn.Size = new System.Drawing.Size(60, 19);
            this.msgLabelLgn.TabIndex = 9;
            this.msgLabelLgn.Text = "message";
            this.msgLabelLgn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.msgLabelLgn.Visible = false;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(143, 93);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.PasswordBox.Location = new System.Drawing.Point(103, 64);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(162, 23);
            this.PasswordBox.TabIndex = 3;
            this.PasswordBox.Text = "Password";
            this.PasswordBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PasswordBox.Click += new System.EventHandler(this.PasswordBox_Click);
            // 
            // UsernameBox
            // 
            this.UsernameBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.UsernameBox.Location = new System.Drawing.Point(103, 35);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(162, 23);
            this.UsernameBox.TabIndex = 2;
            this.UsernameBox.Text = "Username";
            this.UsernameBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.UsernameBox.Click += new System.EventHandler(this.UsernameBox_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.MsgLabel);
            this.metroTabPage2.Controls.Add(this.RegisterBtn);
            this.metroTabPage2.Controls.Add(this.RegisterPasswordBox);
            this.metroTabPage2.Controls.Add(this.RegisterPassBox);
            this.metroTabPage2.Controls.Add(this.RegisterNameBox);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(403, 166);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Register";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // MsgLabel
            // 
            this.MsgLabel.AutoSize = true;
            this.MsgLabel.Location = new System.Drawing.Point(3, 147);
            this.MsgLabel.Name = "MsgLabel";
            this.MsgLabel.Size = new System.Drawing.Size(60, 19);
            this.MsgLabel.TabIndex = 8;
            this.MsgLabel.Text = "message";
            this.MsgLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MsgLabel.Visible = false;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(146, 119);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(75, 23);
            this.RegisterBtn.TabIndex = 7;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // RegisterPasswordBox
            // 
            this.RegisterPasswordBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.RegisterPasswordBox.Location = new System.Drawing.Point(105, 90);
            this.RegisterPasswordBox.Name = "RegisterPasswordBox";
            this.RegisterPasswordBox.Size = new System.Drawing.Size(162, 23);
            this.RegisterPasswordBox.TabIndex = 6;
            this.RegisterPasswordBox.Text = "Password";
            this.RegisterPasswordBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RegisterPasswordBox.Click += new System.EventHandler(this.RegisterPasswordBox_Click);
            // 
            // RegisterPassBox
            // 
            this.RegisterPassBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.RegisterPassBox.Location = new System.Drawing.Point(105, 61);
            this.RegisterPassBox.Name = "RegisterPassBox";
            this.RegisterPassBox.Size = new System.Drawing.Size(162, 23);
            this.RegisterPassBox.TabIndex = 5;
            this.RegisterPassBox.Text = "Password";
            this.RegisterPassBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RegisterPassBox.Click += new System.EventHandler(this.RegisterPassBox_Click);
            // 
            // RegisterNameBox
            // 
            this.RegisterNameBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.RegisterNameBox.Location = new System.Drawing.Point(105, 32);
            this.RegisterNameBox.Name = "RegisterNameBox";
            this.RegisterNameBox.Size = new System.Drawing.Size(162, 23);
            this.RegisterNameBox.TabIndex = 4;
            this.RegisterNameBox.Text = "Username";
            this.RegisterNameBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.RegisterNameBox.Click += new System.EventHandler(this.RegisterNameBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 285);
            this.Controls.Add(this.MainTab);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Era Bank";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MainTab.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl MainTab;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton LoginBtn;
        private MetroFramework.Controls.MetroTextBox PasswordBox;
        private MetroFramework.Controls.MetroTextBox UsernameBox;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton RegisterBtn;
        private MetroFramework.Controls.MetroTextBox RegisterPasswordBox;
        private MetroFramework.Controls.MetroTextBox RegisterPassBox;
        private MetroFramework.Controls.MetroTextBox RegisterNameBox;
        private MetroFramework.Controls.MetroLabel MsgLabel;
        private MetroFramework.Controls.MetroLabel msgLabelLgn;
    }
}

