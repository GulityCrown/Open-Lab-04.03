using System;
using static System.Net.Mime.MediaTypeNames;

namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string original)
        {
            if (original.Length > 2)
                return original.Substring(1, original.Length - 2);
            else if (original.Length > 0 && original.Length < 2)
                return original;
            else
                return string.Empty;
        }   
    }
}
