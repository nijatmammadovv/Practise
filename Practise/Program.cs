using System;
using System.Text;

namespace Practise
{
    static class Program
    {
        static void Main(string[] args)
        {
            string text = "exTensiON claSSi staTIc OLMalIdiR";
            Console.WriteLine(text.Capitalized());
        }
        static StringBuilder Capitalized(this string word)
        {
            StringBuilder result = new StringBuilder();
            foreach (var item in word)
            {
                result.Append(char.ToLower(item));
            }
            result.Append(char.ToUpper(word[0]));
            for (int i = 1; i < word.Length; i++)
            {
                if (word[i] == ' ')
                {
                    result.Append(word[i]);
                    result.Append(char.ToUpper(word[i + 1]));
                    i++;
                }
                else
                {
                    result.Append(word[i]);
                }
            }
            word = result.ToString();
            return result;
        }
    }
}
