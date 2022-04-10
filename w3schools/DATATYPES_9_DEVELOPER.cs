//Write a C# Sharp program that takes a character as input and check the input (lowercase) is a vowel, a digit, or any other symbol.
namespace w3schools
{
    public static class DATATYPES_9_DEVELOPER

    {
        public static void Run(char c){
        if ((c == 'a') || (c == 'e') || (c == 'i') || 
                (c == 'o') || (c == 'u'))
            Console.WriteLine("It's a lowercase vowel.");
        else if ((c >= '0') && (c <= '9'))
            Console.WriteLine("It's a digit.");
        else
            Console.Write("It's another symbol.");  
        }
    }
}
