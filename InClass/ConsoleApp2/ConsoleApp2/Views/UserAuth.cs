using ConsoleApp2.Controllers;
using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.Views
{
    // this is a service class
    class UserAuth
    {
        public bool DoLogIn(IAuthentication auth, User user)
        {
            return auth.Authenticate(user);
        }
    }
}
