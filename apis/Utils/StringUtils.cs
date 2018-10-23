using System;
using System.Linq;

namespace Utils
{
    public class StringUtils
    {
        private static readonly Random random = new Random();
        private const string Chars = "abcdefghijklmnopqrstuvwxyz0123456789";

        public static string Random(int length)
        {
            return new string(Enumerable.Repeat(Chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}