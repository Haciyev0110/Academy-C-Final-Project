using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace WindowsFormsApp1.Extensions
{
    public static class Extension
    {
        public static string HashPassword(string password)
        {
            byte[] byteArray = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hashedArray = new SHA256Managed().ComputeHash(byteArray);
            string hashedPassword = ASCIIEncoding.ASCII.GetString(hashedArray);

            return hashedPassword;
        }

        public static bool CheckPassword(string password, string hashedPassword) => HashPassword(password) == hashedPassword;

        public static bool CheckTextValues(string text, int len, char[] chars = null)
        {
            if (String.IsNullOrEmpty(text) || text.Length < len)
            {
                return false;
            }

            if (chars != null)
            {
                foreach (char c in chars)
                {
                    if (text.Contains(c))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

       
    }
}
