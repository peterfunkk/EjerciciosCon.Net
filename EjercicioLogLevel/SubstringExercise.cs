using System;

namespace ConsoleApp1
{
    public static class StringExtensions
    {
        public static string SubstringAfter(this string source, string after)
        {
            int index = source.IndexOf(after);
            return source.Substring(index + after.Length);
        }

        public static string SubstringBetween(this string source, string index, string index2)
        {

            int str1 = source.IndexOf(index) + 1;
            int str2 = source.IndexOf(index2) - 1 ;
            return source.Substring(str1, str2);
        }

        public static string Message(this string source)
        {
            string source1 = source;
            int index = source1.IndexOf(": ") + 2;
            return source1.Substring(index);
        }

        public static string LogLevel(this string source)
        {
            string source1 = source;
            int str1 = source1.IndexOf("[") + 1;
            int str2 = source1.IndexOf("]");
            return source1.Substring(str1, str2 - str1);
        }
    }


};
