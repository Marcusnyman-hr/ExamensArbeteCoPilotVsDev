// Write a C# Sharp program to check if one of the first 4 elements in an array of integers is equal to a given element.
namespace w3schools
{
    public static class BASIC_ALGORITHM_33_COPILOT
    {
        public static bool Run(int[] array, int element)
        {
            for (int i = 0; i < 4; i++)
            {
                if (array[i] == element)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
