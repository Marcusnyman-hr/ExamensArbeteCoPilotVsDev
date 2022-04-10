//Write a C# Sharp program to display alphabet pattern like T with an asterisk.
namespace w3schools
{
    public static class FORLOOP_77_DEVELOPER

    {
        public static void Run()
        {
            int row,column; 
            for(row=0;row<=6;row++)
            {
                for (column=0; column<=6; column++)
                {
            if (column == 3 || (row == 0 && column > 0 && column < 6))
                Console.Write("*");
                    else
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            }
    }
}
