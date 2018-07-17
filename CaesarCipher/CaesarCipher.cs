using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            String encryptedString = "";
            if (!String.IsNullOrWhiteSpace(text))
            {
                foreach (char c in text)
                {
                    if (Regex.IsMatch(Char.ToString(c), @"[a-zA-Z]"))
                    {
                        char result = (char) (c + (shiftKey % 26));
                        encryptedString = String.Concat(encryptedString, (char) (((char.IsUpper(c) && result > 90) || (char.IsLower(c) && result > 122)) ? result - 26 : result));
                    }
                    else
                    {
                        encryptedString = String.Concat(encryptedString, c);
                    }
                }
            }
            return encryptedString;
        }
    }
}
