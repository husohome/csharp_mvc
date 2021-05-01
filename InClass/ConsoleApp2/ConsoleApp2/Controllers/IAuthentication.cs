using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Controllers
{
    public enum LoginProviders { 
        Facebook, Line, Google, Microsoft
    }

    public interface IAuthentication
    {
        public LoginProviders loginProvider { get; set; }

        public string GetConnectionString();
        public bool Authenticate(User user);


    }
}
