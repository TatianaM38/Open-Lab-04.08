using System;
using System.Collections.Generic;
namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            List<string> str = new List<string>();
            foreach (string four in strings)
            {
                if (four.Length == 4)
                {
                    str.Add(four);
                }
            }
            return str.ToArray();
        }
    }
}
