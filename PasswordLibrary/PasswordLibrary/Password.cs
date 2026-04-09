using System.Text.RegularExpressions;

namespace PasswordLibrary
{
    public class Password
    {
        string myPassword;
        public Password(string password)
        {
            myPassword = password;
        }
        public bool CheckPassword()
        {
            Regex digit = new Regex(@"\d");
            if (myPassword.Length < 6)
                return false;
            else
                return digit.IsMatch(myPassword);
        }
    }
}
