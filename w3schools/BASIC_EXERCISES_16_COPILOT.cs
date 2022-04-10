using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3schools
{
    public static class BASIC_EXERCISES_16_COPILOT
    {
        //Write a C# program to create a new string from a given string where the first and last characters will change their positions
        public static void Run(string text)
        {
            Console.WriteLine(text.Substring(text.Length - 1) + text.Substring(1, text.Length - 2) + text.Substring(0, 1));
        }
    }
}
