﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Neo_Alfred.User_Interactions
{
    class User_Identity : IIdentity
    {
        public User_Identity(string name, string email, string role)
        {
            Name = name;
            Email = email;
            Role = role;
        }

        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Role { get; private set; }

        #region IIdentity Members
        public string AuthenticationType { get { return "Custom authentication"; } }
        public bool IsAuthenticated { get { return !string.IsNullOrEmpty(Name); } }
        #endregion
    }
}
