using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3schools
{
    public static class BASIC_EXERCISES_8_COPILOT
    {
        public static void Print_Multiplication_Table(int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
    }
}
