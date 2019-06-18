using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo_Alfred.User_Interactions
{
    class User_AnonymousIdentity : User_Identity
    {
        public User_AnonymousIdentity()
            : base(string.Empty, string.Empty, string.Empty)
        { }
    }
}
