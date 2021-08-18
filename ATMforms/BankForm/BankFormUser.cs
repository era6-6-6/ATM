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

namespace ATMforms.BankForm
{
    public partial class BankFormUser : MetroForm
    {
     
        public BankFormUser()
        {
            InitializeComponent();
        }

        private void BankFormUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.list.Remove(this.Name);
        }
    }
}
