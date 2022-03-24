using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public static class DetectPangramService
    {
        public static bool IsPangram(string str)
        {
            char[] alphabet = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            foreach (char c in alphabet)
                if (!str.Contains(c, StringComparison.OrdinalIgnoreCase))
                    return false;

            return true;
        }

        public static bool IsPangramBestAnswer(string str)
        {
            return str.Where(ch => Char.IsLetter(ch)).Select(ch => Char.ToLower(ch)).Distinct().Count() == 26;
        }
    }
}
