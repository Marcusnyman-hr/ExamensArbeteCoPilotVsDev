//Write a program in C# Sharp to display the sum of the series [ 9 + 99 + 999 + 9999 ...]
namespace w3schools
{
    public static class FORLOOP_21_DEVELOPER
    {
        public static void Run(int[] nines)
        {
            int sum = 0;
            for (int i = 0; i < nines.Length; i++)
            {
                sum = sum + nines[i];
            }
            Console.WriteLine(sum);
        }
    }
}
