using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            StringBuilder encryptedStringBuilder = new StringBuilder();
            if (!String.IsNullOrWhiteSpace(text))
            {
                foreach (char c in text)
                {
                    if (Regex.IsMatch(Char.ToString(c), @"[a-zA-Z]"))
                    {
                        char result = (char) (c + (shiftKey % 26));
                        encryptedStringBuilder.Append((char)(((char.IsUpper(c) && result > 90) || (char.IsLower(c) && result > 122)) ? result - 26 : result));
                    }
                    else
                    {
                        encryptedStringBuilder.Append(c);
                    }
                }
            }
            return encryptedStringBuilder.ToString();
        }
    }
}
