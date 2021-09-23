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
            
            _historyManager = new HistoryManager();
            _historyManager.SaveTransaction(DateTime.Now , int.Parse(IdLbl.Text.Replace("ID: " , "")) , 11 , 5000);
            _historyManager.GetTransaction(int.Parse(IdLbl.Text.Replace("ID: " , "")));
        }
    }
}
