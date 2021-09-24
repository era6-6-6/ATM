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
            BuildListView();
        }

        private void BankFormUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.list.Remove(this.Name);
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            OnAction();
        }

        private bool EnoughMoney(int id)
        {
            _balanceMAnager = new BalanceManager();

            if (_balanceMAnager.BalanceUSerID(id) <= 0)
                return false;
            else
                return true;
        }
        private void OnAction()
        {
            _balanceMAnager = new BalanceManager();
            _historyManager = new HistoryManager();
            if (!EnoughMoney(int.Parse(IdLbl.Text.Replace("ID: ", ""))) || BalanceManager.Balance < 5000)
            {
                MessageBox.Show("Not enough money");
                return;
            }
            else
            {
                _historyManager.SaveTransaction(DateTime.Now, int.Parse(IdLbl.Text.Replace("ID: ", "")), 11, 5000);

                addToHistory();
              
                _historyManager.MinusBalance(int.Parse(IdLbl.Text.Replace("ID: ", "")), 5000);
                _balanceMAnager.BalanceUSerID(int.Parse(IdLbl.Text.Replace("ID: ", "")));
                BalanceBtn.Text = " " + BalanceManager.Balance.ToString("N0",
                    System.Globalization.CultureInfo.GetCultureInfo("de")) + "$";
                BalanceLbl.Text = "Balance: " + " " + BalanceManager.Balance.ToString("N0",
                    System.Globalization.CultureInfo.GetCultureInfo("de")) + "$";
            }
        }

        private void MainTAb_Click(object sender, EventArgs e)
        {
            ResetBal();
        }
        private void ResetBal()
        {
            _balanceMAnager = new BalanceManager();
            _balanceMAnager.BalanceUSerID(int.Parse(IdLbl.Text.Replace("ID: ", "")));
            BalanceBtn.Text = " " + BalanceManager.Balance.ToString("N0",
                  System.Globalization.CultureInfo.GetCultureInfo("de")) + "$";
            BalanceLbl.Text = "Balance: " + " " + BalanceManager.Balance.ToString("N0",
                System.Globalization.CultureInfo.GetCultureInfo("de")) + "$";
        }
        private void BuildListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Date", 230, HorizontalAlignment.Left);
            listView1.Columns.Add("From", 130, HorizontalAlignment.Left);
            listView1.Columns.Add("To", 130 , HorizontalAlignment.Left);
            listView1.Columns.Add("Amount", 130, HorizontalAlignment.Left);
            listView1.Columns.Add("Message", 680, HorizontalAlignment.Left);
            addToHistory();
        }

        private void HistoryTab_Click(object sender, EventArgs e)
        {

        }
        private void addToHistory()
        {
            

            _historyManager = new HistoryManager();
            _historyManager.GetTransactions(int.Parse(IdLbl.Text.Replace("ID: ", "")));
            listView1.Items.Clear();
            if (HistoryManager.ListV != null)
            {
                
                foreach (var item in HistoryManager.ListV)
                {
                    listView1.Items.Add(item);
                }
            }
        }
    }
}
