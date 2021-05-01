using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Apr24_.Models
{
    public static class AuthServices
    {
        public static Boolean Verify(LoginModel lm) {

            if (lm.uid == "nick" && lm.pwd == "1234")
                return true;
            return false;
        
        }
    }
}