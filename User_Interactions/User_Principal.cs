using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Neo_Alfred.User_Interactions
{
    class User_Principal
    {
        private User_Identity _identity;
        public User_Identity Identity
        {
            get { return _identity ?? new User_AnonymousIdentity(); }
            set { _identity = value; }
        }
    }
}
