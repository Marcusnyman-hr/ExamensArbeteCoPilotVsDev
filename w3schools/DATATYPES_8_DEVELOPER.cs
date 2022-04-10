//Write a C# Sharp program that takes the radius of a sphere as input and calculate and display the surface and volume of the sphere.
namespace w3schools
{
    public static class DATATYPES_8_DEVELOPER
    
    {
        public static void Run(int num){
        float radius = num;
        float pi = 3.1415926535f;
         
        Console.Write("Radius: ");
        radius = Convert.ToSingle(Console.ReadLine());
         
        Console.WriteLine( 4 * pi * (radius * radius) );
         
        Console.WriteLine( 4f/3f * pi * (radius * radius * radius));
        }
    }
}
