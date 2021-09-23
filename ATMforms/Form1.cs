using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using ATMforms.Managers;
using System.Collections;

namespace ATMforms
{
   
    public partial class Form1 : MetroForm
    {
        private LoginManager loginManager;
        private MetroForm form;
        public static ArrayList list;
        BalanceManager _Bal;

    
        public Form1()
        {
            list = new ArrayList();
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            loginManager = new LoginManager();
            if(RegisterNameBox.Text == string.Empty || RegisterNameBox.Text == "Username" || RegisterPassBox.Text == string.Empty || RegisterPassBox.Text == "Password")
            {
                MessageBox.Show("Please enter right details");
                return;
            }
            if(RegisterPassBox.Text != RegisterPasswordBox.Text)
            {
                MsgLabel.Visible = true;
                MsgLabel.Text = "control password don't match";
                return;
            }
            if(!loginManager.Register(RegisterNameBox.Text, RegisterPassBox.Text))
            {
                
                MsgLabel.Visible = true;
                MsgLabel.Text = "User Already exist";
            }
            else
            {
                MsgLabel.Visible = true;
                MsgLabel.Text = "Succesfully registered!";
            }
        }

        private void RegisterNameBox_Click(object sender, EventArgs e)
        {
            if (RegisterNameBox.Text == "Username")
            {
                RegisterNameBox.Text = "";
            }
        }

        private void RegisterPassBox_Click(object sender, EventArgs e)
        {
            if (RegisterPassBox.Text == "Password")
            {
                RegisterPassBox.Text = "";
            }
        }

        private void RegisterPasswordBox_Click(object sender, EventArgs e)
        {
            if (RegisterPasswordBox.Text == "Password")
            {
                RegisterPasswordBox.Text = "";
            }
        }

        private void UsernameBox_Click(object sender, EventArgs e)
        {
            if(UsernameBox.Text == "Username")
            {
                UsernameBox.Text = "";
            }
        }

        private void PasswordBox_Click(object sender, EventArgs e)
        {
            if(PasswordBox.Text == "Password")
            {
                PasswordBox.Text = "";
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UsernameBox.Text == string.Empty || UsernameBox.Text =="Username")
            {
                msgLabelLgn.Visible = true;
                msgLabelLgn.Text = "Enter valid username";
                return;
            }
            if(PasswordBox.Text == "Password" || PasswordBox.Text == string.Empty)
            {
                msgLabelLgn.Visible = true;
                msgLabelLgn.Text = "Enter valid password";
                return;
            }
            loginManager = new LoginManager();
            msgLabelLgn.Text = loginManager.login(UsernameBox.Text, PasswordBox.Text);
            if(LoginSucces())
            {
                _Bal = new BalanceManager();
                _Bal.BalanceUSer(UsernameBox.Text , PasswordBox.Text);
                form = new BankForm.BankFormUser();
                form.Name = $"{UsernameBox.Text}";
                form.Text = $"Logged as {UsernameBox.Text}";
                if (list.Contains(this.form.Name))
                {
                    msgLabelLgn.Visible = true;
                    msgLabelLgn.Text = "User already logged in";
                    return;
                }
                else
                {
                    list.Add(this.form.Name);
                    form.Show();
                }
                
            }
            else
            {
                MessageBox.Show(msgLabelLgn.Text);
            }
        }
        private bool LoginSucces()
        {
            return msgLabelLgn.Text == "Succesfully logged in";
        }
    }
}
