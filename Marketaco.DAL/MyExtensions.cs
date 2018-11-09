using System;

namespace Marketaco.DAL
{
    public static class MyExtensions
    {
        public static bool Contains(this string source, string toCheck, StringComparison comp)
        {
            return source != null && toCheck != null && source.IndexOf(toCheck, comp) >= 0;
        }
    }

    public static class StringExt
    {
        public static string PadBoth(this string str, int length, char character = ' ')
        {
            return str.PadLeft((length - str.Length) / 2 + str.Length, character).PadRight(length, character);
        }
    }
}
