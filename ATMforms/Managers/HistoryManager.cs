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
        private readonly string PATHUsers = $@"{Environment.CurrentDirectory}/SmallDB/users.txt";
        public static List<string> Data;
    
        public void GetTransaction(int id)
        { 
            if(!File.Exists(PATH))
            {
               var file = File.Create(PATH);
               file.Close();
            }
            Data = new List<string>();
            Data.Clear();
            string text;
            using (StreamReader reader = File.OpenText(PATH))
            {
                 text = reader.ReadToEnd();
}
            Match Balance = Regex.Match(text, $"!(.*) , {id} , (.*) , (.*)!");
            if (Balance.Success)
            {
                for (int i = 0; i < Balance.Length; i++)
                {
                    
                    
                    Data.Add($"{Balance.Groups[1]} - {Balance.Groups[2]} - {Balance.Groups[3]}");
                    Balance = Balance.NextMatch();

                }
                foreach (var item in Data)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                throw new Exception("nothing found");
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
                writer.WriteLine($"!{date} , {IDFrom} ,  {IDTo} , {amount}!");
            }
        }
        public void MinusBalance(int id, double bal)
        {
            string text = "";
            using(StreamReader read = File.OpenText(PATHUsers))
            {
                text = read.ReadToEnd();
                
            }
            Match balance = Regex.Match(text, $"! {id} , (.*) , (.*) , Balance: (.*)!");
            if(balance.Success)
            {
                using(StreamWriter write = File.CreateText(PATHUsers))
                {
                    double newBalance = double.Parse(balance.Groups[3].ToString()) - bal;
                    if (double.Parse(balance.Groups[3].ToString()) == 0)
                    {
                        return;
                    }
                    else
                    {
                        text = text.Replace(balance.Groups[3].ToString(), newBalance.ToString());
                        write.Write(text);
                    }
                }
            }
            else
            {
                throw new Exception("Nothing Found!");
            }


        }
    }
}
