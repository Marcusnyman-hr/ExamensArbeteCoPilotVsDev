// Write a C# Sharp program to read temperature in centigrade and display a suitable message according to temperature state below
// Temp < 0 then Freezing weather
// Temp 0-10 then Very Cold weather
// Temp 10-20 then Cold weather
// Temp 20-30 then Normal in Temp
// Temp 30-40 then Its Hot
// Temp >=40 then Its Very Hot
namespace w3schools
{
    public static class CONDITIONAL_15_DEVELOPER

    {
        public static void Run(int temp)
        {
            if (temp < 0)
            {
                Console.WriteLine("Freezing weather");
            }
            else if (temp >= 0 && temp <= 10)
            {
                Console.WriteLine("Very Cold weather");
            }
            else if (temp >= 10 && temp <= 20)
            {
                Console.WriteLine("Cold weather");
            }
            else if (temp >= 20 && temp <= 30)
            {
                Console.WriteLine("Normal in Temp");
            }
            else if (temp >= 30 && temp <= 40)
            {
                Console.WriteLine("Its Hot");
            }
            else
            {
                Console.WriteLine("Its Very Hot");
            }
        }
    }
}
