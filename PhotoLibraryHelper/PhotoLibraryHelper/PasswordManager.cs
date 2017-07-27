using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace PhotoLibraryHelper
{
    public class PasswordManager
    {

        public static string HashPassword(string unhashedPassword)
        {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] unhashedBytes = Encoding.Unicode.GetBytes(unhashedPassword);
            byte[] hashedBytes = sha1.ComputeHash(unhashedBytes);

            return Encoding.Unicode.GetString(hashedBytes);
        }
        //at least 1 digit, 1 alphabet character, 6-16 total length.
        public static bool IsValidPassword(string password)
        {
            return Regex.IsMatch(password, @"^.*(?=.{5,15})(?=.*\d)(?=.*[a-zA-Z]).*$");
        }





    }
}
