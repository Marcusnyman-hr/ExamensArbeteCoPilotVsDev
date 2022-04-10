//Write a program in C# Sharp to display the sum of the series [ 9 + 99 + 999 + 9999 ...]
namespace w3schools
{
    public static class FORLOOP_21_COPILOT

    {
        public static void Run(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine(sum);
        }
    }
}
