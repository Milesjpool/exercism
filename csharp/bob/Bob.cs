using System.Linq;
using System.Text.RegularExpressions;

namespace bob
{
    internal class Bob
    {
        public object Hey(string message)
        {
            if (IsSilence(message))
            {
                return "Fine. Be that way!";
            }
            if (ContainsLetters(message) && IsAllCaps(message))
            {
                return "Woah, chill out!";
            }
            if (message.EndsWith("?"))
            {
                return "Sure.";
            }
            return "Whatever.";
        }

        private bool IsSilence(string message)
        {
            return message.All(char.IsWhiteSpace);
        }

        private bool ContainsLetters(string message)
        {
            return message.Any(char.IsLetter);
        }

        private static bool IsAllCaps(string message)
        {
            return message.All(c => !char.IsLower(c));
        }
    }
}