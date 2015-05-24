using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StringBuilderExtensions
{
    public static class Extensions
    {
        public static string Substring(this string str,int startIndex, int length)
        {
            
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                result.Append(str[startIndex]);
                startIndex++;
            }
            return result.ToString();
        }
        public static string RemoveText(this string str,string text)
        {
            StringBuilder result = new StringBuilder();
            string[] words;
            words = str.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == text)
                {
                    words[i] = words[i + 1];
                }
                else
                {
                    result.Append(words[i]);
                    result.Append(" ");
                }
            }
            return result.ToString();
        }
        public static string AppendAll<T>(this string str,IEnumerable<T> items)
        {
            StringBuilder result = new StringBuilder();
            foreach (var item in items)
            {
                result.Append(item);
            }
            return result.ToString();
        } 
    }
    class MainProgram
    {
        static void Main(string[] args)
        {
            string s = "Hello extension Methods";

            Console.WriteLine("Substring: ---->");
            Console.WriteLine(s.Substring(0, 4));
            Console.WriteLine();
            Console.WriteLine("RemoveText: ---->");
            Console.WriteLine(s.RemoveText("Hello"));
            Console.WriteLine();
            Console.WriteLine("AppendAll: ---->");
            Console.WriteLine(s.AppendAll(new List<string> 
                              { "Hi", " ", "I"," ", "am"," ", "your"," ", "homework" }));
            Console.WriteLine();
        }
    }

}
