using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3schools
{
    public static class BASIC_EXERCISES_16_DEVELOPER
    {
        public static void Run(string text)
        {
            var newText = text.Substring(text.Length - 1) + text.Substring(1, text.Length - 2) + text.Substring(0, 1);
            System.Console.WriteLine(newText);
        }
    }
}
