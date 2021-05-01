using ConsoleApp2.Controllers;
using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Views
{
    class LoginViaFacebook : IAuthentication
    {
        public LoginProviders loginProvider {
            get; set; }

        public bool Authenticate(User user)
        {
            loginProvider = LoginProviders.Facebook;
            GetConnectionString();
            Console.WriteLine(" Assuming it passed Facebook's auth API.");
            return true;
        }

        public string GetConnectionString()
        {
            Console.WriteLine(" Assuming it got the correct connection string to FB database.");
            return "Facebook Connection String";
        }
    }
}
