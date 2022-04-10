//Write a C# Sharp program that takes the radius of a sphere as input and calculate and display the surface and volume of the sphere.
namespace w3schools
{
    public static class DATATYPES_8_COPILOT
    
    {
        public static void Run(int num){
            double radius = num;
            double surfaceArea = 4 * Math.PI * (radius * radius);
            double volume = (4f / 3f) * Math.PI * (radius*radius*radius);
            Console.WriteLine("The surface area of the sphere is {0}", surfaceArea);
            Console.WriteLine("The volume of the sphere is {0}", volume);
        }
    }
}
