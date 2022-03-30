using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika_3
{
    class User
    {
        public User(string username , string password ,Role role)
        {
            this.Username = username;
            this.Password = password;
            this.Role = role;
            _id++;
            Id= _id;
        }
        private int _id;
        public int Id { get; }

        public string Username;
        private string _password;
        public string Password { get=>_password; 
            
            set
            {
                if (CheckPassword(value)==true)
                {
                    _password = value;
                }
            }
        }
        public Role Role;

        public void ShowInfo()
        {
            Console.WriteLine($"Username:{this.Username}");
        }
        public static bool CheckPassword(string str)
        {
            bool checkUpper = false;
            bool checkLower = false;
            bool chekDigit = false;
            if (!string.IsNullOrWhiteSpace(str) && str.Length>= 8)
            {
                
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsUpper(str[i]))
                    {
                        checkUpper = true;
                    }else if (char.IsLower(str[i]))
                    {
                        checkLower = true;
                    }else if (char.IsDigit(str[i]))
                    {
                        chekDigit = true;
                    }
                    if(chekDigit==true && checkLower ==true && chekDigit == true)
                        return true;
                
            }
          }
            return false;
        }
    }
}
