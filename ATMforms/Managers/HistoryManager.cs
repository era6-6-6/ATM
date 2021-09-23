using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ATMforms.Managers
{
    class HistoryManager
    {
        private readonly string PATH = $@"{Environment.CurrentDirectory}/SmallDB/Transactions.txt";
        public void GetTransaction(int id)
        { 
            if(!File.Exists(PATH))
            {
               var file = File.Create(PATH);
               file.Close();
            }
            using (StreamReader reader = File.OpenText(PATH))
            {
                string text = reader.ReadToEnd();
                Match Balance = Regex.Match(text, "");
            }

        }
        public void SaveTransaction(DateTime date, int IDFrom , int IDTo, double amount)
        {
            if(!File.Exists(PATH))
            {
                var file = File.Create(PATH);
                file.Close();
            }
            
            using(StreamWriter writer = File.AppendText(PATH))
            {
                writer.WriteLine($"!{date} , {IDFrom} ,  {IDTo} , {amount}");
            }
        }
    }
}
