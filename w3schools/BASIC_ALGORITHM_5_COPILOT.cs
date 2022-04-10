//Write a C# Sharp program to create a new string where 'if' is added to the front of a given string. If the string already begins with 'if', return the string unchanged. 
namespace w3schools
{
    public static class BASIC_ALGORITHM_5_COPILOT
    {
        public static void Run(string text){
            if(text.Substring(0,2) == "if") {
                Console.WriteLine(text);
            }
            else {
                Console.WriteLine("if " + text);
            }
        }
    }
}
