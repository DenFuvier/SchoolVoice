﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Classes
{
    public class Users
    {
        
            public string Login { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }

            public  Users(string login, string password, string role)
            {
                Login = login;
                Password = password;
                Role = role;
            }
       


    }
}