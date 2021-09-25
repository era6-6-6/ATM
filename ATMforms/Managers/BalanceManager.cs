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
        public double BalanceUSerID(int id)
        {
            string text;
            using (StreamReader read = File.OpenText(PATH))
            {
                text = read.ReadToEnd();
            }
            Match match = Regex.Match(text, $"! {id} , (.*) , (.*)! , Balance: (.*)!");
            
            Balance = double.Parse(match.Groups[3].ToString());

            return double.Parse(match.Groups[3].ToString());
        }
        //TODO: rewrite this method 
        public void Send(int FromID , double amount , int ToID)
        {
            string text = "";
            using (StreamReader read = File.OpenText(PATH))
            {
                text = read.ReadToEnd();
            }
            Match matchFrom = Regex.Match(text, $"! {FromID} , (.*) , (.*)! , Balance: (.*)!");
            Match matchTo = Regex.Match(text, $"! {ToID} , (.*) , (.*)! , Balance: (.*)!");
            double newAmount = double.Parse(matchFrom.Groups[3].ToString()) - amount;
            double newAmountPlus = double.Parse(matchTo.Groups[3].ToString()) + amount;
            #region Lines
            string oldLineFrom = $"! {FromID} , {matchFrom.Groups[1]} , {matchFrom.Groups[2]}! , Balance: {matchFrom.Groups[3]}!";
            string oldLineTo = $"! {ToID} , {matchTo.Groups[1]} , {matchTo.Groups[2]}! , Balance: {matchTo.Groups[3]}!";

            string NewLineFrom = $"! {FromID} , {matchFrom.Groups[1]} , {matchFrom.Groups[2]}! , Balance: {newAmount}!";
            string newLineTo = $"! {ToID} , {matchTo.Groups[1]} , {matchTo.Groups[2]}! , Balance: {newAmountPlus}!";
            #endregion

            using (StreamWriter write = File.CreateText(PATH))
            {
                write.Write(text.Replace(oldLineTo , newLineTo).Replace(oldLineFrom , NewLineFrom));
            }
        }
        public void AddToBalance(int id, double amount )
        {

        }
    }
}
