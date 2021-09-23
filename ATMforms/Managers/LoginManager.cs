using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ATMforms.Managers
{
    class LoginManager
    {
        IdManager _idManager;
        private readonly string PATH = $@"{Environment.CurrentDirectory}/users.txt";
        public bool Register(string username, string password)
        {
            _idManager = new IdManager();
            string text;
            if(!File.Exists(PATH))
            {
                var file = File.Create(PATH);
                file.Close();
            }
            if(CheckIfUserExist(username)) return false;
            using (StreamReader read = File.OpenText(PATH))
            {
                text = read.ReadToEnd();
            }
            using (StreamWriter writer = new StreamWriter(PATH))
            {
                writer.WriteLine($"! {_idManager.ID()} , {username} , {password}! , Balance: 500!");
                writer.WriteLine(text);
            }
            return true;
        }
        public bool CheckIfUserExist(string username)
        {
            if(!File.Exists(PATH))
            {
                var file = File.Create(PATH);
                file.Close();
            }
            
            string text;
            using (StreamReader read = File.OpenText(PATH))
            {
               text = read.ReadToEnd();
                
            }
            Match match = Regex.Match(text, $"!(.*) , {username} , (.*)!");
            return match.Success;
                
        }
        public string login(string username, string password)
        {
            string text;
            if(!File.Exists(PATH))
            {
                var file = File.Create(PATH);
                file.Close();
            }
            using (StreamReader read = File.OpenText(PATH))
            {
                text = read.ReadToEnd();
            }
            Match match = Regex.Match(text, $"!(.*) , {username} , (.*)! , Balance: (.*)!");
            if(!match.Success)
            {
                return "user don't exist register please";
            }
            if(match.Groups[2].ToString() != password)
            {
                return "Wrong password";
            }
            else
            {
                return "Succesfully logged in";
            }
        }
    }
}
