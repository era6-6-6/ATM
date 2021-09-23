using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ATMforms.Managers
{
    class BalanceManager
    {
        public static int ID {get; set;}
        public static double Balance { get; set; }

        private readonly string PATH = $"{Environment.CurrentDirectory}/SmallDB/users.txt";

        public double BalanceUSer(string username, string password)
        {
            string text;
            using (StreamReader read = File.OpenText(PATH))
            {
                text = read.ReadToEnd();
            }
            Match match = Regex.Match(text, $"!(.*) , {username} , {password}! , Balance: (.*)!");
            ID = int.Parse(match.Groups[1].ToString());
            Balance = double.Parse(match.Groups[2].ToString());

            return double.Parse(match.Groups[2].ToString());
        }
    }
}
