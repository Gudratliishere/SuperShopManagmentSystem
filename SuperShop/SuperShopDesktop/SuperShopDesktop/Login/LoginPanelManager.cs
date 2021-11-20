using SuperShopDesktop.Login.SignIn;
using SuperShopDesktop.Login.SignUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperShopDesktop.Login
{
    public class LoginPanelManager
    {
        private static SigninAdmin signinAdmin = null;
        private static SigninOperator signinOperator = null;
        private static SignupAdmin signupAdmin = null;
        private static SignupOperator signupoperator = null;

        public static SigninAdmin GetSigninAdminPanel ()
        {
            if (signinAdmin == null)
                signinAdmin = new SigninAdmin();

            return signinAdmin;
        }

        public static SigninOperator GetSigninOperatorPanel ()
        {
            if (signinOperator == null)
                signinOperator = new SigninOperator();

            return signinOperator;
        }

        public static SignupAdmin GetSignupAdminPanel ()
        {
            if (signupAdmin == null)
                signupAdmin = new SignupAdmin();

            return signupAdmin;
        }

        public static SignupOperator GetSignupOperatorPanel ()
        {
            if (signupoperator == null)
                signupoperator = new SignupOperator();

            return signupoperator;
        }
    }
}
