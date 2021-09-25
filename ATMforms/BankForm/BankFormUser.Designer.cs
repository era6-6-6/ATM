
namespace ATMforms.BankForm
{
    partial class BankFormUser
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
            this.MainTAb = new MetroFramework.Controls.MetroTabControl();
            this.OverViewTab = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.BalanceBtn = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTabPage5 = new MetroFramework.Controls.MetroTabPage();
            this.TransactionTab = new MetroFramework.Controls.MetroTabPage();
            this.InstantPayCheck = new MetroFramework.Controls.MetroCheckBox();
            this.MessageBox = new MetroFramework.Controls.MetroTextBox();
            this.VsBox = new MetroFramework.Controls.MetroTextBox();
            this.KSbox = new MetroFramework.Controls.MetroTextBox();
            this.AmountBox = new MetroFramework.Controls.MetroTextBox();
            this.BankID = new MetroFramework.Controls.MetroTextBox();
            this.ReceiverID = new MetroFramework.Controls.MetroTextBox();
            this.SendBtn = new MetroFramework.Controls.MetroButton();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.HistoryTab = new MetroFramework.Controls.MetroTabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.metroTabPage6 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.BalanceLbl = new MetroFramework.Controls.MetroLabel();
            this.IdLbl = new MetroFramework.Controls.MetroLabel();
            this.MainTAb.SuspendLayout();
            this.OverViewTab.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.TransactionTab.SuspendLayout();
            this.HistoryTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTAb
            // 
            this.MainTAb.Controls.Add(this.OverViewTab);
            this.MainTAb.Controls.Add(this.metroTabPage5);
            this.MainTAb.Controls.Add(this.TransactionTab);
            this.MainTAb.Controls.Add(this.HistoryTab);
            this.MainTAb.Controls.Add(this.metroTabPage6);
            this.MainTAb.Controls.Add(this.metroTabPage4);
            this.MainTAb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTAb.Location = new System.Drawing.Point(20, 60);
            this.MainTAb.Name = "MainTAb";
            this.MainTAb.SelectedIndex = 2;
            this.MainTAb.Size = new System.Drawing.Size(1301, 718);
            this.MainTAb.TabIndex = 0;
            this.MainTAb.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.MainTAb.Click += new System.EventHandler(this.MainTAb_Click);
            // 
            // OverViewTab
            // 
            this.OverViewTab.Controls.Add(this.metroPanel1);
            this.OverViewTab.HorizontalScrollbarBarColor = true;
            this.OverViewTab.HorizontalScrollbarSize = 0;
            this.OverViewTab.Location = new System.Drawing.Point(4, 35);
            this.OverViewTab.Name = "OverViewTab";
            this.OverViewTab.Size = new System.Drawing.Size(1293, 679);
            this.OverViewTab.TabIndex = 0;
            this.OverViewTab.Text = "OverView";
            this.OverViewTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OverViewTab.VerticalScrollbarBarColor = true;
            this.OverViewTab.VerticalScrollbarSize = 0;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroButton4);
            this.metroPanel1.Controls.Add(this.BalanceBtn);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(444, 414);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroButton4
            // 
            this.metroButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton4.Location = new System.Drawing.Point(158, 41);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(286, 41);
            this.metroButton4.TabIndex = 4;
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // BalanceBtn
            // 
            this.BalanceBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.BalanceBtn.Location = new System.Drawing.Point(158, 0);
            this.BalanceBtn.Name = "BalanceBtn";
            this.BalanceBtn.Size = new System.Drawing.Size(286, 41);
            this.BalanceBtn.TabIndex = 3;
            this.BalanceBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroButton2);
            this.metroPanel2.Controls.Add(this.metroButton1);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(158, 414);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroButton2
            // 
            this.metroButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton2.Location = new System.Drawing.Point(0, 41);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(158, 41);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Saving Account";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton1
            // 
            this.metroButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroButton1.Location = new System.Drawing.Point(0, 0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(158, 41);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Balance";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabPage5
            // 
            this.metroTabPage5.HorizontalScrollbarBarColor = true;
            this.metroTabPage5.HorizontalScrollbarSize = 0;
            this.metroTabPage5.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage5.Name = "metroTabPage5";
            this.metroTabPage5.Size = new System.Drawing.Size(1293, 679);
            this.metroTabPage5.TabIndex = 4;
            this.metroTabPage5.Text = "metroTabPage5";
            this.metroTabPage5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage5.VerticalScrollbarBarColor = true;
            this.metroTabPage5.VerticalScrollbarSize = 0;
            // 
            // TransactionTab
            // 
            this.TransactionTab.Controls.Add(this.InstantPayCheck);
            this.TransactionTab.Controls.Add(this.MessageBox);
            this.TransactionTab.Controls.Add(this.VsBox);
            this.TransactionTab.Controls.Add(this.KSbox);
            this.TransactionTab.Controls.Add(this.AmountBox);
            this.TransactionTab.Controls.Add(this.BankID);
            this.TransactionTab.Controls.Add(this.ReceiverID);
            this.TransactionTab.Controls.Add(this.SendBtn);
            this.TransactionTab.Controls.Add(this.metroPanel3);
            this.TransactionTab.HorizontalScrollbarBarColor = true;
            this.TransactionTab.HorizontalScrollbarSize = 0;
            this.TransactionTab.Location = new System.Drawing.Point(4, 35);
            this.TransactionTab.Name = "TransactionTab";
            this.TransactionTab.Size = new System.Drawing.Size(1293, 679);
            this.TransactionTab.TabIndex = 2;
            this.TransactionTab.Text = "Transactions";
            this.TransactionTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransactionTab.VerticalScrollbarBarColor = true;
            this.TransactionTab.VerticalScrollbarSize = 0;
            // 
            // InstantPayCheck
            // 
            this.InstantPayCheck.AutoSize = true;
            this.InstantPayCheck.Location = new System.Drawing.Point(547, 243);
            this.InstantPayCheck.Name = "InstantPayCheck";
            this.InstantPayCheck.Size = new System.Drawing.Size(123, 15);
            this.InstantPayCheck.TabIndex = 12;
            this.InstantPayCheck.Text = "Instant pay (1$ fee)";
            this.InstantPayCheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.InstantPayCheck.UseVisualStyleBackColor = true;
            // 
            // MessageBox
            // 
            this.MessageBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.MessageBox.Location = new System.Drawing.Point(441, 195);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(354, 31);
            this.MessageBox.TabIndex = 11;
            this.MessageBox.Text = "Message";
            // 
            // VsBox
            // 
            this.VsBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.VsBox.Location = new System.Drawing.Point(660, 134);
            this.VsBox.Name = "VsBox";
            this.VsBox.Size = new System.Drawing.Size(227, 31);
            this.VsBox.TabIndex = 10;
            this.VsBox.Text = "VS";
            // 
            // KSbox
            // 
            this.KSbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.KSbox.Location = new System.Drawing.Point(371, 134);
            this.KSbox.Name = "KSbox";
            this.KSbox.Size = new System.Drawing.Size(227, 31);
            this.KSbox.TabIndex = 9;
            this.KSbox.Text = "CS";
            // 
            // AmountBox
            // 
            this.AmountBox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.AmountBox.Location = new System.Drawing.Point(803, 68);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(227, 31);
            this.AmountBox.TabIndex = 8;
            this.AmountBox.Text = "Amount";
            // 
            // BankID
            // 
            this.BankID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.BankID.Location = new System.Drawing.Point(533, 68);
            this.BankID.Name = "BankID";
            this.BankID.Size = new System.Drawing.Size(227, 31);
            this.BankID.TabIndex = 6;
            this.BankID.Text = "Bank ID";
            // 
            // ReceiverID
            // 
            this.ReceiverID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.ReceiverID.Location = new System.Drawing.Point(254, 68);
            this.ReceiverID.Name = "ReceiverID";
            this.ReceiverID.Size = new System.Drawing.Size(227, 31);
            this.ReceiverID.TabIndex = 5;
            this.ReceiverID.Text = "Id of Receiver";
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(547, 279);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(105, 42);
            this.SendBtn.TabIndex = 4;
            this.SendBtn.Text = "Send";
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(1293, 62);
            this.metroPanel3.TabIndex = 2;
            this.metroPanel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // HistoryTab
            // 
            this.HistoryTab.Controls.Add(this.listView1);
            this.HistoryTab.HorizontalScrollbarBarColor = true;
            this.HistoryTab.HorizontalScrollbarSize = 0;
            this.HistoryTab.Location = new System.Drawing.Point(4, 35);
            this.HistoryTab.Name = "HistoryTab";
            this.HistoryTab.Size = new System.Drawing.Size(1293, 679);
            this.HistoryTab.TabIndex = 1;
            this.HistoryTab.Text = "History";
            this.HistoryTab.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.HistoryTab.VerticalScrollbarBarColor = true;
            this.HistoryTab.VerticalScrollbarSize = 0;
            this.HistoryTab.Click += new System.EventHandler(this.HistoryTab_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.MenuText;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView1.ForeColor = System.Drawing.SystemColors.Control;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(1293, 679);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // metroTabPage6
            // 
            this.metroTabPage6.HorizontalScrollbarBarColor = true;
            this.metroTabPage6.HorizontalScrollbarSize = 0;
            this.metroTabPage6.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage6.Name = "metroTabPage6";
            this.metroTabPage6.Size = new System.Drawing.Size(1293, 679);
            this.metroTabPage6.TabIndex = 5;
            this.metroTabPage6.Text = "metroTabPage6";
            this.metroTabPage6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage6.VerticalScrollbarBarColor = true;
            this.metroTabPage6.VerticalScrollbarSize = 0;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarSize = 0;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(1293, 679);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "metroTabPage4";
            this.metroTabPage4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarSize = 0;
            // 
            // BalanceLbl
            // 
            this.BalanceLbl.AutoSize = true;
            this.BalanceLbl.Location = new System.Drawing.Point(1141, 50);
            this.BalanceLbl.Name = "BalanceLbl";
            this.BalanceLbl.Size = new System.Drawing.Size(57, 19);
            this.BalanceLbl.TabIndex = 1;
            this.BalanceLbl.Text = "Balance:";
            this.BalanceLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Location = new System.Drawing.Point(1141, 31);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(28, 19);
            this.IdLbl.TabIndex = 2;
            this.IdLbl.Text = "ID: ";
            this.IdLbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // BankFormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 798);
            this.Controls.Add(this.IdLbl);
            this.Controls.Add(this.BalanceLbl);
            this.Controls.Add(this.MainTAb);
            this.Name = "BankFormUser";
            this.Text = "BankFormUser";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BankFormUser_FormClosed);
            this.MainTAb.ResumeLayout(false);
            this.OverViewTab.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.TransactionTab.ResumeLayout(false);
            this.TransactionTab.PerformLayout();
            this.HistoryTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl MainTAb;
        private MetroFramework.Controls.MetroTabPage OverViewTab;
        private MetroFramework.Controls.MetroTabPage HistoryTab;
        private MetroFramework.Controls.MetroTabPage TransactionTab;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroTabPage metroTabPage5;
        private MetroFramework.Controls.MetroTabPage metroTabPage6;
        private MetroFramework.Controls.MetroLabel BalanceLbl;
        private MetroFramework.Controls.MetroLabel IdLbl;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton BalanceBtn;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton SendBtn;
        private System.Windows.Forms.ListView listView1;
        private MetroFramework.Controls.MetroCheckBox InstantPayCheck;
        private MetroFramework.Controls.MetroTextBox MessageBox;
        private MetroFramework.Controls.MetroTextBox VsBox;
        private MetroFramework.Controls.MetroTextBox KSbox;
        private MetroFramework.Controls.MetroTextBox AmountBox;
        private MetroFramework.Controls.MetroTextBox BankID;
        private MetroFramework.Controls.MetroTextBox ReceiverID;
    }
}