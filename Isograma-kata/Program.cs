using System;
using System.Collections.Generic;

namespace Isograma_kata
{
    public class Program
    {
        public static bool IsIsogram(string str)
        {
            var hashChar = new HashSet<char>();
            str = str.ToLower();
            foreach (var letter in str)
            {
                if (hashChar.Add(letter) == false)
                {
                    return false;
                }
            }

            return true;
        }

        public static void Main(string[] args)
        {
           
        }
    }
}
