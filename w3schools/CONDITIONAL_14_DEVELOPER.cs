//Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene. 
namespace w3schools
{
    public static class CONDITIONAL_14_DEVELOPER
    {
        public static void Run(int sidea, int sideb, int sidec)
        {
            if(sidea==sideb && sideb==sidec) 
            {  
                Console.Write("This is an equilateral triangle.");  
            }  
            else if(sidea==sideb || sidea==sidec || sideb==sidec) 
            {  
                Console.Write("This is an isosceles triangle.");  
            }  
            else 
            {  
                Console.Write("This is a scalene triangle.");  
            }  
        }
    }
}
