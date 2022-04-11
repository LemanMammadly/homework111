using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class User
    {
        private string _userName;
        private string _passWord;


       
        public string Username
        {
            get 
            { 
                return _userName;
            }
            set
            {
                if (value.Length >=8 )
                {
                    _userName = value;
                }
                else
                {
                    Console.WriteLine("Minimum 8 uzunlugunda olamlidir..");
                }
            }
        }

        public string PassWord
        {
            get
            {
                return _passWord;
            }
            set
            {
                if (value.Length >= 8)
                {
                    _passWord = value;
                }
                else
                {
                    Console.WriteLine("Minimum 8 uzunlugunda olmalidir..");
                }
            }
        }

        public User(string username,string password)
        {
            Username = username;
            PassWord = password;
        }

    }


}
