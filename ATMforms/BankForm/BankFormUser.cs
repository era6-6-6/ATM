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

namespace ATMforms.BankForm
{
    public partial class BankFormUser : MetroForm
    {
       HistoryManager _historyManager;
        BalanceManager _balanceMAnager;
      
        public BankFormUser()
        {
            InitializeComponent();
            BalanceLbl.Text += " " + BalanceManager.Balance.ToString("N0",
    System.Globalization.CultureInfo.GetCultureInfo("de")) + "$";
            IdLbl.Text += " " + BalanceManager.ID;
            BalanceBtn.Text = " " + BalanceManager.Balance.ToString("N0",
    System.Globalization.CultureInfo.GetCultureInfo("de")) + "$";
        }

        private void BankFormUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.list.Remove(this.Name);
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            _balanceMAnager = new BalanceManager();
            _historyManager = new HistoryManager();
            if (!EnoughMoney(int.Parse(IdLbl.Text.Replace("ID: ", ""))))
            {
                MessageBox.Show("Not enough money");
                return;
            }
            else
            {
                _historyManager.SaveTransaction(DateTime.Now, int.Parse(IdLbl.Text.Replace("ID: ", "")), 11, 5000);
                _historyManager.GetTransaction(int.Parse(IdLbl.Text.Replace("ID: ", "")));
                listView1.View = View.List;
                listView1.GridLines = false;
                listView1.Items.Clear();
                foreach (var item in HistoryManager.Data)
                {
                    listView1.Items.Add(item);
                }
                _historyManager.MinusBalance(int.Parse(IdLbl.Text.Replace("ID: ", "")), 5000);
                _balanceMAnager.BalanceUSerID(int.Parse(IdLbl.Text.Replace("ID: ", "")));
                BalanceBtn.Text = " " + BalanceManager.Balance.ToString("N0",
                    System.Globalization.CultureInfo.GetCultureInfo("de")) + "$";
                BalanceLbl.Text = "Balance: " + " " + BalanceManager.Balance.ToString("N0",
                    System.Globalization.CultureInfo.GetCultureInfo("de")) + "$";
            }



        }

        private bool EnoughMoney(int id)
        {
            _balanceMAnager = new BalanceManager();

            if (_balanceMAnager.BalanceUSerID(id) <= 0)
                return false;
            else
                return true;
        }
    }
}
