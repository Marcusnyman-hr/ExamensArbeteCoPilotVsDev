using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w3schools
{
    public static class BASIC_EXERCISES_8_DEVELOPER
    {
        public static void Print_Multiplication_Table(int num)
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }

        }
    }
}
