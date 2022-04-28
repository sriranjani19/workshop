using System;
using System.Collections.Generic;
using System.Linq;


    public class Anagram_detection
    {
        public static void main()
        {
            string str1 = "abcd";
            string str2 = "dcba";
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);

            if (val1 == val2)
            {
                Console.WriteLine(" Both the strings are Anagrams");
            }
            else
            {
                Console.WriteLine("Both the string are not Anagrams");
            }
        }
    }

